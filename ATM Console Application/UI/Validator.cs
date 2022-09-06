using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_Application.UI
{
    public class Validator
    {
        public static T Convert<T>(string promot)
        {
            bool valid = false;
            string userInput;

            while(!valid)
            {
                userInput = Utility.GetUserInput(promot);
                try
                {
                    var convertor = TypeDescriptor.GetConverter(typeof(T);

                    if(convertor != null)
                    {
                        return (T)convertor.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, Try again.");
                    
                }
                return default;
            }
        }
    }
}
