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

            //Data Transformation Object  // DTO
             CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç Adı: " + car.CarName + "\t" + " Marka: " + car.BrandName + "\t" + "Renk: " +
                                  car.ColorName + "\t" + "Günlük Ücret: " + car.DailyPrice);
            }
        }
    }
}
