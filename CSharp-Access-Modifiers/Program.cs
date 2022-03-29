using System;
using ClassLibrary;

namespace CSharp_Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Yusif";
            employee1.Surname = "Osmanov";
            employee1.Salary = 2300;

            Employee employee2 = new Employee();
            employee2.Name = "Hikmet";
            employee2.Surname = "Abbasov";
            employee2.Salary = 230;

            Department dep = new Department();
            dep.EmployeeLimit = 2;
            dep.AddEmployee(employee1);
            dep.AddEmployee(employee2);
            foreach (var item in dep.Employees)
            {
                Console.WriteLine($"name: {item.Name} || surname: {item.Surname} || salary: {item.Salary}");
            }
        }
    }
}
