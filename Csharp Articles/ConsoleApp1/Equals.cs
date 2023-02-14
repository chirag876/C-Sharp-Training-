using System;
using System;
    class Equals
    {
        public void equality()
        {
        int i = 10, j = 10;
        Console.WriteLine(i == j); // true
        Console.WriteLine(i.Equals(j)); // true

        string str1 = "Hello", str2 = "Hello", str3 = "hello";
        Console.WriteLine(str1 == str2); // true
        Console.WriteLine(str1 == str3); // false - case-sensitive comparison

        Console.WriteLine(str1.Equals(str2)); // true
        Console.WriteLine(str1.Equals(str3)); // false - case-sensitive comparison

        object obj1 = "Hello";
        object obj2 = "Hello";
        Console.WriteLine(obj1 == obj2);
        Console.WriteLine(obj1.Equals(obj2));
    }
    }
