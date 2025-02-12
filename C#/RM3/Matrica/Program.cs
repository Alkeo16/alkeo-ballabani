using System;

namespace App
{
    class Program
    {

        static void Shuma_Mesatarja(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                double average = (double)sum / matrix.GetLength(1);
                Console.WriteLine("Student " + (i + 1) + " - Shuma: " + sum + ", Mesatarja: " + average);
            }
        }

        static void Gjetja_Notes(int[,] matrix, int nota_per_tu_gjet)
        {
            bool found = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == nota_per_tu_gjet)
                    {
                        Console.WriteLine("Nota " + nota_per_tu_gjet + " gjendet te studenti " + (i + 1) + ", lenda " + (j + 1));
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Nota " + nota_per_tu_gjet + " nuk gjendet.");
            }
        }

        static int[,] Matrixa_Modifikuar(int[,] matrix, double koeficenti)
        {
            int[,] second_matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    second_matrix[i, j] = (int)(matrix[i, j] * koeficenti);
                }
            }
            return second_matrix;
        }

        static void Max_Min_Matrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int maxScore = matrix[i, 0];
                int minScore = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxScore)
                        maxScore = matrix[i, j];
                    if (matrix[i, j] < minScore)
                        minScore = matrix[i, j];
                }
                Console.WriteLine("Student " + (i + 1) + "- Nota me e madhe: " + maxScore + ", Nota me e vogel: " + minScore);
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 3];

            Console.WriteLine("Miresevini ne menaxhimin e rezulateve te studenteve !");
            Console.WriteLine("Fusni rezultatin per secilin student dhe secilen lende:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Studenti " + (i + 1) + ", lenda " + (j + 1) + ": ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matrica fillestare");
            PrintMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("Shuma dhe mesatarja per cdo student:");
            Shuma_Mesatarja(matrix);

            Console.WriteLine();
            Console.Write("Vendos noten qe kerkoni te gjeni: ");
            int nota_per_tu_gjet = Convert.ToInt32(Console.ReadLine());
            Gjetja_Notes(matrix, nota_per_tu_gjet);

            Console.WriteLine();
            Console.Write("Vendosni koeficentin qe doni te shumzoni matricen: ");
            double koeficenti = Convert.ToDouble(Console.ReadLine());
            int[,] multipliedMatrix = Matrixa_Modifikuar(matrix, koeficenti);
            Console.WriteLine("Matrica e re pas ndyshimit:");
            PrintMatrix(multipliedMatrix);

            Console.WriteLine();
            Console.WriteLine("Nota me e madhe dhe me e vogel per secilin student:");
            Max_Min_Matrix(matrix);
        }
    }
}