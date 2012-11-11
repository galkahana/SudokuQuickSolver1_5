using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class ColumnConstraint : Sudoku1_9RangeAssignmentConstraint
    {
        private int mColumnIndex;

        public ColumnConstraint(int inColumnIndex) : base() 
        {
            mColumnIndex = inColumnIndex;
        }

        public bool Init(Board inBoard)
        {
            bool ok = true;
            FillValuesWithRange();
            for (int i = 0; i < 9 && ok; ++i)
                if (!inBoard.IsAvailable(mColumnIndex,i))
                    ok = AssignValue(inBoard.Get(mColumnIndex,i));
            return ok;
        }

        protected override CellConstraint GetCellFromIndex(BoardConstraints inConstraints, int inCellIndex)
        {
            return inConstraints.CellsConstraints[mColumnIndex,inCellIndex];
        }
    }
}
