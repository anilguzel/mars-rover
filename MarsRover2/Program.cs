using MarsRover2.Command;
using System;
using System.Collections.Generic;

namespace MarsRover2
{

    class Program
    {
        static void Main(string[] args)
        {
        RunRoverRun:
            var positions = Console.ReadLine().Split(' ');
            State.coordinateX = int.Parse(positions[0]);
            State.coordinateY = int.Parse(positions[1]);
            State.direction = positions[2];

            var commands = Console.ReadLine().ToCharArray();

            var invoker = new CommandInvoker();

            foreach (var command in commands)
            {
                invoker.AddCommand(CommandFactory.GetCommand(command.ToString()));
            }

            invoker.ExecuteAll();

            Console.WriteLine($"{State.coordinateX} {State.coordinateY} {State.direction}");

            goto RunRoverRun;
        }
    }
}
