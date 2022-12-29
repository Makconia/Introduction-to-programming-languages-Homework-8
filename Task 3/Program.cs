// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Задайте размер мартиц");
int m = InputNumber("Введите количество сторок первой матрицы: ");
int n = InputNumber("Введите количество столбцов первой матрицы (равную количеству строк второй матрицы): ");
int p = InputNumber("Введите количество столбцов второй матрицы: ");

System.Console.WriteLine("Первая матрица:");
int[,] matrix_1 = RandArray(m, n);
Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
int[,] matrix_2 = RandArray(n, p);
Console.WriteLine();

PrintArray(multiplyArray(matrix_1, matrix_2));


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


int[,] multiplyArray(int[,] arr1, int[,] arr2)
{
    int[,] newArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                newArr[i, j] += arr1[i, k] * arr2[k, j];
            }

        }
    }
    return newArr;
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine("Результат перемножения матриц: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
