using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class Assignment
    {
        public Assignment(int inCellColumn, int inCellRow, int inValueToAssign)
        {
            CellColumn = inCellColumn;
            CellRow = inCellRow;
            ValueToAssign = inValueToAssign;
        }

        public int CellRow;
        public int CellColumn;
        public int ValueToAssign;
    }
}
