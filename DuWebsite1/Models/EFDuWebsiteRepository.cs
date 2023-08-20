using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models
{
    public class EFDuWebsiteRepository /*: IDuWebsiteRepository*/
    {
        private DuDbContext context;
        public EFDuWebsiteRepository(DuDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Duyuru> Duyurular => context.Duyurular;

        //public List<Duyuru> GetById(int id)
        //{

        //}



        //public void DuyuruEkle(Duyuru duyuru)
        //{
        //    duyuru.YayinTarihi = DateTime.Now;
        //    context.Add(duyuru);
        //    context.SaveChanges();
        //}
        //public void DuyuruSil(Duyuru Duyuru)
        //{
        //    context.Remove(Duyuru);
        //    context.SaveChanges();
        //}

        ////public Duyuru Duyurulistele()
        ////{
        ////    var liste = context.Duyurular;
        ////    return liste;
            
        ////}
        //public void DuyuruGüncelle(Duyuru Duyuru)
        //{
        //    context.Update(Duyuru);
        //    context.SaveChanges();
        //}

        //public Duyuru IdyegoreDuyuru(int duyuruId)
        //{
        //    //var veri = context.Set<Duyuru>().Find(duyuruId);
        //    var veri = context.Duyurular.FirstOrDefault(x => x.DuyuruId == duyuruId);


        //    return veri;
        //}
    }
}
