using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var result =_rentalCarDal.GetAll(c=>(c.CarId == rentalCar.CarId)&& !(c.RentDate==null && c.ReturnDate==null) && (c.ReturnDate==null)).ToList();
            if (result.Count==0)
            {
                _rentalCarDal.Add(rentalCar);
                return new SuccessResult(Messages.RentalAdded);
                        
            }
            else
            {
                return new ErrorResult(Messages.NotRentalAdded);
            }
            
        }

        public IResult Delete(RentalCar rentalCar)
        {
            _rentalCarDal.Delete(rentalCar);
            return new SuccessResult(Messages.RentalDeleted);
            
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
            _rentalCarDal.Update(rentalCar);
            return new SuccessResult(Messages.RentalUpdated);
            
        }
    }
}
