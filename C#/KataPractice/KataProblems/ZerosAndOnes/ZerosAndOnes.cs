using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPractice;
public static class ZerosAndOnes{
    public static string TextToNumberBinary(string text){
        
        string lowerCaseText = text.ToLower();
        string[] splitString = lowerCaseText.Split(" ");
        string result = "";

        foreach(string s in splitString){
            if(s == "zero")
                result += "0";
            else if (s == "one")
                result += "1";   
        }

        if(result.Length % 8 > 0){
            result = result.Remove(result.Length - result.Length % 8);
        }
        
        return result;
    }
}