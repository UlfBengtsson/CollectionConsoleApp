using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            do
            {
                Console.Clear();

                Console.WriteLine("---- Menu ----\n1: ArrayEx\n2: ListEx\n3: DictionaryEx\n0: Exit\n\nPress number to run Example.\n\n");

                char selection = Console.ReadKey(true).KeyChar;

                switch (selection)
                {
                    case '1':
                        ArrayEx();
                        break;

                    case '2':
                        ListEx();
                        break;

                    case '3':
                        DictionaryEx();
                        break;

                    case '4':
                        int startNumber = 13;
                        int result = PrimitivVarible(startNumber);
                        Console.WriteLine($"start number = {startNumber}\nresult number = {result}");
                        break;

                    case '5':
                        
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append("Hello ");

                        Console.WriteLine("string builder before method: " + stringBuilder);

                        AddWorld(stringBuilder);

                        Console.WriteLine("string builder after method: " + stringBuilder);

                        Console.WriteLine("index 4 on stringbuilder is = " + stringBuilder[4]);

                        break;

                    case '6':
                        SpeedTest();
                        break;

                    case '7':
                        ExceptionsEx();
                        break;

                    case '8':
                        RandomEx();
                        break;

                    case '0':
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);

            } while (loop);


        }//end of main

        private static void RandomEx()
        {
            Random random = new Random(1);//seed number tells the random what table of random numbers to use
            //Random random = new Random();//uses the computer clock to get as a seed number
            //Random random = new Random(DateTime.Now.Ticks);//same as new Random()

            int randomNumber = random.Next();

            Console.WriteLine("Random Number was: " + randomNumber); //0 to 2.1B


            Console.WriteLine("0 to 10");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(11));// 0-10 max
            }

            Console.WriteLine("1 to 10");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,11));//min and max 1-10
            }
        }

        private static void ExceptionsEx()
        {
            bool notNumber = true;

            while (notNumber)
            {
                Console.Write("Input number: ");
                string userInput = Console.ReadLine();

                try
                {
                    int number = Convert.ToInt32(userInput);
                    notNumber = false;//this line of code will not run if Convert above has a exception
                }
                catch (FormatException)
                {
                    Console.WriteLine("Im unable to use that as a number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number was too big for me to handel.");
                }
                finally//will always run this part
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            Console.WriteLine("after loop");

        }

        private static void SpeedTest()
        {
            string starsString = "";
            DateTime stringStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                starsString += "*";
            }

            DateTime stringEnd = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            DateTime sbStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("*");
            }

            DateTime sbEnd = DateTime.Now;

            Console.WriteLine($"string time: {stringEnd - stringStart}");
            Console.WriteLine($"StringBuilder time: {sbEnd - sbStart}");
        }

        private static void AddWorld(StringBuilder stringBuilder)//ref to original varible
        {
            stringBuilder.Append("world!");
        }

        static int PrimitivVarible(int numberIn)//int is a copy
        {
            numberIn = numberIn + 12;

            return numberIn;
        }

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
