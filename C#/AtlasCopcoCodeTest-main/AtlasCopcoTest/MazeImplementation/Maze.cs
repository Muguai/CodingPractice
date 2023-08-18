namespace MazeImplementation
{
    public class Maze {
        public int Rows { get; }
        public int Columns { get; }
        public int StartRoomId { get; set;}
        public MazeRoom[,] Rooms { get; }
        public Dictionary<int, MazeRoom> RoomDictionary { get; }

        public Maze(int rows, int columns) {
            Rows = rows;
            Columns = columns;
            Rooms = new MazeRoom[rows, columns];
            RoomDictionary = new Dictionary<int, MazeRoom>();
        }

        public virtual MazeRoom GetAdjacentRoom(MazeRoom room, char direction)
        {
            int adjacentRow = room.Row;
            int adjacentColumn = room.Column;

            switch (direction)
            {
                case Direction.North:
                    adjacentRow--;
                    break;
                case Direction.South:
                    adjacentRow++;
                    break;
                case Direction.West:
                    adjacentColumn--;
                    break;
                case Direction.East:
                    adjacentColumn++;
                    break;
                default:
                    throw new ArgumentException("Invalid direction.");
            }

        
            // Check if the adjacent room is out of bounds
            if (adjacentRow < 0 || adjacentRow >= Rows || adjacentColumn < 0 || adjacentColumn >= Columns)
                return null;
            

            return Rooms[adjacentRow, adjacentColumn];
        }
    }
}