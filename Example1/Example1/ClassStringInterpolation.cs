using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    
    public class ClassStringInterpolation
    {
        string name = "Diksha";
        int age = 28;
        // using string interpolation with expressions

        public void fun()
        {
            string greeting = $"Hello, {name}. You are {age} years old.";
            // using string interpolation with format specifiers $"ghg { }";
            string date = $"Today is {DateTime.Now:dd/MM/yyyy}";
            string name1 = $"my name {name} and my age is {age}";
            Console.WriteLine(greeting);
            Console.WriteLine(date);
            Console.WriteLine(name1);
            //Console.ReadKey();

            //TOPIC 2. If needs to write /t c:/ we needs to decalre string in between @""
            String example = @"C:\Diksha Sample code";
            string example1 = @"\t\t@hello";
            Console.WriteLine($"example {example} example1 {example1}");
            //Console.ReadKey();
        }

    }
}
