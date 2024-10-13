public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today what would it be?",
        "What are you looking forward to this week?",
        "How did you serve someone today?",
        "What is love? (baby don't hurt me no more)",
        "How did someone serve you today?",
        "What am you grateful for today?",
        "How have you felt God's love in your life today?"
    };

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
        using (StreamWriter outputFile = new StreamWriter("userPrompts.txt"))
        {
            outputFile.WriteLine($"{newPrompt}");
        }
    }

    public void LoadUserPrompts()
    {
        string[] lines = System.IO.File.ReadAllLines("userPrompts.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }
}