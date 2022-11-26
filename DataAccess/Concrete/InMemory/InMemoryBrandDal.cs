using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryBrandDal()
        {
            _cars = new List<Car>()
            {
                new Car(){CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2022, DailyPrice = 1500, Description = "Wolsvagen Golf"},
                new Car(){CarId = 2, BrandId = 1, ColorId = 2, ModelYear = 2019, DailyPrice = 2200, Description = "Wolsvagen Passat"},
                new Car(){CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 2007, DailyPrice = 1200, Description = "Fiat Fiorino"},
                new Car(){CarId = 4, BrandId = 2, ColorId = 1, ModelYear = 2009, DailyPrice = 1000, Description = "Fiat Egea"},
                new Car(){CarId = 5, BrandId = 2, ColorId = 1, ModelYear = 2015, DailyPrice = 850, Description = "Fiat Punto"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
