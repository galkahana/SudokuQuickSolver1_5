# SudokuQuickSolver1_5
An old Sudoku solver project of mine

Normally when studying a language involving desktop UI i like to implement this sodoku solver based on a simple idea 
i had to how to solve this riddle. This is from my C# studies. I got example here from various other methods, even one for Flash haha. and [here's](https://app.box.com/s/epoo4b3stt9ystdmep8b) the objective c version.

I look for cells that have only one options for assignment based on the constraints applied to them, and also for numbers in a 9 constraint (row, col or 3 by 3) 
that have just one possible cell assignment. by repeatedly assigning those, the constraints are updated to include the now assigned elements and i can normally
solve a whole sudoku board just with that. For those cases where i need some "guessing" i got a simple backtracking algo (form my zero sum games era) to guess and repeat the
base algo. with max tree depth of 2 (meaning if after two guesses i can't complete the board based on the regular method I quit that particular path) i'm still to find a sudoku board
that can't be solved.

in any case...this ones in C#.
