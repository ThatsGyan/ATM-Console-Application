using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_Application.UI
{
    public class AppScreen
    {
        internal static void Welcome()
        {
            //Clears The Console//
            Console.Clear();
            //Set the title of the Console Window//

            Console.Title = "MyATM";

            //sets the text color or forground color to white//
            Console.ForegroundColor = ConsoleColor.White;

            //Set the welcome message.//

            Console.WriteLine("\t\t <------------------ Welcome to MyATM ----------------->");

            //prompt to insert atm card

            Console.WriteLine(" \t\t\tPlease insert Your ATM card.\t\t || --->\n\t\t\t NOTE : Actual atm machine will accept and validate \" as physical ATM card,ReaderWriterLock the card number and validate it. ");
            Utility.PressEnterToContinue();
        }


    }
}
