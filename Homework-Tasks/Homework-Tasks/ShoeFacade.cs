using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class ShoeFacade
    {
        private ShoeModel model;
        private ShoeBase shoeBase;
        private ShoeMaterial material;

        public ShoeFacade()
        {
            model = new ShoeModel();
            shoeBase = new ShoeBase();
            material = new ShoeMaterial();
        }

        public void CreateCompleteShoe()
        {
            Console.WriteLine("------ Creating a Shoe -------\n");
            model.SetModel();
            shoeBase.SetBase();
            material.SetMaterial();

            Console.WriteLine("\n------ Shoe creation is completed ------");
        }
    }
}
