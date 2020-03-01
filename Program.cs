using System;

namespace Interest_accrul
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0; /* current summary */
            decimal constribution = 0;

            Console.WriteLine("Hello, User! Today you can receive additional deposit ammount.\n" 
                               + "What contribution do you want to make?");
            do
            {
                try
                {
                    string input = Console.ReadLine();

                    if ((input == "quit") || (input == "Quit") || (input == "QUIT")
                        || (input == "q") || (input == "Q"))
                    {
                        Console.WriteLine("Good Bye!");
                        return;
                    }

                    constribution += checked(Convert.ToDecimal(input));
                    break;
                }
                catch(Exception)
                {
                    Console.WriteLine("The inputed object is not decimal.\nPlease, try again.");
                }
            } while (true);

            decimal deposit = 0;
            if (constribution < 100)
                deposit = 5;
            else if ((constribution >= 100) || (constribution < 200))
                deposit = 7;
            else if (constribution >= 200)
                deposit = 10;
            sum = constribution += constribution / 100 * deposit;

            Console.WriteLine($"The operation was succesfully! Your current balance - {sum}.\nGood Bye!");
            Console.ReadKey();
        }
    }
}
