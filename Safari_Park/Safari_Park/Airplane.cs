using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Airplane :Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity)
        {

        }
        public Airplane(int capacity, int speed, string airline)
        {
            _capacity = capacity;
            _speed = speed;
            _airline = airline;
        }
      
        public void Ascend(int distance)
        {
            _altitude += distance;
        }

        public void Descend(int distance)
        {
            _altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {_altitude} metres.";
        }
        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {_altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {_altitude}"; 
        }


    }
}
