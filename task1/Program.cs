/* Задача 54: Задайте двумерный массив. Напишите программу,
   которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int [,] tempArray = new int[m,n];
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

void PrintArray(int [,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortingArrayRowsZA(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        int tempNum = 0;
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = j+1; k < tempArray.GetLength(1); k++)
            {
                if(tempArray[i,j] < tempArray[i,k])
                {
                    tempNum = tempArray[i,j];
                    tempArray[i,j] = tempArray[i,k];
                    tempArray[i,k] = tempNum;
                }
            } 
        }
    }
    return tempArray;
}

int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
int[,] array = InitArray(m, n);
PrintArray(array);
Console.WriteLine();
int[,] resultArray = SortingArrayRowsZA(array);
PrintArray(resultArray);