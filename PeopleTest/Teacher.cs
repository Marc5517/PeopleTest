using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleTest
{
    public class Teacher : Person
    {

        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0) throw new ArgumentException();
                _salary = value;
            }
        }

        public Teacher(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
