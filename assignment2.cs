using System;
 class assignment
  {
    static void Main(string[] args)
      {
        int choice;
        do
        {
            int num;
            Console.WriteLine("Odd or Even");
            Console.WriteLine("Please enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
                Console.WriteLine("1.Exit");

                choice = Convert.ToInt32(Console.ReadLine());
            }
        } while (choice!=1);
      }
   }