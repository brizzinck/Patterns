using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ConveyorAdjustCommand : ICommand
    {
        private Conveyor _conveyor;
        public ConveyorAdjustCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }

        public void Negative() => _conveyor.SpeedDecrease();

        public void Positive() => _conveyor.SpeedIncrease();
    }
}
