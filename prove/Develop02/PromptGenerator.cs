public class PromptGenerator
{
    public List<string> _prompts = new List<string> {};

    public void LoadPrompts()
    {
        string[] lines = System.IO.File.ReadAllLines("userPrompts.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public string GetRandom()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void AddPrompt()
    {
        Console.Write("What prompt would you like to add? ");
        string newPrompt = Console.ReadLine();
        _prompts.Add(newPrompt);
        using (StreamWriter outputFile = new StreamWriter("userPrompts.txt", true))
        {
            outputFile.WriteLine(newPrompt);
        }
    }
}