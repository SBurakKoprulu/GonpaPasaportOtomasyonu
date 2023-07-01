using ClosedXML;
using ClosedXML.Excel;
using GonpaPasaportOtomasyonu.Common.Extensions;
using GonpaPasaportOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GonpaPasaportOtomasyonu.Services
{
    public static class ReportService
    {
        public static void Export<T>(string sheetName, IList<T> data, string filePath)
        {
            var workbook = new XLWorkbook();

            workbook.ToWorkSheet(data, sheetName);
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            workbook.SaveAs(filePath);
        }

        public static void ExportBatch(string sheetName, Batches data, string filePath)
        {
            var workbook = new XLWorkbook();

            workbook.ToWorkSheet(data, sheetName);
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            workbook.SaveAs(filePath);
            
        }


        /// <summary>
        /// Multiple Sheet Export Class to Excel
        /// NOTE:Class DisplayName and Order Attiribute Required
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public static void Export<T>(Dictionary<string, IList<T>> data, string filePath)
        {
            var workbook = new XLWorkbook();

            foreach (var item in data)
            {
                workbook.ToWorkSheet(item.Value, item.Key);
            }
            workbook.SaveAs(filePath);
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        //public static Dictionary<string, IList<T>> Import<T>(string filePath) where T : new()
        //{
        //    Dictionary<string, IList<T>> sheetList = new Dictionary<string, IList<T>>();
        //    var workbook = new XLWorkbook(filePath);
        //    foreach (var item in workbook.Worksheets)
        //    {
        //        sheetList.Add(item.Name, ToEntity<T>(item));
        //    }
        //    return sheetList;
        //}

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="workBook"></param>
        /// <param name="data"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        private static IXLWorksheet ToWorkSheet<T>(this XLWorkbook workBook, IList<T> data, string sheetName = "Sheet1")
        {
            var genericType = typeof(T);
            var workSheet = workBook.Worksheets.Add("Batch Ozet");

            var dataParts = data.ToList().SplitPartition(data.Count / 2);
            var columnList = GetColomnList(genericType);
            int colOffset = 0;

            var HeaderCell = workSheet.Cell(1, 1);
            HeaderCell.Value = "Batch Kodu";
            var BatchCode = workSheet.Cell(1, 2);
            BatchCode.Value = sheetName;
            var DateCell = workSheet.Cell(1, 5);
            DateCell.Value = "Tarih";
            var DateCode = workSheet.Cell(1, 6);
            DateCode.Value = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            foreach (var item in dataParts)
            {
                for (int i = 0; i < columnList.Count; i++)
                {
                    var column = columnList[i];
                    var cell = workSheet.Cell(3, colOffset + i + 1);

                    cell.Value = column.Attribute.Name;
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    cell.Style.Font.Bold = true;
                }

                // Create Rows
                for (int rowIndex = 0; rowIndex < data.Count; rowIndex++)
                {
                    var row = data[rowIndex];

                    for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++)
                    {
                        var column = columnList[columnIndex];
                        var cell = workSheet.Cell(rowIndex + 4, colOffset + columnIndex + 1);
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        var propInfo = genericType.GetProperty(column.PropertyName);
                        //var cl = new XLCellValue();
                        cell.Value = GetCellValue(propInfo, row);
                    }
                }
                colOffset += (columnList.Count + 1);
            }
            //ColumnProperty Info

            workSheet.Columns().AdjustToContents();
            return workSheet;
        }

        private static IXLWorksheet ToWorkSheet(this XLWorkbook workBook, Batches data, string sheetName = "Paket_Bilgi")
        {
            
            var workSheet = workBook.Worksheets.Add("Batch Ozet");
            var HeaderCell = workSheet.Cell(1, 1);
            HeaderCell.Value = "Batch Kodu";
            var BatchCode = workSheet.Cell(1, 2);
            BatchCode.Value = data.BatchCode;
            var DateCell = workSheet.Cell(2, 1);
            DateCell.Value = "Tarih";
            var DateCode = workSheet.Cell(2, 2);
            DateCode.Value = data.CreateDate?.ToString("dd.MM.yyyy HH:mm");
            var HeaderCountCell = workSheet.Cell(3, 1);
            HeaderCountCell.Value = "Pakette Bulunan Pasport Sayısı";
            var ValCountCell = workSheet.Cell(3, 2);
            ValCountCell.Value = data.PassportCount.ToString();

            workSheet.Columns().AdjustToContents();
            return workSheet;
        }

        //private static List<T> ToEntity<T>(this IXLWorksheet workSheet) where T : new()
        //{
        //    var genericType = typeof(T);
        //    var columnList = GetColomnList(genericType);

        //    List<T> data = new List<T>();
        //    var rowList = workSheet.Rows().ToList();

        //    for (int i = 1; i < rowList.Count; i++)
        //    {
        //        var row = rowList[i];
        //        var instance = new T();

        //        for (int x = 0; x < columnList.Count; x++)
        //        {
        //            var propertyName = columnList[x].PropertyName;
        //            var property = genericType.GetProperty(propertyName);
        //            var cell = row.Cell(x + 1);

        //            property.SetValue(instance, JohnsonManager.Convert.To(property.PropertyType, cell.Value), null);
        //        }
        //        data.Add(instance);
        //    }
        //    return data;
        //}

        private static List<InternalExcelHelperAttribute> GetColomnList(Type genericType)
        {
            var columnList = genericType.GetProperties().Where(property => property.GetAttributes<DisplayAttribute>() != null && property.GetAttributes<DisplayAttribute>().Count() > 0).ToList();

            var props = columnList
                .Select(property =>
                {
                    return new InternalExcelHelperAttribute
                    {
                        Attribute = property.GetCustomAttribute<DisplayAttribute>(),
                        PropertyName = property.Name,
                        PropertyType = property.PropertyType
                    };
                })
                .OrderBy(p => p.Attribute.GetOrder())
                .ToList();
            return props;
        }

        private static XLCellValue GetCellValue<T>(PropertyInfo propInfo, T inst)
        {
            var refObj = propInfo.GetValue(inst, null);
            if (refObj == null)
                return "";
            if (propInfo.PropertyType.IsEnum)
            {
                return propInfo.Name;
            }

            switch (Type.GetTypeCode(propInfo.PropertyType))
            {
                case TypeCode.Empty:
                case TypeCode.DBNull:
                    return "";
                case TypeCode.String:
                default:
                    return (refObj).ToString();
                case TypeCode.Double:
                    return Convert.ToDouble(refObj);
                case TypeCode.Int32:
                    return Convert.ToInt32(refObj);
                case TypeCode.Int64:
                    return Convert.ToInt64(refObj);
                case TypeCode.Boolean:
                    var boolObj = Convert.ToBoolean(refObj);
                    if (boolObj)
                        return "Evet";
                    else
                        return "Hayır";

            }
        }
    }
    public static class AttributeExtensions
    {
        public static TValue GetAttributeValue<TAttribute, TValue>(
            this Type type,
            Func<TAttribute, TValue> valueSelector)
            where TAttribute : Attribute
        {
            var att = type.GetCustomAttributes(
                typeof(TAttribute), true
            ).FirstOrDefault() as TAttribute;
            if (att != null)
            {
                return valueSelector(att);
            }
            return default(TValue);
        }
    }
    public class InternalExcelHelperAttribute
    {
        public DisplayAttribute Attribute { get; set; }
        public string PropertyName { get; set; }
        public Type PropertyType { get; set; }
    }
}
