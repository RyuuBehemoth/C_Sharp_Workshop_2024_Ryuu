// See https://aka.ms/new-console-template for more information


public class ConsecutiveSequenceFinder
{
    public static List<int> FindLongestConsecutiveSequence(List<int> sortedList)
    {
        if (sortedList == null || sortedList.Count == 0)
            return new List<int>();

        List<int> longestSequence = new List<int>();
        List<int> currentSequence = new List<int> { sortedList[0] };

        for (int i = 1; i < sortedList.Count; i++)
        {
            if (sortedList[i] == sortedList[i - 1] + 1)
            {
                currentSequence.Add(sortedList[i]);
            }
            else
            {
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }
                currentSequence.Clear();
                currentSequence.Add(sortedList[i]);
            }
        }

        // Final check at the end of the list
        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence = currentSequence;
        }

        return longestSequence;
    }

    public static void Main()
    {
        List<int> sortedList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> longestSequence = FindLongestConsecutiveSequence(sortedList);

        Console.WriteLine("La secuencia más larga de números consecutivos es:");
        foreach (int num in longestSequence)
        {
            Console.Write(num + " ");
        }
    }
}
