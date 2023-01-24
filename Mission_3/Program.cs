using System;

namespace Mission_3
{
    class Program
    {
        static void Main (string[] args)
        {
            // Define Variables

            Accept_Board ab = new Accept_Board();
            string winner = ""; 
            string[] boardArray = new string[9];
            bool gameContinue = true;
            bool inputContinue = true;
            bool moveContinue = true;
            int playerTurn = 0;
            int movePosition = 10;

            Console.WriteLine("Welcome to Tic Tac Toe");

            // Loop while in game
            while (gameContinue == true)
            {
                inputContinue = true;



                //If statement alternates game players
                //Player 1
                if (playerTurn % 2 == 0)
                {
                    //Continue asking for input until the space is available
                    while (inputContinue == true)
                    {
                        moveContinue = true;

                        //Continue asking for input if the number is outside 1-9
                        while (moveContinue == true)
                        {
                            //Recieve player 1 input
                            Console.WriteLine("Player 1, where would you like to move?");
                            movePosition = Convert.ToInt32(Console.ReadLine());
                            movePosition = movePosition - 1;

                            //Check if number is in range
                            if (movePosition < 0 | movePosition > 8)
                            {
                                Console.WriteLine("Please enter a number between 1 and 9");
                            }
                            else
                            {
                                moveContinue = false;
                            }
                        }


                        //Check if board space is available
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
                //Player 2
                if (playerTurn % 2 == 1)
                {
                    //Continue asking for input until the space is available
                    while (inputContinue == true)
                    {
                        //Continue asking for input if the number is outside 1-9
                        moveContinue = true;

                        while (moveContinue == true)
                        {
                            //Recieve player 2 input
                            Console.WriteLine("Player 2, where would you like to move?");
                            movePosition = Convert.ToInt32(Console.ReadLine());
                            movePosition = movePosition - 1;

                            //Check if number is in range
                            if (movePosition < 0 || movePosition > 8)
                            {
                                Console.WriteLine("Please enter a number between 1 and 9");
                            }
                            else
                            {
                                moveContinue = false;
                            }
                        }


                        //Check if board space is available
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
                //Display board
                ab.Board(boardArray);

                //Determine winner
                winner = ab.winCheck(boardArray);

                //Determine outcome based on winner

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
                else if (winner == "tie")
                {
                    Console.WriteLine("You tied");
                    gameContinue = false;
                }

                //Increment player turn
                playerTurn++;
                
                if (playerTurn == 9 && winner == "nobody")
                {
                    Console.WriteLine("The game is a tie");
                    gameContinue = false;
                }
            }
            Console.WriteLine("Thanks for playing!");

        }

    }

}
