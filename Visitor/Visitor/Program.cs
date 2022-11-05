using Visitor;

List<IPlace> places = new List<IPlace>() { new Zoo(), new Cinema(), new Circus()};
foreach (IPlace place in places)
{
    HolidayMaker visitor = new HolidayMaker();
    place.Accept(visitor);
    Console.WriteLine(visitor.Value);
}