using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=50,Description="Toyota",ModelYear=2010},
             new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=150,Description="Tofaş",ModelYear=2000},
             new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=100,Description="Mersedes",ModelYear=2005},
             new Car{Id=4,BrandId=2,ColorId=4,DailyPrice=220,Description="Bmw",ModelYear=2015},
             new Car{Id=5,BrandId=3,ColorId=5,DailyPrice=250,Description="Jaguar",ModelYear=2012},

            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

       
        public void Deleted(Car car)
        {
            Car carToDelete =
            carToDelete = _cars.SingleOrDefault(c=>c.Id ==car.Id);  //linq //=> öyle ki
            _cars.Remove(carToDelete);
        }

       
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id ).ToList();
        }

        public void Update(Car car)
        {
            //gonderdıgım urun ıd sine sahip olan listedeki ürünü bul 
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        

        
    }
}
