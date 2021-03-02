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

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç Açıklaması: " + car.CarName + "/  " + " Marka: " + car.BrandName + "/  " + "Renk: " +
                                      car.ColorName + "/  " + "Günlük Ücret: " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
