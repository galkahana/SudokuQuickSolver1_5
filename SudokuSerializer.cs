using System;
using System.IO;

namespace SudokuQuickSolver1_5
{
	public class SudokuSerializer
	{
		public SudokuSerializer()
		{
		}


		public bool Write(string inPath,Board inBoard)
		{
			FileStream fsOut = new FileStream(inPath, FileMode.OpenOrCreate,
				FileAccess.Write, FileShare.Write);
			StreamWriter sr = new StreamWriter(fsOut); 
			FillDataWithBoard(sr,inBoard);
			sr.Close();
			return true;
		}

		private bool FillDataWithBoard(StreamWriter inData,Board inBoard)
		{
			for(int i=0;i<9;++i)
			{
				for(int j=0;j<9;++j)
				{
					inData.Write(inBoard.Get(i,j).ToString());
				}
				inData.Write(inData.NewLine);
			}
			return true;			
		}

		public bool Read(string inPath,Board inBoard)
		{
			if (!File.Exists(inPath)) 
			{
				return false;
			}
			FileStream fsIn = new FileStream(inPath, FileMode.Open,
				FileAccess.Read, FileShare.Read);
			StreamReader sr = new StreamReader(fsIn); 
			FillBoardWithData(sr,inBoard);
			sr.Close();
			return true;
		}

		private bool FillBoardWithData(StreamReader inData,Board inBoard)
		{
			int number;
			for(int i=0;i<9;++i)
				for(int j=0;j<9;++j)
				{
					number = ReadNextDigit(inData);
					if(number != Board.EMPTY_CELL_VALUE)
						inBoard.Set(i,j,number);
				}
			return true;
		}

		private static char scZero = '0';
		private static char scNine = '9';

		private int ReadNextDigit(StreamReader inData)
		{
			bool digitNotFound = true;
			int digit = 0;
			int readChar;

			do
			{
				readChar = inData.Read();
				if(-1 == readChar)
					break;

				if(readChar >= scZero && readChar <=scNine)
				{
					digitNotFound = false;
					digit = (readChar - scZero);
				}
			}while(digitNotFound);
			return digit;
		}
	}
}
