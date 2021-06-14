using System;
using System.Collections.Generic;
using System.Linq;

namespace Array__Lists__Dictionaries_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueFlag;
            do
            {
                #region exercise37

                int[] myArray = new int[5];
                int numbers = 0;

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Enter a number to sum");
                    myArray[i] = int.Parse(Console.ReadLine());
                    numbers += myArray[i];
                }


                Console.WriteLine($"The sum of your numbers is {numbers}");

                #endregion
                #region exercise40
               
                List<int> numbers1 = new List<int>();
                numbers1.Sort();

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Enter 5 numbers");
                    int input = int.Parse(Console.ReadLine());

                    numbers1.Add(input);

                    
                }
                numbers1.Sort();
                Console.WriteLine($"The median is {numbers1[2]}");

                //for (int i = 0; i <=4 ; i++)
                //{
                //    numbers1.Sort();
                //    Console.WriteLine($"The median is {3}"); 
                //}

                //int sum = 0;
                //foreach (int num in numbers1)
                //{
                //    sum += num;
                //}
                //Console.WriteLine($"The average of your list is {Index[3]}");

                //another option instead of foreach
                // Console.WriteLine($"The sum of your numbers is {numbers1.Sum()}");
                #endregion

                #region exercise50

                Console.WriteLine("Enter a name");
                string userInput = Console.ReadLine();
                //         key      value
                Dictionary<string, int> age = new Dictionary<string, int>();
                age.Add("Domenic", 20);
                age.Add("Scott", 30);
                age.Add("Leslie", 55);
                age.Add("Larissa", 28);
                age.Add("Todd", 29);
                age.Add("Craig", 41);
                age.Add("Bobby", 76);
                age.Add("Michele", 17);
                age.Add("Lindsey", 08);
                age.Add("John", 64);

                foreach (KeyValuePair<string, int> name in age)
                {
                    if (name.Key == userInput)
                    {
                        Console.WriteLine($"{name.Key} is {name.Value} years old");
                    }

                    //else if (name.Key != userInput)
                    //{
                    //    Console.WriteLine($"{name.Key} is not a student here");
                    //}


                }

                #endregion
                Console.WriteLine("would you like to continue? (y/n)");
                continueFlag = Console.ReadLine();
            } while (continueFlag == "y");

        
        }
    }
}
