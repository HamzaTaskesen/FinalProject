using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarCoContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarCoContext context = new CarCoContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors
                             on p.Description equals c.ColorName
                             select new CarDetailDto
                             {
                                 Id = p.CarId,
                                 BrandId = p.BrandId,
                                 ColorId = p.ColorId

                             };
                return result.ToList();
            }
        }
    }
}
