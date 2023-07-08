using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*The Open-Closed Principle (OCP) is a design principle in object-oriented programming that suggests that a software entity (class, method, etc.) should be 
 * open for extension but closed for modification. This means that you should be able to extend the behavior of a software entity without modifying its source 
 * code. The Open-Closed Principle is one of the SOLID principles in object-oriented programming, and it helps to improve the maintainability, extensibility, 
 * and testability of software.*/

/*In C#, the Open-Closed Principle can be implemented in several ways. Here are a few examples:*/

/*Inheritance and Polymorphism: You can use inheritance and polymorphism to extend the behavior of a base class without modifying its source code. 
 * You can create a derived class that inherits from the base class and adds new behavior or overrides the behavior of the base class. The base class is closed 
 * for modification but open for extension. Here's an example:
 
 The idea of using inheritance and polymorphism to implement the OCP is to create a base class that defines the behavior that the derived classes can inherit
and override. This allows you to create a framework that can be extended with new functionality by creating new classes that inherit from the base class.*/

namespace Solid_Principles
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

/*In this example, the Shape class is closed for modification, but it is open for extension. You can create new shapes by creating derived classes that inherit 
 * from the Shape class and override its Area method.*/

/*In this example, we create the Shape class, which is an abstract class that defines the behavior that the derived classes can inherit and override. We then create the Rectangle and Circle classes, which both inherit from the Shape class and provide their own implementation of the Area method.*/