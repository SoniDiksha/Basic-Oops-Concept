using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            //Topic Extension Method - 
            DemoExtensionMethod de = new DemoExtensionMethod();
            de.hello();
            //bye method is exension method added in static class ExtensionMethod
            de.bye("exension method call");
            de.bye2();
            de.abcc();
         
            baseclass b = new derivedclass();
            b.func1();
            b.func2();
            b.func3();

            //Genrics in C# - Generics allow you to define type-safe data structures, without committing to actual data types.
            //This results in a significant performance boost and higher quality code, because you get to reuse data processing algorithms without duplicating type-specific code.

            GenericsDemo gd = new GenericsDemo();
            gd.AddDataToList("Diksha");
            string result = gd.Fizzbuzz("04-06-2023");
            string result1 = gd.Fizzbuzz(348978797899234);
            
            Console.WriteLine(result);
            Console.WriteLine(result1);

            DemoGenericClass<string> g = new DemoGenericClass<string>();
            g.MyProperty = "hello";
            DemoGenericClass<int> demo2 = new DemoGenericClass<int>();
            demo2.MyProperty = 100;
            DemoGenericClass<float> demo3 = new DemoGenericClass<float>();
            demo3.MyProperty = 100.60f;


            Console.WriteLine(g.MyProperty);
            Console.WriteLine(demo2.MyProperty);
            Console.WriteLine(demo3.MyProperty);

            Console.ReadLine();
        }
    }
    

}
