using System;

namespace SudokuQuickSolver1_5
{
	public class Board
	{
		public const int EMPTY_CELL_VALUE = 0;
		private int[,] mCells;

		public Board()
		{
			mCells = new int[9,9];
            Clear();
		}

        public void Clear()
        {
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    mCells[i, j] = EMPTY_CELL_VALUE;
        }


		public void Set(int inX,int inY,int inValue)
		{
			if(AreValidCoordinates(inX,inY))
				mCells[inX,inY] = inValue;
		}

		public int Get(int inX,int inY)
		{
			if(AreValidCoordinates(inX,inY))
				return mCells[inX,inY];
			else
				return EMPTY_CELL_VALUE;
		}

		private bool AreValidCoordinates(int inX,int inY)
		{
			return ((inX < 9) && (inX >= 0) && (inY < 9) && (inY >= 0));
		}

		public bool IsAvailable(int inX,int inY)
		{
			return Get(inX,inY) == EMPTY_CELL_VALUE;
		}

		public bool IsFull()
		{
			bool notFullNotFound = true;

			for(int i=0;i<9 && notFullNotFound;++i)
				for(int j=0;j<9 && notFullNotFound;++j)
					notFullNotFound = (mCells[i,j] != EMPTY_CELL_VALUE);
			return notFullNotFound;
		}

		public void Assign(Board inBoard)
		{
			for(int i=0;i<9;++i)
				for(int j=0;j<9;++j)
					mCells[i,j] = inBoard.mCells[i,j];
		}
	}
}
