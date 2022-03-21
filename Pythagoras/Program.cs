Console.WriteLine("Insert A value");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("\nInsert B value");
double b = double.Parse(Console.ReadLine());

double cpow = Math.Pow(a, 2) + Math.Pow(b, 2);

double c = Math.Round(Math.Sqrt(cpow),2);

Console.WriteLine("\nC = {0}", c);


if (a > b)
{
    Console.WriteLine("a is bigger than b");
}
else if (a < b)
{
    Console.WriteLine("\nb is bigger than a");
}

Console.ReadKey();


