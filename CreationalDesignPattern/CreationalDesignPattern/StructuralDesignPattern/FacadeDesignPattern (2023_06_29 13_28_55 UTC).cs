using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern
{
    public class FacadeDesignPattern
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }

    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }

    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }

    public class Order
    {
        public static void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Console.WriteLine(" ");

            //Calling the FacadeDesignPattern class method object
            FacadeDesignPattern product = new FacadeDesignPattern();
            product.GetProductDetails();
            Console.WriteLine(" ");

            Payment payment = new Payment();
            payment.MakePayment();
            Console.WriteLine(" ");

            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine(" ");

            Console.WriteLine("Order Placed Successfully");
            Console.WriteLine(" ");

        }
    }
}
