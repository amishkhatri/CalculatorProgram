using System;
using calc.validation;

// Entry Class
namespace calc.console
{

    public class CalculatorConsole
    {
        [STAThread]
        private static void Main(string[] args) 
        {
            
            ConsoleProcessor c = new ConsoleProcessor(new Validator());
            c.StartOperation();

            if (!c.IsValidOperation)
            { Console.WriteLine("Please enter a valid option");  }
            else
                c.SetNumbers();
                if (!c.AreValidNumbers)
                    Console.WriteLine("Please enter a valid number");
                else c.Execute();
            
        }
    }

   


}

