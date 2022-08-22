Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);

int Sum = 0;

for(int i = 0; i < num.Length; i++)
{
       Sum = Sum + num[i] - '0';
}
Console.Write("Сумма: " + Sum);
