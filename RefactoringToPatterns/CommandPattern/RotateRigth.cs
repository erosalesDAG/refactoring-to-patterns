namespace RefactoringToPatterns.CommandPattern
{
    public class RotateRigth
    {
        private MarsRover _marsRover;

        public RotateRigth(MarsRover marsRover)
        {
            _marsRover = marsRover;
        }

        public void Execute()
        {
            // get new direction
            var currentDirectionPosition = _marsRover._availableDirections.IndexOf(_marsRover._direction);
            if (currentDirectionPosition != 3)
            {
                _marsRover._direction = _marsRover._availableDirections[currentDirectionPosition + 1];
            }
            else
            {
                _marsRover._direction = _marsRover._availableDirections[0];
            }
        }
    }
}