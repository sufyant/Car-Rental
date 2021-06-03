using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public IDataResult<List<User>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<User> GetUserById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}