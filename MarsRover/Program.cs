using System;

namespace MarsRover
{
    class Program
    {
        public static int coordinateX = 0;
        public static int coordinateY = 0;
        public static string direction = "N";

        static void Main(string[] args)
        {
        RunRoverRun:
            var positions = Console.ReadLine().Split(' ');
            coordinateX = int.Parse(positions[0]);
            coordinateY = int.Parse(positions[1]);
            direction = positions[2];

            var commands = Console.ReadLine().ToCharArray();

            foreach (var command in commands)
            {
                MarsRoverCommander(command.ToString());
            }

            Console.WriteLine($"{coordinateX} {coordinateY} {direction}");

            goto RunRoverRun;
        }

        private static void MarsRoverCommander(string command)
        {
            switch (command)
            {
                case "L":
                    LeftCommand();
                    break;
                case "M":
                    MoveCommand();
                    break;
                case "R":
                    RightCommand();
                    break;
                default:
                    break;
            }
        }

        private static void RightCommand()
        {
            if (direction == "N")
            {
                direction = "E";
            }
            else if (direction == "E")
            {
                direction = "S";
            }
            else if (direction == "S")
            {
                direction = "W";
            }
            else if (direction == "W")
            {
                direction = "N";
            }
            else Console.WriteLine("Wrong Command");
        }

        private static void MoveCommand()
        {
            if (direction == "N")
            {
                coordinateY++;
            }
            else if (direction == "E")
            {
                coordinateX++;
            }
            else if (direction == "S")
            {
                coordinateY--;
            }
            else if (direction == "W")
            {
                coordinateX--;
            }
            else Console.WriteLine("Wrong Command");
        }

        private static void LeftCommand()
        {
            if (direction == "N")
            {
                direction = "W";
            }
            else if (direction == "E")
            {
                direction = "N";
            }
            else if (direction == "S")
            {
                direction = "E";
            }
            else if (direction == "W")
            {
                direction = "S";
            }
            else Console.WriteLine("Wrong Command");
        }
    }
}
