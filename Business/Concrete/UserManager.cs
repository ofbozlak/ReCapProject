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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            return new SuccessResult(Messages.UserAdded);
            _userDal.Add(user);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.UserDeleted);
            _userDal.Delete(user);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(c => c.UserId == userId));
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.UserUpdated);
            _userDal.Update(user);
        }
    }
}
