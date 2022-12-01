using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on
                             r.CarId equals c.CarId
                             join cu in context.Customers
                             on
                             r.CustomerId equals cu.UserId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select
                             new RentalDetailDto { Id = r.Id, FirstName = u.FirstName, LastName = u.LastName, CompanyName = cu.CompanyName, CarName = c.Description, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();

            }
        }
    }
}
