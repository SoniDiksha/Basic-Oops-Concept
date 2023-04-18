using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    public class GenericsDemo 
    {
       public List<string> strList = new List<string>();
       public List<int> intList = new List<int>();

        public void AddDataToList(string data)
        {
            strList.Add(data);

            Console.WriteLine($"Adding data in List of type String : Hello {strList[0].ToString()}.");
        }

        public string Fizzbuzz<T>(T item)
        {
            //if item divided by 3 Fizz, if divided by 5 Buzz and if divided by 3 & 5 Fizzbuzz 
            string output="";
            if(item.ToString().Length % 3 == 0)
            {
                output += "Fizz";
            }
            if(item.ToString().Length % 5 == 0)
            {
                output += "Buzz";
            }
            return output;
        }
        
          
    }

    public class DemoGenericClass <T>
    {
        private T myVar;

        public T MyProperty
        {
            get { return this.myVar; }
            set { this.myVar = value; }
        }

        //public T tempprop { get; set; }
    }
}
