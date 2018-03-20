using System;

namespace OopEightQueens
{
    /// <summary>
    /// Create the all queens and have the last one find this solution
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queen lastQueen = null;

            for (int i = 0; i < ChessBoard.Size; i++)
            {
                lastQueen = new Queen(i, lastQueen);
            }


            while (lastQueen.FindSolution())
            {
                lastQueen.Print();
                lastQueen.Advance();
                Console.WriteLine();
            }

            Console.WriteLine("Press The Any To Continue");
            Console.ReadKey();
        }
    }
}