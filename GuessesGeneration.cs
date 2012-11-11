using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class GuessesGeneration : IComparer<GuessGroup>
    {
        private bool mGenerateCellGuesses;

        public GuessesGeneration(bool inGenerateCellGuesses)
        {
            mGenerateCellGuesses = inGenerateCellGuesses;
        }

        public List<GuessGroup> GetListOfGuesses(BoardConstraints inConstraints)
        {
            List<GuessGroup> guesses = new List<GuessGroup>();

            if (mGenerateCellGuesses)
                GenerateGroupsOfCellGuesses(inConstraints,guesses);
            else
                GenerateGroupsOfNumberGuesses(inConstraints,guesses);
            guesses.Sort(this);
            return guesses;
        }

        private void GenerateGroupsOfCellGuesses(
            BoardConstraints inConstraints,
            List<GuessGroup> guesses
        )
        {
            GuessGroup aGroup;
            foreach (CellConstraint cellConstraint in inConstraints.CellsConstraints)
            {
                if (!cellConstraint.HasNoPossibleAssignments())
                {
                    aGroup = new GuessGroup();
                    List<int> numbers = new List<int>();
                    foreach (int assignmentNumber in cellConstraint.GetAllowedValues())
                        numbers.Add(assignmentNumber);
                    numbers.Sort();

                    foreach (int assignmentNumber in numbers)
                        aGroup.Add(new Assignment(
                                    cellConstraint.GetColumn(), 
                                    cellConstraint.GetRow(), 
                                    assignmentNumber
                                ));
                    guesses.Add(aGroup);
                }
            }
        }

        private void GenerateGroupsOfNumberGuesses(
            BoardConstraints inConstraints, 
            List<GuessGroup> guesses
        )
        {
            for (int i = 0; i < 9; ++i)
                guesses.Add(new GuessGroup());
            foreach (CellConstraint cellConstraint in inConstraints.CellsConstraints)
                if (!cellConstraint.HasNoPossibleAssignments())
                    foreach (int assignmentNumber in cellConstraint.GetAllowedValues())
                        guesses[assignmentNumber - 1].Add(
                                new Assignment(
                                    cellConstraint.GetColumn(),
                                    cellConstraint.GetRow(),
                                    assignmentNumber
                                ));
            for (int i = 8; i >= 0; --i)
                if (guesses[i].Rank() == 0)
                    guesses.Remove(guesses[i]);
        }

        #region IComparer<GuessGroup> Members

        public int Compare(GuessGroup x, GuessGroup y)
        {
            if (x.Rank() != y.Rank())
                return x.Rank() - y.Rank();

            List<Assignment>.Enumerator xEnum = x.Guesses.GetEnumerator();
            List<Assignment>.Enumerator yEnum = y.Guesses.GetEnumerator();

            while (xEnum.MoveNext())
            {
                yEnum.MoveNext();
                if (xEnum.Current.CellColumn != yEnum.Current.CellColumn)
                    return xEnum.Current.CellColumn - yEnum.Current.CellColumn;
                if(xEnum.Current.CellRow != yEnum.Current.CellRow)
                    return xEnum.Current.CellRow - yEnum.Current.CellRow;
                if (xEnum.Current.ValueToAssign != yEnum.Current.ValueToAssign)
                    return xEnum.Current.ValueToAssign - yEnum.Current.ValueToAssign;
            }
            return 0;
        }

        #endregion
    }
}
