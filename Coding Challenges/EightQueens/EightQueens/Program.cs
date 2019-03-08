//Have the function EightQueens(strArr) read strArr which will be an array consisting of the locations of eight Queens on a standard 8x8 
//chess board with no other pieces on the board.The structure of strArr will be the following: ["(x,y)", "(x,y)", ...] where (x, y) 
//represents the position of the current queen on the chessboard (x and y will both range from 1 to 8 where 1,1 is the bottom-left of the
//chessboard and 8,8 is the top-right). Your program should determine if all of the queens are placed in such a way where none of them
//are attacking each other. If this is true for the given input, return the string true otherwise return the first queen in the list that 
//is attacking another piece in the same format it was provided. 


using System;

class MainClass
{
    private static string EightQueens(string[] strArr)
    {   
        foreach (string coord in strArr)
        {
            int x = (int)Char.GetNumericValue(coord[1]);
            int y = (int)Char.GetNumericValue(coord[3]);
            Console.WriteLine("{0}, {1}", x, y);
        }

        return strArr[0];

    }

    static void Main()
    {
        string[] input = new string[] { "(2,1)", "(4,3)", "(6,3)", "(8,4)", "(3,4)", "(1,6)", "(7,7)", "(5,8)" };
        Console.WriteLine(EightQueens(input));
        Console.ReadLine();
    }

}