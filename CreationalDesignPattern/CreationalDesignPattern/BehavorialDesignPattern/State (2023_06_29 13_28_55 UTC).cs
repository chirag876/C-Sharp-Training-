using DesignPattern.StructuralDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavorialDesignPattern
{
    public interface StateBase

    {

        void Change(Context1 context1);

    }

    public class StateA : StateBase

    {
        public void Change(Context1 context1)

        {
            //Change state of context from A to B.
            context1.State = new StateB();
            Console.WriteLine("Change state from A to B.");
        }
    }



    public class StateB : StateBase

    {

        public void Change(Context1 context1)

        {

            //Change state of context from B to C.

            context1.State = new StateC();

            Console.WriteLine("Change state from B to C.");

        }

    }



    public class StateC : StateBase

    {

        public void Change(Context1 context1)

        {

            //Change state of context from C to A.

            context1.State = new StateA();

            Console.WriteLine("Change state from C to A.");

        }

    }

    public class Context1

    {

        public Context1(StateBase state)

        {

            State = state;

            Console.WriteLine("Create object of context class with initial State.");

        }



        public StateBase State { get; set; }



        /// <summary>

        /// State change request

        /// </summary>

        public void Request()

        {

            State.Change(this);

        }

    }

}
