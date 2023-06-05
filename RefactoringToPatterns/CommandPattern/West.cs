using System.Linq;

namespace RefactoringToPatterns.CommandPattern
{
    public class West
    {
        private readonly MarsRover _marsRover;

        public West(MarsRover marsRover)
        {
            _marsRover = marsRover;
        }

        public void MoveToWest()
        {
            _marsRover._obstacleFound = _marsRover._obstacles.Contains($"{_marsRover._x - 1}:{_marsRover._y}");
            // check if rover reached plateau limit or found an obstacle
            _marsRover._x = _marsRover._x > 0 && !_marsRover._obstacleFound ? _marsRover._x -= 1 : _marsRover._x;
        }
    }
}