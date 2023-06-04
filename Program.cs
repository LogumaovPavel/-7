// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    for (int i = 0;  i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next (minValue , maxValue);
            array[i, j] = array[i, j] + Math.Round (new Random().NextDouble(), 1);
        }
    }
    return array;
}
void Print2DArray (double[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++ )
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
Console.Write("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Print2DArray(Create2DRandomArray(rows, colums, minValue, maxValue));

// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.NextDouble();
            Console.Write($"{randomArray[i,j]:F2} ");
        }
    Console.WriteLine();
    }
}
mas(m,n);
if (m2<1 || n2<1)
Console.Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
else Console.Write("Такого элемента нет в массиве");

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void array(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.Next(1,9);
            Console.Write($"{randomArray[i,j]} ");
        }
    Console.WriteLine();
    }
}
void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i,j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i,j];
        }
    Console.Write($"{sum/(i):F1}; ");
    }
}
array(m,n);
arif(m,n);



