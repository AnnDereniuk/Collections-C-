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
            string MESSAGE = "Please enter students' surnames and their marks. Desired format: 'Surname:mark'. Enter 'stop' to finish.";
            string WRONG_FORMAT_MESSAGE = "Wrong Format! Desired format:Desired format: 'Surname:mark' ";
            string surname="";
            int mark=-1;
            String strmark = "";
            bool loop = true;

            while (loop)
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
                    loop = false;
                }

                else if (enteredText.Contains(delimiter))
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
                        else surname = String.Concat(surname, text[i]);

                    }

                    for (int i = delimiterIndex + 1; i < text.Length; i++)
                    {
                        if (Char.IsDigit(text[i]))
                        {
                            strmark = String.Concat(strmark, text[i]);
                        }
                      //  else isMarkCorrect = false;
                    }

                    try
                    {
                        Int32.TryParse(strmark, out mark);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(WRONG_FORMAT_MESSAGE + "3");
                        isMarkCorrect = false;
                    }

                    // if (existsDelimiter&&isSurnameCorrect&&isMarkCorrect)
                    // {
                    //     surname = enteredText.Substring(0, delimiterIndex - 1);
                    //     mark = Convert.ToInt32(enteredText.Substring((delimiterIndex + 1),(enteredText.Length-delimiterIndex)));
                    //     Console.WriteLine("Surname: " + surname + ", Mark: " + mark);
                    //     students.Add(surname, mark);
                    // }
                }


            }
            Console.ReadKey();
        }
    }
}