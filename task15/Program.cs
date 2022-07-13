// на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int den = Convert.ToInt32(Console.ReadLine());

if (den >=1 && den <=5 )
{
  Console.WriteLine("Это не выходной день");
}

if (den == 6 || den == 7)
{
  Console.WriteLine("ВЫХОДНОЙ");
}

if (den <1 || den >7)
{
  Console.WriteLine("Нет такого дня недели");
}