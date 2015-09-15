using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class ShoeStartUp
    {
        static void Main(string[] args)
        {
            ShoeFacade shoeFacade = new ShoeFacade();

            shoeFacade.CreateCompleteShoe();

            Console.ReadKey();
        }
    }
}
