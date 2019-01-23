using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 20");
            string input = Console.ReadLine();

            int input_value = int.Parse(input);

            try
            {
                if ((input_value > 0) && (input_value <= 10))
                {
                    int[] phoneno = { 8, 1, 3, 9, 4, 7, 8, 4, 3, 6 };
                    Console.WriteLine("The value that you entered is " + input_value.ToString());

                    foreach (int i in phoneno)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                //If the user value is between 11 and 20 using a for loop to populate the array
                else if ((input_value > 10) && (input_value <= 20))
                {
                    int[] countdown = new int[input_value];
                    Console.WriteLine("The value that you entered is " + input_value.ToString());

                    int populate_array = 0;

                    //Iterate through the array using  a for loop
                    for (int i = 0; i < input_value; i++)
                    {
                        countdown[i] = populate_array;
                        Console.Write(i + " ");
                    }

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);

                }//End of else if

                else
                {
                    Console.WriteLine("Please input an integer value between 1 and 20 next time");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }

            }//End of try block

            catch
            {
                Console.WriteLine("Please input an integer between 1 and 20 next time");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);

            }//End of catch block
        }
    }
}
