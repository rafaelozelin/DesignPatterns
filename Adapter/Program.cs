using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var payment = new PayPal();
            //var payment = new Payonner(); 
            //var payment = new PayonnerAdapter(new Payonner());
            var payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            //payment.SendPayment();
            //payment.ReceivePayment();

            Console.ReadLine();
        }
    }
}
