using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueenProblem
{
    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public void Print()
        {
            Console.WriteLine("Row : {0} Col : {1}", Row, Col);
        }
    }
}
