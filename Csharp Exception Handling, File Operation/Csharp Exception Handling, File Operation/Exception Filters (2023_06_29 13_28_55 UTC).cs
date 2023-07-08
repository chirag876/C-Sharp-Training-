using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ExceptionFilters
    {
    public static void exceptionfilterfunc()
    {
        Console.Write("Please enter a number to divide 100: ");

        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero. Please try again.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation. Please try again.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Not a valid format. Please try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred! Please try again.");
        }

    }
}

