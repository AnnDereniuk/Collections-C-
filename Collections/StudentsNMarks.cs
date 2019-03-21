using System;
//using System.Collections;
using System.Collections.Generic;


namespace Collections
{
    class StudentsNMarks
    {
        static void Main(string[] args)
        {
            string stop = "stop";
            string delimiter = ":";
            int delimiterIndex=9;
            Dictionary<string, int> students = new Dictionary<string, int>();
            string MESSAGE = "Please enter students' surnames and their marks. " +
                                     "Desired format: 'Surname:mark'. Enter 'stop' to finish.";
            string WRONG_FORMAT_MESSAGE = "Wrong Format! Desired format:Desired format: 'Surname:mark' ";
            string surname;
            int mark;


            while (true)
            {
                Console.WriteLine(MESSAGE);
                string enteredText = Console.ReadLine();
                char[] text = enteredText.ToCharArray();
                bool existsDelimiter = false;
                bool isSurnameCorrect = true;
                bool isMarkCorrect = true;

                if (enteredText.Equals(stop))
                {
                    Console.WriteLine("");
                }

                if (enteredText.Contains(delimiter))
                {
                    delimiterIndex = Array.IndexOf(text, delimiter);
                    existsDelimiter = true;
                    for (int i = 0; i < delimiterIndex; i++)
                    {
                        if (Char.IsDigit(text[i]))
                        {
                            Console.WriteLine(WRONG_FORMAT_MESSAGE + "1");
                            isSurnameCorrect = false;
                            break;
                        }

                    }
                }
                  
                 
                  else if (!Char.IsDigit(text[text[text.Length - 1]]) || (mark >= 5) || (mark <= 0))
                  { mark = Convert.ToInt32(text[text.Length-1]);
                      Console.WriteLine(WRONG_FORMAT_MESSAGE+"2");
                      isMarkCorrect = false;
                      break;
                  }
                  
               
                 else if (!existsDelimiter)
                 {
                    Console.WriteLine(WRONG_FORMAT_MESSAGE+"3");
                 }


                if (existsDelimiter&&isSurnameCorrect&&isMarkCorrect)
                {
                    surname = enteredText.Substring(0, delimiterIndex - 1);
                    mark = Convert.ToInt32(enteredText.Substring((delimiterIndex + 1),(enteredText.Length-delimiterIndex)));
                    Console.WriteLine("Surname: " + surname + ", Mark: " + mark);
                    students.Add(surname, mark);
                }
            }
        }

    }
}