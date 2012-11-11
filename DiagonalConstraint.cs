using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class DiagonalConstraint : Sudoku1_9RangeAssignmentConstraint
    {
        // diagonal can either be top to bottom, or bottom to top, meaning  (0,0)-(8,8) or (0,8) to (8,0) accordingly
        private bool mTopToBottom;

        public DiagonalConstraint(bool inTopToBottom): base() 
        {
            mTopToBottom = inTopToBottom;
        }

        public bool Init(Board inBoard)
        {
            bool ok = true;
            FillValuesWithRange();
            if (mTopToBottom)
            {
                for (int i = 0; i < 9 && ok; ++i)
                    if (!inBoard.IsAvailable(i,i))
                        ok = AssignValue(inBoard.Get(i,i));
            }
            else
            {
                for (int i = 0; i < 9 && ok; ++i)
                    if (!inBoard.IsAvailable(i, 8 - i))
                        ok = AssignValue(inBoard.Get(i, 8 - i));
            }
            return ok;
        }

        protected override CellConstraint GetCellFromIndex(BoardConstraints inConstraints, int inCellIndex)
        {
            if (mTopToBottom)
                return inConstraints.CellsConstraints[inCellIndex, inCellIndex];
            else
                return inConstraints.CellsConstraints[inCellIndex, 8 - inCellIndex];
        }
    }
}
