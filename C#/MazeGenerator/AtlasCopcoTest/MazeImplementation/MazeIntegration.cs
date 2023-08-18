using System;
using System.Linq;
using AtlasCopco.Integration.Maze;
using MazeImplementation;
public class MazeIntegration : IMazeIntegration
{
    public Maze _maze {get; set;}
    public MazeRoom currentLocation {get; set;}
    public void BuildMaze(int size)
    {
        _maze = new VerySimpleMaze(size, size);
        GenerateStartRoom();

        Stack<MazeRoom> mazeStack = new Stack<MazeRoom>();
        mazeStack.Push(_maze.RoomDictionary[_maze.StartRoomId]);
        
        while(mazeStack.Count() > 0){
            MazeRoom current = mazeStack.Pop();

            Console.WriteLine("Add Neighbors to Room #: " + current.RoomId);

            foreach(char d in Direction.GetEveryDirection()){
                MazeRoom adjacentRoom = _maze.GetAdjacentRoom(current, d);

                if(adjacentRoom != null){
                    current.Neighbors.Add(d, adjacentRoom);
                    if(adjacentRoom.IsGenerated == false && !mazeStack.Contains(adjacentRoom))
                        mazeStack.Push(adjacentRoom);
                }

            }

            current.IsGenerated = true;
            
        }
        
        currentLocation = _maze.RoomDictionary[GetEntranceRoom()];
    }

    private void GenerateStartRoom(){
        // Get a random start room at the edge of the maze
        int startX, startY;
        int rows = _maze.Rows;
        int columns = _maze.Columns;
        Random random = new Random();
        int edge = random.Next(4);
        switch (edge)
        {
            case 0: // left edge
                startX = 0;
                startY = random.Next(1, columns - 1);
                break;
            case 1: // top edge
                startX = random.Next(1, rows - 1);
                startY = 0;
                break;
            case 2: // right edge
                startX = rows - 1;
                startY = random.Next(1, columns - 1);
                break;
            case 3: // bottom edge
                startX = random.Next(1, rows - 1);
                startY = columns - 1;
                break;
            default:
                throw new InvalidOperationException("Invalid edge value.");
        }
        if(_maze.Rooms[startX, startY].GetType() == typeof(TreasureRoom)){
            Console.WriteLine("Start Room cant be Treasure room");         
            GenerateStartRoom();
            return;
        }

        _maze.Rooms[startX, startY] = (MazeRoom)Activator.CreateInstance(typeof(StartRoom), startX, startY, _maze.Rooms[startX, startY].RoomId);
        
        _maze.StartRoomId = _maze.Rooms[startX, startY].RoomId;
        _maze.RoomDictionary[_maze.StartRoomId] = _maze.Rooms[startX, startY];
        
        Console.WriteLine("Generate Start Room at X: " + startX + " Y: " + startY);
    }

    public bool CausesInjury(int roomId)
    {
        return _maze.RoomDictionary[roomId].Visit();
    }

    public string GetDescription(int roomId)
    {
        if(_maze.RoomDictionary.ContainsKey(roomId))
            return _maze.RoomDictionary[roomId].Description;
        else
            return "No room found";
    }

    public int GetEntranceRoom()
    {
        return _maze.StartRoomId;
    }

    public int? GetRoom(int roomId, char direction)
    {
        MazeRoom room = _maze.GetAdjacentRoom(_maze.RoomDictionary[roomId], direction);
        if(room != null)
            return room.RoomId;
        else
            return null;
    }

    public bool HasTreasure(int roomId)
    {
        return _maze.RoomDictionary[roomId].GetType() == typeof(TreasureRoom);
    }
}
