using MyClassLibrary;



// Console.WriteLine(RecursionMy.SumFor(15));
// Console.WriteLine(RecursionMy.SumRec(15));

// Console.WriteLine(RecursionMy.FactorialFor(10));
// Console.WriteLine(RecursionMy.FactorialRec(10));

// Console.WriteLine(RecursionMy.PowerFor(10,5));
// Console.WriteLine(RecursionMy.PowerRec(10,5));
// Console.WriteLine(RecursionMy.PowerRecMath(10,5));

// Оно не работает как показано на лекции.
// int n = 1;
// void FindWords(string alphabet, char[] word, int lenght = 0)
// {
//     if (lenght == word.Length);
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }

//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[lenght] = alphabet[i];
//         FindWords(alphabet, word, lenght + 1);
//     }

// }

// FindWords("аисв", new char[4]);


// string path = "D:/";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);

// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }




void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}


// string path = "D:/";
// path = "C:/Users/User/Desktop/Introduction_to_programming_languages";
// CatalogInfo(path);



void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Towers(with, some, on, count - 1);
    // Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

// Towers();


string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                 0    1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}


// InOrderTraversal();



decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}


//# 1 2 3 4 5 6
//V 1 1 2 3 5 8 

// Console.ReadLine();


// DateTime dt = DateTime.Now;
// for (int n = 1; n < 138; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ### ###"), -15}");
//     fIte = 0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
//  dt = DateTime.Now;

// Console.WriteLine();
// // Console.ReadLine();

// DateTime dt = DateTime.Now;
// for (int n = 1; n < 138; n++)
// {
//     Console.Write($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fIRec = {fRec.ToString("### ### ### ###"), -15}   ");
//     fIte = 0;
//     Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
//     dt = DateTime.Now;
// }

/// <summary>
/// O(n^2) : TL;DR; don't use this
/// </summary>
/// <param name="n"></param>
/// <returns></returns>
decimal fcRec = 0;
decimal Caltulate(int n)
{
    fcRec++;
    if (n <= 2) return n;
    return Caltulate(n - 1) + Caltulate(n - 2);
}


// DateTime dt = DateTime.Now;
// for (int n = 1; n < 43; n++)
// {
//     Console.Write($"Caltulate({n}) = {Caltulate(n)} fcRec = {fcRec.ToString("### ### ### ###"), -15}   ");
//     fcRec = 0;
//     Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
//     dt = DateTime.Now;
// }



// void Rec(decimal n)
// {
//     if (n <= 6000)
//     {
//         Console.WriteLine(n);
//         Rec(n+1);
//     }
    
// }

// Rec(1);