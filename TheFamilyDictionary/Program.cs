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

        myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Mom"},
            {"age", "45"}

        });
        }
    }
}
