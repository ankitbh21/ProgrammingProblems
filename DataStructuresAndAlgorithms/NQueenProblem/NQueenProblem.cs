using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueenProblem
{
    class NQueenProblem
    {
        static void Main(string[] args)
        {
            int n = 4;
            Position[] positions = NQueenSolver.SolveNQueen(n);
            foreach(Position position in positions)
            {
                position.Print();
            }
            Console.ReadLine();
        }
    }
}
