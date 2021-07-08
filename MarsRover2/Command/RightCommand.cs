using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2.Command
{
    public class RightCommand : Command
    {
        public override void Execute()
        {
            if (State.direction == "N")
            {
                State.direction = "E";
            }
            else if (State.direction == "E")
            {
                State.direction = "S";
            }
            else if (State.direction == "S")
            {
                State.direction = "W";
            }
            else if (State.direction == "W")
            {
                State.direction = "N";
            }
            else Console.WriteLine("Wrong Command");
        }
    }
}
