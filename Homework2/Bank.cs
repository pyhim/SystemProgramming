namespace SystemProgramming;

public class Bank
{
    private readonly string _filePath = Directory.GetCurrentDirectory() + "/data.txt";
    private StreamWriter _fileStream;

    private string _name = string.Empty;
    private int _money;
    private int _percent;

    public string Name
    {
        get => _name;
        set
        {
            SerializeAsync();
            _name = value;
        }
    }

    public int Money
    {
        get => _money;
        set
        {
            SerializeAsync();
            _money = value;
        }
    }

    public int Percent
    {
        get => _percent;
        set
        {
            SerializeAsync();
            _percent = value;
        }
    }

    public Bank()
    {
        _fileStream = new StreamWriter(
            File.Open(_filePath, FileMode.OpenOrCreate, FileAccess.Write));
    }

    private void SerializeAsync()
    {
        var thread = new Thread(Serialize);
        
        thread.Start();
        thread.Join();
    }

    private void Serialize()
    {
        string toWrite = $"{Name}{Environment.NewLine}{Money}{Environment.NewLine}{Percent}{Environment.NewLine}";
        _fileStream.WriteLine(toWrite);
        _fileStream.Flush();
    }

    public override string ToString()
    {
        return $"{Name}, {Money}, {Percent}";
    }

    ~Bank()
    {
        _fileStream.Close();
    }
}