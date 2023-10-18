// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввдите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];
for(int i = 0; i < array.GetLength(0); i++)
{
  for(int j= 0; j < array.GetLength(1); j++)
  {
    array[i, j] = new Random().Next(9, 10);
  }
}

Console.WriteLine(array);

int sum = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
  for(int j= 0; j < array.GetLength(1); j++)
  {
    if(i == j)
    {
      sum += array[i, j];
    }
  }
}

Console.WriteLine(sum);





