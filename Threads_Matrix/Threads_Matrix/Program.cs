using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            Test test = new Test();
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];
            int row_begin = 0;
            int row_amount = n / 16;

            Random rnd = new Random();


            for (int i = 0; i < n; i++) //nadajemy wartosci macierzom
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = rnd.Next(10,100);
                    matrix2[i, j] = rnd.Next(10,100);
                }
            }

            //Console.Write("Macierz A:\n"); //wypisujemy macierz A

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Macierz B:\n"); //wypisujemy macierz B

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("\n\n");


////////////////////////// WATKI ///////////////////////////////////////////
            int[,] matrix_final = new int[n, n];
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int j = 0; j < 5; j++)
            {
                Thread[] threads = new Thread[7];

                for (int i = 0; i < 7; i++) {
                    threads[ i] = new Thread(new ParameterizedThreadStart(Test.multiplyRow));

                    //threads[i].Start(new object[5] { matrix1, matrix2, n, i, matrix_final });
                    //threads[i].Join();
                }
                for (int i = 0; i < 7; i++)
                {
                    threads[i].Start(new object[5] { matrix1, matrix2, n, i, matrix_final });
                }
                for (int i = 0; i < 7; i++)
                {
                    threads[i].Join();
                }


            }

            watch.Stop();
            var elapsedMs = watch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Czas z watkami:    "+elapsedMs + " ms");


////////////////////// SEKWENCYJNIE /////////////////////////////////////
            int[,] matrix_final2 = new int[n, n];
            var watch2 = System.Diagnostics.Stopwatch.StartNew();

            for (int j=0;j<5;j++)
                test.multiplyAll(matrix1, matrix2, n, matrix_final2);

            watch2.Stop();
            var elapsedMs2 = watch2.Elapsed.TotalMilliseconds;

            //Console.WriteLine("Czas z watkami: " + elapsedMs + " ms");

            Console.WriteLine("Czas sekwencyjnie: "+elapsedMs2 + " ms");


            if (elapsedMs < elapsedMs2)
                Console.WriteLine("Watki szybciej!!!");
            if (elapsedMs > elapsedMs2)
                Console.WriteLine("Sekwencyjnie szybciej!!!");
            //for(int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix_final[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix_final2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            Console.Read();
        }
    }


    public class Test
    {   
        //private readonly object matrixLock = new object();

        static public void multiplyRow(object args)
        {
            Array argArray = new object[5];
            argArray = (Array)args;

            int[,] matrix1 = (int[,])argArray.GetValue(0);
            int[,] matrix2 = (int[,])argArray.GetValue(1);
            int n = (int)argArray.GetValue(2);
            int row = (int)argArray.GetValue(3);
            int[,] matrix_final = (int[,])argArray.GetValue(4);
            int row_amount =n / 7;//rozmiar na ilosc watkow

            for (int i = row*row_amount; i < row*row_amount+row_amount; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix_final[i,j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        matrix_final[i,j] += matrix1[i,k] * matrix2[k,j];

                    }

                }
            }
            //Console.WriteLine();

            //lock (matrixLock)
            //{
            //    for(int i=0;i<n;i++)
            //        Console.Write(matrix_final[row, i] + "\t");
            //}
            //Console.WriteLine();

        }

        
        public void multiplyAll(int[,] matrix1, int[,] matrix2, int n, int[,] matrix_final)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix_final[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        matrix_final[i, j] += matrix1[i, k] * matrix2[k, j];
                    }

                }
            }
        }
        
    }
}