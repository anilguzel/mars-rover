using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2.Command
{
    public interface ICommandInvoker
    {
        void ExecuteAll();

        void AddCommand(Command c);
    }
}
