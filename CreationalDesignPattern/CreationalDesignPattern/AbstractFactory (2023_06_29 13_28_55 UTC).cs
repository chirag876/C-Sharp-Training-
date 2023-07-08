using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects 
 * without specifying their concrete classes. It allows clients to create objects without knowing their specific implementation, while ensuring 
 * that all the objects in a particular family are created to work together.*/

/*The Abstract Factory pattern involves the following components:

Abstract Factory: an interface that declares a set of factory methods, each of which creates a different abstract product.

Concrete Factory: a class that implements the Abstract Factory interface and creates concrete products.

Abstract Product: an interface that declares a set of methods that are common to all products created by the Abstract Factory.

Concrete Product: a class that implements the Abstract Product interface and provides a specific implementation.*/

/*Suppose we're building a car dealership management system that needs to create different types of cars based on the customer's preferences. We can
 * use the Abstract Factory pattern to create two types of cars: Electric cars and Gasoline cars.*/

    //This interface will define set of factory methods for creating abstract product IAbstractProductA
    public interface ICarFactory
    {
        IEngine CreateEngine(); //this is a factory method this will create engine object
        IWheels CreateWheels(); //this will create wheel object
    }

    //Next, we create the concrete factory classes that implement this interface
    public class ElectricCarFactory : ICarFactory //provide specific implementations for creating engine and wheel objects for electric  and gasoline cars
    {
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }

        public IWheels CreateWheels()
        {
            return new RegularWheels();
        }
    }

    public class GasolineCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }

        public IWheels CreateWheels()
        {
            return new AlloyWheels();
        }
    }
    //Defining abstract product interfaces for engine and wheels 
    //These interfaces define the methods that all engine and wheels obejcts must implement.
    public interface IEngine
    {
        void Start();
    }

    public interface IWheels
    {
        void Spin();
    }

    //this interface will declare a set of methods that all products in their respective families must implement.
    public interface IAbstractProductA
    {
        string GetName();
    }

    //We create the concrete product classes that implement these interfaces
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine...");
        }
    }

    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting gasoline engine...");
        }
    }

    public class RegularWheels : IWheels
    {
        public void Spin()
        {
            Console.WriteLine("Spinning regular wheels...");
        }
    }

    public class AlloyWheels : IWheels
    {
        public void Spin()
        {
            Console.WriteLine("Spinning alloy wheels...");
        }
    }
    //We can use the abstract factory pattern to create different types of cars based on the customers preferences

    //cardealer class takes an instance of the Icarfactory interface as a constructor argument and used it to create engine and wheels objects based on the customers preferecnes the buildcar() method creates the car with the specified engine and wheels and outputs the result to the console.
    public class CarDealer
    {
        private ICarFactory carFactory;

        public CarDealer(ICarFactory factory)
        {
            this.carFactory = factory;
        }

        public void BuildCar()
        {
            IEngine engine = carFactory.CreateEngine();
            IWheels wheels = carFactory.CreateWheels();

            Console.WriteLine("Building car with:");
            engine.Start();
            wheels.Spin();
        }
    }
