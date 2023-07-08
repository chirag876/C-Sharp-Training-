public class program
{
    public static void Main()
    {
        ////Exception Handling class
        //ExeceptionHandling.exceptionfunc();

        ////Try Catch block class
        //TryCatch.trycatchfunc();

        ////Exception Filter class
        //ExceptionFilters.exceptionfilterfunc();


        //Throw Keyword class
        //Throwkeyword.throwfunc();

        //Throw 2 keyword class
        //Throw2.rethrowfunc();

        //Throw 3 keyword class
        //Throw3.rethrowfunc2();

        //File Exists class
        FileOperations.fileexistsfunc();
        FileOperations.filereadallines();
        //FileOperations.filewritealltext();
        //FileOperations.filecopyfunc();
        //FileOperations.filedeletefunc();
        //FileOperations.appendallline();
        //FileOperations.appendalltext();
        //FileOperations.writealltext();
        //FileOperations.multiplefileoperations();








        //Custom Exception class
        // an instance of the class temperat is defined
//        Temperat tem = new Temperat();
//                try
//                {
//                    //the show method of temperat class is called using the instance of the temperat class
//                    tem.show();
//                }
//                catch (WeatheriscoldException e)
//{
//    Console.WriteLine("The weather is cold Exception: {0}", e.Message);
//}
//Console.ReadKey();
//            }
//        }
//        //a custom exception class called Weather is cold Exception class is created which is thrown if the weather is cold
//        public class WeatheriscoldException : Exception
//{
//    public WeatheriscoldException(string message) : base(message)
//    {
//    }
//}
////a class called temperat is defined
//public class Temperat
//{
//    //a variable called temp is defined and assigned to zero
//    int temp = 0;
//    //a method called show is defined
//    public void show()
//    {
//        //the temperature is checked to determine the weather
//        if (temp == 0)
//        {
//            throw (new WeatheriscoldException("The temperature is found to be zero and hence the weather is cold"));
//        }
//        else
//        {
//            Console.WriteLine("The Temperature is: {0}", temp);
//        }
    }
}
