using static AnonymousMethod;

public class program
{
    public static void Main(string[] args)
    {
        string ch = "";
        Console.WriteLine("1. Delegate");
        Console.WriteLine("2. Multicast Delegate");
        Console.WriteLine("3. Generic Delegate");
        Console.WriteLine("4. Function Delegate");
        Console.WriteLine("5. Action Delegate");
        Console.WriteLine("6. Predicate Delegate");
        Console.WriteLine("7. Anonymous Method");
        Console.WriteLine("8. Events");
        Console.WriteLine(" ");

        do
        {
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Set target method by creating object of delegate
                    MyDelegate del = Delegates.Method1; //delegate name = classname.methodname
                    del("Chirag Gupta");
                    del = Delegates.Method2;
                    del("Vidhushi Sharma");//invoking the delegate
                    Delegates.InvokeDelegate(del);//Passing delegate as a parameter
                    break;

                case 2:
                    MyDelegate2 del1 = MulticastDelegate.MethodA;
                    MyDelegate2 del2 = MulticastDelegate.MethodB;

                    MyDelegate2 del3 = del1 + del2;
                    Console.WriteLine("After del1 + del2");
                    del3("Hello World");

                    del3 = del3 - del2;
                    Console.WriteLine("After del3 - del2");
                    del3("Hello World");

                    del3 -= del1;
                    Console.WriteLine("After del1 - del1");
                    del3("Chirag Gupta");
                    break;

                case 3:
                    add<int> sum = GenericDelegate.Sum;
                    Console.WriteLine(sum(10, 20));
                    add<string> conct = GenericDelegate.Concat;
                    Console.WriteLine(conct("Hello", "World!!"));
                    break;

                case 4:
                    Func<int, int, int> add = FuncDelegate.Sum;
                    int result = add(10, 10);
                    Console.WriteLine("Function Delegate: " + result);
                    Console.WriteLine(" ");


                    Console.WriteLine("Assigning an anonymous method to the Func delegate:");
                    int randomNumber = FuncDelegate.getRandomNumber();
                    Console.WriteLine("Random number: " + randomNumber);
                    Console.WriteLine(" ");
                    break;

                case 5:
                    Console.WriteLine("Action Delegate");
                    Action<int> printActionDel = ActionDelegate.ConsolePrint;
                    //Or
                    //Action<int> printActionDel = new Action<int>(ConsolePrint);
                    printActionDel(10);


                    Console.WriteLine("Action Delegate using anonymous objec");
                    Action<int> printActionDel1 = delegate (int i)
                    {
                        Console.WriteLine(i);
                    };
                    printActionDel1(67696);
                    Console.WriteLine(" ");
                    break;

                case 6:
                    Predicate<string> isUpper = PredicateDelegate.IsUpperCase;

                    bool result1 = isUpper("Predicate Delegate!!");

                    Console.WriteLine(result1);
                    Console.WriteLine(" ");

                    Predicate<string> isUpper1 = delegate (string s) { return s.Equals(s.ToUpper()); };
                    bool result2 = isUpper1("Predicate delegate with anonymous method!!");

                    Console.Write(result2);
                    break;

                case 7: //Anonymous Method
                    Print print = delegate (int val)
                    {
                        Console.WriteLine("Inside Anonymous method. Value: {0}", val);
                        Console.WriteLine(" ");
                    };

                    print(100);

                    //Anonymous methods can access variables defined in an outer function.
                    Console.WriteLine("Anonymous methods can access variables defined in an outer function.");
                    int i = 10;

                    Print prnt = delegate (int val)
                    {
                        val += i;
                        Console.WriteLine("Anonymous method: {0}", val);
                    };

                    prnt(1001);


                    //Anonymous methods can also be passed to a method that accepts the delegate as a parameter.
                    sampleProgram.PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
                    break;

                case 8:
                    //This is a subscriber implementation of the event who will take action on the event occured
                    AddTwoNumbers a = new AddTwoNumbers();
                    //Event gets binded with delegates
                    a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage); // ev_oddnumber event calls the delegate //4
                    a.Add();
                    Console.Read();

                    static void EventMessage() //Delegates calls this method when event raised.  //5 
                    {
                        Console.WriteLine("********Event Executed : This is Odd Number**********");
                    }
                    break;
            }
            Console.WriteLine("Do you want to continue: y/n");
            ch = Console.ReadLine();
        }
        while (ch.Equals("y"));
    }
}
