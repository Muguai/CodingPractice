using AtlasCopco.Integration.Maze;
using MazeImplementation;
public class TestMaze
{
   
    static void Main(string[] args)
    {
        MazeIntegration mazeGenerator = new MazeIntegration();
        mazeGenerator.BuildMaze(3);
        TraverseMaze(mazeGenerator);
    }

    private static void TraverseMaze(MazeIntegration mazeGenerator)
    {
        int currentRoomId = mazeGenerator.currentLocation.RoomId;
        bool endGame = mazeGenerator.CausesInjury(currentRoomId); 
        Console.WriteLine(mazeGenerator.GetDescription(currentRoomId));
        
        if(endGame == false)
            endGame = mazeGenerator.HasTreasure(currentRoomId);
        
        if(endGame)
            System.Environment.Exit(1);

        string path =  "There is a path in these directions:";
        foreach(KeyValuePair<char, MazeRoom> dir in mazeGenerator.currentLocation.Neighbors){
            path += " " + dir.Key;
        }
        Console.WriteLine(path);

        while(true){
            char input = Console.ReadKey().KeyChar;
            if(!Direction.GetEveryDirection().Contains(Char.ToUpper(input))){
                Console.WriteLine(Char.ToUpper(input) + " is not a valid direction");
                continue;
            }
                
            int? nextRoomId = mazeGenerator.GetRoom(currentRoomId, Char.ToUpper(input));

            if(nextRoomId == null){
                Console.WriteLine("You can't go that way!");
            }
            else{
                mazeGenerator.currentLocation = mazeGenerator._maze.RoomDictionary[(int)nextRoomId];
                TraverseMaze(mazeGenerator);
                break;
            }

        }
    }
}