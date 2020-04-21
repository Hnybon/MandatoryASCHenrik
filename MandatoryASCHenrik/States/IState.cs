using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryASCHenrik.States
{
    public enum StatesTypes
    {
        NORTH,
        EAST,
        WEST,
        SOUTH
    };

    public interface IState
    {
        StatesTypes NextMove();
    }
}
