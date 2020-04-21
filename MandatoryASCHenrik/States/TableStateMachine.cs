using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryASCHenrik.States
{
    class StateAction
    {
        public StatesTypes State { get; set; } // next state
        public StatesTypes Action { get; set; } // direction the snake should move

    }
    public class TableStateMachine:IState
    {
        // internal table as StateMachine
        private StateAction[,] _stateMachine;
        private StatesTypes _currentState;

        //public TableStateMachine()
        //{
        //    _currentState = StatesTypes.NORTH;

        //    // initialize table
        //    _stateMachine = new StateAction[4,3];
        //    _stateMachine[(int)StatesTypes.NORTH, (int)InputType.LEFT] = new StateAction() { State = StatesTypes.WEST, Action = StatesTypes.WEST };
        //    _stateMachine[(int)StatesTypes.NORTH, (int)InputType.RIGHT] = new StateAction() { State = StatesTypes.EAST, Action = StatesTypes.EAST };
        //    _stateMachine[(int)StatesTypes.NORTH, (int)InputType.FORWARD] = new StateAction() { State = StatesTypes.NORTH, Action = StatesTypes.NORTH };

        //    _stateMachine[(int)StatesTypes.EAST, (int)InputType.LEFT] = new StateAction() { State = StatesTypes.NORTH, Action = StatesTypes.NORTH };
        //    _stateMachine[(int)StatesTypes.EAST, (int)InputType.RIGHT] = new StateAction() { State = StatesTypes.SOUTH, Action = StatesTypes.SOUTH };
        //    _stateMachine[(int)StatesTypes.EAST, (int)InputType.FORWARD] = new StateAction() { State = StatesTypes.EAST, Action = StatesTypes.EAST };

        //    _stateMachine[(int)StatesTypes.WEST, (int)InputType.LEFT] = new StateAction() { State = StatesTypes.SOUTH, Action = StatesTypes.SOUTH };
        //    _stateMachine[(int)StatesTypes.WEST, (int)InputType.RIGHT] = new StateAction() { State = StatesTypes.NORTH, Action = StatesTypes.NORTH };
        //    _stateMachine[(int)StatesTypes.WEST, (int)InputType.FORWARD] = new StateAction() { State = StatesTypes.WEST, Action = StatesTypes.WEST };

        //    _stateMachine[(int)StatesTypes.SOUTH, (int)InputType.LEFT] = new StateAction() { State = StatesTypes.EAST, Action = StatesTypes.EAST };
        //    _stateMachine[(int)StatesTypes.SOUTH, (int)InputType.RIGHT] = new StateAction() { State = StatesTypes.WEST, Action = StatesTypes.WEST };
        //    _stateMachine[(int)StatesTypes.SOUTH, (int)InputType.FORWARD] = new StateAction() { State = StatesTypes.SOUTH, Action = StatesTypes.SOUTH };
        //}


        //public StatesTypes NextMove(InputType input)
        //{
        //    // Find next move from current state and input
        //    StatesTypes nextMove = _stateMachine[(int) _currentState, (int) input].Action;

        //    // Find next state from current state and input
        //    _currentState = _stateMachine[(int) _currentState, (int) input].State;
        //    return nextMove;
        //}
        public StatesTypes NextMove()
        {
            throw new NotImplementedException();
        }
    }
}
