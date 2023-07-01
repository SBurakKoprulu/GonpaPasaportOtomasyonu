using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GonpaPasaportOtomasyonu.Models
{
    public partial class PassportDetails
    {
        public int Id { get; set; }
        public string TeslimAlacakKisi1 { get; set; }
        public string TeslimAlacakKisi2 { get; set; }
        public string TeslimAlacakKisi3 { get; set; }
        public string AliciAdres1 { get; set; }
        public string AliciAdres2 { get; set; }
        public string AliciAdres3 { get; set; }
        public string AliciAdSoyad1 { get; set; }
        public string AliciAdSoyad2 { get; set; }
        public string Alici2AdSoyad1 { get; set; }
        public string Alici2AdSoyad2 { get; set; }
        public string Alici2AdSoyad3 { get; set; }
        public string AliciCepTelefonu { get; set; }
        public string AliciTelefon { get; set; }
        public string AliciIl { get; set; }
        public string AliciIlce { get; set; }
        public string IadeAdresi1 { get; set; }
        public string IadeAdresi2 { get; set; }
        public string IadeAdresi3 { get; set; }
        public string PasaportNo { get; set; }
        public long? PttBarkod { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool Sent { get; set; }
        public DateTime? SentDate { get; set; }
        public int? State { get; set; }
        public int? MachineOrderId { get; set; }
        public DateTime? MachineRecordDate { get; set; }
        public string BatchCode { get; set; }
        public int? BatchId { get; set; }
        public int? IssuerMachineId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string IssuerName { get; set; }
        public int? IssuerId { get; set; }
    }
}
