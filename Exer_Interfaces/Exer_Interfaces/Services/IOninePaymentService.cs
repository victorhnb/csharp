namespace Exer_Interfaces.Services
{
     interface IOnlinePaymentService
    {

        public double PaymentFree(double amount);
        public double Interest(double amount, int months);

    }
}
