using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarDetailDto> GetCarDetails();
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetCarsByColorId(int ColorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}