using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalCarManager : IRentalCarService
    {
        IRentalCarDal _rentalCarDal;

        public RentalCarManager(IRentalCarDal rentalCarDal)
        {
            _rentalCarDal = rentalCarDal;
        }


        public IResult Add(RentalCar rentalCar)
        {
            //if ((rentalCar.RentDate == null && rentalCar.ReturnDate == null) || (!(rentalCar.RentDate == null) && !(rentalCar.ReturnDate==null)))
            //{
                return new SuccessResult(Messages.RentalAdded);
                _rentalCarDal.Add(rentalCar);
           // }
           // else
           // {
              //  return new ErrorResult(Messages.NotRentalAdded);
           // }
            
        }

        public IResult Delete(RentalCar rentalCar)
        {
            return new SuccessResult(Messages.RentalDeleted);
            _rentalCarDal.Delete(rentalCar);
        }

        public IDataResult<List<RentalCar>> GetAll()
        {
            return new SuccessDataResult<List<RentalCar>>(_rentalCarDal.GetAll());
        }

        public IDataResult<RentalCar> GetById(int rentalCarId)
        {
            return new SuccessDataResult<RentalCar>(_rentalCarDal.Get(c => c.RentalCarId == rentalCarId));
        }

        public IResult Update(RentalCar rentalCar)
        {
            return new SuccessResult(Messages.RentalUpdated);
            _rentalCarDal.Update(rentalCar);
        }
    }
}
