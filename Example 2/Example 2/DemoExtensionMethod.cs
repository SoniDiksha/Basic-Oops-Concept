using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    public class DemoExtensionMethod : Iabc
    {

        public void hello()
        {
            Console.WriteLine("Welcome User");
        }
    }

    public interface Iabc
    {

    }

    public static class ExentionMethod
    {
        //An extension method in C# is a static method that is defined in a static class and can be called as if it were an instance method of another type.
        //Extension methods allow you to add functionality to an existing type without modifying the type itself,
        //which can be useful when working with third-party libraries or when you want to keep your code organized and modular.
        public static void bye(this DemoExtensionMethod de, string temp)
        {
            Console.WriteLine(temp + " Good Bye");
        }
        public static void bye2(this DemoExtensionMethod de)
        {
            Console.WriteLine("Good Bye 2");
        }
        public static void abcc(this Iabc b)
        {
            Console.WriteLine("Using extension method extending interface");
        }
    }
}
