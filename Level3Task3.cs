using System.Collections.Generic;
using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the lenght of matrix side: ");
        int n = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the second matrix size: ");
        //int m = Convert.ToInt32(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();
        var A = new List<int>();
        var B = new List<int>();
        var C = new List<int>();
        var mas = new List<int>();
        int sum = 0;
        string s = "0";
        int[] str = new int[n];
        int b=0;
        int v1 = 0, v2 = 0;
        int k = 0;
        int x;
        int t = 0;
        Console.WriteLine("Enter the matrix: ");
        for (int i = 0; i < n ; i++)
        {
            matrix.Add(new List<int>());
            string[] line = Console.ReadLine().Split(" ");
            for (int j = 0; j < n; j++)
            {
                matrix[i].Add(Convert.ToInt32(line[j]));
            }
        }
        for (int i = n-1; i > 0; i--)
        {   
            for (int j = 0; j <= k; j++)
            {
                sum = sum + matrix[i+j][j];
            }
            k++;
            A.Add(sum);
            sum = 0;
        }
        k = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j <= k; j++)
            {
                sum = sum + matrix[j][i+j];
            }
            k++;
            B.Add(sum);
            sum = 0;
        }
        B.Reverse();
        for (int i=0; i<B.Count(); i++)
        {
            A.Add(B[i]);
        }
        Console.WriteLine("Sums of diagonals: ");
        for (int i=0; i<A.Count(); i++)
        {
            Console.Write(A[i] + " ");
        }

        /*Console.WriteLine("New matrix: ");
        for (int i = 0; i < matrix.Count(); i++)
        {
            for (int j = 0; j < matrix[0].Count(); j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }*/
        return 0;
    }
}