/**
 * Date 02/20/2016
 * @author Ankit Bhardwaj
 *
 * Given nxn board place n queen on this board so that they dont attack each other. One solution is to find
 * any placement of queens which do not attack each other. Other solution is to find all placements of queen
 * on the board.
 *
 * Time complexity O(n*n)
 * Space complexity O(n*n)
 */
 
 #include <iostream>
 
 using namespace std;
 
 class Position
 {
 	public:
 		int row;
 		int col;
 		Position();
 		void Set(int row, int col);
 		void Print();
 };
 
 Position::Position()
 {
 	row = -1;
 	col = -1;
 }
 
 void Position::Set(int row, int col)
 {
 	this->col = col;
 	this->row = row;
 }
 
 void Position::Print()
 {
 	cout<<"Row : "<<this->row<<" Col : "<<this->col<<endl;
 }
 
 bool NQueenRecursive(int n, int row, Position position[])
 {
 	if(n==row)
 	{
 		return true;
	}
	for(int col = 0; col < n ; col++)
	{
		bool foundSafe = true;
		for(int queenPos = 0; queenPos < row; queenPos++)
		{
			int qRow = position[queenPos].row;
			int qCol = position[queenPos].col;
			if(qCol == col || qCol - qRow == col - row || qCol + qRow == col + row)
			{
				foundSafe = false;
				break;
			}
		}
		if(foundSafe)
		{
			//position[row] = new Position();
			position[row].Set(row, col);
			if(NQueenRecursive(n, row + 1, position))
			{
				return true;
			}
		}
	}
	return false;
 }
 
 Position* SolveNQueen(int n)
 {
 	Position *position = new Position[n];
 	if(NQueenRecursive(n, 0, position))
 	{
 		return position;
	}	
	return position;
 }
  
 int main()
 {
 	int n = 4;
 	Position* position = SolveNQueen(n);
 	for(int i = 0; i < n; i++)
 	{
 		position[i].Print();
	}
 	return 0;
 }
