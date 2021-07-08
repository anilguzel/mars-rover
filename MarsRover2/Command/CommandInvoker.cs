using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2.Command
{
    public class CommandInvoker : ICommandInvoker
    {
        readonly List<Command> commandList = new List<Command>();

        public void ExecuteAll()
        {
            commandList.ForEach(c => c.Execute());
        }

        public void AddCommand(Command c)
        {
            commandList.Add(c);
        }
    }
}
