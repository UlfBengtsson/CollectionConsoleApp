using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryEx();

        }//end of main



        static void DictionaryEx()
        {

            Dictionary<int, string> socialNumberVualt = new Dictionary<int, string>();

            //                   key unique , then just a value and it can be duplicants of it.
            socialNumberVualt.Add(19820825, "Ulf Bengtsson");
            socialNumberVualt.Add(19800617, "Kent Bengtsson");
            socialNumberVualt.Add(19770809, "Jonas Bengtsson");

            Console.WriteLine(socialNumberVualt.GetValueOrDefault(19820825));

            foreach (KeyValuePair<int, string> item in socialNumberVualt)
            {
                Console.WriteLine("Key: " + item.Key);
                Console.WriteLine("Value: " + item.Value);
            }

            Console.WriteLine("none exsicting key used: " + socialNumberVualt.GetValueOrDefault(0));
            string badKeyValue = socialNumberVualt.GetValueOrDefault(0);//default for string is null

        }//end of DictionaryEx

    }//end of Program

}//end of namespace
