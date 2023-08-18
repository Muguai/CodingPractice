public class DesertRoom : MazeRoom
{
    Random rd;

    public DesertRoom(int row, int column, int roomId) : base(row, column, roomId)
    {
        Description = "You are in a hot, sandy desert, with no shade in sight.";
        rd = new Random();
    }

    public override bool Visit()
    {
        if (rd.Next(100) < 20)
        {
            Description += " Suddenly, you feel very thirsty and weak! You pass out from dehydration. This is the end of your adventure";
            return true;
        }
        return false;
    }
}