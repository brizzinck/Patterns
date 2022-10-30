using Observer;

var directory = @"D:\C#\Patterns\Observer\File";
var fileStatusDelegate = new FileStatusDelegate(directory, new Subsciber(String.Empty).ItIsSubscriber);
Console.ReadKey();