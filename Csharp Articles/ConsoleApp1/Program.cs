
using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        //////singleton class object
        ////Singleton singleton = new Singleton();
        ////singleton.RegisterVote();

        ////Singleton singleton1 = new Singleton();
        ////singleton1.RegisterVote();
        ////Console.WriteLine("Total number of votes: {0}", Singleton.TotalVotes());

        //////equals class object
        ////Equals equals = new Equals();
        ////equals.equality();

        //////asyncronous class object
        ////Asyncronous asyncronous = new Asyncronous();
        ////asyncronous.LongProcess();
        ////asyncronous.ShortProcess();

        //////asyncronous2 class object
        ////Asyncronous2 asyncronous2 = new Asyncronous2();
        ////asyncronous2.LongProcess2();
        ////asyncronous2.ShortProcess2();

        //////index out range class object
        ////Indexoutofrange indexoutofrange = new Indexoutofrange();
        ////indexoutofrange.range1();
        ////indexoutofrange.range2();

        //////index out range 2 class object
        ////Indexoutofrange2 indexoutofrange2 = new Indexoutofrange2();
        ////indexoutofrange2.arrayrange();

        //////for each loop class object
        //Foreachloop foreachloop = new Foreachloop();
        //foreachloop.loop();
        //foreachloop.loop2();
        //foreachloop.loop3();

        //////null reference exception class object
        ////NullReferenceException nullreferenceexception = new NullReferenceException();
        ////IList<string> cities = null;
        ////nullreferenceexception.DisplayCities(cities);

        //////generate random number class object
        ////RandomNumber randomnumber = new RandomNumber();
        ////randomnumber.randomnumber();
        ////randomnumber.randomnumber2();
        ////randomnumber.randomnumber3();

        //////big integer class object
        ////BigInteger bi1 = 2147483647;
        ////Console.WriteLine("biginteger: {0}", bi1);

        //////biginteger from double value
        ////BigInteger bi2 = new BigInteger(2147483647);
        ////Console.WriteLine("biginteger from double value: {0}", bi2);

        ////// biginteger from int64 value
        ////BigInteger bi3 = new BigInteger(9223372036854775807);
        ////Console.WriteLine("biginteger from int64 value: {0}", bi3);
        ////BigInteger bi4 = new BigInteger(18446744073709551615);
        ////Console.WriteLine("biginteger from uint64 value: {0}", bi4);

        //////duplicate arrays class object
        ////DuplicateArrays duplicate = new DuplicateArrays();
        ////duplicate.duplicatearrays();

        //////string and string class object
        ////Stringandstring stringandstring = new Stringandstring();
        ////stringandstring.stringfunc();

        //////comma separated values class object
        ////Commaseparatedvalues commaseparatedvalues = new Commaseparatedvalues();
        ////commaseparatedvalues.commaseparatedfunc();


        //////StringtoInt class object
        ////StringtoInt stringtoint = new StringtoInt();
        ////stringtoint.stringconvert();
        ////stringtoint.stringconvert2();
        ////stringtoint.stringconvert3();

        //////Count Array class object
        ////CountArray countArray = new CountArray();
        ////countArray.countfunc();


        //////StructReadOnlyConst class object
        ////StructReadOnlyConst mc = new StructReadOnlyConst(50);
        ////mc.ChangeVal(45);
        ////mc.Display();
        ////Console.WriteLine("MyClass.constvar = {0}", StructReadOnlyConst.constvar);
        ////Console.WriteLine("MyClass.staticvar = {0}", StructReadOnlyConst.staticvar);



        ////Stream Writer class object Create StreamWriter object to write string to FileSream
        ////Open file for Read\Write
        ////Create object of FileInfo for specified path            
        ////FileInfo fi = new FileInfo(@"When to use Struct over Class in C#.txt");
        ////FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
        ////StreamWriter sw = new StreamWriter(fs);
        ////sw.WriteLine("Another line from streamwriter");
        ////sw.Close();


        //////ref keyword class object
        ////int myNum = 10;
        ////refKeyword.ProcessNumber(myNum);// pass value type
        ////Console.WriteLine(myNum);
        ////Console.ReadLine();

        ////int myNum1 = 10;
        ////refKeyword.ProcessNumber(ref myNum1); //use ref to pass the parameter by reference 
        ////Console.WriteLine(myNum1);
        ////Console.ReadLine();

        ////int myNum2 = 10;
        ////refKeyword.ProcessNumber(myNum); //Compile-time Error: Must use ref keyword 
        ////Console.WriteLine(myNum);
        ////Console.ReadLine();




        //FileInfo fi2 = new FileInfo(@"D:\DummyFile.txt");//Create an object of FileInfo for specified path   
        //FileStream fs2 = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);//Open a file for Read\Write
        //StreamReader sr = new StreamReader(fs);/*Create an object of StreamReader by passing FileStream object on which it 
        //                                        needs to operates on*/
        //string fileContent = sr.ReadToEnd(); //Use the ReadToEnd method to read all the content from file
        //sr.Close();//Close the StreamReader object after operation
        //fs.Close();


        //////Generic sortedlist class object
        ////SortedList<int, int> descSortedList = new SortedList<int, int>(new DecendingComparer<int>());
        ////descSortedList.Add(1, 1);
        ////descSortedList.Add(4, 4);
        ////descSortedList.Add(3, 3);
        ////descSortedList.Add(2, 2);

        ////for (int i = 0; i < descSortedList.Count; i++)
        ////{
        ////    Console.WriteLine("key: {0}, value: {1}", descSortedList.Keys[i], descSortedList.Values[i]);
        ////}

        ////var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));

        ////SortedList<int, int> descSortedList1 = new SortedList<int, int>(descendingComparer);
        ////descSortedList.Add(1, 1);
        ////descSortedList.Add(4, 4);
        ////descSortedList.Add(3, 3);
        ////descSortedList.Add(2, 2);
        ////for (int i = 0; i < descSortedList.Count; i++)
        ////{
        ////    Console.WriteLine("key: {0}, value: {1}", descSortedList.Keys[i], descSortedList.Values[i]);
        ////}

        //delegatesandevents class objects
        //public Notify MyDelegate;
        //public event Notify MyEvent;
        //MyDelegate = MyMethod;// valid
        //MyDelegate += MyMethod;// valid
        //MyEvent = MyEventHandler;// Error
        //MyEvent += MyEventHandler;// valid



        //// CommandLineArguments program execution starts from here
        //Console.WriteLine("Total Arguments: {0}", args.Length);
        //Console.Write("Arguments: ");
        //foreach (var arg in args)
        //Console.Write(arg + ", ");


        ////Out keyword class object
        ////int a; // declare variable without initialization
        //OutKeyword.OutParamExample(out int a);// calling method with out declare variable while calling the method.
        //Console.Write(a);// accessing out parameter value


        //int random1, random2;
        //OutKeyword.GetMultipleRandomValue(out random1, out random2);
        //Console.WriteLine($"{random1}, {random2}");

        //Static class object
        staticvar army = new staticvar();
        army.printfunc();
        staticvar.printfunc1();
        army.resultfunc();





    }

}

