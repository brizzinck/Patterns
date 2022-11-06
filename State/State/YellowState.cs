using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace State
{
    public class YellowState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Из желтого в красный");
            trafficLight.SetState(new RedState());
        }

        public override void PreviousState()
        {
            Console.WriteLine("Из желтого в зеленый");
            trafficLight.SetState(new GreenState());
        }
    }
}
