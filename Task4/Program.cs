
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
int digitlast = number % 10;
Console.Write(digitlast);
}
else
{
 Console.Write("Введите трехзначное число: ");   
}
