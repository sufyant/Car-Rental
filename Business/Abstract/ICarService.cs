using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
       List<Car> GetCarsByBrandId(int Id);
       List<Car> GetCarsByColorId(int Id);
       List<Car> GetAll();
       void Add(Car car);
       void Update(Car car);
       void Delete(Car car);

    }
}