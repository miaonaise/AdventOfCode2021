using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

public class Day4Board
{
	public List<List<int>> board;
	public List<List<int>> mark = new List<List<int>>();

	public Day4Board(List<List<int>> input)
	{
		board = input;
		for (int i = 0; i < 5; i++)
		{
			mark.Add(new List<int>(new int[5]));
        }
	}

	public void Mark(int calling_number)
	{
		for (int i = 0; i < 5; i++)
			for (int j = 0; j < 5; j++)
				if (board[i][j] == calling_number)
				{
					mark[i][j] = 1;
				}
	}

	public bool Check_Win()
    {
		for (int i = 0; i < 5; i++)
        {
			if (mark[i].Sum() == 5)
            {
				return true;
            }

			else if (mark.Select(x => x[i]).Sum() == 5)
            {
				return true;
            }
        }
		return false;

    } 

	public int Sum_of_Unmarked()
    {
		int sum = 0;
		for (int i = 0; i < 5; i++)
			for (int j = 0; j < 5; j++)
				if (mark[i][j] == 0)
				{
					sum += board[i][j];
				}

		return sum;
    }
}
