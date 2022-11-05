using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ConveyorWorkCommand : ICommand
    {
        private Conveyor _conveyor;
        public ConveyorWorkCommand(Conveyor conveyor)
        {
            _conveyor = conveyor;
        }

        public void Negative() => _conveyor.Off();

        public void Positive() => _conveyor.On();
    }
}
