using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateAndMileage
{
    class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private int _mileage;
        private decimal _rate;

        //constructor
        public Car(string make, string model, int year, int mileage, decimal rate)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
            _rate = rate;
        }
        //properties
        public string Make { get { return _make; } }
        public string Model { get { return _model; } }
        public int Year { get { return _year; } }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
        public decimal Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                _rate = value;
            }
        }
    }
}
