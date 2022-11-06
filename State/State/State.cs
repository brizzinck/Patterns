using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class State
    {
        protected TrafficLight trafficLight;
        public TrafficLight TrafficLight { set => trafficLight = value; }
        public abstract void NextState();
        public abstract void PreviousState();
    }
}
