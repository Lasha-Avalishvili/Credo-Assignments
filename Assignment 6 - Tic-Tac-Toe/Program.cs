using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{

    class Program
    {
        static bool noWinner = true;   /// Global variable

        public static void PrintBoard(char[,] myArray)   // Function to console board
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }

                Console.WriteLine("\n");
            }
        }
        public static bool IsInRange(int target, int start, int end)  // checks if target number is in range
        {

            return target >= start && target <= end;

        }

        public static bool IsValid(int integer1, int integer2, char[,] myArray, string userInput)     // method checks if user input is valid
        {
            if (IsInRange(integer1, 0, 2) && IsInRange(integer2, 0, 2) &&
                myArray[integer1, integer2] != 'O' && myArray[integer1, integer2] != 'X' &&
                 userInput.Length == 3 && (userInput[1] == ' ' || userInput[1] == ','))

                return true;
            else
                return false;
        }


        public static void PlayerWins(char[,] myArray, char myChar)    //  function to check if X or O wins
        {
            if (myArray[0, 0] == myArray[0, 1] && myArray[0, 0] == myArray[0, 2] && myArray[0, 0] == myChar) /// 1st row
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }
            else if (myArray[1, 0] == myArray[1, 1] && myArray[1, 0] == myArray[1, 2] && myArray[1, 0] == myChar) /// 2nd row
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }
            else if (myArray[2, 0] == myArray[2, 1] && myArray[2, 0] == myArray[2, 2] && myArray[2, 0] == myChar) /// 2nd row
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }
            else if (myArray[0, 0] == myArray[1, 0] && myArray[0, 0] == myArray[2, 0] && myArray[0, 0] == myChar) ///1st column
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }
            else if (myArray[0, 1] == myArray[1, 1] && myArray[0, 1] == myArray[2, 1] && myArray[0, 1] == myChar) /// 2nd clmn 
            {
                Console.WriteLine($"\nplayer{myChar} wins!\n");
                noWinner = false;
            }
            else if (myArray[0, 2] == myArray[1, 2] && myArray[0, 2] == myArray[2, 2] && myArray[0, 2] == myChar) ///3rd clmn
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }
            else if (myArray[0, 0] == myArray[1, 1] && myArray[0, 0] == myArray[2, 2] && myArray[0, 0] == myChar) /// 1sr diagonal
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }
            else if (myArray[2, 0] == myArray[1, 1] && myArray[2, 0] == myArray[0, 2] && myArray[2, 0] == myChar) /// 2nd diagonal
            {
                Console.WriteLine($"player{myChar} wins!");
                noWinner = false;
            }

        }


        static void Main(string[] args)
        {

            char[,] myArray = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Console.WriteLine("Player1 is playing as x\nPlayer2 is playing as o");

            PrintBoard(myArray);



            while (noWinner)   ///// 
            {

                bool isInput1 = true;
                while (isInput1)
                {
                    Console.Write("Enter Player1 position (x,y or x y):");
                    string input1 = "";
                    input1 = Console.ReadLine();
                    char firstLetter = ' ';
                    char lastLetter = ' ';
                    int player1X = 0;
                    int player1Y = 0;

                    try
                    {
                        firstLetter = input1[0];              // converting char to int 
                        player1X = firstLetter - '0';

                        lastLetter = input1[^1];
                        player1Y = lastLetter - '0';
                    }
                    catch
                    {

                    }

                    if (IsValid(player1X, player1Y, myArray, input1))
                    {
                        myArray[player1X, player1Y] = 'X';
                        isInput1 = false;

                        PlayerWins(myArray, 'X');
                        PrintBoard(myArray);
                    }
                    else
                    {
                        Console.WriteLine("incorrect input");
                    }

                }

                bool isInput2 = true;

                if (noWinner == false)
                {
                    isInput2 = false;
                }

                while (isInput2)
                {
                    Console.Write("Enter Player2 position (x,y or x y):");
                    string input2 = "";
                    input2 = Console.ReadLine();


                    char firstLetter = ' ';
                    char lastLetter = ' ';
                    int player2X = 0;
                    int player2Y = 0;
                    try
                    {

                        firstLetter = input2[0];
                        player2X = firstLetter - '0';

                        lastLetter = input2[^1];
                        player2Y = lastLetter - '0';

                    }
                    catch
                    {

                    }

                    if (IsValid(player2X, player2Y, myArray, input2))
                    {

                        myArray[player2X, player2Y] = 'O';
                        isInput2 = false;
                        PlayerWins(myArray, 'O');
                        PrintBoard(myArray);
                    }
                    else
                    {
                        Console.WriteLine("incorrect input");
                    }

                }
            }

        }

    }
}
