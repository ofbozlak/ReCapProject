using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalCarService
    {
        IDataResult<List<RentalCar>> GetAll();
        IDataResult<RentalCar> GetById(int rentalCarId);
        IResult Add(RentalCar rentalCar);
        IResult Delete(RentalCar rentalCar);
        IResult Update(RentalCar rentalCar);
    }
}
