Console.WriteLine("rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max = ");
int max = Convert.ToInt32(Console.ReadLine()); //вводим данные


var A_B = CreatingArray(rows, columns, min, max); //создаем массив

WriteArray(A_B);
var sum = RowsSummary(A_B);
Console.WriteLine($"Строка с наименьшей суммой - " + Array.IndexOf(sum, sum.Min()));   
int[] RowsSummary(int[,] array)
{
    var sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}

int[,] CreatingArray(int rows, int columns, int min, int max)
{
    var array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}