using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryASCHenrik.States
{
    public class StateMachinePattern:IState
    {
        //TODO Why do I suck at statemachines?

        // internal StateMachine as pattern i.e. objects
        private IStateMachinePattern _currentState;

        public StateMachinePattern()
        {
            //_currentState = new StateMachinePatternNorth();
        }

        public StatesTypes NextMove()
        {
            // Find next move from current state and input
            StatesTypes nextMove = _currentState.NextAction();

            // Find next state from current state and input
            _currentState = _currentState.NextState();

            return nextMove;
        }
    }
}
