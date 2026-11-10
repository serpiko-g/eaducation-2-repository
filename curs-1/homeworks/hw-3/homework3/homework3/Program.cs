Console.WriteLine("Введите температуру в градусах цельсия:");
int v = Convert.ToInt32(Console.ReadLine());
int v2 = v * 9 / 5 + 32;
Console.Write("Температура по шкале фаренгейта:");
Console.Write(v2);

Thread.Sleep(1000);
Console.Clear();

Console.WriteLine("Введите свои числа, каждое по очереди");
int a = Convert.ToInt32(Console.ReadLine());
int b  = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
float d = (a + b + c) / 3;
Console.WriteLine("Среднее арифметическое ваших чисел:");
Console.Write(d);

Thread.Sleep(1000);
Console.Clear();

while (true)
{
    Console.WriteLine("Введите ваши числа");
    int g = Convert.ToInt32(Console.ReadLine());
    int h = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Выберите действие");
    Console.WriteLine("+");
    Console.WriteLine("/");
    Console.WriteLine("*");
    Console.WriteLine("-");
    string znak = Console.ReadLine();
    if (znak == "+")
    {
        int r = g + h;
        Console.WriteLine("Результат =");
        Console.WriteLine(r);
    }
    else if (znak == "-")
    {
        int r1 = g - h;
        Console.WriteLine("Результат =");
        Console.WriteLine(r1);
    }
    else if (znak == "*")
    {
        int r2 = g * h;
        Console.WriteLine("Результат =");
        Console.WriteLine(r2);
    }
    else if (znak == "/")
    {
       float r3 = g / h;
        Console.WriteLine("Результат =");
        Console.WriteLine(r3);
    }

    Console.WriteLine("Если хотите завершить ваше пребывание в калькуляторе то введите число 1, если хотите продолжить то введите любое другое число, или букву:");
    string r4 = Console.ReadLine();

    if (r4 == "1")
    {
        break;  
    }
    else
    {
        Thread.Sleep(1000);
        Console.Clear();
     continue;  
    }
}