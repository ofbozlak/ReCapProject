using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal  _customerdal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerdal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            return new SuccessResult(Messages.CustomerAdded);
            _customerdal.Add(customer);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.CustomerDeleted);
            _customerdal.Delete(customer);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll());
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerdal.Get(c => c.CustomerId == customerId));
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.CustomerUpdated);
            _customerdal.Update(customer);
        }
    }
}
