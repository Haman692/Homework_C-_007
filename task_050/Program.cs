// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FindNumber(int[,] arr, int find)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] == find)
                System.Console.WriteLine($"The number is on [{i+1}, {j+1}]");            
        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("[" + arr[i, j] + "]");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

int EnterNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int desiredNumber = EnterNumber("Enter the desired number");
int columns = EnterNumber("Enter the number of columns");
int lines = EnterNumber("Enter the number of lines");
int[,] matrix = new int[columns, lines];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
FindNumber(matrix, desiredNumber);

