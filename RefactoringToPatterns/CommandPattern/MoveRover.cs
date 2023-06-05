namespace RefactoringToPatterns.CommandPattern
{
    public class MoveRover 
    {
        private MarsRover _marsRover;

        public MoveRover(MarsRover marsRover)
        {
            _marsRover = marsRover;
        }

        public void Execute()
        {
            _marsRover.directions[_marsRover._direction].Move();
        }
    }
}