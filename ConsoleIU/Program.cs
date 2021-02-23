using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId +"----"+ car.Description+"---"+car.ColorId+"-----"+car.BrandId+"-----"+car.ModelYear+"----"+car.DailyPrice);
            }

        }
    }
}
