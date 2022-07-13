// thurd zifra chisla libo net tret`ei zifri
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 100)
{
 Console.WriteLine("Cообщаю, что третьей цифры в Вашем числе нет");
}

while (N>=1000)
{
  N=N/10;
}

if (N >= 100 && N <= 999)
{
 Console.WriteLine($"Третья цифра этого числа {N%10}");
}