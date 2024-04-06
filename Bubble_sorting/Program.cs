using System;

namespace Bubble_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbArray = new int[20];

            Console.WriteLine("Welcome to the sorting app!");
            Console.WriteLine("Here I can sort your numbers");

            Console.WriteLine("Enter a maximum of 20 numbers. Enter 0 to end.");

            int counter = 0;
            int num = 0;
            string number = " ";
            do
            {
                Console.WriteLine("What is your " + (counter + 1) + " number?");
                number = Console.ReadLine();
                num = Convert.ToInt32(number);
                numbArray[counter] = num;
                counter++;

            } while ((counter < 20) && (num != 0));

            Console.WriteLine("Do you want it in Descending or Ascending order");
            string choice = Console.ReadLine();

            
            //Ascending
            
            if(choice == "Ascending")
            {
                for (int i = 0; i < counter; i++)
                {
                    for (int j = i + 1; j < counter; j++)
                    {
                        if (numbArray[i] > numbArray[j])
                        {
                            int temp = numbArray[j];
                            numbArray[j] = numbArray[i];
                            numbArray[i] = temp;


                        }

                    }

                    Console.Write(numbArray[i]+", ");

                }
                
            }

            //Descending
            
            else
            {
                for (int i = 0; i < counter; i++)
                {
                    for (int j = i + 1; j < counter; j++)
                    {
                        if (numbArray[i] < numbArray[j])
                        {
                            int temp = numbArray[j];
                            numbArray[j] = numbArray[i];
                            numbArray[i] = temp;


                        }

                    }


                    Console.Write(numbArray[i]);
                }
                
            }

            
           
            Console.ReadLine();


        }
    }
}
