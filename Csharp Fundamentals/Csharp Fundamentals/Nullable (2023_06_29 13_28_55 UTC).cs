using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class nullable
    {
        public static void nullfunc()
        {
            Nullable<int> x = null;
            if (x.HasValue == false)
            {
                Console.WriteLine("x = null");
            }
        }
        public static void nulshortfunc()
        {
            int? x;
            x = null;
            int y = x ?? 6145;
            if (x.HasValue == false)
            {
                Console.WriteLine("x = null");
            }
            else
            {
                Console.WriteLine(x.GetValueOrDefault());
            }
            Console.WriteLine(y);
        }
        public static void nulhelperclassfunc()
        {
            int i = 50;
            int? j = null;

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }
    }
