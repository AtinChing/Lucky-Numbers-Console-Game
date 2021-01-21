using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace finalPractice
{
    class sofDev : Dev
    {
        static bool hasBeenDone;
        public sofDev(string name, string type, Data1 esx) { 
        
        int accuracy = Intro(60, 80, name, type, esx);
        bool didWin = Tools.hasWonGame(accuracy);
            hasBeenDone = true;
            if (didWin)
            {
                Tools.winSequence(name, type, esx);
            }
            else
            {
                Tools.loseSequence(name);
            }
        }
    
    }
}
