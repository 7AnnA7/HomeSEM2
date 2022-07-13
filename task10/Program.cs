// demo vtoraya zifra chisla abc
Console.WriteLine("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 100 && N <= 999)
{
Console.WriteLine($"Вторая цифра этого числа {(N/10)%10} ");
}
else
{
    Console.WriteLine("Введённое Вами число не совсем трёхзначное");
}