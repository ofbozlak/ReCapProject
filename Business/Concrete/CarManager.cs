using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                return new SuccessResult(Messages.CarAdded);
                _carDal.Add(car);
            }
            else
            {
                return new ErrorResult(Messages.CartDescriptionInvalid);
            }
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.CarDeleted);
            _carDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {               //SuccessDataResult
            return new ErrorDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarDetailed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new  SuccessDataResult< List < Car >> (_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult < List < Car >> (_carDal.GetAll(p => p.ColorId == id),Messages.GetedCarsByColorId);
        }

        

        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.CarUpdated);
            _carDal.Update(car);
        }
    }
}
