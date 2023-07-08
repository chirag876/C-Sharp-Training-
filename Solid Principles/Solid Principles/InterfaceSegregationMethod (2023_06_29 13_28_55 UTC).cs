using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    public interface IOrder
    {
        void Purchase();
        //void ProcessCard();
    }

    public interface IOnlineOrder
    {
        void ProcessCard();
    }
    public class OnlineOrder: IOrder, IOnlineOrder
    {
        public void ProcessCard()
        {
            Console.WriteLine("Enter card Details");
        }
        public void Purchase()
        {
            Console.WriteLine("Thanks for Ordering Online");
            Console.WriteLine(" ");
        }

        
    }

    public class CashOrder : IOrder
    {
        public void Purchase()
        {
            Console.WriteLine("Thanks for shopping from our store do visit us again");
        }
        //public void ProcessCard()
        //{
        //    //Not required to purchase just adding to cart
        //    throw new NotImplementedException();
        //}
        }
    }