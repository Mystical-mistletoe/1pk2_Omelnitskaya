using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_10
{
    internal class DictionaryTogether
    {
        public static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            Dictionary<string, int> mergedDict = new Dictionary<string, int>(dict1);

            foreach (KeyValuePair<string, int> k in dict2)
            {
                if (mergedDict.ContainsKey(k.Key))
                {
                    mergedDict[k.Key] += k.Value; //Сумм знач, если ключ уже существует
                }
                else
                {
                    mergedDict.Add(k.Key, k.Value); // Добав нов пару
                }
            }

            return mergedDict;
        }
    }
}
