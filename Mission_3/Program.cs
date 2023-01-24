using System;

namespace Mission_3
{
    class Program
    {
        static void Main (string[] args)
        { 
            Console.WriteLine("Hello World!");
            char[] gameArray = new char[9] { 'O', 'O', 'O', 'X', 'O', 'O','O', 'X', 'O' };
 
            Accept_Board ab = new Accept_Board();
            ab.Board(gameArray);

            string winner;
            winner = ab.winCheck(gameArray); 
            Console.WriteLine(winner);
        }

    }

}
