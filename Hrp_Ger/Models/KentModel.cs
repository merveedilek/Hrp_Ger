using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrp_Ger.Models
{
    public class KentModel
    {
        public int KentId { get; set; }
        public string UrunAdi { get; set; }
        public string En { get; set; }
        public string Boy { get; set; }
        public string Yukseklik { get; set; }
        public string Malzeme { get; set; }
        public string Renk { get; set; }
        public string Yuzeytipi { get; set; }
        public string TemizlikveBakim { get; set; }
        public List<Images> Images { get; set; }
    }
}