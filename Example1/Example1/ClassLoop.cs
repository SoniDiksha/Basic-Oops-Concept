using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class ClassLoop
    {
        string numb = "Five";

        public void loop()
        {
            do
            {
                Console.WriteLine(numb);
            }
            while (numb == "four");

            while (numb == "four")
            {
                Console.WriteLine();
            }

            //switch case 
            switch(numb.ToLower())
            {
                case  "four" :
                   Console.WriteLine("hello");
                    break;
                case "five":
                    Console.WriteLine("hi");
                    break;
                case "six":
                    Console.WriteLine("hiii");
                    break ;
                default:
                    Console.WriteLine("not matched with any case");
                    break;

            }

            //Foreeach
            //with list its good to use foreach loop
            List<string> listofnames = new List<string>();
            listofnames.Add("Diksha");
            listofnames.Add("Pradeep");
            listofnames.Add("Tanuj");
            listofnames.Add("Aniru");

            foreach (string name in listofnames)
            {
                Console.WriteLine(name);              
            }

            //for loop
            //for loop goes really well with Arrys as array index also starts with 0
            string[] Names = new string[] {"Diksha","Pradeep","Tanuj","Aniru" };
            //Arrayname.length will give total number of emelemnt in array 
            for(int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names[i]);
            }
            //listofnames.count will give total number of element in list
            for(int i = 0; i < listofnames.Count; i++)
            {
                Console.WriteLine(listofnames[i]);
            }
         
        }      
    }
}
