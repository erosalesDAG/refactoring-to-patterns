using System.Collections.Generic;

namespace RefactoringToPatterns.CommandPattern
{
    public class MoveRoverTowards : IMovementCommand
    {
        private readonly MarsRover _marsRover;
        private readonly Dictionary<char, IDirectionCommand> directions = new Dictionary<char, IDirectionCommand>();

        public MoveRoverTowards(MarsRover marsRover)
        {
            _marsRover = marsRover;
            directions.Add('E', new East(_marsRover));
            directions.Add('S', new South(_marsRover));
            directions.Add('W', new West(_marsRover));
            directions.Add('N', new North(_marsRover));
        }

        public void Execute()
        {
            directions[_marsRover._direction].Move();
        }
    }
}