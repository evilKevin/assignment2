using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int AttemptToConvertToInt()
            {
                string optionInput;
                int optionReturn;

                string formatError = "Enter a whole number please.";
                string exceptionError = "There was a problem with your entry. Please enter 1, 2, or 3.";

                WriteLine("Enter 1, 2, or 3 to select your option, then press Enter: \n1. Calculate sum of scores \n2. Enter customer purchases \n3. Quit");
                optionInput = ReadLine();
                try {
                    Convert.ToInt32(optionInput);
                    optionReturn = Convert.ToInt32(optionInput);
                }
                catch (FormatException)
                {
                    WriteLine(formatError);
                    optionReturn = 0;
                }
                catch (Exception e)
                {
                    WriteLine("{0} (Error: {1}).", exceptionError, e);
                    optionReturn = 0;
                }
                return optionReturn;
            }
            int option = AttemptToConvertToInt();
            do
            {
                WriteLine(option);
            }
            while (AttemptToConvertToInt() < 1 && AttemptToConvertToInt() > 3);
            
            
            WriteLine(option);
            /*
            WriteLine("Enter 1, 2, or 3 to select your option, then press Enter: \n1. Calculate sum of scores\n 2. Enter customer purchases\n 3. Quit");
            option = Convert.ToInt32(ReadLine());
            WriteLine("Option number chosen: {0}", option);
            ReadLine();

           
            if (option == 1)
            {

            }
            else if (option == 2)
            {

            }
            else
            {

            }
            */
        }
    }
}
