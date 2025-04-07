using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_08
{
    internal class StringArray
    {
        public static string[] GetUniqueStrings(string[] inputArray)
        {
            List<string> uniqueStrings = new List<string>();
            HashSet<string> seenStrings = new HashSet<string>();

            foreach (string str in inputArray)
            {
                if (!seenStrings.Contains(str)) //Если не встречалась
                {
                    uniqueStrings.Add(str);
                    seenStrings.Add(str);
                }
            }

            return uniqueStrings.ToArray();
        }
    }
}
