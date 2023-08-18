
public class TreasureRoom : MazeRoom
{
    public TreasureRoom(int row, int column, int roomId) : base(row, column, roomId)
    {
        Description = "You have found the treasure! Congratulations!";
    }
}