using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer: DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="c#"},
                new Category(){KategoriAdi="Asp.net Mvc"},
                new Category(){KategoriAdi="Asp.net Web form"},
                new Category(){KategoriAdi="windows Form"},
            };
            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,CategoryId=1},
                new Blog(){Baslik="C# Delegates",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,CategoryId=1},
                new Blog(){Baslik="C# Delegates",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=false,Onay=false,CategoryId=1},
                new Blog(){Baslik="C# Delegates",Aciklama="C# DelegatesC# Delegates",Resim="2.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=true,CategoryId=2},
                new Blog(){Baslik="C# Generic List Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=false,CategoryId=2},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="2.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false,Onay=false,CategoryId=2},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="2.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,CategoryId=3},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="2.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false,Onay=true,CategoryId=3},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-15),Anasayfa=true,Onay=false,CategoryId=3},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="2.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-17),Anasayfa=true,Onay=true,CategoryId=4},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,CategoryId=4},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,CategoryId=4},
                new Blog(){Baslik="C# Delegates Hakkında",Aciklama="C# DelegatesC# Delegates",Resim="1.jpg",İcerik="C# DelegatesC# DelegatesC# DelegatesC# Delegates",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,CategoryId=4},

            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}