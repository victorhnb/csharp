using System.Globalization;
namespace ExePropostoHerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) 
        {
            this.customsFee = customsFee;
        }

        public double totalPrice()
        {
            return base.Price + customsFee;
        }

        public override string priceTag()
        {
          return  base.Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: " + customsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
