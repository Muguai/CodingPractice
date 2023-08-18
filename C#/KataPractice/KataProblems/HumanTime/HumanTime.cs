public static class HumanTime{

    public static string GetReadableTime(int time){
        int hours = time / 3600;
        int minutes = (time % 3600) / 60;
        int seconds = ((time % 3600) % 60) % 60;
        string result = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
        return result; 
    }
}