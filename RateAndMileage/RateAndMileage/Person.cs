using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateAndMileage
{
    class Person
    {
        private string _firstname;
        private string _lastname;
        private string _phone;
        private List<Car> _carList;

        //constructor
        public Person(string firstname, string lastname, string phone)
        {
            _firstname = firstname;
            _lastname = lastname;
            _phone = phone;
            //create the carList
            _carList = new List<Car>();
        }
        //properties
        public string Firstname { get { return _firstname; } }
        public string Lastname { get { return _lastname; } }
        public string Phone { get { return _phone; } }
        public Car[] CarList { get { return _carList.ToArray(); } }

        //add a car to the carlist
        public void AddCar(Car car)
        {
            if (car != null)
                _carList.Add(car);
        }
        public void RemoveCar(Car car)
        {
            if (car != null)
                _carList.Remove(car);
        }
    }
}

