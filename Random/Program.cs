using System;

class Program
{
    static string[] listePrenoms = new string[] {"Simon", "Kevin", "Franck", "Amelie", "Patricia", "Joel", "Thibault", "Azrael", "Angelique", "Loic", "Kristelle", "Lucas"};

    static void Main()
    {
        var result = Shuffle(listePrenoms);
        foreach (var i in result)
        {
            Console.Write(i + " ");
        }
        Console.ReadKey();
    }

    static string[] Shuffle(string[] wordArray)
    {
        Random random = new Random();
        for (int i = wordArray.Length - 1; i > 0; i--)
        {
            int swapIndex = random.Next(i + 1);
            string temp = wordArray[i];
            wordArray[i] = wordArray[swapIndex];
            wordArray[swapIndex] = temp;
        }
        return wordArray;
    }
}