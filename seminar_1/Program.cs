Console.Clear();

// 1. На вход число на ывход его квадрат.

Console.Write("Ввведите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int sqrt = Convert.ToInt32(Math.Pow(num, 2));

Console.WriteLine("Число в квадрате " + sqrt);

