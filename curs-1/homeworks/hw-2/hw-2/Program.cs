int number = 10;
if (number < 0)
{
    Console.WriteLine("Число положительное");
}
else if  (number > 0)
{
    Console.WriteLine("Число отрицательное");
}


else if (number == 0)
{
    Console.WriteLine("Число равно нулю");
}

Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Введите свой возраст:");
string age = Console.ReadLine();
int intage = Convert.ToInt32(age);

if  (intage >= 18)
{
    Console.WriteLine("Вы совершеннолетний");
}
else if (intage < 18)
{
    Console.WriteLine("Вы несовершеннолетний");
}

Thread.Sleep(1000);
Console.Clear();

int num = 7;
if(num % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

Thread.Sleep(1000);
Console.Clear();

int a = 5;
int b = -2; 
if(a > 0 && b > 0)
{
    Console.WriteLine("Числа положительные");
}
else if (a > 0 || b > 0)
{
    Console.WriteLine("Хотя-бы одно число положительное");
}
if  (a < 0)
{
    Console.WriteLine("Число а отрицательное");
}

Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Введите свою оценку за четверть");
string grade = Console.ReadLine();
int intgrade = Convert.ToInt32(grade);

if (intgrade  < 3)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (intgrade == 3)
{
    Console.WriteLine("Удовлетворительно");  
}
else if (intgrade == 4)
{
    Console.WriteLine("Хорошо");
}
else if (intgrade == 5)
{
    Console.WriteLine("Отлично");
}

Thread.Sleep(1000);
Console.Clear();

Console.WriteLine("Я создал другой репозиторий потому что старый почему-то воспринимал новые папки как каталоги с какимито сабрепозиториями, не бейте:((");