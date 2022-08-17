// Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

int rows = 3;

int columns = 3;

int[,] matrix = new int[rows, columns];

int minElement = int.MaxValue; // само число
int indexRows = 0; // номер строчки минимального элемента
int indexColumns = 0; // номер столбца минимального элемента

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int m = 0; m < matrix.GetLength(1); m++)
{
matrix[i, m] = new Random().Next(11); // [0; 10]
Console.Write(matrix[i, m] + "\t");
if (minElement > matrix[i, m]) // 5 > 0; min =0
{
minElement = matrix[i, m];
indexRows = i;
indexColumns = m;
}
}
Console.WriteLine();
}
Console.WriteLine($"Минимум: {minElement} => Строчка: {indexRows} => Столбец: {indexColumns}");
for (int i = 0; i < rows; i++)
{
    if(i != minIndexRows)
    {
        for (int j = 0; j < columns; j++)
        {
            if( != minIndexColumns)
            {
                System.Console.WriteLine(matrix[i,j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

