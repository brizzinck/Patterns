using FactoryMethod;

var messager = new TesttMessanger("Vlad", "123123");
messager.SendMessage("Hi, world!", "Vlad", "Maks");
Console.WriteLine("-------------------------------");
var twitter = new TwitterMessanger("Vlad", "123123");
twitter.CreatMessage("Hi, world", "Vlad", "Maks");
Console.ReadLine();