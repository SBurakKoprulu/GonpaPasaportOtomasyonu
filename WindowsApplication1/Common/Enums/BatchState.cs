using System.ComponentModel.DataAnnotations;

namespace GonpaPasaportOtomasyonu
{
    internal enum BatchState
    {
        [Display(Description = "Oluşturuldu")]
        BS_Created = 1,
        [Display(Description = "Veri Alındı")]
        BS_DataRecieved = 2,
        [Display(Description = "Gönderime Hazır")]
        BS_ReadyToSend = 3,
        [Display(Description = "Gönderimde")]
        BS_Sending = 4,
        [Display(Description = "Web Servise Gönderildi")]
        BS_SendedToWS = 5,
        [Display(Description = "İşlem Bitti")]
        BS_Finished = 6,
        [Display(Description = "Tekrar Okunuyor")]
        BS_ReRead = 7,
    }
}
