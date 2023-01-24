using System;

namespace Mission_3
{
    class Program
    {
        static void Main (string[] args)
        {
            Accept_Board ab = new Accept_Board();
            string winner = ""; 
            string[] boardArray = new string[9];
            bool gameContinue = true;
            bool inputContinue = true;
            bool moveContinue = true;
            int playerTurn = 1;
            int movePosition = 10;

            Console.WriteLine("Welcome to Tic Tac Toe");

            while (gameContinue == true)
            {
                inputContinue = true;
                playerTurn++;
                if (playerTurn % 2 == 0)
                {
                    while (inputContinue == true)
                    {
                        moveContinue = true;
                        while (moveContinue == true)
                        {
                            Console.WriteLine("Player 1, where would you like to move?");
                            movePosition = Convert.ToInt32(Console.ReadLine());
                            movePosition = movePosition - 1;
                            if (movePosition < 0 | movePosition > 8)
                            {
                                Console.WriteLine("Please enter a number between 1 and 9");
                            }
                            else
                            {
                                moveContinue = false;
                            }
                        }



                        if (string.IsNullOrEmpty(boardArray[movePosition]))
                        {
                            boardArray[movePosition] = "X";
                            inputContinue = false;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Please choose another number");
                        }

                    }
                }
                if (playerTurn % 2 == 1)
                {
                    while (inputContinue == true)
                    {
                        moveContinue = true;
                        while (moveContinue == true)
                        {
                            Console.WriteLine("Player 2, where would you like to move?");
                            movePosition = Convert.ToInt32(Console.ReadLine());
                            movePosition = movePosition - 1;
                            if (movePosition < 0 | movePosition > 8)
                            {
                                Console.WriteLine("Please enter a number between 1 and 9");
                            }
                            else
                            {
                                moveContinue = false;
                            }
                        }



                        if (string.IsNullOrEmpty(boardArray[movePosition]))
                        {
                            boardArray[movePosition] = "O";
                            inputContinue = false;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Please choose another number");
                        }

                    }
                }

                //for (int i = 0; i < 9; i++)
                //    Console.WriteLine(boardArray[i]);
                ab.Board(boardArray);

                winner = ab.winCheck(boardArray);
                Console.WriteLine(winner);
                if (winner == "player 1")
                {
                    Console.WriteLine("Player 1 is the winner");
                    gameContinue = false;
                }
                else if (winner == "player 2")
                {
                    Console.WriteLine("Player is the winner");
                    gameContinue = false;
                }
            }
            Console.WriteLine("Thanks for playing!");

        }

    }

}
