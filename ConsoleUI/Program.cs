﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
              foreach (var car in result.Data )
            {
                Console.WriteLine(car.BrandName + "/" + car.ColorName);
            }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
