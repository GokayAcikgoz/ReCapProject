using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetAll().Data)
{
    Console.WriteLine(car.CarId);
}
