using System.Collections.Generic;
using WebApplication3.Interfaces;

namespace WebApplication3.services
{
    public class CarsServices: ICarServices
    {
        public CarsServices()
        {

        }

        private List<string> cars = new List<string> { "audi" , "bmw" , "volvo" }; 
        public List<string> GetCars()
        {
            return cars;
        }
        public List<string> PostCars(string car)
        {
            cars.Add(car);
            return cars;
        }
        public List<string> DeleteCars(string car)
        {
            cars.Remove(car);
            return cars;
        }
    }
}
