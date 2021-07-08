using MarsRover2.Command;
using NUnit.Framework;
using Xunit;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRover2.Test
{
    public class Tests
    {
        [Fact]
        public async Task Scenario_1()
        {
            // Arrange
            State.coordinateX = 1;
            State.coordinateY = 2;
            State.direction = "N";
            CommandInvoker invoker = new CommandInvoker();
            var commandString = "LMLMLMLMM";
            var commandList = commandString.ToCharArray();

            // Act
            foreach (var command in commandList)
            {
                invoker.AddCommand(CommandFactory.GetCommand(command.ToString()));
            }
            invoker.ExecuteAll();

            // Assert
            Xunit.Assert.Equal(1, State.coordinateX);
            Xunit.Assert.Equal(3, State.coordinateY);
            Xunit.Assert.Equal("N", State.direction);
        }

        [Fact]
        public async Task Scenario_2()
        {
            // Arrange
            State.coordinateX = 3;
            State.coordinateY = 3;
            State.direction = "E";
            CommandInvoker invoker = new CommandInvoker();
            var commandString = "MMRMMRMRRM";
            var commandList = commandString.ToCharArray();

            // Act
            foreach (var command in commandList)
            {
                invoker.AddCommand(CommandFactory.GetCommand(command.ToString()));
            }
            invoker.ExecuteAll();

            // Assert
            Xunit.Assert.Equal(5, State.coordinateX);
            Xunit.Assert.Equal(1, State.coordinateY);
            Xunit.Assert.Equal("E", State.direction);
        }
    }
}