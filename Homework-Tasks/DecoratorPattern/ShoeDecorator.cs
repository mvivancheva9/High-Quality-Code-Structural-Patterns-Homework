using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ShoeDecorator : Shoe
    {
        protected string material = "Undefined Decorator";
        protected double price = 0.0;

        protected Shoe decoratedShoe;

    public ShoeDecorator(Shoe shoe)
        {
            this.decoratedShoe = shoe;
        }

        public override double GetCost()
        {
            return price + decoratedShoe.GetCost();
        }

        public override String GetMaterials()
        {
            return string.Format("{0}, {1}", decoratedShoe.GetMaterials(), material);
        }
    }
}
