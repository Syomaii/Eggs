using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Egg e = new Egg(EggType.SUNNYSIDEUP);
            FrontTuyok f = new FrontTuyok();
            BackTuyok b = new BackTuyok();

            e.displayinfo();

            Console.ReadLine();
        }
    }
}
