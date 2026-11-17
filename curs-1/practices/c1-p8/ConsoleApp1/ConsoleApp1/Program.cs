

string SayHello()
{
    return "Привет, мир";
}

Console.WriteLine(SayHello());
Console.WriteLine(SayHello());
Console.WriteLine(SayHello());


string Greet(string name)
{
    return $"Привет,{name}";
}

Console.WriteLine(Greet("Ярослав"));
Console.WriteLine(Greet("Артем"));


string PrintPerson(string name, int age, string gorod)
{
    return $"Город: {gorod}, Возраст : {age}, Имя : {name} ";
   
}
Console.WriteLine(PrintPerson("Ярослав", 15, "Республика башкортостан"));



string PrintPerson1(string name, int age, string hobby = "Не указано")
{                                           
    return $" хобби : {hobby}, имя : {name}, возраст : {age} ";

}
Console.WriteLine(PrintPerson1("Ярослав", 15, "программирование"));
Console.WriteLine(PrintPerson1("Ярослав", 15 ));

int Square(int x)
{
    return x * x;
}

Console.WriteLine(Square(5));
Console.WriteLine(Square(10));


