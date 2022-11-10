using ChainOfResponsibility;

Designer designer = new Designer();
Carpenters carpenters = new Carpenters();
FinishingWorker FinishingWorker = new FinishingWorker();

designer.SetNextWorker(carpenters).SetNextWorker(FinishingWorker);
Command.GiveCommand(designer, "Спроектировать дом");
Command.GiveCommand(designer, "Класть кирпич");
Command.GiveCommand(designer, "Клеить обои");

Command.GiveCommand(designer, "Провести проводку");