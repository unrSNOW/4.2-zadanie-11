int[,] matrix = 
    {
            { 3, 7, 2 },
            { 8, 5, 1 },
            { 4, 6, 9 }
     };

int row= matrix.GetLength(0);
int col = matrix.GetLength(1);

int[] min = new int[row];
for (int i = 0; i < row; i++)
{
    int minValue = int.MaxValue;
    for (int j = 0; j < col; j++)
    {
        if (matrix[i, j] < minValue)
        {
            minValue = matrix[i, j];
        }
    }
    min[i] = minValue;
}
int maxIndex = 0;
for (int i = 0; i < row; i++)
{
    if (min[i] > min[maxIndex])
    {
        maxIndex = i;
    }
}
Console.WriteLine($"Индексы элемента с найденным значением: ({maxIndex})");

