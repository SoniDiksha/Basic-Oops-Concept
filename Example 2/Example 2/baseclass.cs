using Example_2;
using System;

namespace Example_2
{
    class baseclass
    {
        public void func1() 
        {
            Console.WriteLine("BASE");
        }
        public virtual void func2() { Console.WriteLine("BASE"); }
        public virtual void func3() 
        { 
            Console.WriteLine("BASE"); 
        }
    }

    class derivedclass : baseclass
    {
        new public void func1() { Console.WriteLine("CHILD"); }
        public override void func2() { Console.WriteLine("CHILD"); }
        public new void func3()
        {
            Console.WriteLine("CHILD");
        }
    }

}

