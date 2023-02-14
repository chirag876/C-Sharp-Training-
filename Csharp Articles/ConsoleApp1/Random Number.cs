using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class RandomNumber
    {
    public void randomnumber()
    {
        Random rnd = new Random();

        for (int j = 0; j < 4; j++)
        {
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next(10));//returns random integers < 10, Generate Random Numbers in Range
            Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20, Generate Random Number in Min to Max Range
            Console.WriteLine(rnd.NextDouble());//Generate Random Floating Point Number
        }
    }

    public void randomnumber2()
    {
        //Generate Random Bytes
        Random rnd = new Random();
        byte[] randomBytes = new byte[4];

        rnd.NextBytes(randomBytes);

        foreach (byte val in randomBytes)
        {
            Console.WriteLine(val);
        }
    }

    public void randomnumber3()
    {
        //Seed Value in Random Class
        Random rnd1 = new Random(10); //seed value 10
        for (int j = 0; j < 4; j++)
        {
            Console.WriteLine(rnd1.Next());
        }

        Console.WriteLine("Using another object");

        Random rnd2 = new Random(10);//seed value 10
        for (int j = 0; j < 4; j++)
        {
            Console.WriteLine(rnd2.Next());
        }
    }
    }

