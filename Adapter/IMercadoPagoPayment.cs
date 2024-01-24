namespace Adapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void CreatePayment();
        void GetPayment();
    }
}
