using System.Linq;

class Words 
{
    private string[] words;
    private Random random = new Random();

    public Words(string text) 
    {
        words = text.Split(' ');
    }
    public bool checkWords() 
    {
        foreach(string word in words) {
            if(word != "____") {
                return true;
            }
        }

        return false;
    }
    public string wordsToString()
    {
        string newText = String.Join(" ", words);
        return newText;
    }

    // public string[] getRandomWords() 
    // {
    //     if (words.Count(w => w != "____") > 1) {
    //         string randomWord = words[random.Next(0, words.Length)];
    //         if(words.Count(w => w != "____") > 2) {
    //             string randomWord2 = "";
    //             do {
    //                 randomWord2 = words[random.Next(0, words.Length)];
    //             } while ( randomWord == randomWord2 );
    //             return [randomWord, randomWord2];
    //         }
    //         return [randomWord];
    //     };
    // }
}