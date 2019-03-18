using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList integerItems = new ArrayList();
            Console.WriteLine("Please, enter integer values to the list (enter 'stop' to finish):");
            int value;
            string stop = "stop";
            while (true)
            {
                var enteredValue = Console.ReadLine();
                try
                {
                    value = Convert.ToInt32(enteredValue);
                   
                    if (Object.ReferenceEquals(typeof(Int32), value.GetType()))
                    {
                        integerItems.Add(value);
                    }
                    
                }
                catch (FormatException ex)
                {
                    if (Object.Equals(enteredValue, stop))
                    {
                        break;
                    }
                    else if (!Object.ReferenceEquals(typeof(Int32), enteredValue.GetType()))
                    {
                        Console.WriteLine("Entered value is not an int. Please, enter an integer value:");
                    }
                }
            }
                Console.WriteLine("Here are your values:");
                foreach (int num in integerItems)
                {
                    Console.Write(num + " ");
                }

            Console.WriteLine();
            Console.WriteLine("Here is a sorted descending list of your values:");
                integerItems.Sort();
                int min = (int)integerItems[0];
                integerItems.Reverse();
                int max = (int)integerItems[0];
                foreach (int num in integerItems)
                {
                    Console.Write(num + " ");
                }

            Console.WriteLine();
            Console.WriteLine("Here is your short list:");
                Console.Write(max + ", " + min);
                Console.ReadKey();
            }

        }
    }

