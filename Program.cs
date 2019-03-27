using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Anagrams
{
    public class Program
    {
         private static bool areAnagrams(string s1, string s2)
        {
            if (s1.Length == 1)
                return s1.Equals(s2);
            if(s1.Equals(s2))
                return true;
            foreach (char letter in s1)
                if (s1.Where(s => s == letter).Count() != s2.Where(s => s == letter).Count())
                    return false;
            return true;
        }

        public static int sherlockAndAnagrams(string s)
        {
            var alreadyVerified = new List<string>();
            var anagrams = 0;
            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
            for (int length = 1; length < s.Length; length++)
                for (int index = 0; index <= s.Length - length; index++)
                {
                    string subString = s.Substring(index, length);
                    if (!dictionary.ContainsKey(subString.Length))
                        dictionary.Add(subString.Length, new List<string>());
                    dictionary[subString.Length].Add(subString);
                }
            foreach (var entry in dictionary)
            {
                var array = entry.Value.ToArray();
                for (int index = 0; index < array.Length - 1; index++)
                {
                    for (int index2 = index+1; index2 < array.Length; index2++)
                        if (index != index2 && areAnagrams(array[index], array[index2]))
                        {
                            anagrams++;
                            Console.WriteLine(string.Format("[{0}][{1}]=<{2}><{3}>", index, index2, array[index], array[index2]));
                        }

                }
            }
            return anagrams;

        }
        static void Main(string[] args)
        {
           
        }
    }
}
