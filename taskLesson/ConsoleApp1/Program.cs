using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, double> groups = new Dictionary<string, double>();
            groups.Add("P232", 87);
            groups.Add("P290", 31);
            groups.Add("P190", 53);
            groups.Add("P227", 3);
            foreach (var item in groups)
            {
                Console.WriteLine($"{item.Key}- {item.Value}");
            }

            Console.WriteLine("Qrupuun nomresini daxil edin: ");
            var grpStr = Console.ReadLine();
            if(grpStr.Contains(grpStr))
                Console.WriteLine(groups[grpStr]);
           
            
        }
    }
}
