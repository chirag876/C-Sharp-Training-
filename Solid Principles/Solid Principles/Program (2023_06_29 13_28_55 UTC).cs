using System.Collections;
using System.Text.Json;
using System;
using Solid_Principles;

public class program
{
    public static void Main()
    {
        string ch = "";

        Console.WriteLine("1. Single Responsibility Pattern");
        Console.WriteLine("2. Open/Closed Principle");
        Console.WriteLine("3. Liskov Substitution Principle");
        Console.WriteLine("4. Interface Segregation Principle");
        
        Console.WriteLine(" ");

        do
        {
            Console.WriteLine("Enter your choice....");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Customer customer = new Customer //Creating customer object
                    {
                        Name = "John Smith",
                        Address = "123 Main St"
                    };

                    CustomerRepository customerRepository = new CustomerRepository();
                    customerRepository.Save(customer);

                    EmailService emailService = new EmailService();
                    emailService.SendEmail(customer, "Thank you for your business!");
                    break;

                    case 2:

                    /*To call the Area method of the Rectangle and Circle classes in the Main function, you can create instances of these classes and then call
                     * their Area methods*/

                    Rectangle rectangle = new Rectangle();
                    rectangle.Width = 5;
                    rectangle.Height = 10;
                    double rectangleArea = rectangle.Area(); //storing the result in a rectangleArea variable.

                    Circle circle = new Circle();
                    circle.Radius = 5;
                    double circleArea = circle.Area();

                    Console.WriteLine($"Rectangle area: {rectangleArea}");
                    Console.WriteLine($"Circle area: {circleArea}");
                    break;

                /*In this example, we first create an instance of the Rectangle class and set its Width and Height properties to 5 and 10, respectively. 
                 * We then call the Area method of the rectangle object and store the result in a rectangleArea variable. Similarly, we create an instance
                 * of the Circle class, set its Radius property to 5, and call its Area method, storing the result in a circleArea variable. Finally, 
                 * we print out the values of rectangleArea and circleArea to the console.*/

                case 3:
                    Animal myAnimal = new Animal();
                    myAnimal.MakeSound(); // outputs "The animal makes a sound."

                    Animal myCat = new Cat();
                    myCat.MakeSound(); // outputs "Meow!"

                    Animal myDog = new Dog();
                    myDog.MakeSound(); // outputs "Woof!"
                    break;

                    case 4: OnlineOrder onlineOrder = new OnlineOrder();
                    onlineOrder.ProcessCard();
                    onlineOrder.Purchase();

                    CashOrder cashOrder = new CashOrder();
                    //cashOrder.ProcessCard();
                    cashOrder.Purchase();
                    break;

                    case 5:
                    Person.GetPersonName();
                    break;

            }
            Console.WriteLine("Do you want to Constinue press(y/n)");
            ch = Console.ReadLine();
        }
        while (ch.Equals("y"));
    }
}