// Двумерный массив. Меняет строки на столбцы.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

if (rows != columns)
{
Console.WriteLine("В данной матрице нельзя заменить элементы!");
return;
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));

int[,] GetArray(int m, int n, int min, int max)
{
int[,] result = new int[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().Next(min, max + 1);
}

}
return result;
}

int[,] ChangeArray(int[,] array)
{
int[,] result = new int[array.GetLength(0), array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
result[j, i] = array[i, j];
}
}
return result;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} ");
}
Console. WriteLine();
}
}