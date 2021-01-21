using System;
using System.Linq;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace finalPractice
{
    public class Program
    {
        private string type;
        static void Main(string[] args)
        { //Introduction

            //  ArrayList types = new ArrayList();
            //ArrayList names = new ArrayList();
            Data1 esx = new Data1();
            Tools tools = new Tools();
            Tools.increase();
            Console.WriteLine("Welcome to the game user. This is a roleplay luck-based game. You'll see where the luck part comes in later.");
            Thread.Sleep(6000);
            Console.Write("You've finally woken up. ");
            Thread.Sleep(1000);
            Console.Write("Finally.");
            Thread.Sleep(3000);
            Console.WriteLine(" You're applying to Ching technologies.");
            Thread.Sleep(2000);
            Console.WriteLine("The interview will commence soon. ");
            Thread.Sleep(4000);
            Console.WriteLine("Good luck.");
            Thread.Sleep(2000);
            Console.WriteLine("Admin: You're applying to Ching Techonologies as well?");
            Thread.Sleep(3000);
            Console.WriteLine("Admin: Hmm. Cool. Lets see if you can answer basic questions.");
            Thread.Sleep(2000);
            Console.WriteLine("Admin: You answer one question stupidly and you're out.");
            Thread.Sleep(5000);
            Console.WriteLine("Admin: So whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Admin: Well, hi " + name + ", they told me you were gonna arrive soon. Whats your SECOND name?");
            string secName = Console.ReadLine();
            Console.WriteLine("Admin: Cool name.");
            Thread.Sleep(3000);
            string shorName = string.Concat(Tools.convertTo2Chars(name, secName, 0, 0));
            Console.WriteLine("Admin: Hope you don't mind me just calling you " + shorName + ". I just don't like wasting time saying peoples names.");
            Thread.Sleep(3000);
            // Not entering numbers exception handling
            try
            {
                Console.WriteLine("Admin: So when were you born? (Write in DDMMYYY format)");
                string birthDate = Console.ReadLine();
                int birthDateNum = Convert.ToInt32(birthDate);
                string monthborn = Tools.convertToMonth(Convert.ToInt32((Tools.convertTo2Chars1W(birthDate, 2, 3))));
                Console.WriteLine("Admin: So you were born in " + monthborn + "? Same as me.");
                Thread.Sleep(3000);
            }
            catch {
                Tools.destroyInterview();
            }
            Console.WriteLine("Admin: You think you're good enough to be a developer?");
            string isDev = Console.ReadLine();
            if (isDev == "Yes" || isDev == "yes" || isDev == "Yeah" || isDev == "yeah")
            {
                Console.WriteLine("Admin: Huh, nice confidence. Let's see if you're actually good enough.");
                Thread.Sleep(2000);
            }
            else if (isDev == "No" || isDev == "no") {
                Tools.destroyInterview();
            }
            Console.WriteLine("*door opens*");
            Thread.Sleep(3000);
            Console.WriteLine("Admin: Oh, thats Uand, Reda and Khaban, the controllers. Ones a web developer, ones a game developer and the other is a software developer.");
            Thread.Sleep(5000);
            Console.WriteLine("Admin: This is where your task is introduced " + shorName + ".");
            Thread.Sleep(3000);
            Console.WriteLine("*Admin leaves*");
            // User doesn't actually have to guess the right profession for the right person.
            Thread.Sleep(1000);
            Console.WriteLine("You choose one person out of Uand, Reda and Khaban. You will then have to guess which one is their profession. You have to get lucky when guessing which kind of developer they are. You will not be tested on your ability to code and make programs but rather your competence and your ability to work with others.");
            Thread.Sleep(8000);
            Console.WriteLine("Once you choose one of them and their right profession, you will be asked to think of 5 different numbers between a certain range. The partner you've chosen will have to guess right 3 times. The more answers your partner guesses right increases your chances of being accepted.");
            Thread.Sleep(5000);
            Console.WriteLine("Which one would you like to pick? Uand, Reda or Khaban?");
            string chosen1 = Console.ReadLine();
            Console.WriteLine("What kind of development do you think " + chosen1 + " does? Web, software or game development? (You can just enter \"Web\" or \"Game\" or \"Soft\")."); // Using \ lets you include "" in the string without messing it up. (Because string are defined with whatever goes inside the "").
            string ctype = Console.ReadLine();
            string c1type = Tools.getType(ctype);
            
            System.Tuple<int, int> range = Tools.getNumRange(c1type);
            esx.names.Remove(chosen1);
            esx.types.Remove(c1type);
            // Decides which one to use
            // User will choose numbers based on a certain range, the certain range changes depending on the type of development User chose.
            if (c1type == "Software Development")
            {
                sofDev SD = new sofDev(chosen1, c1type, esx);
                

            }
            else if (c1type == "Web Development")
            {
                webDev WD = new webDev(chosen1, c1type, esx);
                
            }
            else if (c1type == "Game Development")
            {
                gameDev GD = new gameDev(chosen1, c1type, esx);
            }
            else {
                Tools.destroyInterview();
            }

            Console.ReadLine();
        }
       
        

    }
}
