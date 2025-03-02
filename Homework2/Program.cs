namespace SystemProgramming;

internal static class Program
{
    private static void Task1()
    {
        Console.WriteLine("Enter sequence of numbers: ");
        string input = Console.ReadLine() ?? string.Empty;
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
        
        var threads = new LinkedList<Thread>();
        foreach (int number in numbers)
        {
            var thread = new Thread(() => Console.WriteLine(number));
            threads.AddLast(thread);
            threads.Last!.Value.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }
    }
    
    private static void Main(string[] args)
    {
        // Task1();
        var bank = new Bank();

        Console.WriteLine(bank);
        
        bank.Name = "fsdfsdf";
        bank.Money = 500;
        bank.Percent = 10;
        
        Console.WriteLine(bank);
    }
}