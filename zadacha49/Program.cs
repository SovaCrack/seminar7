// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
Console.Write("введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввдите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
    array[i, j] = new Random().Next(-9,10);
   } 
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
PrintArr(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0) ; j++)
    {
       if((i % 2 == 1) && (j % 2 == 1))
       {
        array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
       } 
    }
    
}
Console.WriteLine();
PrintArr(array);