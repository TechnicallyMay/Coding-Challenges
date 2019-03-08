using System;
using System.Drawing;

class MainClass
{
    //Converts char to int
    private static int CharToInt(char character) => (int)Char.GetNumericValue(character);

    //Converts the input format "(x,y)" to a Point object
    private static Point StringToPoint(string coords)
    {
        Point pointCoords = new Point(CharToInt(coords[1]), CharToInt(coords[3]));
        return pointCoords;
    }   

    private static Point[] StrArrToPointArr(string[] strArr)
    {
        Point[] pointArr = new Point[8];
        for (int i = 0; i < 8; i++)
        {
            pointArr[i] = StringToPoint(strArr[i]);
        }
        return pointArr;
    }

    private static string EightQueens(string[] strArr)
    {
        Point[] pointArr = StrArrToPointArr(strArr); 
        return "true";

    }

    static void Main()
    {
        string[] input = new string[] { "(2,1)", "(4,3)", "(6,3)", "(8,4)", "(3,4)", "(1,6)", "(7,7)", "(5,8)" };
        Console.WriteLine(EightQueens(input));
        Console.ReadLine();
    }

}