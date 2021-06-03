using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        public IDataResult<List<Customer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Customer>> GetCustomersByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}