using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    abstract class Sudoku1_9RangeAssignmentConstraint : AssignmentConstraint
    {

        protected Sudoku1_9RangeAssignmentConstraint() : base() { }

        protected void FillValuesWithRange()
        {
            mAllowedValues.Clear();
            for (int i = 1; i < 10; ++i)
                mAllowedValues.Add(i, i);
        }

        public bool isFull()
        {
            return 0 == mAllowedValues.Count;
        }

        public bool ImproveSingleNumberAssignment(Board inBoard, BoardConstraints inConstraints)
        {
            if (isFull())
                return false;

            int possibleAssisgnmentsCount = 0;
            List<CellConstraint> cellAssignments = new List<CellConstraint>();
            List<int> numberAssignments = new List<int>();
            CellConstraint aPossibleAssignment = null, aCell;

            foreach (int numberValue in mAllowedValues.Keys)
            {
                possibleAssisgnmentsCount = 0;
                for (int i = 0; i < 9; ++i)
                {
                    aCell = GetCellFromIndex(inConstraints, i);
                    if (inBoard.IsAvailable(aCell.GetColumn(), aCell.GetRow()) && 
                        aCell.CanAssignValue(numberValue))
                        {
                            ++possibleAssisgnmentsCount;
                            aPossibleAssignment = aCell;
                        }
                }
                if (1 == possibleAssisgnmentsCount)
                {
                    cellAssignments.Add(aPossibleAssignment);
                    numberAssignments.Add(numberValue);
                }
            }

            for (int i = 0; i < cellAssignments.Count; ++i)
            {
                inConstraints.AssignValueToCell(
                    cellAssignments[i].GetColumn(),
                    cellAssignments[i].GetRow(),
                    numberAssignments[i]
                );
            }

            return (cellAssignments.Count > 0);
        }

        abstract protected CellConstraint GetCellFromIndex(BoardConstraints inConstraints, int inCellIndex);

        public bool AssignValue(int inNumberValue, BoardConstraints inConstraints)
        {
            if (AssignValue(inNumberValue))
            {
                for (int i = 0; i < 9; ++i)
                    GetCellFromIndex(inConstraints, i).AssignValue(inNumberValue);
                return true;
            }
            else
                return false;
        }

        public bool HasNumbersWithNoPossibleAssignments(Board inBoard, BoardConstraints inConstraints)
        {
            if (isFull())
                return false;

            int possibleAssisgnmentsCount = 0;
            CellConstraint aCell;

            foreach (int numberValue in mAllowedValues.Keys)
            {
                possibleAssisgnmentsCount = 0;
                for (int i = 0; i < 9; ++i)
                {
                    aCell = GetCellFromIndex(inConstraints, i);
                    if (inBoard.IsAvailable(aCell.GetColumn(), aCell.GetRow()) &&
                        aCell.CanAssignValue(numberValue))
                            ++possibleAssisgnmentsCount;
                }
                if (0 == possibleAssisgnmentsCount)
                    break;
            }

            return (0 == possibleAssisgnmentsCount);
        }
    }
}
