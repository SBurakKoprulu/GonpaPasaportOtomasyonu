using System.ComponentModel.DataAnnotations;

namespace GonpaPasaportOtomasyonu
{
    internal enum PassportState
    {
        [Display(Description = "Tanımsız")]
        Undefined,
        [Display(Description = "Veri Alındı")]
        DataRecieved,
        [Display(Description = "Veri Doğrulandı")]
        DataChecked,
        [Display(Description = "Veri makineye Gönderildi")]
        DataSendedToMachine,
        [Display(Description = "Veri Web Servise gönderildi")]
        SendToWS,
        [Display(Description = "Veri Arşivlendi")]
        Archived,
        [Display(Description = "Hasarlı")]
        Damaged,
        [Display(Description = "Pasaport Gönderime Hazır")]
        ReadyToSend,
        //[Display(Name = "Pasaport Verisi yeniden Alındı")]
        //DataRecievedAgain,
        [Display(Description = "Pasaport Paketleme İşlemi Tamamlandı")]
        Finished
    }
}   
