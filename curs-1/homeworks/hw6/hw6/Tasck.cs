

/// задание 3 
var player1 = new Player("Artem", 15);
var player2 = new Player("Oleg", 20);
Console.WriteLine(player1.PrintInfo());
Console.WriteLine(player2.PrintInfo());
Console.WriteLine(player1 == player2);

Console.WriteLine(player1.Equals(player2));


Thread.Sleep(2000);
Console.Clear();

/// задание 4
var user1 = new User();
user1.Pasword = "12543";
Console.WriteLine(user1.CheckPassword("12543"));
var user2 = new User();
user2.Pasword = "";

Thread.Sleep(2000);
Console.Clear();

//  задание 5

var p1 = new Point(4, 5);

var p2 = p1;

p2.Move(5, 7);

Console.WriteLine(p1.StringPoint();
