using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class RedState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Красный цвет");
        }

        public override void PreviousState()
        {
            Console.WriteLine("Из красного в желтый цвет");
            trafficLight.SetState(new YellowState());
        }
    }
}
