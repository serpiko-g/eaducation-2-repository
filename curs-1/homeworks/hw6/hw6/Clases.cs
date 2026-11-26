

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml;

class Player
{
    public string name = ""; 
    public int level;

    public  Player(string name, int level)
    {
        this.name = name;
        this.level = level;
    }


    public string PrintInfo()
    {
        return $"Имя игрока:{name}\n" +
            $"Уровень игрока:{level}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is Player player)
            return this.name == player.name && this.level == player.level;
        else return false;
    }


}


public class User
{
    private string pasword;
    public string Pasword
    {
        get => pasword;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                pasword = value;
                
                Console.WriteLine("Пароль обновлен");
                Console.WriteLine(pasword);
            }
            else Console.WriteLine("Пароль не может быть пустым");

        }
    }

        public bool CheckPassword(string input)
    {
        return Pasword == input;
    }
 }
    



public class Point
{
    public int x;
    public int y;
    public Point (int x, int y)
    {
        this.x = x; 
        this.y = y;
    }

    public string StringPoint()
    {
        return $"координата x:{x}\n" +
              $"координата y:{y}";

    }


    public void Move(int dx, int dy)  
    {
        x += dx;
        y += dy;
    }
}



