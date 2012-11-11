using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class BoardConstraints
    {

        public RowConstraint[] RowsConstraints;
        public ColumnConstraint[] ColumnsConstraints;
        public ThreeByThreeBlockConstraint[,] ThreeByTreeBlockConstraints;
        public CellConstraint[,] CellsConstraints;
        public DiagonalConstraint TopToBottomDiagonalConstraint;
        public DiagonalConstraint mBottomToTopDiagonalConstraint;

        private Board mBoard;

        public BoardConstraints()
		{
            RowsConstraints = new RowConstraint[9];
            ColumnsConstraints = new ColumnConstraint[9];
			for(int i=0;i<9;++i)
			{
                RowsConstraints[i] = new RowConstraint(i);
                ColumnsConstraints[i] = new ColumnConstraint(i);
			}
            ThreeByTreeBlockConstraints = new ThreeByThreeBlockConstraint[3, 3];
			for(int i=0;i<3;++i)
				for(int j=0;j<3;++j)
                    ThreeByTreeBlockConstraints[i, j] = new ThreeByThreeBlockConstraint(i,j);
            
            CellsConstraints = new CellConstraint[9,9];
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    CellsConstraints[i, j] = new CellConstraint(i,j);
            
            TopToBottomDiagonalConstraint = null;
            mBottomToTopDiagonalConstraint = null;
		}

        public bool Init(Board inBoard, bool inEnforceDiagonalsConstraint)
        {
            bool statusOK;

            mBoard = inBoard;
            do
            {
                statusOK = SetupDiagonalConstraints(inEnforceDiagonalsConstraint);
                if (!statusOK)
                    break;

                statusOK = SetupGroupConstraints();
                if (!statusOK)
                    break;

                statusOK = SetupCellConstraints(inEnforceDiagonalsConstraint);
                if (!statusOK)
                    break;

                statusOK = !HasConflicts();
            } while (false);
            return statusOK;
        }

        private bool SetupDiagonalConstraints(bool inEnforceDiagonalsConstraint)
        {
            bool statusOK;
            if (inEnforceDiagonalsConstraint)
            {
                TopToBottomDiagonalConstraint = new DiagonalConstraint(true);
                statusOK = TopToBottomDiagonalConstraint.Init(mBoard);
                if (statusOK)
                {
                    mBottomToTopDiagonalConstraint = new DiagonalConstraint(false);
                    statusOK = mBottomToTopDiagonalConstraint.Init(mBoard);
                }
            }
            else
            {
                TopToBottomDiagonalConstraint = null;
                mBottomToTopDiagonalConstraint = null;
                statusOK = true;
            }
            return statusOK;
        }

        private bool SetupGroupConstraints()
        {
            bool statusOK = true;

            for (int i = 0; i < 9 && statusOK; ++i)
            {
                statusOK =
                    RowsConstraints[i].Init(mBoard) &&
                    ColumnsConstraints[i].Init(mBoard) &&
                    ThreeByTreeBlockConstraints[i % 3, i / 3].Init(mBoard);
            }
            return statusOK;
        }

        private bool SetupCellConstraints(bool inEnforceDiagonalConstraints)
        {
            bool statusOK = true;
            int k;
            AssignmentConstraint[] thisCellConstraints = new AssignmentConstraint[5];

            if (inEnforceDiagonalConstraints)
            {
                for (int i = 0; i < 9 && statusOK; ++i)
                    for (int j = 0; j < 9 && statusOK; ++j)
                    {
                        thisCellConstraints[0] = ThreeByTreeBlockConstraints[i / 3, j / 3];
                        thisCellConstraints[1] = ColumnsConstraints[i];
                        thisCellConstraints[2] = RowsConstraints[j];
                        k = 3;
                        if (i == j)
                            thisCellConstraints[k++] = TopToBottomDiagonalConstraint;
                        if (i == 8 - j)
                            thisCellConstraints[k++] = mBottomToTopDiagonalConstraint;
                        statusOK = CellsConstraints[i, j].Init(mBoard, thisCellConstraints, k);
                    }

            }
            else
            {
                for (int i = 0; i < 9 && statusOK; ++i)
                    for (int j = 0; j < 9 && statusOK; ++j)
                    {
                        thisCellConstraints[0] = ThreeByTreeBlockConstraints[i / 3, j / 3];
                        thisCellConstraints[1] = ColumnsConstraints[i];
                        thisCellConstraints[2] = RowsConstraints[j];
                        statusOK = CellsConstraints[i, j].Init(mBoard, thisCellConstraints,3);
                    }
            }
            return statusOK;
        }
    
        public bool ImproveFollowingContraints()
        {
            bool improved = false, mightHaveMoreToImprove;

            do
            {
                mightHaveMoreToImprove = 
                    ImproveCellsWithSinglePossibleAssignment()  |
                    ImproveNumbersWithSinglePossibleAssignment();
                if (mightHaveMoreToImprove)
                    improved = true;
            } while (mightHaveMoreToImprove);
            return improved;
        }

        private bool ImproveCellsWithSinglePossibleAssignment()
        {
			bool improved = false;

            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    if (mBoard.IsAvailable(i, j) && CellsConstraints[i, j].HasSinglePossibleAssignment())
                    {
                        improved = true;
                        AssignValueToCell(i,j,CellsConstraints[i, j].GetAPossibleAssignment());
                    }
            return improved;
        }

        public void AssignValueToCell(Assignment inAssignment)
        {
            AssignValueToCell(inAssignment.CellColumn, inAssignment.CellRow, inAssignment.ValueToAssign);
        }

        public void AssignValueToCell(int inCellColumn, int inCellRow, int inAssignedNumberValue)
        {
            mBoard.Set(inCellColumn, inCellRow, inAssignedNumberValue);
            CellsConstraints[inCellColumn, inCellRow].MarkAsAssigned();
            RowsConstraints[inCellRow].AssignValue(inAssignedNumberValue, this);
            ColumnsConstraints[inCellColumn].AssignValue(inAssignedNumberValue, this);
            ThreeByTreeBlockConstraints[inCellColumn / 3, inCellRow / 3].AssignValue(inAssignedNumberValue, this);
            if ((TopToBottomDiagonalConstraint != null) && (inCellColumn == inCellRow))
                TopToBottomDiagonalConstraint.AssignValue(inAssignedNumberValue, this);
            if ((mBottomToTopDiagonalConstraint != null ) && (inCellColumn == 8 - inCellRow))
                mBottomToTopDiagonalConstraint.AssignValue(inAssignedNumberValue, this);
               
        }

        private bool ImproveNumbersWithSinglePossibleAssignment()
        {
            return ImproveRows() | ImproveColumns() | ImproveThreeByThreeBlocks() | ImproveDiagonals();
        }

        private bool ImproveRows()
        {
            bool improved = false;
            foreach(RowConstraint constraint in RowsConstraints)
                improved |= constraint.ImproveSingleNumberAssignment(mBoard, this);
            return improved;
        }

        private bool ImproveColumns()
        {
            bool improved = false;
            foreach(ColumnConstraint constraint in ColumnsConstraints)
                improved |= constraint.ImproveSingleNumberAssignment(mBoard, this);
            return improved;
        }

        private bool ImproveThreeByThreeBlocks()
        {
            bool improved = false;
            foreach(ThreeByThreeBlockConstraint constraint in ThreeByTreeBlockConstraints)
                improved |= constraint.ImproveSingleNumberAssignment(mBoard, this);
            return improved;
        }

        private bool ImproveDiagonals()
        {
            bool improved = false;
            if (TopToBottomDiagonalConstraint != null)
                improved |= TopToBottomDiagonalConstraint.ImproveSingleNumberAssignment(mBoard, this);
            if (mBottomToTopDiagonalConstraint != null)
                improved |= mBottomToTopDiagonalConstraint.ImproveSingleNumberAssignment(mBoard, this);
            return improved;
        }

        public bool HasConflicts()
        {
            return HasCellWithNoPossibleAssignments() || HasNumbersWithNoPossibleAssignments();
        }

        private bool HasCellWithNoPossibleAssignments()
        {
            bool result = false;

            foreach (CellConstraint aCell in CellsConstraints)
                if(aCell.HasNoPossibleAssignments() && 
                    mBoard.IsAvailable(aCell.GetColumn(),aCell.GetRow()))
                {
                    result = true;
                    break;
                }

            return result;
        }

        private bool HasNumbersWithNoPossibleAssignments()
        {
            return HasRowsWithNoPossibleAssignments() ||
                HasColumnsWithNoPossibleAssignments() ||
                HasThreeByThreeBlockWithNoPossibleAssignments() ||
                HasDiagonalWithNoPossibleAssignments();
        }

        private bool HasRowsWithNoPossibleAssignments()
        {
            bool improved = false;
            foreach (RowConstraint constraint in RowsConstraints)
                improved |= constraint.HasNumbersWithNoPossibleAssignments(mBoard, this);
            return improved;
        }

        private bool HasColumnsWithNoPossibleAssignments()
        {
            bool improved = false;
            foreach (ColumnConstraint constraint in ColumnsConstraints)
                improved |= constraint.HasNumbersWithNoPossibleAssignments(mBoard, this);
            return improved;
        }

        private bool HasThreeByThreeBlockWithNoPossibleAssignments()
        {
            bool improved = false;
            foreach (ThreeByThreeBlockConstraint constraint in ThreeByTreeBlockConstraints)
                improved |= constraint.HasNumbersWithNoPossibleAssignments(mBoard, this);
            return improved;
        }

        private bool HasDiagonalWithNoPossibleAssignments()
        {
            bool improved = false;
            if (TopToBottomDiagonalConstraint != null)
                improved |= TopToBottomDiagonalConstraint.HasNumbersWithNoPossibleAssignments(mBoard, this);
            if (mBottomToTopDiagonalConstraint != null)
                improved |= mBottomToTopDiagonalConstraint.HasNumbersWithNoPossibleAssignments(mBoard, this);
            return improved;
        }

        public void Assign(BoardConstraints inBoardConstraints,Board inBoard)
        {
            mBoard = inBoard;
            for (int i = 0; i < 9; ++i)
            {
                RowsConstraints[i].Assign(inBoardConstraints.RowsConstraints[i]);
                ColumnsConstraints[i].Assign(inBoardConstraints.ColumnsConstraints[i]);
                ThreeByTreeBlockConstraints[i % 3, i / 3].Assign(
                    inBoardConstraints.ThreeByTreeBlockConstraints[i % 3, i / 3]
                );
                for (int j = 0; j < 9; ++j)
                    CellsConstraints[i, j].Assign(inBoardConstraints.CellsConstraints[i, j]);

                if (inBoardConstraints.TopToBottomDiagonalConstraint != null)
                {
                    TopToBottomDiagonalConstraint = new DiagonalConstraint(true);
                    TopToBottomDiagonalConstraint.Assign(inBoardConstraints.TopToBottomDiagonalConstraint);
                }
                else
                {
                    TopToBottomDiagonalConstraint = null;
                }

                if (inBoardConstraints.mBottomToTopDiagonalConstraint != null)
                {
                    mBottomToTopDiagonalConstraint = new DiagonalConstraint(false);
                    mBottomToTopDiagonalConstraint.Assign(inBoardConstraints.mBottomToTopDiagonalConstraint);
                }
                else
                {
                    mBottomToTopDiagonalConstraint = null;
                }
            }
        }
    }
}
