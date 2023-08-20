using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models
{
    public interface IDuWebsiteRepository
    {
        IQueryable<Duyuru> Duyurular { get; }


    }
}
