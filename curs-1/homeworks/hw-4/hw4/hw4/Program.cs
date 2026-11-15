

// задание 1
using System.Reflection.Metadata.Ecma335;

short[] grades = [2, 3, 2, 4, 5, 2, 4];
var c = 0;
var b = 0;
var resalt = 0;

foreach(short x in  grades)
{
    

    if (x == 2)
    {
        c++;
    }
    if (x == 5)
    {
        b++;
    }

    resalt = x * 7 / 7;
}

Console.WriteLine("Количество пятерок:");
Console.WriteLine(b);
Console.WriteLine("Количество двоек:");
Console.WriteLine(c);
Console.WriteLine("Среднее арифметическое оценок:");
Console.WriteLine(resalt);

Thread.Sleep(1000);
Console.Clear();



// задание 2
short[] list = [1, 4, 5, 32, 756];
foreach (short g in list)
{
    Console.Write(g + " ");

}
Console.WriteLine();


var i = 1;
while (i <= list.Length) 
{
    int index = list.Length - i;
    Console.Write(list[index] + " ");
    i++;
    if (i > list.Length)
    {
        break;
    }
}

Thread.Sleep(3000);
Console.Clear();

// задание 3 вариант решения 1 

for (int j = 0; j % 2 == 0; j += 2)
{
    Console.Write(j + " ");


    if (j == 20)
    {
        break;
    }
}

// задание 3 вариант решения 2 (через continue)


Thread.Sleep(3000);
Console.Clear();


var o = 1;
while (o <= 20) 
{
    

    if (o % 2 != 0)
    {
        o++;
        continue;
    }

    Console.Write(o + " ");
    o++;

    
    
}

Thread.Sleep(3000);
Console.Clear();

// задание 4 
var Truepassword = "1234";
var y = 0;
while (y < 3) 
{
    Console.WriteLine("Введите пароль:");
    var userpassword = Console.ReadLine();
    if (userpassword != Truepassword)
    {
        y++;
    }
    if (y == 3)
    {
        Console.WriteLine("Доступ запрещен");
    }
   

    if (userpassword == Truepassword) 
    {
        Console.WriteLine("Доступ разрешен");
        break ;
    }
    


}













