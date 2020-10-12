using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjisuan
{
    class Multiply: Calculate
    {
        public override void Calcu(int x, int y)
        {
            Console.WriteLine("{0}乘{1}等于{2}", x, y, x * y);
        }
    }
}
