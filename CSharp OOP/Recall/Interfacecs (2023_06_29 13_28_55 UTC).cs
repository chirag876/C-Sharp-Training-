using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface IDevelopment
    {
        void coding();
    }

    class developer: IDevelopment
    {
        public void coding() {
            Console.WriteLine("Implements Projects");
        }    
    }

    class QA: IDevelopment
    {
        public void coding()
        {
            Console.WriteLine("Testing Projects");
        }
    }
}
