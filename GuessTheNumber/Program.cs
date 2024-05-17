using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            private IView view;
            // Game loop
            while (!guessedCorrectly)
            {
                

                if (guess == targetNumber)
                {
                    view.CorrectNumber();
                }
                else if (guess < targetNumber)
                {
                    view.LowerNumber();
                }
                else
                {
                    view.HigherNumber();
                }
            }

            view.EndMessage();
        }
    }
}