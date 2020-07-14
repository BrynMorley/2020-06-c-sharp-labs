using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        
    public int NumPassengers
    {
        get { return _numPassengers; }
            set
            {
                if (value >= 0)
                {
                    if(value <= _capacity)
                    {
                        _numPassengers = value;
                    }
                    else
                    {
                        _numPassengers = _capacity;
                    }
                }
                else
                {
                    _numPassengers = 0;
                }
            }
    }
    public int Position { get; private set; }

        public string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }

        public Vehicle()
        {
            _speed = 10;
        }

        public Vehicle(int capacity, int speed)
        {
            _speed = speed;
            _capacity = capacity;
        }
    }
}
