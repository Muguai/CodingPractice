namespace MazeImplementation
{
    public static class Direction
    {
        public const char North = 'N';
        public const char South = 'S';
        public const char West = 'W';
        public const char East = 'E';

        public static char[] GetEveryDirection(){
            return new char[] {North, South, West, East};
        }
        
    }
}