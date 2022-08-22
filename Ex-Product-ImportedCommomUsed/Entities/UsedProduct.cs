using System;
using System.Globalization;

namespace Ex_Product_ImportedCommomUsed.Entities
{
    class UsedProduct : Product
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base (name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CI) +
                " (Manufacture date: " +
                ManufactureDate.ToShortDateString() + ")";
        }
    }
}
