﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }
      
        public Person()
        {

        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
