using MazeImplementation;
public class VerySimpleMaze : Maze
{
    private List<Type> roomTypes = new List<Type> { typeof(ForestRoom), typeof(MarshRoom), typeof(DesertRoom), typeof(HillsRoom), typeof(TreasureRoom) };

    public VerySimpleMaze(int rows, int columns) : base(rows, columns)
    {
        int counter = 0;
        Random rd = new Random();

        for (int i = 0; i < Rows; i++) {
            for (int j = 0; j < Columns; j++) {
                
                var roomType = roomTypes[rd.Next(roomTypes.Count)];
                if(counter == (Rows * Columns) - 1){
                    if(roomTypes.Contains(typeof(TreasureRoom)))
                        roomType = typeof(TreasureRoom);
                }
                var room = (MazeRoom)Activator.CreateInstance(roomType, i, j, counter);
                
                if(roomType == typeof(TreasureRoom))
                    roomTypes.Remove(roomType);

                Console.WriteLine("Generate Room with type of " + room.GetType());
                Rooms[i, j] = room;
                RoomDictionary.Add(counter, Rooms[i, j]);
                counter++;
            }
        }
    }
}