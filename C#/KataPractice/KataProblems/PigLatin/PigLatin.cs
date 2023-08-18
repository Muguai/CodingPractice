namespace KataPractice;
public static class PigLatin{

    private static List<string> vowels = new List<string>(){
        "a",
        "e",
        "i",
        "o",
        "u"
    };

    public static string Translate(string word){
        string[] wordArray = word.Split(new char[]{' '});

        string result = "";

        foreach(string s in wordArray){
            if(vowels.Contains(s.Substring(0, 1).ToLower())){
                result += s + "yay ";
            }else{
                string start = "";
                string end = "";
                string specialChars = "";
                bool gotToVowel = false;
                foreach(char s2 in s){
                    if(vowels.Contains(s2.ToString().ToLower()))
                        gotToVowel = true;
       
                    if(!IsEnglishLetter(s2))
                        specialChars += s2;
                    else if(!gotToVowel)
                        start += s2.ToString().ToLower();
                    else
                        end += s.Substring(0, 1) == s.Substring(0, 1).ToUpper() ? s2.ToString().ToUpper() : s2; 
                }
                result += end + start + "ay" + specialChars + " ";
            }
        }

        return result;
    }


    private static bool IsEnglishLetter(char c)
    {
        return (c>='A' && c<='Z') || (c>='a' && c<='z');
    }


}