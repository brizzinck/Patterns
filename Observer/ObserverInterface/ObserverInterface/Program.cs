using ObserverInterface;

var directory = @"D:\C#\Patterns\Observer\File";
var provider = new FileStatusEventObservable(directory);
var observer = new Observer();

observer.Subscribe(provider);
Console.ReadKey();
