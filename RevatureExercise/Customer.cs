using System;

namespace RevatureExercise
{
    class Customer : Person 
    {
        string Address;
        string City;
        string State;
        public Customer(string address, string city, string state)
        {
            Address = address;
            City = city;
            State = state;
        }
   
        static void Main(string[] args)
        {
            Customer cust1 = new Customer();
            cust1.Address = "1234 Awesome St.";
            cust1.City = "Berlin";
            cust1.State = "Wisconsin";

            Customer[] customers = new Customer[]{};

            customers[0] = new Customer(cust1.Address, cust1.City, cust1.State);

            Console.WriteLine(customers[0]);
            
        }
    }
}