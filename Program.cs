using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesAnimalDictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("Bear", 4);
            animals.Add("Snake", 0);
            animals.Add("Parrot", 2);
            animals.Add("Centipede", 100);
            animals.Add("Injured Dog", 3);
            animals.Add("Spider", 8);
            foreach (KeyValuePair<string, int> entry in animals)
            {
                Console.WriteLine("{0} has {1} legs.", entry.Key, entry.Value);
            }
        }
    }
}
