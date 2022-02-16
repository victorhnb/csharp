
namespace Heranca.Entities
{
    class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }

        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }


        //palavra virtual diz que o metodo pode ser sobrescrito 
        public virtual void withDraw (double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

    }
}
