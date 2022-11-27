/* Задача 56: Задайте прямоугольный двумерный массив. 
   Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine()); ;
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int[,] tempArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 10);
        }
    }

    return tempArray;
}

void PrintArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetArrayRowsSumms(int[,] tempArray)
{
    int[] arrayRowsSumms = new int[tempArray.GetLength(1)];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            arrayRowsSumms[j] = arrayRowsSumms[j] + tempArray[i, j];
        }
    }
    return arrayRowsSumms;
}

int GetMinimalArrayRowsSumm(int[] summs)
{
    int minimalSumm = summs[0];
    int minimalSummIndex = 1;
    for (int i = 1; i < summs.Length; i++)
    {
        if (minimalSumm < summs[i]) minimalSummIndex = i + 1;
    }
    return minimalSummIndex;
}

int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
int[,] array = InitArray(m, n);
PrintArray(array);
Console.WriteLine();
int[] summs = GetArrayRowsSumms(array);
Console.WriteLine($"Сумма элементов {GetMinimalArrayRowsSumm(summs)} строки минимальная");