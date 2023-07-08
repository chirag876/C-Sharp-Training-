using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*The Liskov Substitution Principle (LSP) is a principle in object-oriented programming that states that if a class is a subtype of another class, then instances 
 * of the subtype should be able to be used in place of instances of the supertype without affecting the correctness of the program. In simpler terms, this means 
 * that a subclass should be able to be substituted for its parent class without breaking anything.*/
namespace Solid_Principles
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

    }
}

/*The Liskov Substitution Principle (LSP) states that if Cat and Dog are both subclasses of Animal, then instances of Cat and Dog should be able to be used 
 * interchangeably with Animal without affecting the correctness of the program.*/

/*This demonstrates the LSP in action because we are able to use instances of Cat and Dog in place of Animal without affecting the correctness of the program. 
 * This means that any code that works with an Animal object should also work correctly with a Cat or Dog object, without requiring any modifications to the code. 
 * This makes our code more flexible and extensible, allowing us to write generic code that can work with a variety of different types of objects.*/