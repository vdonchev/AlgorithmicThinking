namespace _01.ReverseWordsInAString
{
    using System;

    class ReverseWordsInAString
    {
        static void Main()
        {
            // Sample input: "You with be force the may" ;)
            Console.Write("Insert text = ");
            string[] text = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] reversedtext = new string[text.Length];

            for (int word = text.Length - 1, index = 0; word >= 0; word--, index++)
            {
                if (word == text.Length - 1)
                {
                    reversedtext[index] = char.ToUpper(text[word][0]) + text[word].Substring(1);
                }
                else
                {
                    reversedtext[index] = text[word];
                }
            }

            Console.WriteLine(string.Join(" ", reversedtext));
        }
    }
}
