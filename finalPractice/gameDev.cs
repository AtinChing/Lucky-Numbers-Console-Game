using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace finalPractice
{
    class gameDev : Dev
    {
        static bool hasBeenDone; 
        public gameDev(string name, string type, Data1 esx) {
        int accuracy = Intro(0, 20, name, type, esx);
        bool didWin = Tools.hasWonGame(accuracy);
            hasBeenDone = true;
            
            if (didWin)
            {
                Console.WriteLine("*Admin enters*");
                Tools.winSequence(name, type, esx);

            }
            else
            {
                Tools.loseSequence(name);
            }
        }
    }
}
