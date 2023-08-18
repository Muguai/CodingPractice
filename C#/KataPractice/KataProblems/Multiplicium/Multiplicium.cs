namespace KataPractice;
public static class Multiplicium
{
    public static int Reducto(params int[] numbers)
    {
        int sum = numbers.Sum(x => x);
        int[] result = sum.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

        int prod = 1;

        do
        {
            prod = 1;
            foreach (int value in result)
            {
                prod *= value;
            }
            result = prod.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

        } while (prod > 9);

        return prod;
    }

    public static int Reducto2(params int[] numbers)
    {
        int sum = numbers.Sum(x => x);

        int prod = 1;

        do
        {
            prod = 1;
            for (int i = 0; i < sum.ToString().Length - 1; i++)
            {
                prod = Convert.ToInt32(sum.ToString()[i + 1] - 48) * Convert.ToInt32((int)sum.ToString()[i] - 48);
            }
            sum = prod;

        } while (prod > 9);

        return prod;
    }

    public static int Reducto3(params int[] numbers)
    {
        Console.WriteLine("Testing");
        foreach (int value in numbers)
        {

            Console.Write(value + " ");
        }
        Console.WriteLine(" ");

        if ( numbers.Length == 1 && numbers[0].ToString().Length == 1)
        {
            return numbers[0];
        }

        int sum = numbers.Sum(x => x);
        int[] result = sum.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        int prod = 1;

        do
        {
            for (int i = 0; i < sum.ToString().Length - 1; i++)
            {
                prod = (int)(sum % Math.Pow(10, i + 1)  * Math.Floor((sum % Math.Pow(10, i + 2)) / Math.Pow(10, i + 1)));
                Console.WriteLine("CHECK");
                Console.WriteLine("THIS IS SUM > " + sum + " " + sum % Math.Pow(10, i + 1) + " VS " + ((sum % Math.Pow(10, i + 2)) / Math.Pow(10, i + 1)));
            }
            sum = prod;

        } while (prod > 9);

        //Console.WriteLine("Answer");
        return prod;
    }
}