using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseClassEmp b = new BaseClassEmp();
            b.Name = "Diksha";
            b.LastName = "Bisht";
            b.GetFullName();   //BASE hello Diksha Bisht
            b.demoC();  //base class demoC
            b.demoB();  //base class demoB
            ChildTempEmp ch = new ChildTempEmp();
            ch.hello();    //Hello child method, base class demoB
            ch.GetFullName();  //hello child class testing
            ch.demoB();  //Child class demoB
            ch.demoC();  //child class demoC

            //overriding and hiding concept in C#
            //To achive overriding and hiding create child class object from base class like below
            BaseClassEmp child = new ChildTempEmp();
            //overriding
            child.GetFullName(); ////BASE hello Diksha Bisht
            //overhiding 
            child.demoC();
            child.demoB();


            //Interface is a contract  
            //Classes implements interfaces 
            ClassToUnderstandInterface ct = new ClassToUnderstandInterface();
            ct.interfaceMethodCall();

            //Multiuple inheritance by using Interface
            UnderstandMultipleInheritance mi = new UnderstandMultipleInheritance();
            string firstName = "Diksha";
            string lastName = "Soni Bisht";
            mi.UserName(firstName, lastName);
            mi.interfaceMethodCall();

            //method Overriding 
            Base demo = new DemoMethodOverriding();
            demo.hourlyRate = 5000;
            decimal actaulSalary =demo.employeeSalary(45);
            Console.WriteLine(actaulSalary);


            
            Console.ReadLine(); 

        }
    }

}

