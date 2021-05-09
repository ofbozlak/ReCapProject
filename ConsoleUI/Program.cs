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
            //CarManager carManager = new CarManager(new EfCarDal());
            //GetCarDetailsText(carManager);


            //RentalCar rentalCar1 = new RentalCar()
            //{
            //    RentalCarId=2,
            //    CarId = 3,
            //    CustomerId = 2,
            //    RentDate = "8.05.2021",
            //    ReturnDate= "10.05.2021"
            //};


            //RentalCarManager rentalCarManager = new RentalCarManager(new EfRentalCarDal());
            //rentalCarManager.Add(rentalCar1);

            //var result = rentalCarManager.Add(rentalCar1);
            //if (result.Success == true)
            //{
            //    Console.WriteLine(result.Massage);
            //}
            //else
            //{
            //    Console.WriteLine(result.Massage);
            //}


        }

        private static void GetCarDetailsText(CarManager carManager)
        {
            

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("CarId" + ":" + car.CarId + " -- " + "BrandName " + ":" + car.BrandName + "-- " + " ColorName" + ":" + car.ColorName + "-- " + " DailyPrice" + ":" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Massage);
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
                CarId=7,
                CategoryId = 2,
                ColorId = 2,
                BrandId = 1,
                ModelId = 2019,
                DailyPrice = 89,
                Description = "Temiz"
            };


            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
        }
    }
}
