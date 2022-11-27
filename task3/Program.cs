/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] MatrixMultiplication(int[,] mA, int[,] mB)
{
    int mMultRow;
    int mMultCoumn;
    int[,] tempA;
    int[,] tempB;
    if(mA.GetLength(1) == mB.GetLength(0))
    {
        tempA = mA;
        tempB = mB;
        mMultRow = mA.GetLength(0);
        mMultCoumn = mB.GetLength(1);
        
    }
    else
    {
        tempA = mB;
        tempB = mA;
        mMultRow = mB.GetLength(0);
        mMultCoumn = mA.GetLength(1);  
    }
    int[,] mMult = new int[mMultRow, mMultCoumn];
    for (int i = 0; i < mMult.GetLength(0); i++)
    {
        for (int j = 0; j < mMult.GetLength(1); j++)
        {
            for (int k = 0; k < tempA.GetLength(1); k++)
            {
                mMult[i,j] =  mMult[i,j] + tempA[i,k]*tempB[k,j];
            }
        }
    }
    return mMult;
}


int firstMatrixRows = GetNumber("Введите число строк 1 матрицы: ");
int firstMatrixColumns = GetNumber("Введите число столбцов  1 матрицы: ");
int secondMatrixRows = GetNumber("Введите число строк 2 матрицы: ");
int secondMatrixColumns = GetNumber("Введите число столбцов  2 матрицы: ");

if (firstMatrixRows == secondMatrixColumns || firstMatrixColumns == secondMatrixRows)
{
    int[,] firstMatrix = InitArray(firstMatrixRows, firstMatrixColumns);
    int[,] secondMatrix = InitArray(secondMatrixRows, secondMatrixColumns);
    PrintArray(firstMatrix);
    Console.WriteLine();
    PrintArray(secondMatrix);
    Console.WriteLine();
    int[,] matrixMult = MatrixMultiplication(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение матриц");
    PrintArray(matrixMult);
}
else
    Console.WriteLine("Матрицы не согласованные - их произведения не существует");