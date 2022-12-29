// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
System.Console.WriteLine("Сгенерируйте прямоугольный массив");
int y = InputNumber("Для этого задайте количество столбцов (количество строк будет х2) = ");
int x = y * 2;
int[,] array = RandArray(x, y);
System.Console.WriteLine();
int[] ArrSumRow = sumRow(array, x);
System.Console.WriteLine();
minSumRow(ArrSumRow);
 
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
            arr[i, j] = rand.Next(0, 11);
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    return arr;
}
 
int[] sumRow(int[,] arr, int row)
{
    int[] sum = new int[row];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
        System.Console.WriteLine($"Сумма элементов строки {i + 1} = {sum[i]}");
    }
    return sum;
}
 
void minSumRow(int[] array)
{
    int min = array[0];
    int index = -1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] <= min)
        {
        min = array[i];
        index = i;
        }
    }
    System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {index + 1} строка");
}