using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
     class RuntimePoly
    {
        public virtual void arts()
        {
            Console.WriteLine("Singing");
        }
    }
    class Person: RuntimePoly
    {
        public  override void arts()
        {
            Console.WriteLine("Coding");
        }
    }
}
