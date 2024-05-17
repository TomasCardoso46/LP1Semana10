using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void StartMessage();

        void TakeAGuess();
        
        void HigherNumber();

        void LowerNumber();

        void CorrectNumber();

        void EndMessage();
    }
}