namespace OOPs;
class program
{
    public static void Main(string[] args)
    {
        string ch = "";

        Console.WriteLine("1. Single Inharitance");
        Console.WriteLine("2. Multilevel Inharitance");
        Console.WriteLine("3. Hierarchical Inheritance");
        Console.WriteLine("4. Complie Time Polymorphism");
        Console.WriteLine("5. RunTime Polymorphism");
        Console.WriteLine("6. Abstraction");
        Console.WriteLine("7. Interface");
        Console.WriteLine("8. Encapsulation");
        Console.WriteLine("9. Method Hiding");
        Console.WriteLine("10. Dependency Injection");
        Console.WriteLine(" ");

        do
        {
            Console.WriteLine("Enter Our Choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Car c1 = new Car();
                    c1.Engine();
                    c1.wheels();
                    break;

                case 2:
                    Motor m1 = new Motor();
                    m1.Engine();
                    m1.wheels();
                    m1.steering();
                    break;

                case 3:
                    cycle cy1 = new cycle();
                    cy1.Engine();
                    cy1.handle();
                    break;

                case 4:
                    Console.WriteLine(Polymorphism.add(10, 20));
                    Console.WriteLine(Polymorphism.add(20, 30, 50));
                    break;

                case 5:
                    RuntimePoly p1 = new Person();
                    p1.arts();//coding

                    Person p2 = new Person();
                    p2.arts();// Coding

                    RuntimePoly r1 = new RuntimePoly();
                    r1.arts();//singing                
                    break;

                case 6:
                    Abstraction Ab = new Human();
                    Ab.active();//Working                    
                    Ab.eating();
                    Ab = new Animal();
                    Ab.active();//Sleeping
                    break;

                case 7:
                    IDevelopment id1 = new developer();
                    id1.coding();
                    id1 = new QA();
                    id1.coding();
                    break;

                case 8:
                    Buisness T = new Buisness();
                    T.SetType("Food");
                    Console.WriteLine(T.GetType());

                    Business2 T2 = new Business2();
                    T2.Name = "Fashion";
                    Console.WriteLine(T2.Name);
                    break;

                case 9:
                    BaseClass baseClass = new BaseClass();
                    baseClass.MethodToHide();
                    DerivedClass derivedObj = new DerivedClass();
                    derivedObj.MethodToHide(); // Output: Derived class method
                    break;

                case 10: //creating object
                    Service1 s1 = new Service1();
                    //passing dependency
                    Client cli1 = new Client(s1);
                    //TO DO:
                    cli1.ServeMethod();

                    Service2 s2 = new Service2();
                    //passing dependency
                    cli1 = new Client(s2);
                    //TO DO:
                    cli1.ServeMethod();
                    break;

                    //case 10:// create instances of the Product class
                    //Product product1 = new Product { Name = "Product 1", Price = 10.99M };
                    //Product product2 = new Product { Name = "Product 2", Price = 19.99M };
                    //Product product3 = new Product { Name = "Product 3", Price = 7.50M };

                    //// create an instance of the ShoppingCart class
                    //ShoppingCart cart = new ShoppingCart();

                    //// add products to the shopping cart
                    //cart.AddProduct(product1);
                    //cart.AddProduct(product2);
                    //cart.AddProduct(product3);

                    //// remove a product from the shopping cart
                    //cart.RemoveProduct(product2);

                    //// display the contents of the shopping cart
                    //Console.WriteLine("Shopping Cart:");
                    //foreach (Product product in cart.GetProducts())
                    //{
                    //    Console.WriteLine("- {0} (${1})", product.Name, product.Price);
                    //}
                    //Console.WriteLine("Total: ${0}", cart.GetTotal());
                    //break;



            }

            Console.WriteLine("Do you want to continue: y/n");
            Console.WriteLine(" ");

            ch = Console.ReadLine();

        }
        while (ch.Equals("y"));
    }
}


