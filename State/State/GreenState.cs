using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GreenState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Из зеленого в желтый");
            trafficLight.SetState(new YellowState());
        }

        public override void PreviousState()
        {
            Console.WriteLine("Зеленый цвет");
        }
    }
}
