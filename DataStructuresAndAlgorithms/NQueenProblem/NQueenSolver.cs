using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueenProblem
{
    public static class NQueenSolver
    {
        private static bool NQueenRecursive(int n, int row, Position[] position)
        {
            if(n == row)
            {
                return true;
            }
            for(int col = 0; col < n; col++)
            {
                bool foundSafe = true;
                for(int queenPos = 0; queenPos < row; queenPos++)
                {
                    int qRow = position[queenPos].Row;
                    int qCol = position[queenPos].Col;
                    if(qCol == col || qCol + qRow == col + row || qCol - qRow == col - row)
                    {
                        foundSafe = false;
                        break;
                    }
                }
                if(foundSafe)
                {
                    position[row] = new Position() { Col = col, Row = row };
                    if(NQueenRecursive(n, row+1, position))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Position[] SolveNQueen(int n)
        {
            Position[] position = new Position[n];
            if(NQueenRecursive(n, 0, position))
            {
                return position;
            }
            return new Position[0];
        }
    }
}
