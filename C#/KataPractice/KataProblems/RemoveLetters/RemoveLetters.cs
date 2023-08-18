namespace KataPractice;

/*
KATA: Remove the word 

Create a function that takes an array and string. The function should remove the 
letters in the string from the array and return the array. 

Examples 
1.  RemoveLetters(["s", "t", "r", "i", "n", "g", "w"], "string") ➞ ["w"] 
2.  RemoveLetters(["b", "b", "l", "l", "g", "n", "o", "a", "w"], "balloon") ➞ ["b", 
"g", "w"] 
3.  RemoveLetters(["a", "n", "r", "y", "o", "w"], "norway") ➞ [] 
4.  RemoveLetters(["t", "t", "e", "s", "t", "u"], "testing") ➞ ["t", "u"] 

Notes 
If number of times a letter appears in the array is greater than the number of 
times the letter appears in the string, the extra letters should be left behind (see 
example #2). 
If all the letters in the array are used in the string, the function should return an 
empty array (see example #3). 
*/
public class RemoveLetters
{
    public static char[] RemoveLettersFunc(string[] charArray, string removeString)
    {
        string result = string.Empty;

        foreach (string s in charArray)
        {
            int index = removeString.IndexOf(s);
            if (index >= 0)
                removeString = removeString.Remove(index, 1);
            else
                result += s;
        }

        return result.ToCharArray();
    }
}