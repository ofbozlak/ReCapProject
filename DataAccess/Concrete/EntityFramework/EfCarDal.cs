using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
       

        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors 
                             on p.CategoryId equals c.ColorId
                             join b in context.Brands
                             on p.CategoryId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = p.CarId,
                                 ColorName = c.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = p.DailyPrice
                             };
                
                return result.ToList();
            }



        }
    }
}
