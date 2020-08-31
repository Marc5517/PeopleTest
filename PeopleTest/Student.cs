using System;

namespace PeopleTest
{
    public enum GenderType { male, female }

    public class Person
    {
        private string _name;
        private string _address;

        /// <summary>
        /// Her er gøres det, at navnets længde må ikke være mindre end 2 karakter.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length <= 2) throw new ArgumentException();
                _name = value;
            }
        }

        /// <summary>
        /// Her må addressen ikke være "null".
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentNullException();
                _address = value;
            }
        }

        /// <summary>
        /// Vi giver Gender properties.
        /// </summary>
        public GenderType Gender { get; set; }
    }

    public class Student : Person
    {
        private int _semester;

        /// <summary>
        /// Elevens semester skal være fra 1 til 8.
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                if (value <= 0 || value >= 9) throw new ArgumentOutOfRangeException();
                _semester = value;
            }
        }

        public Student(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Hvor vi kan starte vores test.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
