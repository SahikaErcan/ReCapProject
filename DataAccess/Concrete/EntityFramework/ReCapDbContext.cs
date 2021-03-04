using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{/* Kurulumunu yaptığımız EntityFramework ile beraber böyle bir base sınıfı geliyor.Veritabanı 
  * nesneleri ile kendi nesnelerimizi ilişkilendirmemizi sağlayan Context class'ıdır.*/
    public class ReCapDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//SqlServer kullanacağımızı ve hangi veritabanına bağlanacağımızı belirttik.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                                          DataBase=ReCapDb; 
                                          Trusted_Connection=true");
 // "Trusted_Connection=true" ifadesi ile kullanıcı adı ve şifre gerektirmeden bağlan diyoruz.
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
// "DbSet<>" metodu ile hangi nesnenin hangi nesneye karşılık geldiğini belirtiyoruz.
    }
}
