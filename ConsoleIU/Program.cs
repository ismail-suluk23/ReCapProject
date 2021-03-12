﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            // AddCar(carManager);

            // GetDailyPrice(carManager);

            // GetColors(colorManager);

            // GetUserEmail(userManager);

            // AddUserManuel(userManager);

            // TakeInfoAndAddUser(userManager);

            Car car = new Car
            {
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 200,
                Description = "New Model",
                ModelYear = 2021,
            };

            carManager.Delete(car);
        }

        //private static void TakeInfoAndAddUser(UserManager userManager)
        //{
        //    Console.Write("FirstName: ");
        //    string FirstName = Console.ReadLine();

        //    Console.Write("LastName: ");
        //    string Lastname = Console.ReadLine();

        //    Console.Write("Email: ");
        //    string Email = Console.ReadLine();

        //    Console.Write("Password: ");
        //    string Password = Console.ReadLine();

        //    User user = new User
        //    {
        //        FirstName = FirstName,
        //        LastName = Lastname,
        //        Email = Email,

        //    };
        //    userManager.Add(user);
        //}

        //private static void AddUserManuel(UserManager userManager)
        //{
        //    User user = new User
        //    {
        //        Email = "ismil123@gmail.com",
        //        FirstName = "ismail",
        //        LastName = "Suluk",
        //        Password = "ismail123"
        //    };

        //    userManager.Add(user);
        //}

        //private static void GetUserEmail(UserManager userManager)
        //{
        //    foreach (User user in userManager.GetUsers().Data)
        //    {
        //        Console.WriteLine(user.Email);
        //    }
        //}

        //private static void GetColors(ColorManager colorManager)
        //{
        //    foreach (Color color in colorManager.GetColors().Data)
        //    {
        //        Console.WriteLine(color.Name);

        //    }
        //}

        //private static void AddCar(CarManager carManager)
        //{
        //    Car car = new Car
        //    {
        //        BrandId = 2,
        //        ColorId = 3,
        //        DailyPrice = 200,
        //        Description = "New Model",
        //        ModelYear = 2021,
        //    };
        //    carManager.Add(car);
        //}

        //private static void GetDailyPrice(CarManager carManager)
        //{
        //    foreach (var car in carManager.GetByDailyPrice(750, 1000).Data)
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}



    }
}
