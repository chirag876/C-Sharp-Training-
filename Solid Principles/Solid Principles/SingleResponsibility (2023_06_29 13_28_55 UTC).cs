using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Single responsibilty pattern
namespace Solid_Principles
{
    //// Example of a class that violates the Single Responsibility Principle
    //public class Customer
    //{
    //    public string Name { get; set; }
    //    public string Address { get; set; }

    //    public void Save()
    //    {
    //        // Code to save the customer to the database
    //    }

    //    public void SendEmail(string message)
    //    {
    //        // Code to send an email to the customer
    //    }
    //}

    /*In the first example, the Customer class is responsible for both saving the customer to the database and sending an email to the customer.This violates the Single Responsibility
    Principle because the class has more than one responsibility.*/

  

    // Example of a class that follows the Single Responsibility Principle
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("The customer has been saved");
            Console.WriteLine("");
        }
    }

    public class EmailService
    {
        public void SendEmail(Customer customer, string message)
        {
            // Code to send an email to the customer
            Console.WriteLine("The email has been sent");
            Console.WriteLine("");
            Console.WriteLine(customer.Name + " " + customer.Address + " " + message);

        }
    }
}

/*In this implementation, the Customer class has a single responsibility of storing customer information. The CustomerRepository class is responsible for saving the customer to the 
 * database, and the EmailService class is responsible for sending an email to the customer. Each class has a clear and focused responsibility, which makes the code more maintainable,
 * extensible, and testable.*/

//To use this implementation, you can create a Customer object and pass it to the CustomerRepository and EmailService classes as needed