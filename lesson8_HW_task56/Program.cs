/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int getMinSumLine(int[,] incomingArray)
{
    int row = 0;
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        int sum = 0;
        int minSum = 0;

        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            sum = sum + incomingArray[i, j];
            minSum = minSum + incomingArray[0, j];

        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}

int[,] generateArray = generate2DArray(3, 4, 1, 9);
print2DArray(generateArray);
int minSumLine = getMinSumLine(generateArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumLine}");
