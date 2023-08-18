namespace KataPractice;
public class PhoneNumbersTwo
{
    private static readonly Dictionary<char, string> convertdict = new(){
        { '0', "*+" },
        { '1', ".,!?" },
        { '2', "ABC" },
        { '3', "DEF"},
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
    };

    public static string Translate(string text)
    {
        string result = string.Empty;
        char tempLetter = '*';
        char lastChar = '-';
        int index = 0;

        foreach (char s in text)
        {
            string letters = convertdict[s];

            if (s != lastChar)
            {
                result += tempLetter;
                index = 0;
                tempLetter = letters[index];
                lastChar = s;
            }
            else
            {
                index++;
                tempLetter = letters[index];
            }
        }
        
        result += tempLetter;

        return result.Replace('+',' ').Replace("*", "");
    }
}