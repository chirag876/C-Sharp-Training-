using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public enum Week2
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class Inttoenum
    {

        public static void enumconvert()
        {
            int i = 2, j = 6, k = 10;
            Week2 day1, day2, day3;

            day1 = (Week2)i;
            day2 = (Week2)j;
            day3 = (Week2)k;

            Console.WriteLine(day1);
            Console.WriteLine(day2);
            Console.WriteLine(day3);
        }
        public static void enumconvert1()
        {
            int i = 2, j = 6, k = 10;
            Week2 day1, day2, day3;

            day1 = (Week2)Enum.ToObject(typeof(Week2), i);
            day2 = (Week2)Enum.ToObject(typeof(Week2), j);
            day3 = (Week2)Enum.ToObject(typeof(Week2), k);

            Console.WriteLine(day1);
            Console.WriteLine(day2);
            Console.WriteLine(day3);
        }
    }
