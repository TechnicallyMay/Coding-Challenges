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

    //Converts original input to array of points
    private static Point[] StrArrToPointArr(string[] strArr)
    {
        Point[] pointArr = new Point[8];
        for (int i = 0; i < 8; i++)
        {
            pointArr[i] = StringToPoint(strArr[i]);
        }
        return pointArr;
    }

    //Checks if one queen can attack another (does not check diagonal movement
    //because not possible to attack diagonally without also being able to attack
    //laterally
    private static bool CheckAttack(Point point, Point other)
    {
        if (point.X == other.X || point.Y == other.Y)
        {
            return true;
        }
        return false;
    }

    private static string EightQueens(string[] strArr)
    {
        Point[] pointArr = StrArrToPointArr(strArr);
        foreach (Point point in pointArr)
        {
            foreach (Point other in pointArr)
            {
                if (point != other)
                {
                    if (CheckAttack(point, other))
                    {
                        string coords = $"{point.X},{point.Y}";
                        return coords;
                    }
                }
            }
        }
        return "true";
    }

    static void Main()
    {
        string[] failing = new string[] {"(2,1)", "(4,3)", "(6,3)", "(8,4)", "(3,4)", "(1,6)", "(7,7)", "(5,8)"};
        string[] passing = new string[] {"(2,1)", "(4,2)", "(6,3)", "(8,4)", "(3,5)", "(1,6)", "(7,7)", "(5,8)"};
        Console.WriteLine(EightQueens(failing));
        Console.ReadLine();
    }
}