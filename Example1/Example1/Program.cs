using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using DemoClassLibrary;



namespace Example1
{
    internal class Program
    {
        //Class is blueprint
        //When we are initiated class we are building house from blue print  Person p = new Person();
        static void Main(string[] args)
        {
            //TOPIC 1. String interpolation - string literal that contains placeholders for the values to be included in the resulting string.
            //The placeholders can be either expressions or format specifiers that define how the value should be formatted. 
            ClassStringInterpolation si = new ClassStringInterpolation();
            si.fun();
            

            //TOPIC 2. Parse and TryParse
            //try and tryParse used to convert string to intiger 
           ClassTryandTryParse tp = new ClassTryandTryParse();
           tp.convert();


            //TOPIC 4 do while loop and while loop - Pro Tip do while loop executes 1 or more time, but while loop execute 0 or more time 
            ClassLoop dw = new ClassLoop();
            dw.loop();

            //Topic 5 Abstarction - Abstraction is a prpocess of hiding implementaion detail and providing only essential information to the user 
            //We can not create an object of an abstract class
            //abstract class can contain abstract and non-abstract method. Abstract class can not be sealed class. 
            finalClass fn = new finalClass();
            fn.callObject();


            //Topic 6 : Sets - Array, List 

            //Topic 7 : Property Type
            PropertyType p  = new PropertyType();
            string name1 = p.name;
            //p.name = "Sandesh";
            p.Logic = "Diksha Soni";
            Console.WriteLine(p.Logic);
            p.number();

            //topic 8 Namespace - Namesapace is used to organaize code logically 

            //Topic 9 Class Libraries - class library (Dll ) can not be used directly. it did not provide user interface.
            //it can not be run on its own. Pro Tip : store as much is possile code in class library 
            Calculations c = new Calculations();
            c.FirstName = "Diksha";
            c.LastName = "Bisht";
            Console.WriteLine($"Hello {c.FirstName} {c.LastName}");

            //Topic 10 - Inheritance 


        Console.ReadLine();
            
        
        }
    }



    public class PropertyType
    {
        int valuea;
        //Auto property
        public string name { get { return "ghgh"; } }

        private string _myVar;

        public string Logic
        {
            get
            {
                if (_myVar == "Diksha")
                {
                    return "Hi " + _myVar;
                }
                return "Hello " + _myVar;
            }
            set
            {

                _myVar = value;
            }

        }

        public void number()
        {
            Console.WriteLine("Type any number between 1-100");
            string a = Console.ReadLine();
            valuea = int.Parse(a);
            Console.WriteLine($"value is {valuea}");
        }


    }
}
 