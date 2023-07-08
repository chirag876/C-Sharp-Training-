using CreationalDesignPattern;
using DesignPattern.BehavorialDesignPattern;
using DesignPattern.StructuralDesignPattern;

public class program
{
    public static void Main(string[] args)
    {

        string ch = "";
        Console.WriteLine("1.  Abstract Factory Design Pattern");
        Console.WriteLine("2.  Factory Method Design Pattern");
        Console.WriteLine("3.  Facade Design Pattern");
        Console.WriteLine("4   Bridge Design Pattern");
        Console.WriteLine("5   Adapter Design Pattern");
        Console.WriteLine("6.  Proxy Design Pattern");
        Console.WriteLine("7.  Command Design Pattern");
        Console.WriteLine("8.  Interpreter Design Pattern");
        Console.WriteLine("9.  Mediator design pattern");
        Console.WriteLine("10. State design pattern");
        Console.WriteLine("11. Iterator Design Pattern");
        Console.WriteLine(" ");

        do
        {
            Console.WriteLine("Enter your choice....");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //we create two instances of the cardealer class one with an electriccarfactory and one with a gasolinecarfactory when we call the buildcar() method the program creates an instance of the appropriate engine and wheels based on the factory that was passed to the constructor and outputs the results to the console. The output shows that the program creates an electric car with regular wheels using the ElectricCarFactory, and a gasoline car with alloy wheels using the GasolineCarFactory. 

                    CarDealer dealer = new CarDealer(new ElectricCarFactory());
                    dealer.BuildCar(); // Output: Building car with: Starting electric engine... Spinning regular wheels...

                    dealer = new CarDealer(new GasolineCarFactory());
                    dealer.BuildCar(); // Output: Building car with: Starting gasoline engine... Spinning alloy wheels...
                    break;

                case 2:
                    /*create an instance of a concrete creator and use it to create a product without knowing its specific implementation.*/

                    /*creates an instance of ConcreteCreatorA, and then uses it to create a ConcreteProductA object, without knowing its specific implementation.
                     * The GetName() method of the ConcreteProductA object is called, and the output is "Product A".*/
                    Creator creator = new ConcreteCreatorA();
                    IProduct product = creator.CreateProduct();
                    Console.WriteLine(product.GetName()); // Output: Product A
                    break;

                case 3:
                    Order.PlaceOrder();
                    break;

                case 4:
                    SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
                    sonyRemoteControl.SwitchOn();
                    sonyRemoteControl.SetChannel(101);
                    sonyRemoteControl.SwitchOff();

                    Console.WriteLine();
                    SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
                    samsungRemoteControl.SwitchOn();
                    samsungRemoteControl.SetChannel(202);
                    samsungRemoteControl.SwitchOff();
                    break;

                case 5:
                    Adaptee adaptee = new Adaptee();
                    ITarget target = new Adapter(adaptee);
                    Client client = new Client();
                    client.MakeRequest(target);
                    break;

                case 6:
                    IImage Image1 = new ProxyImage("Tiger Image");

                    Console.WriteLine("Image1 calling DisplayImage first time :");
                    Image1.DisplayImage(); // loading necessary
                    Console.WriteLine("Image1 calling DisplayImage second time :");
                    Image1.DisplayImage(); // loading unnecessary
                    Console.WriteLine("Image1 calling DisplayImage third time :");
                    Image1.DisplayImage(); // loading unnecessary
                    Console.WriteLine();
                    IImage Image2 = new ProxyImage("Lion Image");
                    Console.WriteLine("Image2 calling DisplayImage first time :");
                    Image2.DisplayImage(); // loading necessary
                    Console.WriteLine("Image2 calling DisplayImage second time :");
                    Image2.DisplayImage(); // loading unnecessary
                    break;

                case 7:
                    Document document = new Document();
                    ICommand openCommand = new OpenCommand(document);
                    ICommand saveCommand = new SaveCommand(document);
                    ICommand closeCommand = new CloseCommand(document);
                    MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
                    menu.clickOpen();
                    menu.clickSave();
                    menu.clickClose();
                    break;

                case 8:
                    List<AbstractExpression> objExpressions = new List<AbstractExpression>();
                    Context context = new Context(DateTime.Now);
                    Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
                    context.expression = Console.ReadLine();
                    string[] strArray = context.expression.Split(' ');
                    foreach (var item in strArray)
                    {
                        if (item == "DD")
                        {
                            objExpressions.Add(new DayExpression());
                        }
                        else if (item == "MM")
                        {
                            objExpressions.Add(new MonthExpression());
                        }
                        else if (item == "YYYY")
                        {
                            objExpressions.Add(new YearExpression());
                        }
                    }
                    objExpressions.Add(new SeparatorExpression());
                    foreach (var obj in objExpressions)
                    {
                        obj.Evaluate(context);
                    }
                    Console.WriteLine(context.expression);
                    break;

                case 9:
                    FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
                    User Chirag = new ConcreteUser(facebookMediator, "Chirag");
                    User Virushika = new ConcreteUser(facebookMediator, "Virushika");
                    User Manoj = new ConcreteUser(facebookMediator, "Manoj");
                    User Kapil = new ConcreteUser(facebookMediator, "Kapil");

                    facebookMediator.RegisterUser(Chirag);
                    facebookMediator.RegisterUser(Virushika);
                    facebookMediator.RegisterUser(Manoj);
                    facebookMediator.RegisterUser(Kapil);

                    Chirag.Send("I have something to share");
                    Console.WriteLine();
                    Virushika.Send("What do you want to share?");
                    break;

                case 10:// create Context object and suplied current state or initial state (state A).
                    Context1 context1 = new Context1(new StateA());

                    //Change state request from A to B.
                    context1.Request();

                    //Change state request from B to C.
                    context1.Request();

                    //Change state request from C to A.
                    context1.Request();
                    break;

                case 11:
                    //Creating an aggregate
                    ConcreteAggregate aggregate = new ConcreteAggregate();

                    aggregate[0] = "Item 1";
                    aggregate[1] = "Item 2";
                    aggregate[2] = "Item 3";
                    aggregate[3] = "Item 4";
                    aggregate[4] = "Item 5";

                    // Creating the Iterator and assigning an aggregate to it
                    Iterator i = aggregate.Create();
                    Console.WriteLine("Iterating the collection:");

                    string currentItem = i.FirstItem();
                    while (currentItem != null)
                    {
                        Console.WriteLine(currentItem);
                        currentItem = i.NextItem();
                    }
                    break;

            }

            Console.WriteLine("Do you want to Continue");
            ch = Console.ReadLine();
        }

        while (ch.Equals("y"));


    }


}
