using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class UglyView : IView
    {
        


    public void StartMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }
    public void TakeAGuess()
        {
            Console.WriteLine("Take a guess!");
        }
    public void HigherNumber()
        {
            Console.WriteLine("Too high! Try again.");
        }
    public void LowerNumber()
        {
            Console.WriteLine("Too low! Try again.");
        }
    public void CorrectNumber()
        {
           Console.WriteLine("Congratulations! You guessed the number correctly!");
           Console.WriteLine("Number of attempts: " + attempts); 
        }
    public void EndMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

    }
}
