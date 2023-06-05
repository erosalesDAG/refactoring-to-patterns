using System.Linq;

namespace RefactoringToPatterns.CommandPattern
{
    public class South
    {
        private MarsRover _marsRover;

        public South(MarsRover marsRover)
        {
            _marsRover = marsRover;
        }

        public void MoveToSouth()
        {
            _marsRover._obstacleFound = _marsRover._obstacles.Contains($"{_marsRover._x}:{_marsRover._y + 1}");
            // check if rover reached plateau limit or found an obstacle
            _marsRover._y = _marsRover._y < 9 && !_marsRover._obstacleFound ? _marsRover._y += 1 : _marsRover._y;
        }
    }
}