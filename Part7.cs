float num1, num2;
char opr;
Console.Write("Enter your First Number : ");
num1 = float.Parse(Console.ReadLine());
Console.Write("Enter your Secend Number : ");
num2 = float.Parse(Console.ReadLine());
Console.Write("Choise your operation from *,/,+,- : ");
opr =char.Parse(Console.ReadLine());
if (opr=='*')
{
  Console.WriteLine("Result is {0}", num1 * num2);
}
else if (opr == '/')
{
  Console.WriteLine("Result is {0}", num1 / num2);
}
else if (opr == '+')
{
  Console.WriteLine("Result is {0}", num1 + num2);
}
else if (opr == '-')
{
  Console.WriteLine("Result is {0}", num1 - num2);
}
Console.ReadKey();
