/*  Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] getOrderedArray(int[,] incomingArray)
{
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(1) - 1; k++)
            {
                if (incomingArray[i, k] < incomingArray[i, k + 1])
                {
                    int temp = incomingArray[i, k + 1];
                    incomingArray[i, k + 1] = incomingArray[i, k];
                    incomingArray[i, k] = temp;
                }
            }
            
        }
    }
    return incomingArray;
}

int[,] generateArray = generate2DArray(3, 4, 1, 9);
print2DArray(generateArray);
Console.WriteLine();
int[,] orderedArray = getOrderedArray(generateArray);
print2DArray(orderedArray);
