internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 64: Задайте значения M и N. Напишите программу, 
        //которая выведет все натуральные числа в промежутке от M до N, кратные трём.
        //M = 1; N = 5. -> ""1, 2, 3, 4, 5""
        //M = 4; N = 8. -> ""4, 6, 7, 8""

        void zadacha64()
        {
            Console.WriteLine("Введите минимальное число");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное число");
            int M = Convert.ToInt32(Console.ReadLine());
            Recursion(N, M);
            Console.WriteLine();

            void Recursion(int N, int M)
            {
                
                if (N > M) return;
                else if (N%3==0) Console.Write(N+ " ");
                N++;
                Recursion(N, M);
            }


        }


        //Задача 66: Задайте значения M и N. 
        //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        //M = 1; N = 15 -> 120
        //M = 4; N = 8. -> 30

        void zadacha66()
        {
            Console.WriteLine("Введите минимальное число");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное число");
            int M = Convert.ToInt32(Console.ReadLine());
            Recursion(N, M);
            Console.WriteLine();

            void Recursion(int N, int M, int sum=0)
            {
                if (N > M) 
                {
                    Console.Write($"сумма чисел равна: {sum}"); 
                    return;
                }
                sum += N;
                N++;
                Recursion(N, M, sum);
            }
        }

        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        //Даны два неотрицательных числа m и n.
        //m = 3, n = 2 -> A(m,n) = 29




        void zadacha68()
        {
            Console.Write("Введите число m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            A(m, n);
            view(args, m, n);

            int A(int m, int n)
            {
                if (m == 0) return n + 1;
                if (n == 0) return A(m - 1, n);
                return A(m - 1, A(m, n - 1));
            }

            void view(string[] args, int m, int n)
            {
                Console.WriteLine(A(m, n));
            }

        }

        
        //zadacha64();
        //zadacha66();
        zadacha68();
    }
}