using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class List
    {
    public static void listfunc()
    {
        //Creating a list
        var primeNumbers = new List<int>();
        primeNumbers.Add(1);
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);
        Console.WriteLine("No of primeNumbers: " + primeNumbers.Count);


        var cities = new List<string>();
        cities.Add("New York");
        cities.Add("London");
        cities.Add("Mumbai");
        cities.Add("Chicago");
        cities.Add(null); // null is allowed
        Console.WriteLine("No of indian cities: " + cities.Count);



        // adding elements using collection initializer syntax
        var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };
        Console.WriteLine("No of foreign cities: " + bigCities.Count);      
    }

    public static void listfunc2()
    {
     /*You can also add elements of the custom classes using the collection-initializer syntax. The following adds objects of the Student
     class in the List<Student>.*/
        var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

        Console.WriteLine("No of students: " + students.Count);
    }

    }
class Student
{
    //This is a custom class
    public int Id { get; set; }
    public string Name { get; set; }
}
