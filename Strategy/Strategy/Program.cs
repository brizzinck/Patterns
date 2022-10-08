using Strategy;
using Strategy.Strategies;

Hero hero = new("Vlad");
hero.Attack();
hero.SetWepon(new Sword());
hero.Attack();
hero.SetWepon(new WaterGun());
hero.Attack();
Console.ReadLine();