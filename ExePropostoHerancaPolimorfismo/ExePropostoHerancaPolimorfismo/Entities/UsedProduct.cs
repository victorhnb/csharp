using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return base.priceTag() + "\n" + 
            base.Name + " (used) " + " $ " + base.Price + " (Manufcture Date: " + manufactureDate ;
        }
    }
}
