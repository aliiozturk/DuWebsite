using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DuDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<DuDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Duyurular.Any())
            {
                context.Duyurular.AddRange(
                new Duyuru
                {
                    DuyuruAdi = "Duyuru1",
                    Aciklama = "Rektörümüz Kariyer Buluşmaları Programına Konuk Oldu"


                },
                 new Duyuru
                 {
                     DuyuruAdi = "Duyuru2",
                     Aciklama = "Akçakoca Turizm İşletmeciliği ve Otelcilik Yüksekokulu’nda Unlu Mamuller Workshop’u Gerçekleştirildi"


                 },
                  new Duyuru
                  {
                      DuyuruAdi = "Duyuru3",
                      Aciklama = "“Web 2.0 Araçlarının Kimya Konularının Öğretiminde Kullanılması” Projesi Sonuçlandı"


                  },
                   new Duyuru
                   {
                       DuyuruAdi = "Duyuru4",
                       Aciklama = "Lisansüstü Danışmanlık Eğitimi"


                   },
                    new Duyuru
                    {
                        DuyuruAdi = "Duyuru5",
                        Aciklama = "Uluslararası Bilişim Kongresi (IIC2023)"


                    },
                     new Duyuru
                     {
                         DuyuruAdi = "Duyuru6",
                         Aciklama = "İş Hayatında Beden Dili ve İmajın Önemi Konuşuldu"


                     },
                      new Duyuru
                      {
                          DuyuruAdi = "Duyuru7",
                          Aciklama = "Abhaz Dernekleri Federasyonu Rektörümüzü Ziyaret Etti"


                      },
                       new Duyuru
                       {
                           DuyuruAdi = "Duyuru8",
                           Aciklama = "Düzenlenen Seminerle LÖSEV Katılımcılara Anlatıldı"


                       }
                       );
                context.SaveChanges();



            }
        }
    }
}
