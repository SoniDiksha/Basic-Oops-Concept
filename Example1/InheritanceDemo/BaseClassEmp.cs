using System;

namespace InheritanceDemo
{
    public class BaseClassEmp
    {
        public string Name { get; set; }
        public string LastName { get; set; } 

        public virtual void GetFullName()
        {
            Console.WriteLine($"BASE hello {Name} {LastName}");
        }

        public  void demoB()
        {
            Console.WriteLine("base class demoB");
        }
        public  void demoC()
        {
            Console.WriteLine("base class demoC");
        }
    }

    public class ChildTempEmp : BaseClassEmp
    {
        public string childv = "testing";

        public ChildTempEmp()
        {
            
        }
        public override void GetFullName()
        {
            Console.WriteLine($"hello child class {childv}");
        }
        public void hello()
        {
            Console.WriteLine("Hello child method");
            base.demoB();
        }

        public  void demoB()
        {
            Console.WriteLine("Child class demoB");
        }

        public new void demoC()
        {
            //base.demoC();
            Console.WriteLine("child class demoC");
        }

    }
}

