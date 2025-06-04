namespace HW_7_2;

internal class Program
{
    static void Main(string[] args)
    {
        var matrix = new int[3, 3];
        Random rand = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(1, 100);
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var max = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
            Console.Write("Maximum: " + max);
            Console.WriteLine();
        }
    }
}
