using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //EfCarDalTest();
            //EfBrandTest();
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("CarId" + ":" +car.CarId + " -- " + "BrandName "+":" + car.BrandName + "-- " +" ColorName" + ":" +car.ColorName + "-- " +" DailyPrice"+ ":"+ car.DailyPrice);
            }

            
           
        }

        private static void EfBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand
            {
                BrandName = "Tesla"
            };

            brandManager.Add(brand1);
        }

        private static void EfCarDalTest()
        {
            Car car1 = new Car
            {
                CarId = 6,
                CategoryId = 2,
                ColorId = 2,
                BrandId = 1,
                ModelId = 2019,
                DailyPrice = 89000,
                Description = "Temiz"
            };


            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
        }
    }
}
