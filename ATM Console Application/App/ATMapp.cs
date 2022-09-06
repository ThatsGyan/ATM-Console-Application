using ATM_Console_Application.UI;

namespace ATM_Console_Application.App
{
    internal class ATMapp
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            string CardNumber = Utility.GetUserInput("Your  Card Number");
            Console.WriteLine($"Your Card Number is {CardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}