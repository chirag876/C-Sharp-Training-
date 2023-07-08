using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Throwkeyword
    {
    public static void throwfunc()
    {
        /*An exception can be raised manually by using the throw keyword. Any type of exceptions which is derived from
        Exception class can be raised using the throw keyword.*/
        Student std = null;

        try
        {
            PrintStudentName(std);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }

    public static void PrintStudentName(Student std)
    {
        if (std == null)
            throw new NullReferenceException("Student object is null. ");

        Console.WriteLine(std.StudentName);
    }
}

public class Student
{

    public string StudentName { get; set; }
}

