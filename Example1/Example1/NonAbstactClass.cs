using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class NonAbstactClass : ExampleofAbstarction
    {
        int a = 1, b = 2;

        public override void sum()
        {
            a = a + b;
            Console.WriteLine(a);
        }

    }
}
