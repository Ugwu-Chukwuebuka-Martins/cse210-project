public class Entry
{
   public string _date;
   public string _promptText;
   public string _entryText;

   public void Display(Entry item)
   {
      Console.WriteLine($"Date: {item._date} - Prompt: {item._promptText}");
      Console.WriteLine(item._entryText);
      Console.WriteLine();
   }
}