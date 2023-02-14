using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringtoInt
{
    public void stringconvert()
    {
        //    //Using Parse() method
        Int16.Parse("100"); // returns 100
        Int16.Parse("(100)", NumberStyles.AllowParentheses); // returns -100

        int.Parse("30,000", NumberStyles.AllowThousands, new CultureInfo("en-au"));// returns 30000
        int.Parse("$ 10000", NumberStyles.AllowCurrencySymbol); //returns 10000
        int.Parse("-100", NumberStyles.AllowLeadingSign); // returns -100
        int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite); // returns 100

        Int64.Parse("2147483649"); // returns 2147483649


        //Some errors while using Parse() method
        //int.Parse(null);//thows FormatException
        //int.Parse("");//thows FormatException
        //int.Parse("100.00"); // throws FormatException
        //int.Parse("100a"); //throws formatexception
        //int.Parse(2147483649);//throws overflow exception use Int64.Parse()
    }

    public void stringconvert2()
    {
        //using convert() method
        Convert.ToInt16("100"); // returns short
        Convert.ToInt16(null);//returns 0

        Convert.ToInt32("233300");// returns int
        Convert.ToInt32("1234", 16); // returns 4660 - Hexadecimal of 1234

        Convert.ToInt64("1003232131321321");//returns long

        // the following throw exceptions
        Convert.ToInt16("");//throws FormatException
        Convert.ToInt32("30,000"); //throws FormatException
        Convert.ToInt16("(100)");//throws FormatException
        Convert.ToInt16("100a"); //throws FormatException
        Convert.ToInt16(2147483649);//throws OverflowException
    }
    public void stringconvert3()
    {
        //Using TryParse() method
        string numberStr = "123456";
        int number;

        bool isParsable = Int32.TryParse(numberStr, out number);

        if (isParsable)
            Console.WriteLine(number);
        else
            Console.WriteLine("Could not be parsed.");

        //The following example demonstrates converting invalid numeric string.
        string numberStr2 = "123456as";
        int number2;

        bool isParsable2 = Int32.TryParse(numberStr, out number);
        if (isParsable)
            Console.WriteLine(number);
        else
            Console.WriteLine("Could not be parsed.");
    }
}


