
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Schema;
// задание 1





while (true)
        {

            var math = new MyMath();

            
            Console.WriteLine("Введите выражение(или exit): ");
           var  a = Console.ReadLine();
           if (a == "exit")
          {
             break;
          }

           var w = Convert.ToInt32(a);
           var b = Console.ReadLine();
           var c = Convert.ToInt32(Console.ReadLine());
           if (b == "+")
         {
        Console.WriteLine(math.Add(w, c));
         }
          else if (b == "-")
         {
        Console.WriteLine(math.Subtract(w, c));

         }
          else if (b == "*")
        {
        Console.WriteLine(math.Multiply(w, c));

        }

         else if (b == "/")
         {
        Console.WriteLine(math.Divide(w,c));
          }
        }

Thread.Sleep(3000);
Console.Clear();


// задание 2, вс студио ругается что я делаю второе задание прям под классом я не знаю почему
var phone = new Phone{ Models= "Laifon"};
phone.Charge(150);
Console.WriteLine($"Заряд батареи:{phone.battarey}%");
phone.Use(50);
Console.WriteLine($"Вы израсходовали свой заряд и теперь он равен:{phone.battarey}%");
phone.Charge(40);
Console.WriteLine($" Вы подзарядили телефон. Текущий Заряд батареи:{phone.battarey}%");


public class MyMath
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;

    }
    public double Divide(int x, int y)
    {
        return x / y;
    }
    public int Multiply(int x, int y)
    {
        return (x * y);
    }


}




public class Phone
{
    public string Models="";
    public int battarey = 0;
    public int Charge(int amnout)
    {
        if (battarey + amnout <= 100)

            return battarey += amnout;
        else
            return battarey = 100;

        
        
    }

    public int Use(int amnout)
    {
        if (battarey >= amnout)
        {
            return battarey -= amnout;

        }
        else
           return  battarey = 0;
    }
}


