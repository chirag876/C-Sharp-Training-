using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
     class Vehicle
    {
        public void Engine()
        {
            Console.WriteLine("Vehicle has Enigne");
        }
    }

    class Car : Vehicle 
    {
        public void wheels()
        {
            Console.WriteLine("Car Has 4 wheels");
        }
    }
    class Motor :Car{
        public void steering() {
            Console.WriteLine("Motor has Streeing");
        }
    }
    class cycle : Vehicle
    {
        public void handle() {
            Console.WriteLine("Cycle has handle");
        }
    }
}
