using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace finalPractice
{
    class Tools
    {
        static int rank = 0;
        
        static string finalType;
        public static void increase() {
            rank++;
        }
        public static string convertTo2Chars(string first, string second, int pos1, int pos2) {
            string final;
            final = string.Concat(first.ElementAt(pos1), second.ElementAt(pos2));
            return final;
        }
        public static string convertTo2Chars1W(string first, int pos1, int pos2)
        {
            string final;
            final = string.Concat(first.ElementAt(pos1), first.ElementAt(pos2));
            return final;
        }
        public static void destroyInterview() {
            Console.WriteLine("What? Are you stupid? Can't you answer properly? Good luck getting a job.");
            System.Threading.Thread.Sleep(10000);
            Environment.Exit(0);
        }

        public static Tuple<int, int> getNumRange(string type) {
            int range1 = 0;
            int range2 = 20;
            if (type == "Game Development")
            {
                range1 = 0;
                range2 = 20;

            }
            else if (type == "Web Development")
            {
                range1 = 30;
                range2 = 50;
            }
            else if (type == "Software Development")
            {
                range1 = 60;
                range2 = 80;
            }
            return Tuple.Create(range1, range2);
        }

        public static string convertToMonth(int monthNum) {
            string finalMonth = "";
            if (monthNum > 00 && monthNum < 13) {
                switch (monthNum)
                {
                    case 01:
                        finalMonth = "January";
                        break;
                    case 02:
                        finalMonth = "February";
                        break;
                    case 03:
                        finalMonth = "March";
                        break;
                    case 04:
                        finalMonth = "April";
                        break;
                    case 05:
                        finalMonth = "May";
                        break;
                    case 06:
                        finalMonth = "June";
                        break;
                    case 07:
                        finalMonth = "July";
                        break;
                    case 08:
                        finalMonth = "August";
                        break;
                    case 09:
                        finalMonth = "September";
                        break;
                    case 10:
                        finalMonth = "October";
                        break;
                    case 11:
                        finalMonth = "November";
                        break;
                    case 12:
                        finalMonth = "December";
                        break;
                }
            }
            else {
                Tools.destroyInterview();
            }

            return finalMonth;
        }
        public static bool hasWonGame(int result) {
            bool won = true;
            if (result >= 1) {
                won = true;
            }
            else {
                won = false;
            }
            return won;
        }
        public static int thing(string name, string type, int lower, int higher) {
            if (rank < 2)
            {
                Console.WriteLine("Correct again!");
                Thread.Sleep(3000);
                Console.WriteLine("Well, since you chose " + name + " and their profession is " + type + ", you can choose from " + lower + "-" + higher + ". You will soon be asked to enter in your numbers.");
            } else if (rank == 2) {
                Console.WriteLine("Since " + name + "'s profession is " + type + " you can choose from " + lower + "-" + higher + ". You will now be asked to enter in your numbers.");

            }
            int[] insertedLuckyNum = new int[5];
            ArrayList insLuckyNum = new ArrayList();
            int accuracy = 0;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Please enter a number: ");
                    insertedLuckyNum[i] = Convert.ToInt32(Console.ReadLine());
                    insLuckyNum.Add(insertedLuckyNum[i]);
                }
            }
            catch
            {
                Tools.destroyInterview();
            }
            Console.WriteLine("Okay, now your partner, " + name + ", will have to guess one of the numbers right. They have 3 chances. " + name + " has chosen...");





            Random chance = new Random();
            int rChance = chance.Next(0, 100);
            Random corVal = new Random();
            corVal.Next(0, 4);


            Random rGuess = new Random();

            int ii = 1;
            while (ii > 0 && ii <= 3)
            {
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
                        else
                        {
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
                else
                {
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
            return accuracy;

        }
        public static void tryAgain(string nameDone, string typeDone, Data1 esx) {
            rank++;
            string name2 = "";
            if (rank == 2)
            { // if 2 of them are left
                Console.WriteLine("So which person would you like to choose next? " + esx.names[0] + " or " + esx.names[1] + "?");
                name2 = Console.ReadLine();
            }
            else if (rank == 3) { // if only one of them is left
                Console.WriteLine("Well, you only have " + esx.names[0] + " left.");
                name2 = esx.names[0];
            }

            esx.names.Remove(name2);
            string type2 = "";

            if (rank == 1)
            {

                Console.WriteLine("And so which one do you think " + name2 + " does? " + esx.types[0] + " or " + esx.types[1] + "?");
                type2 = Console.ReadLine();
            }
            else if (rank == 2) {
                Console.WriteLine("And the only thing he could be doing is " + esx.types[0] + ".");
                type2 = esx.types[0];
            }
            System.Tuple<int, int> numRange = getNumRange(type2);
            int accuracy2 = thing(name2, type2, numRange.Item1, numRange.Item2);
            esx.types.Remove(type2);
            if (accuracy2 == 3) // Win sequence is executed again
            {
                winSequence(nameDone, typeDone, esx);
            }
            else {
                loseSequence(nameDone);
            }

        }
        public static void winSequence(string name, string type, Data1 esx) {
            if (rank == 1)
            {
                Console.WriteLine("Admin: Well, " + name + " and you have proved your competence to work as a team. Congratulations, you have earned a place at Ching Technologies. You have earned the position of " + getJob(rank) + ". Would you like to try again with someone else and attempt to achieve a higher rank? I will let you know it will be more difficult.");
            }
            else if (rank == 2)
            {
                Console.WriteLine("Admin: Well, " + name + " and you've proven yourself once again. You have earned the position of " + getJob(rank) + ". Would you like to try again to secure an even better position?");

            }
            else if (rank == 3) {
                Console.WriteLine("Admin: Wow, you've really climbed up the ladders and have secured the position of " + getJob(rank) + "! Well done, we will definitely prosper under your leadership! Make yourself at home!");
                exitSequence();
            }
            string wants2TryAgain = Console.ReadLine();
            if (wants2TryAgain == "Yes" || wants2TryAgain == "yes")
            {
                tryAgain(name, type, esx);
            }
            else {
                Console.WriteLine("Alright, have fun with your position as " + getJob(rank) + "!");

            }
        }
        public static void exitSequence() {
            Thread.Sleep(1000);
            Console.WriteLine("*Interviewer exits*");
            Thread.Sleep(3000);
            Console.WriteLine("Congratulations, you passed the interview, user. Good luck on your future endeavours within the company. The company that YOU will lead to success.");
            Thread.Sleep(6000);
            Console.WriteLine("I'm going offline now.");
            Thread.Sleep(3000);
            Console.WriteLine("*Disconnects*");

        }
        public static string getJob(int num) {
            string job = "";
            switch (num) {
                case 0: job = "N/A";
                    break;
                case 1:
                    job = "Tech Support";
                    break;
                case 2: job = "Head of Development";
                    break;
                case 3: job = "CEO";
                    break;
            }
            return job;

        }
        public static void loseSequence(string name) {
            Console.WriteLine("Admin: Sorry, but you and " + name + " couldn't make it through. you have lost your chance. Good luck on oyur future endeavours.");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
        public static string getType(string type) {

            getterz = type;

            return getterz;
        }
        public static string getterz {
            get { return finalType; }
            set {
                if (value == "Web Development" || value == "Software Development" || value == "Game Development")
                {
                    finalType = value;

                }
                else if (value == "Web" || value == "Web Dev")
                {
                    finalType = "Web Development";

                }
                else if (value == "Software" || value == "Software Dev" || value == "Soft" || value == "Soft Dev")
                {
                    finalType = "Software Development";

                }
                else if (value == "Game" || value == "Game Dev")
                {
                    finalType = "Game Development";

                }
                else {
                    destroyInterview();
                }
            }
        }
    }
}
