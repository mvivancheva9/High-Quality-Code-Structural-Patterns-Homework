using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class WithStones : ShoeDecorator
    {
        public WithStones(Shoe shoe)
        : base(shoe)
        {
            this.material = "Stones";
            this.price = 300;
        }
    }
}
