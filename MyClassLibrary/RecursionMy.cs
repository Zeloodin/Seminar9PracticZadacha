namespace MyClassLibrary;

public class RecursionMy
{
    public static int SumFor(int n)
    {
        int result = 0;
        for (int i = 0; i <= n; i++) result += i;
        return result;
    }

    public static int SumRec(int n)
    {
        if (n == 0) return 0;
        else return n + SumRec(n - 1);
    }

    public static int FactorialFor(int n)
    {
        if (n == 0) return 1;
        int result = 1;
        for (int i = 1; i <= n; i++) result *= i;
        return result;
    }

    public static int FactorialRec(int n)
    {
        if (n == 0) return 1;
        if (n == 1) return 1;
        else return n * SumRec(n - 1);
    }


    public static int PowerFor(int a, int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++) result *= a;
        return result;
    }


    public static int PowerRec(int a, int n)
    {
        // return n == 0 ? 1 : PowerRec(a, n - 1) * a;
        if (n == 0) return 1;
        else return PowerRec(a, n - 1) * a;
    }

    public static int PowerRecMath(int a, int n)
    {
        if (n == 0) return 1;
        else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
        else return PowerRecMath(a, n - 1) * a;
    }

}
