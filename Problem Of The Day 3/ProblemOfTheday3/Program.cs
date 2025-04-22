using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 2, 3, },
                {4, 5, 6, },
                {9, 8 ,9 }
            };
            int m = matrix.GetLength(0);
            int first = 0;
            int second = 0;
            
            for (int i = 0; i < m; i++)
            {
                first += matrix[i,i];
                second += matrix[i,m -i - 1];
            }
            int result =  first - second ;
            Console.WriteLine(Math.Abs(result));
        }
    }
}
