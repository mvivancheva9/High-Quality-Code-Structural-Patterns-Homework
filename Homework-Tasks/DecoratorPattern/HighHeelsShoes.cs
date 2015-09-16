using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HighHeelsShoes : Shoe
    {
        public override double GetCost()
        {
            double price = 122.50;
            return price;
        }
        public override string GetMaterials()
        {
            return "Plastic";
        }
    }
}
