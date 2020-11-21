using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace finalPractice
{
    class Dev
    {
        static string devType;
        public static int Intro(int lower, int higher, string name, string type, Data1 esx) 
        {
            string devType = type;
            int accuracy = 0;
            

            Console.WriteLine("Correct! You're a lucky one, eh.");
            Thread.Sleep(2000);
            Tools.getNumRange(type);
            Console.WriteLine("Since you chose " + name + ", and got " + type + ", you can choose numbers from " + lower + "-" + higher + ". You will now be asked to enter in a number");
            int[] insertedLuckyNum = new int[5];
            ArrayList insLuckyNum = new ArrayList();

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Please enter a number: ");
                    insertedLuckyNum[i] = Convert.ToInt32(Console.ReadLine());
                    insLuckyNum.Add(insertedLuckyNum[i]);
                }
            }
            catch {
                Tools.destroyInterview();
            }
            Console.WriteLine("Okay, now your partner, " + name + ", will have to guess one of the numbers right. They have 3 chances. " + name + " has chosen...");
            // User actually has very high chance of winning
            Random chance = new Random();
            int rChance = chance.Next(0, 100);
            Random corVal = new Random();
            corVal.Next(0, 4);
            
            
            Random rGuess = new Random();
            
            int ii = 1;
            while(ii > 0 && ii <= 3) {
                int guess = insertedLuckyNum[0];
                bool isArray = true;
                if (rChance == 56)
                {
                    while (isArray && guess >= lower && guess <= higher)
                    {

                        if (guess == insertedLuckyNum[0] || guess == insertedLuckyNum[1] || guess == insertedLuckyNum[2] || guess == insertedLuckyNum[3] || guess == insertedLuckyNum[4])
                        {
                            guess = rGuess.Next(lower, higher);
                        }
                        else {
                            isArray = false; 
                        }
                        
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine(name + ": I think I will choose " + guess);
                    Thread.Sleep(2000);
                    Console.WriteLine("Oh wow, they guessed it wrong!");
                    Thread.Sleep(2000);
                    accuracy--;
                }
                else {
                    int randGuess = corVal.Next(insLuckyNum.Count);
                    guess = Convert.ToInt32(insLuckyNum[randGuess]);
                    insLuckyNum.RemoveAt(randGuess);
                    Thread.Sleep(3000);
                    Console.WriteLine(name + ": I think I will choose " + guess);
                    Thread.Sleep(4000);
                    Console.WriteLine("Oh wow, they guessed it right!");
                    Thread.Sleep(4000);
                    accuracy++;
                }
                ii++;
            }
            Console.WriteLine("They got " + accuracy + " right!");
            
            return accuracy;
        }
        
        
    }
}
