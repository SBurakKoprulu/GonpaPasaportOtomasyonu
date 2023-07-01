using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GonpaPasaportOtomasyonu.Models
{
    public partial class Batches
    {
        public int Id { get; set; }
        public string BatchCode { get; set; }
        public int PassportCount { get; set; }
        public bool IsSent { get; set; }
        public int State { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? SendDate { get; set; }
        public int? IssuerMachineId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string IssuerName { get; set; }
        public int? IssuerId { get; set; }
    }
}
