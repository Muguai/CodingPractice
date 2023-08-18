public class StartRoom : MazeRoom
{
    public StartRoom(int row, int column, int roomId) : base(row, column, roomId)
    {
        Description = "You are at the start of your adventure, what treasure and dangers might lie ahead of you?";
    }
}