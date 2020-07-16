using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Camera : IShootable
    {
        private string _brand;
        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot() 
        {
            return $"Snap!! Shooting a {this.ToString()} {_brand}";
        }

    }
}
