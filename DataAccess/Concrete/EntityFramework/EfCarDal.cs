using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = 
                    from ca in context.Cars
                    join co in context.Colors
                        on ca.ColorId equals co.Id
                    join b in context.Brands
                        on ca.BrandId equals b.Id
                    select new CarDetailDto
                    {
                        CarName = ca.CarName,
                        BrandName=b.BrandName,
                        ColorName = co.ColorName,
                        DailyPrice=ca.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}