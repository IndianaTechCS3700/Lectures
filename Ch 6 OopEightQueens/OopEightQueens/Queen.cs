using System;

namespace OopEightQueens
{
    public enum MoveStatus { AbleToMove, UnableToMoveAdvancedNeigbor, CantMove };

    /// <summary>
    /// A Queen class that has the ability to find the solution to the
    /// eight queens problem.
    /// </summary>
    /// <remarks>
    /// Is this the real life?
    /// Is this just fantasy?
    /// Caught in a landslide
    /// No escape from reality
    /// </remarks>
    public class Queen
    {
        private readonly int max_row = ChessBoard.Size - 1;

        private readonly int col = 0;
        private int row;
        private Queen neighbor;

        private Queen()
        {
        }

        public Queen(int newCol, Queen newNeighbor)
        {
            this.col = newCol;
            this.neighbor = newNeighbor;

            row = 0;
        }

        public Queen(int newCol, int newRow, Queen newNeighbor)
        {
            this.col = newCol;
            this.neighbor = newNeighbor;

            this.row = newRow;
        }

        /// <summary>
        /// Move the current queen and the queens to the left to a proper solution.
        /// </summary>
        /// <returns></returns>
        public bool FindSolution()
        {
            MoveStatus status;
            do
            {
                if (neighbor != null)
                {
                    neighbor.FindSolution();
                }
                else //(neighbor == null)
                {
                    return true;
                }

                do
                {
                    if (!neighbor.CanBeAttacked(row, col))
                    {
                        return true;
                    }

                    status = Advance();
                } while (status == MoveStatus.AbleToMove);

                if (status == MoveStatus.CantMove)
                {
                    return false;
                }
            } while (true);

        }

        /// <summary>
        /// Return whether or not a given position can be attacked
        /// </summary>
        public bool CanBeAttacked(int testRow, int testCol)
        {
            if (row == testRow)
            {
                return true;
            }

            int offset = col - testCol;
            if (row == testRow - offset ||
                row == testRow + offset)
            {
                return true;
            }

            if (neighbor != null)
            {
                return neighbor.CanBeAttacked(testRow, testCol);
            }
            return false;
        }

        public MoveStatus Advance()
        {
            if (row < max_row)
            {
                row++;
                return MoveStatus.AbleToMove;
            }
            else
            {
                if (neighbor == null)
                {
                    return MoveStatus.CantMove;
                }

                MoveStatus neighborMoveStatus = neighbor.Advance();

                if (neighborMoveStatus == MoveStatus.AbleToMove)
                {
                    row = 0;
                    return MoveStatus.UnableToMoveAdvancedNeigbor;
                }
                else
                {
                    return MoveStatus.CantMove;
                }
            }
        }

        public void Print()
        {
            if (neighbor != null)
            {
                neighbor.Print();
            }
            Console.WriteLine("{0}, {1}", col, row);
        }
    }
}