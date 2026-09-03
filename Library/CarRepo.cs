using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class CarRepo
    {
        private int carId = 1;
        private Dictionary<int, Car> _carRepo = new Dictionary<int, Car>();
        public void AddCar(Car car)
        {
            _carRepo.Add(++carId, car);
        }

        public IEnumerable<Car> ListCars()
        {
            return _carRepo.Values;
        }
    }
}
