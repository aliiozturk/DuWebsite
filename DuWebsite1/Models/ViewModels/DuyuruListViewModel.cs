using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models.ViewModels
{
    public class DuyuruListViewModel
    {
        public IEnumerable<Duyuru> duyurular { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
