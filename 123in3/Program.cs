Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100)
if (n < 1000)
{
int n1 = n % 10; // 586=58
Console.WriteLine($"Число: {n1}");
}

if (n < 100)
{
    Console.WriteLine("третьей цифры нет");
}

if (n >= 1000)
if (n < 100000)
{
int n1 = n / 100 % 10; 
Console.WriteLine($"Число: {n1}");
}
