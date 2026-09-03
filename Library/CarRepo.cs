using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class CarRepo
    {
        private int carId = 1;
        private Dictionary<int, Car> _carRepo = new Dictionary<int, Car>();

        public CarRepo()
        {
            _carRepo.Add(carId, new Car("Toyota", "Camry", 2020, 25000, true));
            _carRepo.Add(++carId, new Car("Honda", "Civic", 2019, 20000, true));
            _carRepo.Add(++carId, new Car("Ford", "Mustang", 2021, 40000, true));
            _carRepo.Add(++carId, new Car("Itoren", "C1", 2006, 5000, false));
        }   



        public Car Create(string name, string model, int year, decimal price, bool forSale)
        {
            Car car = new Car(name, model, year, price, forSale);
            _carRepo.Add(++carId, car);
            return car;
        }

        public List<Car> carsForSale = new List<Car>();

        public Car SetCarForSale(int id, decimal price)
        {
            if (_carRepo.TryGetValue(id, out var car))
            {
                if (!car.ForSale)
                {
                    car.ForSale = true;
                    car.Price = price;
                    carsForSale.Add(car);
                    return car;
                }
            }

            return null;
        }

       

        
    }
}
