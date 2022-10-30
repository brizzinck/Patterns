using ObserverEvent;

var directory = @"D:\C#\Patterns\Observer\File";
var eventObserver = new FileStatusEvent(directory);
var subscriber1 = new Subscriber(String.Empty);
var subscriber2 = new Subscriber("Second");

eventObserver.RemoveFiles += subscriber1.ItIsSubscriber;
eventObserver.RemoveFiles += subscriber2.ItISecondSubscriber;

Console.ReadKey();
Console.WriteLine("--- Remove second subscriber ---");
eventObserver.RemoveFiles -= subscriber2.ItISecondSubscriber;
Console.ReadKey();
