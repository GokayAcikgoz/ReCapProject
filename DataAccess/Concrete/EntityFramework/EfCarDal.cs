using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on
                             c.BrandId equals b.BrandId
                             join co in context.Colors
                             on
                             c.ColorId equals co.ColorId
                             select
                             new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = co.ColorName, ModelYear = c.ModelYear, DailyPrice = c.DailyPrice };

                return result.ToList();
            }
        }
    }
}
