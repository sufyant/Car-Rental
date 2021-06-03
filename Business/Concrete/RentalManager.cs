using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        public IDataResult<List<Rental>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int carId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Rental> GetRentalById(int rentalId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(Rental rental)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Rental rental)
        {
            throw new System.NotImplementedException();
        }
    }
}