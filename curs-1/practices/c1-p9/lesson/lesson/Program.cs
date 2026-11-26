class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное:{Name}");
    }

    public void Eat()
    {
        Console.WriteLine("Животное ест.");
    }

    public virtual void Speak()
    {
        Console.WriteLine("Животное издает звук");
    }
    public virtual void Move()
    {
        Console.WriteLine("Животное двигается");
    }
}



class Dog
    : Animal
{
    public Dog(string name) : base(name) 
    {
        Console.WriteLine($"Создана собачка по имени:{Name}");
    }
    public void Brak()
    {
        Console.WriteLine("Собака лает");
    }
    public override void Speak()
    {
        Console.WriteLine("Собака говорит: Гав-гав!");
    }
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Собака бежит по дороге");

    }

}

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Кошка мяукает.");
        }
        public override void Speak()
        {
            Console.WriteLine("Кошка говорит: Мяу!");
        }

    public Cat(string name) : base(name)
    {
        Console.WriteLine($"Создана кошечка с именем: {Name}");
    }    
    }

class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт движется");
    }

}

class Car : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }

}

class ElictricCar : Car
{
    public override void Drive()
    {
        Console.WriteLine("Электромобиль тихо едет на батарее");
    }
}