using System;

namespace Basic_core_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.Leap year");
            Console.WriteLine("2.Prime Factors Of Number");
            Console.WriteLine("3.Alphabet Is Vowel Or Consonent");
            Console.WriteLine("4.Largest Among Three Numbers");
            Console.WriteLine("Enter the Option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Leap_year.Readinput();
                    break;
                case 2:
                    Prime_Factors_Of_Number.Readinput();
                    break;
                case 3:
                    Alphabet_Is_Vowel_Or_Consonent.Readinput();
                    break;
                case 4:
                    Largest_Among_Three_Numbers.Readinput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }
        }
    }
}
