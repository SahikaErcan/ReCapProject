using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{ // Veritabanı olmadan bellekte çalışıyoruz. Sanki veri varmış gibi..
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; // veri varmış gibi araba listesi oluşturuyoruz.
 // Proje çalıştırıldığında bellekte bir araba listesi oluşsun istiyoruz.Bu nedenle yapıcı metod oluştururuz.
        public InMemoryCarDal()
        { // sanki veritabanından geliyormuş gibi
            _cars = new List<Car>
            {
                new Car{Id=1,ColorId=1,BrandId=2,DailyPrice=250,ModelYear=2015, Description="HYUNDAI i10 - Black"},
                new Car{Id=2,ColorId=1,BrandId=2,DailyPrice=720,ModelYear=2021, Description="PORSCHE P911 Turbo S - Black"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        { // LINQ (Language Integrated Query) : Dile gömülü sorgu
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
