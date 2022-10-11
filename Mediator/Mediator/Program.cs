using Mediator;

Designer designer = new Designer();
Director director = new Director();
Controller controller = new Controller(designer, director);
director.GiveCommand("Проектировать");
Console.WriteLine();
designer.ExecuteWork();