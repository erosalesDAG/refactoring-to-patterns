using System.Collections.Generic;
using System.Linq;

namespace RefactoringToPatterns.CommandPattern
{
    public class MarsRover
    {
        public int _x;
        public int _y;
        public char _direction;
        public readonly string _availableDirections = "NESW";
        internal readonly string[] _obstacles;
        public bool _obstacleFound;
        private readonly RotateLeft rotateLeft;
        private readonly RotateRigth rotateRigth;
        private readonly MoveRoverTowards _moveRoverTowards;
        private readonly Dictionary<char, IMovementCommand> availableCommands = new Dictionary<char, IMovementCommand>();

        public MarsRover(int x, int y, char direction, string[] obstacles)
        {
            _x = x;
            _y = y;
            _direction = direction;
            _obstacles = obstacles;
            rotateLeft = new RotateLeft(this);
            rotateRigth = new RotateRigth(this);
            _moveRoverTowards = new MoveRoverTowards(this);
            availableCommands.Add('M', _moveRoverTowards);
            availableCommands.Add('R', rotateRigth);
            availableCommands.Add('L', rotateLeft);
        }

        public string GetState()
        {
            return !_obstacleFound ? $"{_x}:{_y}:{_direction}" : $"O:{_x}:{_y}:{_direction}";
        }

        public void Execute(string commands)
        {
            foreach (char command in commands)
            {
                availableCommands[command].Execute();
            }
        }
    }
}