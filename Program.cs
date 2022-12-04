Console.Clear();
Console.WriteLine("Введите натуральное число N: ");
int number = int.Parse (Console.ReadLine());
string str = number.ToString();
if (str.Reverse().SequenceEqual(str))
{
Console.WriteLine("Введенное число является палиндромом");
}
else 
{
Console.WriteLine("Введенное число не является палиндромом");
}
