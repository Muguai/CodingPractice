namespace KataPractice;
/*
Write a function that calculates overtime and pay associated with overtime.

 Working 9 to 5: regular hours 
 After 5pm is overtime 
Your function gets an array with 4 values: 
 Start of working day, in decimal format, (24 -hour day notation) 
 End of working day. (Same format) 
 Hourly rate 
 Overtime multiplier 
Your function should spit out: 
 $  + earned that day (rounded to the nearest hundredth) 

Examples 
OverTime([9, 17, 30, 1.5]) ➞ "$240.00" 
 
OverTime([16, 18, 30, 1.8]) ➞ "$84.00" 
 
OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50" 
 
2nd example explained: 
 From 16 to 17 is regular, so  1 * 30  = 30 
 From 17 to 18 is overtime, so  1 * 30 * 1.8  = 54 
 30 + 54  = $84.00 
*/
public class WorkingNineToFive
{
    public static string OverTime(double[] money)
    {
        //Init Values
        double start = money[0];
        double end = money[1];
        double hourlyRate = money[2];
        double overTimeMultipler = money[3];

        //Check for overtime
        double overTimeWork = 9 - start > 0 ? 9 - start : 0;
        overTimeWork += end - 17 > 0 ? end - 17 : 0;

        //Calculate wage
        double workTime = end - start - overTimeWork + (overTimeWork * overTimeMultipler);
        return "$" + (workTime * hourlyRate);
    }
}