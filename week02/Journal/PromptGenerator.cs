public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random generateRandom = new Random();
        int magic = generateRandom.Next(1, _prompts.Count);
        return _prompts[magic];
    }
}