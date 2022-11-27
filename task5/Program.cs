/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
   Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine()); ;
    return userNumber;
}

int[,] InitArray(int m)
{
    int[,] tempArray = new int[m, m];
    int k = 1;
    int shift = 0;
       while ((m / 2) - shift >= 0)
    {
        for (int i = (0 + shift); i < tempArray.GetLength(1) - shift; i++)
        {
            tempArray[shift, i] = k;
            k++;
        }
        for (int i = (0 + shift) + 1; i < tempArray.GetLength(0) - shift; i++)
        {
            tempArray[i, tempArray.GetLength(1) - shift - 1] = k;
            k++;
        }
        for (int i = tempArray.GetLength(1) - shift-2; i > shift-1; i--)
        {
            tempArray[tempArray.GetLength(0) - shift -1, i] = k;
            k++;
        }
        for (int i = tempArray.GetLength(1) - shift-2; i > shift; i--)
        {
            tempArray[i, tempArray.GetLength(0) - (tempArray.GetLength(0)-shift)] = k;
            k++;
        }
        shift++;
    }

    return tempArray;
}

void PrintArray(int[,] tempArray)
{
    string format = string.Empty;
    string k = (tempArray.GetLength(0) * tempArray.GetLength(1)).ToString();
    for (int i = 0; i < k.Length; i++)
    {
        format = format + "0";
    }
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i, j].ToString(format)} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите размерность квадратной матрицы: ");
int[,] array = InitArray(m);
PrintArray(array);
