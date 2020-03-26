using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CorePortfolio5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            char menuItem, gEdecision = ' ';
            const int MAX649 = 6, MAXLOTTOMAX = 8;
            Random rnd = new Random();
            //initialize arrays
            int[] lottoMax = new int[MAXLOTTOMAX];
            int[] lotto649 = new int[MAX649];
            int[] lottoExtra = new int[MAXLOTTOMAX];
            int[] lottoExtraWinners = new int[MAXLOTTOMAX];
            int[] lotto649Winners = new int[MAX649];
            int[] lottoMaxWinners = new int[MAXLOTTOMAX];
           //fill arrays
            fillLottos( lottoMax,lotto649,lottoExtra,lottoMaxWinners,lottoExtraWinners, lotto649Winners, rnd);
            //this is going to be a loop when done do while?
            Console.WriteLine("Welcome to CPSC1012 Lotto Center!");
            menuItem = GetMenuItem();
            switch (menuItem)
            {
                case '1'://change lotto max numbers
                    {
                        Console.WriteLine("Your current lotto max numbers are: {0},{1},{2},{3},{4},{5},{6}.\n", lottoMax[0], lottoMax[1], lottoMax[2], lottoMax[3], lottoMax[4], lottoMax[5], lottoMax[6]);
                        Console.WriteLine("Would you like to generate or enter your numbers ? (g / e) :");
                        gEdecision = GenerateorEnter("Would you like to generate or enter your numbers ? (g / e) :");

                        if (gEdecision == 'G' || gEdecision == 'g')
                        {
                            for (int index = 0; index < MAX649; index++)
                            {
                                lottoMax[index] = rnd.Next(1, 51);
                            }
                            Array.Sort(lottoMax);
                            Console.WriteLine("Your new lotto max numbers are: {0},{1},{2},{3},{4},{5},{6}.\n", lottoMax[0], lottoMax[1], lottoMax[2], lottoMax[3], lottoMax[4], lottoMax[5], lottoMax[6]);
                        }
                        if (gEdecision == 'e' || gEdecision == 'E')
                        {
                            Console.WriteLine("Please enter your first number: ");
                            lottoMax[0] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoMax[1] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoMax[2] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoMax[3] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoMax[4] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoMax[5] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your final number: ");
                            lottoMax[6] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Your new lotto max numbers are: {0},{1},{2},{3},{4},{5},{6}.\n", lottoMax[0], lottoMax[1], lottoMax[2], lottoMax[3], lottoMax[4], lottoMax[5], lottoMax[6]);
                        }
                        break;
                    }

                case '2'://change 649 numbers can this be a method?
                    {
                        Console.WriteLine("Your current lotto 6/49 numbers are: {0},{1},{2},{3},{4},{5}.\n", lotto649[0], lotto649[1], lotto649[2], lotto649[3], lotto649[4], lotto649[5]);
                        Console.WriteLine("Would you like to generate or enter your numbers ? (g / e) :");
                        gEdecision = GenerateorEnter("Would you like to generate or enter your numbers ? (g / e) :");

                        if (gEdecision == 'G' || gEdecision == 'g')
                        {
                            for (int index = 0; index < MAX649; index++)
                            {
                                lotto649[index] = rnd.Next(1, 10);
                            }
                            Array.Sort(lotto649);
                            Console.WriteLine("Your new lotto 6/49 numbers are: {0},{1},{2},{3},{4},{5}.\n", lotto649[0], lotto649[1], lotto649[2], lotto649[3], lotto649[4], lotto649[5]);
                        }
                        if (gEdecision == 'e' || gEdecision == 'E')
                        {
                            Console.WriteLine("Please enter your first number: ");
                            lotto649[0] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lotto649[1] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lotto649[2] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lotto649[3] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lotto649[4] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your final number: ");
                            lotto649[5] = int.Parse(Console.ReadLine());
                            Array.Sort(lotto649);
                            Console.WriteLine("YYour current lotto 6/49 numbers are: {0},{1},{2},{3},{4},{5},{6}.\n", lotto649[0], lotto649[1], lotto649[2], lotto649[3], lotto649[4], lotto649[5], lotto649[6]);
                        }
                        break;
                    }

                case '3'://change lotto extra numbers can this b a method too?
                    {
                        Console.WriteLine("Your current lotto Extra numbers are: {0}{1}{2}{3}{4}{5}{6}.\n", lottoExtra[0], lottoExtra[1], lottoExtra[2], lottoExtra[3], lottoExtra[4], lottoExtra[5], lottoExtra[6]);
                        Console.WriteLine("Would you like to generate or enter your numbers ? (g / e) :");
                        gEdecision = GenerateorEnter("Would you like to generate or enter your numbers ? (g / e) :");

                        if (gEdecision == 'G' || gEdecision == 'g')
                        {
                            for (int index = 0; index < MAX649; index++)
                            {
                                lottoExtra[index] = rnd.Next(1, 10);
                            }
                          
                            Console.WriteLine("Your new lotto Extra numbers are: {0}{1}{2}{3}{4}{5}{6}.\n", lottoExtra[0], lottoExtra[1], lottoExtra[2], lottoExtra[3], lottoExtra[4], lottoExtra[5], lottoExtra[6]);
                        }
                        if (gEdecision == 'e' || gEdecision == 'E')
                        {
                            Console.WriteLine("Please enter your first number: ");
                            lottoExtra[0] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoExtra[1] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoExtra[2] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoExtra[3] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoExtra[4] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your next number: ");
                            lottoExtra[5] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter your final number: ");
                            lottoExtra[6] = int.Parse(Console.ReadLine());
                           
                            Console.WriteLine("Your current lotto Extra numbers are: {0}{1}{2}{3}{4}{5}{6}.\n", lottoExtra[0], lottoExtra[1], lottoExtra[2], lottoExtra[3], lottoExtra[4], lottoExtra[5], lottoExtra[6]);
                        }
                        break;
                    }
                case '4'://play lotto max
                    { 
                        Console.Write("Your current lotto max numbers are: {0},{1},{2},{3},{4},{5},{6}.\nYour lotto Extra number is:", lottoMax[0], lottoMax[1], lottoMax[2], lottoMax[3], lottoMax[4], lottoMax[5], lottoMax[6]);
                        Console.Write("{0}{1}{2}{3}{4}{5}{6}\n-\n\n", lottoExtra[0], lottoExtra[1], lottoExtra[2], lottoExtra[3], lottoExtra[4], lottoExtra[5], lottoExtra[6]);
                        Console.WriteLine("-\nThe winning lotto max numbers are: {0},{1},{2},{3},{4},{5},{6} bonus({7}).", lottoMaxWinners[0], lottoMaxWinners[1], lottoMaxWinners[2], lottoMaxWinners[3], lottoMaxWinners[4], lottoMaxWinners[5], lottoMaxWinners[6],lottoMaxWinners[7]);
                        Console.WriteLine("The winning Lotto EXTRA number is: {0}{1}{2}{3}{4}{5}{6}", lottoExtraWinners[0], lottoExtraWinners[1], lottoExtraWinners[2], lottoExtraWinners[3], lottoExtraWinners[4], lottoExtraWinners[5], lottoExtraWinners[6]);
                        SearchMAX(lottoMax,lottoMaxWinners);
                        SearchExtra(lottoExtra, lotto649Winners);
                        
                        Console.ReadLine();
                        
                        break;

                    }

                case '5'://play 649
                    {
                        Console.WriteLine("yo");
                        break;
                    }

                case '0'://exit
                    {
                        Console.WriteLine("Good-bye and thanks for coming to the CPSC1012 Lotto Centre.");
                        break;
                    }
            }
            Console.ReadLine();

        }



        static void DisplayMenu()//show menu options
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1: Change player's Lotto Max Numbers");
            Console.WriteLine("2: Change player's 6/49 numbers");
            Console.WriteLine("3: Change player's Lotto Extra numbers");
            Console.WriteLine("4: Play Lotto MAX");
            Console.WriteLine("5: Lotto 6/49");
            Console.WriteLine("0: Exit program");
        }

        static char GetMenuItem()//validation for menu
        {
            string menuItem;
            char validMenuItem;

            DisplayMenu();
            menuItem = Console.ReadLine();
            while (!char.TryParse(menuItem, out validMenuItem) || (validMenuItem != '1' && validMenuItem != '2' && validMenuItem != '3' && validMenuItem != '4' && validMenuItem != '5' && validMenuItem != '0'))
            {
                Console.Clear();
                Console.WriteLine("ERROR! Invalid menu choice\n");
                DisplayMenu();
                menuItem = Console.ReadLine();
            }
            return validMenuItem;
        }

        static int generateRandomDieValue(int MAXDIE, Random rnd)
        {//generate once DO NOT  USE THE SAME SEED VALUE FOR ROLLS
            return rnd.Next(1, MAXDIE + 1);

        }
        static char GenerateorEnter(string question)//validation got Generate or enter numbers
        {
            string input;
            char validInput;
            input = Console.ReadLine();
            while (!char.TryParse(input, out validInput) || (validInput != 'G' && validInput != 'E' && validInput != 'e' && validInput != 'g'))
            {
                Console.WriteLine("Invalid input {0} \n", question);
                input = Console.ReadLine();
            }

            return validInput;
        }
        static void fillLottos(int[] lottoMax, int[] lotto649, int[] lottoExtra, int[] lottoMaxWinners, int[] lottoExtraWinners, int[] lotto649Winners, Random rnd) //fills the arrays
        {
            const int MAX649 = 6, MAXLOTTOMAX = 7;
            for (int counter = 0; counter < MAX649; counter++)
            {
                lotto649[counter] = rnd.Next(1, 51);
            }
            for (int counter1 = 0; counter1 < MAX649; counter1++)
            {
                lottoExtra[counter1] = rnd.Next(1, 10);
            }
            for (int counter2 = 0; counter2 < MAXLOTTOMAX; counter2++)
            {
                lottoMax[counter2] = rnd.Next(1, 51);

            }
            for (int counter = 0; counter < MAX649; counter++)
            {
                lotto649Winners[counter] = rnd.Next(1, 51);
            }
            for (int counter1 = 0; counter1 < MAX649+1; counter1++)
            {
                lottoExtraWinners[counter1] = rnd.Next(1, 10);
            }
            for (int counter2 = 0; counter2 < MAXLOTTOMAX+1; counter2++)
            {
                lottoMaxWinners[counter2] = rnd.Next(1, 51);

            }
            Array.Sort(lotto649);
            Array.Sort(lottoMax);
            
            Array.Sort(lotto649Winners);
            Array.Sort(lottoMaxWinners);
          
            

        }



        static int SearchMAX(int[] lottoMax, int[] lottoMaxWinners)
        {
            int index = 0, matches = 0;
            bool found = false;
            const int MAXLOTTOMAX = 8;
            //Keep searching the array until the playernumber is found or we reach the end of the player list (logical size/playerCount)

            //if the number is in the array it returns the index of its location(for delete) otherwise it returns -1 (indicating that the number is not in the array(for create)
            while (!found && index < MAXLOTTOMAX)
            {
                if (lottoMax[index] == lottoMaxWinners[index])
                {
                    found = true;
                    matches++;
                    Console.WriteLine("Match");
                }
                else
                {
                    index++;
                }
            }

            if (!found)
            {
                index = -1;
            }

            return index;

        }


        static int SearchExtra(int[] lottoExtra, int[] lottoExtraWinners)
        {
            int index = 6, matches = 0;
            bool found = false;
            const int MAXLOTTOMAX = 8;
            //Keep searching the array until the playernumber is found or we reach the end of the player list (logical size/playerCount)

            //if the number is in the array it returns the index of its location(for delete) otherwise it returns -1 (indicating that the number is not in the array(for create)
            while (!found && index < MAXLOTTOMAX)
            {
                if (lottoExtra[index] == lottoExtraWinners[index])
                {
                    found = true;
                    matches++;
                    
                }
                else
                {
                    index++;
                }
            }

            if (!found)
            {
                index = -1;
            }

            return index;

        }




    }
}

    


