using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjisuan
{
    class Divide: Calculate
    {
        public override void Calcu(int x, int y)
        {
            Console.WriteLine("{0}除{1}等于{2}", x, y, (float)x / y);
            
        }
    }
}
