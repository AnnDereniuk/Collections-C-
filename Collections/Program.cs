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
            {  try
                {
                    var enteredValue = Console.ReadLine();
                    value = Convert.ToInt32(enteredValue);
                    if (Object.Equals(enteredValue, stop))
                    {
                        break;
                    }
                    else if (Object.ReferenceEquals(enteredValue.GetType(), value.GetType()))
                    {
                        integerItems.Add(value);
                    }
                    else if (!Object.ReferenceEquals(typeof(Int32), value.GetType()))
                    {
                        Console.WriteLine("Entered value is not an int. Please, enter an integer value:");
                    }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine("Smth is wrong with your input");
                }

                Console.WriteLine("Here are your values:");
                foreach (int num in integerItems)
                {
                    Console.WriteLine(num + " ");
                }

                Console.WriteLine("Here is a sorted descending list of your values:");
                integerItems.Sort();
                //int min = (int)integerItems[0];
                integerItems.Reverse();
               // int max = (int)integerItems[0];
                foreach (int num in integerItems)
                {
                    Console.WriteLine(num + " ");
                }
                
               // Console.WriteLine("Here is your short list:");
               // Console.WriteLine(max + ", " + min);
                Console.ReadKey();
            }

        }
    }
}
