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

            Car car1 = new Car
            {
                CarId =6,
                CategoryId=2,
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
