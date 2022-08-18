// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите 2 числа: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int min = num1;
int max = num1;

if(min < num2)
{
    min = num2;
} 
else
{
max = num2;
}

Console.WriteLine(" max = " + max);
Console.WriteLine(" min = " + min);