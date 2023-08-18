public class MarshRoom : MazeRoom
{
    Random rd;
    public MarshRoom(int row, int column, int roomId) : base(row, column, roomId)
    {
        Description = "You are in a marshy area, with tall reeds and murky water.";
        rd = new Random();
    }

    public override bool Visit()
    {
        if (rd.Next(100) < 30)
        {
            Description += " Suddenly, you feel yourself sinking into the mud! You can't get out and your adventure ends here";
            return true; // player sinks and adventure ends
        }
        return false;
    }
}
