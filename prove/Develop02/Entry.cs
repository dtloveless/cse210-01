public class Entry
{
    public string _timestamp;
    public string _prompt;
    public string _body;

    public void SetDateTime()
    {
        DateTime dateTime = DateTime.Now;
        _timestamp = dateTime.ToString("MM/dd/yyyy hh:mm tt");
    }

    public void SetPrompt()
    {
        PromptGenerator Prompts = new PromptGenerator();
        _prompt = Prompts.GetRandom();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{_prompt}: ");
    }

    public void CaptureResponse()
    {
        _body = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_timestamp} - Prompt: {_prompt}\n {_body}");
    }
}