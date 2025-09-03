using System;

class PatternPrinter
{
    
    public static void SolidSquare(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    
    public static void RightAngledTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    
    public static void InvertedRightAngledTriangle(int height)
    {
        for (int i = height; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    
    public static void Diamond(int size)
    {
        
        for (int i = 1; i <= size; i++)
        {
            for (int s = 0; s < size - i; s++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

      
        for (int i = size - 1; i >= 1; i--)
        {
            for (int s = 0; s < size - i; s++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    
    public static void HollowSquare(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

   
    static void Main(string[] args)
    {
        Console.WriteLine("Solid Square:");
        SolidSquare(4);

        Console.WriteLine("\nRight-Angled Triangle:");
        RightAngledTriangle(5);

        Console.WriteLine("\nInverted Right-Angled Triangle:");
        InvertedRightAngledTriangle(5);

        Console.WriteLine("\nDiamond:");
        Diamond(3);

        Console.WriteLine("\nHollow Square:");
        HollowSquare(5);
    }
}