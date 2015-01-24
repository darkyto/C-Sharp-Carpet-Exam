using System;


/*
 * Input
 * 
 * The input data should be read from the console.
 * You have an integer number N (always even number) showing the width and the height of the most outer rhomb. 
 * The width and the height will always be equal.
 * The input data will always be valid and in the format described. There is no need to check it explicitly.
 * 
 * Output
 * he output should be printed on the console.
 * Use the “/” and “\” characters to print the rhomb sides and “.” (dot) for the rest. 
 * You should print exactly one space between each rhomb.

 * Example
input 6	
 * 
output
 * 
	../\..
    ./  \.
    / /\ \
    \ \/ /
    .\  /.
    ..\/..
Example input	Example output

 */

class Carpets
{
    static void Main(string[] args)
    {
        //input
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {

                bool isInQuadrantOne = col < size/2 && row < size/2;        // top-left
                bool isInQuadrantTwo = col >= size/2 && row < size/2;       // top-right
                bool isInQuadrantThree = col < size/2 && row >= size/2;     // bottom-left
                bool isInQuadrantFour = col >= size/2 && row >= size/2;     //bottom-right

                bool isCoreOne = row + col - size/2 +1 >= 0;                // top-left
                bool isCoreTwo = row - col + size/2  <= 0;                  // top-right
                bool isCoreThree = col - row + size/2 <= 0;                 // bottom-left
                bool isCoreFour = row + col - 3* size/2  +1 >= 0;           // bottom-right

                if ((isInQuadrantOne))   //isCoreOne && isCoreFour && 
                {
                    if (((row + col - size / 2 + 1) % 2 == 0) && (row + col - size/2 >= -1))
                    {
                        Console.Write('/');
    
                    }
                    else 
                    {
                        Console.Write('.');
                    }
                }
                else if (isInQuadrantFour)
                {
                    if (((row + col - size / 2 + 1) % 2 == 0) && (row + col - size <= size/2))
                    {
                        Console.Write('/');
    
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                else if (isInQuadrantTwo) // 
                {
                    if ((row - col + size / 2) % 2 == 0 && (col <= (row + size / 2)))
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                else if (isInQuadrantThree) // 
                {
                    if ( (row - col + size / 2) % 2 == 0  &&  (row <= (col+ size/2)  )  )
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                else
                {
                    Console.Write('.');
                }

                
            }
            Console.WriteLine();
        }
    }
}

