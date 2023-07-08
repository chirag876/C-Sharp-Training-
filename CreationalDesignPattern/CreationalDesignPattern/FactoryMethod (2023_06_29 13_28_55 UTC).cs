using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*The Factory Method pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows 
 * subclasses to alter the type of objects that will be created. It is similar to the Abstract Factory pattern, but instead of creating 
 * families of related objects, it focuses on creating a single object at a time.*/

/*The Factory Method pattern involves the following components:

Creator: an abstract class that declares a factory method that returns an object of a product class. It may also provide a default implementation
of the factory method that creates a default product.

Concrete Creator: a subclass of the Creator that provides its own implementation of the factory method to create a specific type of product.

Product: an interface or abstract class that declares the methods that all products must implement.

Concrete Product: a class that implements the Product interface or extends the abstract Product class and provides a specific implementation.*/

public abstract class Creator //This is creator
{
    public abstract IProduct CreateProduct(); //Factory method that will return an object of IProduct interface.
}

public class ConcreteCreatorA : Creator //this is Concrete Creator that provide its own implementation of CreateProduct() method to create ConcreteProductA and ConcreteProductB objects 
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}

public interface IProduct //This is product that declares a GetName() method that all products must implement. 
{
    string GetName();
}

public class ConcreteProductA : IProduct //this is Concrete Product
{
    public string GetName()
    {
        return "Product A";
    }
}


