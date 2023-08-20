using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models
{
    public class Duyuru
    {
        public int DuyuruId { get; set; }
        public string DuyuruAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime YayinTarihi { get; set; }
    }
}
