using Iterator;

DataStack myStack1 = new DataStack();
for (int i = 0; i < 5; i++)
    myStack1.Push(i);
DataStack myStack2 = new DataStack(myStack1);
Console.WriteLine(myStack1 == myStack2);
myStack2.Push(10);
Console.WriteLine(myStack1 == myStack2);    