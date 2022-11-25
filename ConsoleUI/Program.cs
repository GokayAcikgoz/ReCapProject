using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryBrandDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.CarId);
}
