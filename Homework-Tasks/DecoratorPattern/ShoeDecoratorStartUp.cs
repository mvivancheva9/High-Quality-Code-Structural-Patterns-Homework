using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ShoeDecoratorStartUp
    {
        static void Main(string[] args)
        {
            Shoe shoe = new HighHeelsShoes();
            PrintShoe(shoe);

            shoe = new WithLeather(shoe);
            PrintShoe(shoe);

            shoe = new WithStones(shoe);
            PrintShoe(shoe);

        }
        public static void PrintShoe(Shoe shoe)
        {
            Console.WriteLine("Cost: " + shoe.GetCost() + "; Materials: " + shoe.GetMaterials());
        }
    }
}
