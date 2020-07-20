using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed;

        
    public int NumPassengers
    {
        get { return _numPassengers; }
            set
            {
                if (value > 0)
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
    public int Position { get; protected set; }

        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }

        public Vehicle()
        {
            _speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _speed = speed;
            _capacity = capacity;
        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: { _capacity} passengers: { _numPassengers} speed: {_speed} position: {Position}";
        }
    }
}
