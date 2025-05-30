public class Scripture
{
    public List<string> _words = ["Trust","in","the","LORD","with","all","thine","heart;","and","lean","not","unto","thine","own","understanding;","In","all","thy","ways","acknowledge","him","and","he","shall","direct","thy","paths."];

    public void Script()
    {
        foreach (string word in _words)
        {
            Console.Write(word+" ");
        }
    }

    public void HideRandomWords(int number)
    {
        _words[number] = "____";
    }

    public string GetDisplayText()
    {
        return "Proverbs 3:5-6 ";
    }
}