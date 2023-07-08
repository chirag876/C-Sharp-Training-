using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern
{// The Target interface expected by the client code
    public interface ITarget
    {
        void Request();
    }

    // The Adaptee interface that needs to be adapted to work with the client code
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee method called");
        }
    }

    // The Adapter that adapts the Adaptee to work with the Target interface
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    // The client code that uses the Target interface to make a request
    public class Client
    {
        public void MakeRequest(ITarget target)
        {
            target.Request();
        }
    }
}