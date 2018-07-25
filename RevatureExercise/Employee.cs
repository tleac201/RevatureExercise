using System;

namespace RevatureExercise
{
    class Employee : Person 
    {
         string Department;
        int EmployeeId;
        DateTime DOJ;
        
        public Employee(string department, int employeeId)
        {
            Department = department;
            EmployeeId = employeeId;
        }
        static void Main(string[] args)
        {
            Employee employees = new Employee();
            employees.Department = "Sporting Goods";
            employees.EmployeeId = 100;
            //employees.DOJ = 6/10/2015;

            Employee[] employee = new Employee[]{};

            employee[0] = new Employee(employees.Department, employees.EmployeeId);

            for(int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine(employee[i]);
            }
        }
    }
}