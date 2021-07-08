using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2.Command
{
    public class MoveCommand : Command
    {
        public override void Execute()
        {
            if (State.direction == "N")
            {
                State.coordinateY++;
            }
            else if (State.direction == "E")
            {
                State.coordinateX++;
            }
            else if (State.direction == "S")
            {
                State.coordinateY--;
            }
            else if (State.direction == "W")
            {
                State.coordinateX--;
            }
            else Console.WriteLine("Wrong Command");
        }
    }
}
