using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public abstract class Abstraction
    {
        public abstract void active();
        public void eating()
        {
            Console.WriteLine("Eating");
        }
    }

    public class Human: Abstraction
    {
        public override void active()
        {
            Console.WriteLine("Working");
        }
        
    }
    public class Animal: Abstraction
    {
        public override void active()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
