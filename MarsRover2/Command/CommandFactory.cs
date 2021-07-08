using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2.Command
{
    public static class CommandFactory
    {
        public static Command GetCommand(string command)
        {
            switch (command)
            {
                case "L":
                    return new LeftCommand();
                case "M":
                    return new MoveCommand();
                case "R":
                    return new RightCommand();
                default:
                    throw new Exception();
            }
        }
    }
}
