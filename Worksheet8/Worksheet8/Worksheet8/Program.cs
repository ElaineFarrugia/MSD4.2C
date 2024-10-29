List<string> wordList = new List<string>
{
    "cat", "hat", "bat", "rat", "mat", "flat",
    "dog", "frog", "log", "jog", "smog",
    "tree", "free", "see", "bee", "spree",
    "light", "fight", "night", "sight", "might"
};

Console.WriteLine("Enter a word: ");
string input = Console.ReadLine();
string input_ending = input.Substring(input.Length-2, 2);

foreach (string word in wordList)
{
    string word_ending = word.Substring(input.Length - 2, 2);
    
    if (input_ending == word_ending)
    {
        Console.WriteLine("Found rhyming word: " + word);        
    }
}

