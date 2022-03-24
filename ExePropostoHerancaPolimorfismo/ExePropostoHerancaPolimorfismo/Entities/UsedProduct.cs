using System;
using System.Globalization;

namespace ExePropostoHerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
           return base.Name + " (used) " + " $ " + base.Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture Date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
