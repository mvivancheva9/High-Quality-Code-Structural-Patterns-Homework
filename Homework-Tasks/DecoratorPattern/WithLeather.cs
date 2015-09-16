using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class WithLeather : ShoeDecorator
    {
        public WithLeather(Shoe shoe)
        : base(shoe)
    {
            this.material = "Leather";
            this.price = 30;
        }
    }
}
