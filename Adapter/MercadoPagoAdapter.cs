using System;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando Adaptação de Mercado Pago para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.CreatePayment();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.GetPayment();
        }
    }
}
