using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("*******************************************");
            Console.WriteLine(carManager.GetById(3).Description);
            Console.WriteLine("*******************************************");
            foreach (var car in carManager.GetAllByDailyPriceRange(9000, 29000))
            {
                Console.WriteLine(car.Id + "-" + car.DailyPrice);
            }
        }
    }
}
