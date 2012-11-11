using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{
    class SudokuGame
    {
		public int TotalTriedGuesses;
		public int TotalFailedGuesses;
		public int MaxReachedDepth;
		public int DepthLimit;

		private int mDepth;
		private bool mAbort;

        public SudokuGame()
		{
			DepthLimit = 2;
			mAbort = false;
		}

		public int Solve(Board inBoard,bool inUseCellGuess, bool inEnforceDiagonalsConstraint)
		{
    		BoardConstraints constraints = new BoardConstraints();
            GuessesGeneration guessesGeneration = new GuessesGeneration(inUseCellGuess);
			mAbort = false;
			TotalTriedGuesses = 0;
			TotalFailedGuesses = 0;
			MaxReachedDepth = 0;
			mDepth = 0;

            int status = (constraints.Init(inBoard, inEnforceDiagonalsConstraint) ? 0 : -1);
            if (0 == status)
                status = SearchSollution(inBoard, constraints, guessesGeneration);
			if(mAbort)
				return -2;
			else
				return status;
		}

		private int SearchSollution(
            Board inBoard,
            BoardConstraints inConstraints,
            GuessesGeneration inGuessesGeneration
        )
		{
			if(inConstraints.HasConflicts())
				return -1;

			inConstraints.ImproveFollowingContraints();
			if(inBoard.IsFull())
				return 0;
			else
			{
                if (inConstraints.HasConflicts())
					return -1;
				else
                    return SearchSollutionWithBackTracking(inBoard, inConstraints, inGuessesGeneration);
			}
		}

        private int SearchSollutionWithBackTracking(
            Board inBoard, 
            BoardConstraints inConstraints,
            GuessesGeneration inGuessesGeneration
        )
		{
			bool foundGoodGuess = false;
            BoardConstraints pendingConstraints = new BoardConstraints();
			Board pendingBoard = new Board();
            List<GuessGroup> guesses;
			int status = 1;

			if(mAbort || (DepthLimit == mDepth))
				return status;
			++mDepth;
			MaxReachedDepth = (MaxReachedDepth > mDepth ? MaxReachedDepth : mDepth);
            guesses = inGuessesGeneration.GetListOfGuesses(inConstraints);
            foreach (GuessGroup guessGroup in guesses)
			{
				if(mAbort)
					break;
                foreach(Assignment guess in guessGroup.Guesses)
                {
                    if (mAbort)
                        break;
                    ++TotalTriedGuesses;
                    pendingBoard.Assign(inBoard);
                    pendingConstraints.Assign(inConstraints, pendingBoard);
                    pendingConstraints.AssignValueToCell(guess);
                    if (SearchSollution(pendingBoard, pendingConstraints, inGuessesGeneration) == 0)
                    {
                        foundGoodGuess = true;
                        break;
                    }
                    else
                        ++TotalFailedGuesses;
				}
				if(foundGoodGuess)
				{
                    inBoard.Assign(pendingBoard);
					inConstraints.Assign(pendingConstraints,inBoard);
					status = 0;
					break;
				}
			}
			--mDepth;
			return status;
		}

        public void Abort()
		{
			mAbort = true;
		}

		public bool IsAbort()
		{
			return mAbort;
		}
    }
}
