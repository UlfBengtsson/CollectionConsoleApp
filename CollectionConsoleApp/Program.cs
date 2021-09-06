using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ListEx();

        }//end of main

        static void ListEx()
        {
            List<double> tempeturs = new List<double>();

            tempeturs.Add(6.1);
            tempeturs.Add(9.3);
            tempeturs.Add(14.2);
            tempeturs.Add(17.0);
            tempeturs.Add(17.3);

            Console.WriteLine("Size of capacity list has: " + tempeturs.Capacity);
            tempeturs.Capacity = 5;//set Capacity to 5
            Console.WriteLine("list capacity set to 5: " + tempeturs.Capacity);

            for (int index = 0; index < tempeturs.Count; index++)
            {
                Console.WriteLine("Temp outside: {0}", tempeturs[index] );
            }

            Console.WriteLine("index of 14.2: " + tempeturs.IndexOf(14.2));
        }


        static void ArrayEx()
        {
            string[] names = new string[5];

            names[2] = "Ola";
            names[4] = "Sven";
            names[1] = "Eva";
            names[0] = "Sara";
            names[3] = "Hans";

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine($"Index: {index} Name: {names[index]}" );
            }

            //sort

            Array.Sort(names);

            Console.WriteLine("\nafter Array.Sort\n");

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine($"Index: {index} Name: {names[index]}");
            }
        }

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
