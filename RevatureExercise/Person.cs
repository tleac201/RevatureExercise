using System;
/*
1. new git repo
2. VS code a new project 
3. Person class  (Id, FirstName, LastName, DOB)
4. Employee class (Department, EmployeeId, DOJ)
5. Customer Class (Address, City, State)
6. An array of employees -> populate values
    An array of customers -> populate values
7. Print all values of employees and customers
8. Sort array by FirstName
9. Push code to git repo 
---------- gitignore bin/ and obj/
*/
namespace RevatureExercise
{
    class Person
    {
        
        int Id;
        string FirstName;
        string LastName;
        DateTime DOB;
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Id = 100;
            p1.FirstName = "Bob";
            p1.LastName = "The Builder"; 
        }

    }
}
