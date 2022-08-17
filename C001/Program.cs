// Двумерный массив. Меняет первую и последнюю строку местами.
Console.Write("Кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во строк столбцы: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// 4 параметра:
/// m - кол=во строк, n - кол-во столбцов
/// minRandom, maxRandom
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
int[,] result = new int[m, n];
for (int i = 0; i < result.GetLength(0); i++) // GetLength(0) - по строчкам(GetLength(0) = m)
{
for (int j = 0; j < n; j++) // GetLength(1) = n
{
result[i, j] = new Random().Next(minRandom, maxRandom + 1); //
}
}
return result;
}
// matrix - табличка m на n - двумерный массив
void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int k = 0; k < matrix.GetLength(1); k++)
{
Console.Write(matrix[i, k] + "\t" );
}
Console.WriteLine();
}
}

void ChangeRows(int [,] inputMatrix)
{
int indexLastRow = inputMatrix.GetLength(0) - 1; // Номер = индекс в массиве
for (int i = 0; i < inputMatrix.GetLength(1); i++)
{
int temp = inputMatrix[0,i];
inputMatrix[0,i] = inputMatrix[indexLastRow,i];
inputMatrix[indexLastRow,i] = temp;
}
}

int [,] resultMatrix = GetArray(rows, columns,0,10);
// resultMatrix[rows,columns], элементы от 0 до 10 рандомно
PrintArray(resultMatrix);
System.Console.WriteLine("Результат:");
ChangeRows(resultMatrix);
PrintArray(resultMatrix);