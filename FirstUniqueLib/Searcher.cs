using System.Security.Cryptography.X509Certificates;

namespace FirstUniqueLib;
public class Searcher
{
    
    public static char? Search(string text)
    {
        if (string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text)) return null; 

        var words = text?.Split(' '); //Spliting text on words

        var firstLetters = words?.Select(x => x.First<Char>()); //Take only first letter of words
        
        var target = firstLetters?.Where(x => !MoreThanOne(firstLetters.ToList(), x))?.First(); //Take first unique letter

        if (target != null) return target;

        return null;
     }
    private static bool MoreThanOne(List<Char> letters, char letter)
    {
        int counter = 0;
        foreach (var l in letters)
        {
            if(l == letter) counter++;
            if(counter > 1) return true;
        }
        return false;
    }
}
