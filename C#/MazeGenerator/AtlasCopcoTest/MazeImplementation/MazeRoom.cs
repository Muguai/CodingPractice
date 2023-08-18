public abstract class MazeRoom {
    public int Row { get; }
    public int Column { get; }
    public int RoomId { get; }
    public bool IsGenerated { get; set; }
    public string Description { get; set; }
    
    public Dictionary<char, MazeRoom> Neighbors { get; }

    public MazeRoom(int row, int column, int roomId) {
        Row = row;
        Column = column;
        RoomId = roomId;
        IsGenerated = false;
        Neighbors = new Dictionary<char, MazeRoom>();
    }

    public virtual bool Visit()
    {
        return false;
    }
}