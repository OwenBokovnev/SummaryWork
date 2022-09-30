Console.WriteLine("Enter words AND/OR numbers with SPACE: ");
string userText = Convert.ToString(Console.ReadLine());
string[] words = userText.Split(' ');

foreach (var word in words)
{
    if (word.Length <= 3)
    {
        Console.Write($"{word}" + ", ");    
    }
}
Console.WriteLine("\n");