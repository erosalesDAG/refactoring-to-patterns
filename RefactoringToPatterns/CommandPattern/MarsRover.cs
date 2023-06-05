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
        private readonly East east;
        private readonly South south;
        private readonly West west;
        private readonly North north;
        public readonly Dictionary<char, IDirectionCommand> directions = new Dictionary<char, IDirectionCommand>();
        private readonly RotateLeft rotateLeft;
        private readonly RotateRigth rotateRigth;
        private readonly MoveRover moveRover;

        public MarsRover(int x, int y, char direction, string[] obstacles)
        {
            _x = x;
            _y = y;
            _direction = direction;
            _obstacles = obstacles;
            east = new East(this);
            south = new South(this);
            west = new West(this);
            north = new North(this);
            directions.Add('E',east);
            directions.Add('S',south);
            directions.Add('W',west);
            directions.Add('N',north);
            rotateLeft = new RotateLeft(this);
            rotateRigth = new RotateRigth(this);
            moveRover = new MoveRover(this);
        }   
        
        public string GetState()
        {
            return !_obstacleFound ? $"{_x}:{_y}:{_direction}" : $"O:{_x}:{_y}:{_direction}";
        }

        public void Execute(string commands)
        {
            foreach(char command in commands)
            {
                if (command == 'M')
                {
                    moveRover.Execute();
                }
                else if(command == 'L')
                {
                    // get new direction
                    rotateLeft.Execute();
                } else if (command == 'R')
                {
                    rotateRigth.Execute();
                }
            }
        }
    }
}