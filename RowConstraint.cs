using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class RowConstraint : Sudoku1_9RangeAssignmentConstraint
    {
        private int mRowIndex;

        public RowConstraint(int inRowIndex):base() 
        {
            mRowIndex = inRowIndex;
        }

        public bool Init(Board inBoard)
        {
            bool ok = true;
            FillValuesWithRange();
            for (int i = 0; i < 9 && ok; ++i)
                if (!inBoard.IsAvailable(i, mRowIndex))
                    ok = AssignValue(inBoard.Get(i, mRowIndex));
            return ok;
        }

        protected override CellConstraint GetCellFromIndex(BoardConstraints inConstraints, int inCellIndex)
        {
            return inConstraints.CellsConstraints[inCellIndex,mRowIndex];
        }
    }
}
