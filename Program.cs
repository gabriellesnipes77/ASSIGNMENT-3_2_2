namespace ASSIGNMENT_3_2_2
{
     class MatrixAddition
    {
        static void Main(string[] args)
        {
            int size;

            Console.Write("Enter the size of the square matrix(less than 5): ");
            size = Convert.ToInt32(Console.ReadLine());

            if (size >= 5)
            {
                Console.WriteLine("The size must be less than 5.");
                return;
            }

            int[,] matrix1 = new int[size,size];
            int[,] matrix2 = new int[size,size];
            int[,] resultMatrix = new int[size,size];

            Console.WriteLine("\nEnter elements for the first matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter elements for the second matrix:");
            for (int i = 0;i < size; i++)
            {
                for (int j = 0;j < size; j++)
                {
                    Console.Write($"element - [{i}],[{j}] :");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe First matrix is:");
            for (int i = 0; ; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix1[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe Second matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix2[i, j] + " ");

                }
                Console.WriteLine();
            }

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("\nThe result of adding the two matrices is:");
            for (int i = 0;i < size; i++)
            {
                for(int j = 0;j < size; j++)
                {
                    Console.WriteLine(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        
    }
}
