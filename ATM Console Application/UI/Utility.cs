using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_Application.UI
{
    public static class Utility
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}"); // $ sign to make a use the parameter as a variable//
            return Console.ReadLine();
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress Enter to Continue...");
            Console.ReadLine();
        }
    }
    
}
