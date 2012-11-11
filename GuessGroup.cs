using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class GuessGroup
    {
        private List<Assignment> mGuesses;

        public GuessGroup()
        {
            mGuesses = new List<Assignment>();
        }

        public List<Assignment> Guesses
        {
            get
            {
                return mGuesses;
            }
        }

        public int Rank()
        {
            return mGuesses.Count;
        }

        public void Add(Assignment inAssignment)
        {
            mGuesses.Add(inAssignment);
        }

    }
}
