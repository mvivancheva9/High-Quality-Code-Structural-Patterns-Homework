using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class ShoeMakingTool : ITarget
    {
        public List<string> GetProducts()
        {
            ShoeAdaptee adaptee = new ShoeAdaptee();
            return adaptee.GetListOfProducts();
        }
    }
}
