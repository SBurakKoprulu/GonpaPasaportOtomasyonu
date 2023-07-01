using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonpaPasaportOtomasyonu.Models
{
    internal class PassTrackDTO
    {
        public string PassportNo { get; set; }
        public long? PttBarcode { get; set; }
        public long EncoderPosition { get; set; }
    }
}
