using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mom", new Dictionary<string, string>(){
            {"name", "Amy"},
            {"age", "45"}
        });

            myFamily.Add("dad", new Dictionary<string, string>(){
            {"name", "Scott"},
            {"age", "50"}
        });

            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Alex"},
            {"age", "20"},
            {"name", "Zach"},
            {"age", "16"}
        });


            foreach (var relative in myFamily)
            {
                foreach (var person in relative.Value)
                {
                    if (person.Key == "name")
                    {
                        Console.Write($"{person.Value} is my {relative.Key}");
                    }
                    else if (person.Key == "age")
                    {
                        Console.Write($"and is {person.Value} years old!!!!!");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
