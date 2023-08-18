namespace KataPractice;
using System;

public class FreddyFriday{
    public static int Friday(int year){
        DateTime startDate = new DateTime(year, 1, 1);
        DateTime endDate = new DateTime(year, 12, 31);

        int total = 0;
        foreach (DateTime day in EachDay(startDate, endDate)){
            //Console.WriteLine("Foreach");
            if(day.Day == 13 && day.DayOfWeek == DayOfWeek.Friday){
                total += 1;
            }
        }
        return total;
    }
    public static int MaxFriday(int year){
        DateTime startDate = DateTime.Now;
        DateTime endDate = new DateTime(year, 12, 31);

        int total = 0;
        foreach (DateTime day in EachDay(startDate, endDate)){
            //Console.WriteLine("Foreach");
            if(day.Day == 13 && day.DayOfWeek == DayOfWeek.Friday){
                total += 1;
            }
        }
        return total;
    }

    public static IEnumerable<DateTime> EachDay(DateTime startDate, DateTime endDate)
    {
        for(DateTime day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1)){
            //Console.WriteLine("Ienumerable");
            yield return day;  
        }
    }
}