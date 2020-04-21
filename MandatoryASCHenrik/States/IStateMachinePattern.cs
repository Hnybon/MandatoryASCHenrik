using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryASCHenrik.States
{
    public interface IStateMachinePattern
    {
        IStateMachinePattern NextState();
        StatesTypes NextAction();

    }
}
