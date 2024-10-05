using System;

class Program
{
    static void Main(string[] args)
    { 
        string option = "";
        Reference referecia = new Reference("John", 3, 3, 5);
        List<string> script = new List<string> {
            "Jesus", "answered", "and", "said", "unto", "him,", "Verily,", "verily,", "I", "say", "unto", "thee,", "Except", "a", "man", "be", "aborn", "again,", "he", "cannot", "see", "the", "kingdom", "of", "God.",
            "Nicodemus", "saith", "unto", "him,", "How", "can", "a", "man", "be", "born", "when", "he", "is", "old?", "can", "he", "enter", "the", "second", "time", "into", "his", "mother’s", "womb,", "and", "be", "born?",
            "Jesus", "answered,", "Verily,", "verily,", "I", "say", "unto", "thee,", "Except", "a", "man", "be", "born", "of", "water", "and", "of", "the", "Spirit,", "he", "cannot", "enter", "into", "the", "kingdom", "of", "God."
        };

        List<Word> words = new List<Word>();

        for (int i = 0; i < script.Count; i++)
        {
            Word word = new Word(script[i]);
            words.Add(word);
        }

        Scripture scripture = new Scripture(referecia, words);

        Console.WriteLine(scripture.GetDisplayText());

         while (option != "quit")
        {
            Console.WriteLine("Please, enter to continue or type 'quit' to exit");
            option = Console.ReadLine().ToLower();

            if (option == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                scripture.HideRandomWords(1);
                Console.WriteLine(scripture.GetDisplayText());
                
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are now hidden! Exiting the program.");
                    break;
                }
                
            }
        }
    
    }
}
