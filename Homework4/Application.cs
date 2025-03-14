namespace Homework4;

internal class Application
{
    private readonly string _fileRawPath = Directory.GetCurrentDirectory() + "/data.txt";
    private readonly string _filePrimesPath = Directory.GetCurrentDirectory() + "/primes.txt";
    private readonly string _fileCustomPrimesPath = Directory.GetCurrentDirectory() + "/custom_primes.txt";
    
    private readonly Mutex _firstMutex = new();
    private readonly Mutex _secondMutex = new();

    public Application()
    {
        
    }

    public void Run()
    {
        var fillFileThread = new Thread(FillFile);
        var extractPrimeNumbersThread = new Thread(ExtractPrimeNumbers);
        var extractNumbersWithSeven = new Thread(ExtractNumbersWithSeven);
        
        fillFileThread.Start();
        Thread.Sleep(150);
        extractPrimeNumbersThread.Start();
        Thread.Sleep(150);
        extractPrimeNumbersThread.Join();
        extractNumbersWithSeven.Start();

        fillFileThread.Join();
        extractNumbersWithSeven.Join();
    }

    private void FillFile()
    {
        _firstMutex.WaitOne(5000);
        _secondMutex.WaitOne(15000);

        try
        {
            using var streamWriter = new StreamWriter(
                File.Open(_fileRawPath, FileMode.OpenOrCreate, FileAccess.Write));
        
            Console.WriteLine("Filling up the file with random numbers...");
        
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                streamWriter.WriteLine(random.Next(0, 500));
                Thread.Sleep(30);
            }
        }
        finally
        {
            _firstMutex.ReleaseMutex();
            _secondMutex.ReleaseMutex();
        }
    }

    private void ExtractPrimeNumbers()
    {
        _firstMutex.WaitOne(15000);
        _secondMutex.WaitOne();

        var streamReader = new StreamReader(File.Open(_fileRawPath, FileMode.Open, FileAccess.Read));
        var streamWriter = new StreamWriter(File.Open(_filePrimesPath, FileMode.OpenOrCreate, FileAccess.Write));
        
        Console.WriteLine("Extracting prime numbers...");
        
        foreach (string line in streamReader.ReadToEnd().Split(Environment.NewLine))
        {
            try
            {
                var convertedNumber = Convert.ToInt32(line);
                if (IsPrime(convertedNumber))
                {
                    streamWriter.WriteLine(convertedNumber);
                }
            }
            catch (FormatException e) { }
        }
        
        streamWriter.Dispose();
        streamReader.Dispose();
        
        _secondMutex.ReleaseMutex();
    }

    private void ExtractNumbersWithSeven()
    {
        _secondMutex.WaitOne();
        
        var streamReader = new StreamReader(File.Open(_filePrimesPath, FileMode.Open, FileAccess.Read));
        var streamWriter = new StreamWriter(File.Open(_fileCustomPrimesPath, FileMode.OpenOrCreate, FileAccess.Write));
        
        Console.WriteLine("Extracting custom prime numbers...");

        foreach (string line in streamReader.ReadToEnd().Split(Environment.NewLine))
        {
            try
            {
                var convertedNumber = Convert.ToInt32(line);
                if (convertedNumber % 10 == 7)
                {
                    streamWriter.WriteLine(convertedNumber);
                }
            }
            catch (FormatException e) { }
        }
        
        streamWriter.Dispose();
        streamReader.Dispose();
    }
    
    private static bool IsPrime(int n) 
    {
        switch (n)
        {
            case < 2:
                return false;
            case 2 or 3:
                return true;
        }

        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6) {
            if (n % i == 0 || n % (i + 2) == 0) {
                return false;
            }
        }
        
        return true;
    }
}