/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine()); ;
    return userNumber;
}

int[,,] InitArray(int x, int y, int z)
{
    int[,,] tempArray = new int[x, y, z];
    Random rnd = new Random();
    int st = rnd.Next(10,21);
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray.GetLength(2); k++)
            {
                tempArray[i, j, k] = st;
                st = st + rnd.Next(1,10);
            }            
        }
    }

    return tempArray;
}

void PrintArray(int[,,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray.GetLength(2); k++)
            {
                Console.Write($"{tempArray[i, j, k]}({i},{j},{k}) ");   
            }            
            Console.WriteLine();
        }        
    }
}


int x = GetNumber("Введите марность по x: ");
int y = GetNumber("Введите марность по y: ");
int z = GetNumber("Введите марность по z: ");
int[,,] array = InitArray(x, y, z);
PrintArray(array);