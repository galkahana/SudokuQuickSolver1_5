using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class CellConstraint : AssignmentConstraint
    {
        private int mCellRow;
        private int mCellColumn;



        public CellConstraint(int inCellColumn,int inCellRow) : base() 
        {
            mCellRow = inCellRow;
            mCellColumn = inCellColumn;
        }

        public int GetRow()
        {
            return mCellRow;
        }

        public int GetColumn()
        {
            return mCellColumn;
        }

        public bool Init(
            Board inBoard,
            AssignmentConstraint[] inConstraints,
            int inConstraintsCount
        )
        {
            if (inBoard.IsAvailable(mCellColumn, mCellRow))
            {
                if(inConstraintsCount > 0)
                {
                    Assign(inConstraints[0]);
                    for (int i = 1; i < inConstraintsCount; ++i)
                        IntersectWith(inConstraints[i]);
                }
                return (0 < mAllowedValues.Count);
            }
            else
                return true;
        }

        public bool HasSinglePossibleAssignment()
        {
            return (mAllowedValues.Count == 1);
        }

        public bool HasNoPossibleAssignments()
        {
            return (mAllowedValues.Count == 0);
        }

        public int GetAPossibleAssignment()
        {
            if (mAllowedValues.Count > 0)
            {
                Dictionary<int,int>.Enumerator it = mAllowedValues.GetEnumerator();
                it.MoveNext();
                return it.Current.Key;
            }
            else
                return Board.EMPTY_CELL_VALUE;
        }

        public void MarkAsAssigned()
        {
            mAllowedValues.Clear();
        }
    }
}
