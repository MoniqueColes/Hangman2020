using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Stuff
    {
        public string getWord()
        {
            string[] randHangWord = { "headphones", "computer", "notebook", "snacks", "coding", "keyboard", "monkey", "hangman" };
            Random rand = new Random();
            int randomNumber = rand.Next(0, 8);
           return randHangWord[randomNumber];
        }


    }
}
