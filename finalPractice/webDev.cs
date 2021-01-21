using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace finalPractice
{
    
    class webDev : Dev
    {
        static bool hasBeenDone;
        public webDev(string name, string type, Data1 esx) {
            
        int accuracy = Intro(30, 50, name, type, esx);
            hasBeenDone = true;
            bool didWin = Tools.hasWonGame(accuracy);
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
