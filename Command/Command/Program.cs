using Command;

Conveyor conveyor = new Conveyor();
Multipult multipult = new Multipult();
multipult.SetCommand(0, new ConveyorWorkCommand(conveyor));
multipult.SetCommand(1, new ConveyorAdjustCommand(conveyor));
multipult.PressOn(0);
multipult.PressOn(1);
multipult.PressCancel();
multipult.PressCancel();