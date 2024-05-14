int[,] CreateMatrix(int rowCount, int columscount)
{
 int[,] matrix = new int[rowCount, columscount];
 Random rnd = new Random();
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {

         matrix[i, j] = rnd.Next(1, 1000);
     }
 }
 return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach(int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sumOfDidits = SumOfDigits(value);
    if(sumOfDidits % 2 == 0)
    {
        return true;
    }
    return false;
}

int SumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value/= 10;
    }
    return sum;
}

