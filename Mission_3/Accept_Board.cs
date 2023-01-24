using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_3
{
    class Accept_Board
    {
        //Constructor
        public Accept_Board()
        {

        }
        public void Board(string[] args)
        {
            // class should display sample positions
            // Next it should display board with each X or O at it's respective position
            Console.WriteLine("Each number in position of its respective square");
            Console.WriteLine("1 2 3");
            Console.WriteLine("4 5 6");
            Console.WriteLine("7 8 9 \n");
            char[] spot = new char[9];
            int count = 0;
            foreach (string item in args)
            {

                if (item == "O")
                {
                    spot[count] = 'O';
                }
                else if (item == "X")
                {
                    spot[count] = 'X';
                }
                else
                {
                    spot[count] = ' ';
                }
                count++;
            }
            // display Player inputs at correct positions
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + spot[0] + "  |  " + spot[1] + "  |  " + spot[2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + spot[3] + "  |  " + spot[4] + "  |  " + spot[5] + "  "); ;
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + spot[6] + "  |  " + spot[7] + "  |  " + spot[8] + "  ");
            Console.WriteLine("     |     |     ");
        }

        public string winCheck(string[] arr)
        {
            // class should check wether or not a player has won. If they have, display their name.
            // otherwise display that 'nobody' has won
            string[] option = new string[2] { "X", "O" };
            string[] players = new string[2] { "player 1", "player 2" };
            string winner = "nobody";
            int value = 0;


            foreach (string item in option)
            { 
                if ((arr[0] == item && arr[1] == item && arr[2] == item))
                {
                    winner = players[value];
                }
                else if (arr[3] == item && arr[4] == item && arr[5] == item)
                {
                    winner = players[value];
                }
                else if (arr[6] == item && arr[7] == item && arr[8] == item)
                {
                    winner = players[value];
                }
                else if (arr[0] == item && arr[3] == item && arr[6] == item)
                {
                    winner = players[value];
                }
                else if (arr[1] == item && arr[4] == item && arr[7] == item)
                {
                    winner = players[value];
                }
                else if (arr[2] == item && arr[5] == item && arr[8] == item)
                {
                    winner = players[value];
                }
                else if (arr[0] == item && arr[4] == item && arr[8] == item)
                {
                    winner = players[value];
                }
                else if (arr[2] == item && arr[4] == item && arr[6] == item)
                {
                    winner = players[value];
                }
                value++;
            }

            // return winner if one exists
            return winner;
        }

    }
}
