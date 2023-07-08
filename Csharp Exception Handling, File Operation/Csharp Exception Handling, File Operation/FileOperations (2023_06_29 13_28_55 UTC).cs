using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileOperations
{
    public static void fileexistsfunc()
    {
        //The File exists method is used to check if a particular file exists.
        String path = @"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt";

        if (File.Exists(path))
        {
            Console.WriteLine("File Exists");
            Console.WriteLine(" ");
        }
        Console.ReadKey();
    }

    public static void filereadallines()
    {
        //The method is used to read all the lines one by one in a file. The lines are then stored in a string array variable.
        String path = @"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt";

        String[] lines;
        lines = File.ReadAllLines(path);

        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
        Console.WriteLine(" ");
        Console.ReadKey();
    }

    public static void filewritealltext()
    {
        String path = @"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt";

        String lines;
        lines = File.ReadAllText(path);
        Console.WriteLine(lines);
        Console.WriteLine(" ");
        Console.ReadKey();
    }

    public static void filecopyfunc()
    {
        String path = @"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt";

        String copypath = @"C:\Users\Chirag Gupta\OneDrive\Desktop\abc1.txt";

        File.Copy(path, copypath);

        Console.ReadKey();
    }

    public static void filedeletefunc()
    {
        String path = @"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt";

        File.Delete(path);

        Console.ReadKey();
    }
    public static void appendallline()
    {

        string dummyLines = "This is first line." + Environment.NewLine +
                        "This is second line." + Environment.NewLine +
                        "This is third line.";

        //Opens DummyFile.txt and append lines. If file is not exists then create and open.
        File.AppendAllLines(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
    }

    public static void appendalltext()
    {
        File.AppendAllText(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt", "This is File testing");
    }

    public static void writealltext()
    {
        File.WriteAllText(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt", "This is dummy text");
    }

    public static void multiplefileoperations()
    {
        //Get when the file was accessed last time 
        DateTime lastAccessTime = File.GetLastAccessTime(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc1.txt");

        //get when the file was written last time
        DateTime lastWriteTime = File.GetLastWriteTime(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt");

        //Open file and returns FileStream for reading bytes from the file
        FileStream fs = File.Open(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt", FileMode.OpenOrCreate);

        //Open file and return StreamReader for reading string from the file
        StreamReader sr = File.OpenText(@"C:\Users\Chirag Gupta\OneDrive\Desktop\abc.txt");

    }
}