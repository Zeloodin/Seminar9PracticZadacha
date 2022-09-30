// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// 
// m = 2, n = 3 -> A(m,n) = 9
// 
// m = 3, n = 2 -> A(m,n) = 29
using MyClassLibrary;

Console.Write("Введите целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());



long AckermannFunction(long m, long n)
{
    // if (m == 0) n++;
    // if (m > 0 && n == 0) AckermannFunction(m - 1, n);
    // if (m > 0 && n > 0) AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    // return m;

    // if (m < 0 || n < 0) throw new ArgumentOutOfRangeException();
    // if (m == 0) return n = n + 1;
    // if (n == 0) return AckermannFunction(m - 1, n);
    // return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

    // if (n == 0) return m + 1;
    // else if (n != 0 && m == 0) return AckermannFunction(n - 1, 1);
    // else return AckermannFunction(n - 1, AckermannFunction(n, m - 1));



    
    restart:
        if (m == 0)
            return  n+1;
        if (n == 0)
        {
            m--;
            n = 1;
            goto restart;
        }
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

}




Console.WriteLine(AckermannFunction(m, n));