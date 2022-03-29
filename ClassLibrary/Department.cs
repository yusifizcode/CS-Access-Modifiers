using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        public Department()
        {
            this._employees = new Employee[0];
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int SalaryLimit { get; set; }
        private Employee[] _employees;
        public Employee[] Employees
        {
            get { return _employees; }
        }

        public Employee[] AddEmployee(Employee employee)
        {
            if (this.EmployeeLimit>this._employees.Length)
            {
                Array.Resize(ref this._employees, this._employees.Length + 1);
                this._employees[_employees.Length-1] = employee;
            }
            else
            {
                Console.WriteLine("limiti kecdiniz");
            }
            return this._employees;
        }

    }
}
