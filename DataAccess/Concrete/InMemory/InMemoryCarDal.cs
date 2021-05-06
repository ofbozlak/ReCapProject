using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId = 1, CategoryId = 1, BrandId = 1, ColorId = 1, ModelId = 1, DailyPrice = 10000, Description = "Hafif Hasarlı" },
                new Car { CarId = 2, CategoryId = 2, BrandId = 2, ColorId = 2, ModelId = 2, DailyPrice = 30000, Description = "Temiz Kullanılmış" },
                new Car { CarId = 3, CategoryId = 2, BrandId = 3, ColorId = 2, ModelId = 2, DailyPrice = 50000, Description = "Çizik Var" },
                new Car { CarId = 4, CategoryId = 1, BrandId = 4, ColorId = 3, ModelId = 1, DailyPrice = 5000, Description = "Hafif Hasarlı" },
                new Car { CarId = 5, CategoryId = 3, BrandId = 5, ColorId = 1, ModelId = 2, DailyPrice = 100000, Description = "Sıfır" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
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

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.CarId == car.CarId ).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelId = car.ModelId;
        }
    }
}
