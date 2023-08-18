namespace KataPractice;
public static class PhoneNumbers
{
    private static readonly Dictionary<string, int> letterToNumber = new(){
        {"ABC", 2 },
        { "DEF", 3 },
        { "GHI", 4 },
        { "JKL", 5 },
        { "MNO", 6  },
        { "PQRS", 7 },
        { "TUV" , 8 },
        { "WXYZ", 9 }
    };

    public static string Translate(string phoneNumber)
    {
        string result = string.Empty;

        foreach (char s in phoneNumber)
        {
            if (!IsEnglishLetter(s))
            {
                result += s;
                continue;
            }

            //Console.WriteLine((double)(Char.ToUpper(s) - 'A' + 3) / 3);
            //double calculate = Math.Ceiling((double)(Char.ToUpper(s) - 'A' + 3) / 3);
            //result += calculate;
            
            foreach (KeyValuePair<string, int> ltn in letterToNumber)
            {
                if (ltn.Key.Contains(s.ToString().ToUpper()))
                {
                    result += ltn.Value;
                    break;
                }
            }
         
        }

        return result;
    }


    private static bool IsEnglishLetter(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }
}