using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2.Command
{
    public class LeftCommand : Command
    {
        public override void Execute()
        {
            if (State.direction == "N")
            {
                State.direction = "W";
            }
            else if (State.direction == "E")
            {
                State.direction = "N";
            }
            else if (State.direction == "S")
            {
                State.direction = "E";
            }
            else if (State.direction == "W")
            {
                State.direction = "S";
            }
            else Console.WriteLine("Wrong Command");
        }
    }
}
