using System;
using System.Collections.Generic;

// Tim Orgill
// Tic Tac Toe Program

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int counter = 1;
            string playerTurn = "x";


            // List created to house gameboard data            
            List<string> gameboard = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            startGame(gameboard);

            // When a winner or tie is declared, done will be set to true
            while (done == false)
            {
                if (counter % 2 == 0)
                {
                    playerTurn = "o";
                }
                else
                {
                    playerTurn = "x";
                }

                int userInt = 0;
                bool tryAgain = true;

                while (tryAgain == true)
                {
                    Console.Write($"{playerTurn}'s turn - make selection: ");
                    string userChoice = Console.ReadLine();
                    userInt = int.Parse(userChoice);

                    tryAgain = checkSelection(userInt, gameboard, tryAgain);
                }

                counter = counter + 1;
                Console.WriteLine("");
                Console.WriteLine("");

                updateGameboard(userInt, gameboard, playerTurn);

                displayGameboard(gameboard);

                int checker = checkWinner(gameboard, playerTurn, done);
                if (checker == 1)
                {
                    done = true;
                }
                else
                {
                    done = false;
                }

                if (counter == 10 && checker == 0)
                {
                    Console.WriteLine("It's a tie!");
                    done = true;
                }
            }
        }
        // function to initially display gameboard
        static List<string> startGame(List<string> gameboard)
        {
            Console.WriteLine($" {gameboard[0]} | {gameboard[1]} | {gameboard[2]} ");
            Console.WriteLine($" - + - + - ");
            Console.WriteLine($" {gameboard[3]} | {gameboard[4]} | {gameboard[5]} ");
            Console.WriteLine($" - + - + - ");
            Console.WriteLine($" {gameboard[6]} | {gameboard[7]} | {gameboard[8]} ");

            return gameboard;
        }
        // function to verify user's choice does not conflict with existing board
        static bool checkSelection(int userInt, List<string> gameboard, bool tryAgain)
        {
            int indexToUpdate = convertToIndex(userInt);

            if (gameboard[indexToUpdate] == "o" || gameboard[indexToUpdate] == "x")
            {
                Console.WriteLine("Invalid selection - try again.");
            }
            else
            {
                tryAgain = false;
            }

            if (userInt <= 0 || userInt >= 10)
            {
                Console.WriteLine("Invalid selection - try again.");
            }


            return tryAgain;
        }

        // function to update gameboard according to player choice
        static List<string> updateGameboard(int userInt, List<string> gameboard, string playerTurn)
        {
            int indexToUpdate = convertToIndex(userInt);

            gameboard[indexToUpdate] = playerTurn;

            return gameboard;
        }
        // Create a function to display updated gameboard
        static List<string> displayGameboard(List<string> updatedGameboard)
        {
            Console.WriteLine($" {updatedGameboard[0]} | {updatedGameboard[1]} | {updatedGameboard[2]} ");
            Console.WriteLine($" - + - + - ");
            Console.WriteLine($" {updatedGameboard[3]} | {updatedGameboard[4]} | {updatedGameboard[5]} ");
            Console.WriteLine($" - + - + - ");
            Console.WriteLine($" {updatedGameboard[6]} | {updatedGameboard[7]} | {updatedGameboard[8]} ");

            return updatedGameboard;
        }

        static int convertToIndex(int userInt)
        {
            int indexToUpdate = userInt - 1;

            return indexToUpdate;
        }

        static int checkWinner(List<string> gameboard, string playerTurn, bool done)
        {
            if (gameboard[0] == playerTurn && gameboard[1] == playerTurn && gameboard[2] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[3] == playerTurn && gameboard[4] == playerTurn && gameboard[5] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[6] == playerTurn && gameboard[7] == playerTurn && gameboard[8] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[0] == playerTurn && gameboard[3] == playerTurn && gameboard[6] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[1] == playerTurn && gameboard[4] == playerTurn && gameboard[7] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[2] == playerTurn && gameboard[5] == playerTurn && gameboard[8] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[0] == playerTurn && gameboard[4] == playerTurn && gameboard[8] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }
            else if (gameboard[2] == playerTurn && gameboard[4] == playerTurn && gameboard[6] == playerTurn)
            {
                Console.WriteLine($"{playerTurn} is the winner!");
                done = true;
            }

            int checker = 0;

            if (done == true)
            {
                checker = 1;
            }
            else
            {
                checker = 0;
            }
            return checker;
        }
    }
}

// create board >>

// display board >>

// player turn >>

// track whose turn it is >>

// ask for player choice >>

// check if valid choice >>

// update board >>

// track board progress >>

// check for winner >>

// check for tie