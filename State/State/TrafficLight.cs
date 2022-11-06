using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TrafficLight
    {
        private State _state;
        public TrafficLight(State state) => SetState(state);
        public void SetState(State state)
        {
            _state = state;
            _state.TrafficLight = this;
        }
        public void NextState()
        {
            _state.NextState();
        }
        public void PreviousState()
        {
            _state.PreviousState();
        }
    }
}
