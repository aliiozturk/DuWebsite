using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models
{
    public class EFAdminRepository 
    {
        private DuDbContext context;
        public EFAdminRepository(DuDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Admin> Kullanıcılar => context.Kullanıcılar;
        public IQueryable<Duyuru> Duyurular => context.Duyurular;

       
        public void DuyuruEkle(Duyuru duyuru)
        {
            duyuru.YayinTarihi = DateTime.Now;
            context.Add(duyuru);
            context.SaveChanges();
        }
        public void UserEkle(Admin user)
        {
            context.Add(user);
            context.SaveChanges();
        }
        public void DuyuruSil(Duyuru Duyuru)
        {
            context.Remove(Duyuru);
            context.SaveChanges();
        }

        public void DuyuruGüncelle(Duyuru Duyuru)
        {
            context.Update(Duyuru);
            context.SaveChanges();
        }

        public Duyuru IdyegoreDuyuru(int duyuruId)
        {
            //var veri = context.Set<Duyuru>().Find(duyuruId);
            var veri = context.Duyurular.FirstOrDefault(x => x.DuyuruId == duyuruId);


            return veri;
        }
       
        //public Admin IdyegoreAdmin(int adminId)
        //{
        //    var veri = context.Set<Duyuru>().Find(adminId);

        //    return veri;
        //}

    }
}
