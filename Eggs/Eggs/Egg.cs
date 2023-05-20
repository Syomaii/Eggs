using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    internal class Egg
    {
        FrontTuyok f = new FrontTuyok();
        BackTuyok b = new BackTuyok();
        private EggType eggType;

        public Egg(EggType eggType)
        {
            this.eggType = eggType;
        }
        public void displayinfo()
        {
            Console.WriteLine("***Pagbali sa Egg***");
            f.tuyok();
            b.tuyok();
            Console.WriteLine($"You have a {eggType} order");
        }
    }
}
