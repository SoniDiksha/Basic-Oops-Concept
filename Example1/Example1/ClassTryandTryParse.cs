using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class ClassTryandTryParse
    {
        string Strnumber = "40";

        public void convert()
        {
            int number = int.Parse(Strnumber);  //if value Strnumber is not valid intiger the we will get exception that input string was not in a correct format 
            Console.WriteLine(number);

            //example of tryparse
            string newnumber = "Five";
            Boolean check = int.TryParse(newnumber, out int parsedValue);

            if (check)
            {
                Console.WriteLine(parsedValue);
            }

        }
    }
}
