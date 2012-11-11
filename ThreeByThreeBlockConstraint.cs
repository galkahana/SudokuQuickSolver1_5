using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class ThreeByThreeBlockConstraint : Sudoku1_9RangeAssignmentConstraint
    {
        private int mTopRow;
        private int mLeftColumn;

        public ThreeByThreeBlockConstraint(int inLeftIndex,int inTopIndex) : base() 
        { 
            mLeftColumn = inLeftIndex * 3;
            mTopRow = inTopIndex * 3;
        }

        public bool Init(Board inBoard)
        {
            bool ok = true;
            FillValuesWithRange();
            for (int i = 0; i < 3 && ok; ++i)
                for (int j = 0; j < 3 && ok; ++j)
                    if (!inBoard.IsAvailable(i + mLeftColumn, j + mTopRow))
                        ok = AssignValue(inBoard.Get(i + mLeftColumn, j + mTopRow));
            return ok;
        }

        protected override CellConstraint GetCellFromIndex(BoardConstraints inConstraints, int inCellIndex)
        {
            return inConstraints.CellsConstraints[inCellIndex % 3 + mLeftColumn,inCellIndex / 3 + mTopRow];
        }
    }
}
