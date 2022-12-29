// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

System.Console.WriteLine("Задайте размер массива:");
int x = InputNumber("Введите количество строк = ");
int y = InputNumber("Введите количество столбцов = ");
System.Console.WriteLine();
int[,] array = RandArray(x, y);
System.Console.WriteLine();
regularizeArray(array);
PrintArray(array);

int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}

int[,] RandArray(int x, int y)
{
    int[,] arr = new int[x, y];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = rand.Next(-10, 10);
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    return arr;
}

void regularizeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int index = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = index;
                }

            }
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}