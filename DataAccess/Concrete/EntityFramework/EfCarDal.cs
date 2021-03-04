using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
/* Bir class new'lendiğinde Garbage Collector düzenli olarak belli bir zaman sonra gelir ve onu bellekten atar. 
 * Ancak Context nesnesi biraz pahalıdır. Bu nedenle "using" (C#'ın IDisposable pattern denilen bir 
 * implementasyonudur) içinde yazdığımız nesneler using bittiği anda bellekten atılır.*/
        public void Add(Car entity)
        {
            using (ReCapDbContext context=new ReCapDbContext())
            {
                var addedEntity = context.Entry(entity);// Veri kaynağından bir veri ile gönderilen veriyi eşleştir.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();// Ekleme işlemi yapar.
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapDbContext context=new ReCapDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter); // Tek veri dönecektir.(SingleOrDefault)
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {//filtre vermemişsek 1. adım filtre vermişsek 2. adım yani where şartı ile belirttiğimiz filtre dönecektir.
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
