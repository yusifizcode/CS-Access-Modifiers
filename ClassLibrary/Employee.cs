using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;

        public string Name { get { return _name; } 
            set 
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[0]) && char.IsLetter(value[i]))
                    {
                        _name = value;
                    }
                }  
            } 
        }
        public string Surname { get { return _surname; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[0]) && char.IsLetter(value[i]))
                    {
                        _surname = value;
                    }
                }
            }
        }
        public double Salary { get { return _salary; } set { if (value > 250) { _salary = value; } } }


    }
}
