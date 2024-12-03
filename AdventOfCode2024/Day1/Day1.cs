namespace Day1;

public class Day1 : IDay
{
    public void Problem1(string inputFile)
    {
        List<int> list1 = new();
        List<int> list2 = new();
        int totalDistance = 0;
        foreach(string line in LineReader.ReadLines(inputFile))
        {
            var splitted = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            list1.Add(int.Parse(splitted[0]));
            list2.Add(int.Parse(splitted[1]));
        }
        list1.Sort();
        list2.Sort();

        for(int i = 0; i < list1.Count; i++)
        {
            totalDistance += Math.Abs(list1[i] - list2[i]);
        }

        Console.WriteLine($"Total Distance: {totalDistance}.");
    }

    public void Problem2(string inputFile)
    {
        List<int> list1 = new();
        List<int> list2 = new();
        int similarity = 0;
        foreach(string line in LineReader.ReadLines(inputFile))
        {
            var splitted = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            list1.Add(int.Parse(splitted[0]));
            list2.Add(int.Parse(splitted[1]));
        }
        
        Dictionary<int, int> frequency =
                list2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        foreach(int i in list1)
        {
            similarity += i * frequency.GetValueOrDefault(i, 0);
        }

        Console.WriteLine($"Total Similarity: {similarity}.");
    }
}