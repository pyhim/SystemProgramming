namespace Homework7;

internal static class Program
{
    private static void Main(string[] args)
    {
        // int[] numbers = GetNumbersFromFile();
        //
        // Console.WriteLine($"Sum: {Sum(numbers)}\nMax: {Max(numbers)}\nMin: {Min(numbers)}\n" +
        //                   $"Evens: [{string.Join(", ", Even(numbers))}]\n" +
        //                   $"Odds: [{string.Join(", ", Odd(numbers))}]");

        // int[] numbers = GetNumbersFromFile();
        // Console.WriteLine(LongestAscendingSequenceLength(numbers));
        
        int[] inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        TableOfMultiplies(inputs[0], inputs[1]);
    }

    private static int Sum(int[] numbers)
    {
        return numbers.AsParallel().Sum();
    }

    private static int Max(int[] numbers)
    {
        return numbers.AsParallel().Max();
    }

    private static int Min(int[] numbers)
    {
        return numbers.AsParallel().Min();
    }

    private static int[] Even(int[] numbers)
    {
        return numbers.AsParallel().Where(x => x % 2 == 0).ToArray();
    }

    private static int[] Odd(int[] numbers)
    {
        return numbers.AsParallel().Where(x => x % 2 != 0).ToArray();
    }

    private static int[] GetNumbersFromFile()
    {
        string[] lines = File.ReadAllLines("input.txt");
        var numbers = new LinkedList<int>();

        foreach (string line in lines)
        {
            line.Split(' ').Select(int.Parse).ToList().ForEach(n => numbers.AddLast(n));
        }
        
        return numbers.ToArray();
    }

    private static int LongestAscendingSequenceLength(int[] numbers)
    {
        var biggestLengthSequence = new LinkedList<int>();
        var candidateSequence = new LinkedList<int>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] <= numbers[i + 1])
            {
                candidateSequence.AddLast(numbers[i]);
                continue;
            }
            candidateSequence.AddLast(numbers[i]);

            if (candidateSequence.Count <= biggestLengthSequence.Count)
            {
                candidateSequence.Clear();
                continue;
            }
            
            biggestLengthSequence = candidateSequence;
            candidateSequence = [];
        }
        
        candidateSequence.AddLast(numbers.Last());

        if (candidateSequence.Count > biggestLengthSequence.Count)
        {
            biggestLengthSequence = candidateSequence;
        }
        
        return biggestLengthSequence.Count;
    }

    private static int LongestPositiveSequenceLength(int[] numbers)
    {
        var positiveSequence = new LinkedList<int>();
        
        numbers.AsParallel().Where(n => n > 0).ToList().ForEach(n => positiveSequence.AddLast(n));
        
        return LongestAscendingSequenceLength(positiveSequence.ToArray());
    }

    private static void TableOfMultiplies(int from, int to)
    {
        var outputFile = new StreamWriter(
            new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.Write));
        
        Parallel.For(from, to, (i, state) =>
        {
            for (int j = 1; j <= 10; j++)
            {
                outputFile.WriteLine();
                outputFile.WriteLine($"{j}*{i}={i * j}");
            }
        });
        
        outputFile.Close();
    }
}