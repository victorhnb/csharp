namespace Exer_Interfaces.Services
{
     interface IOninePaymentService
    {

        public double paymentFree(double amount);
        public double interest(double amount, int months);

    }
}
