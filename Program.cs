class SayaMusicTrack
{
    Random random = new Random();
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        // Design Contract untuk title
        if (title == "")
        {
            throw new Exception("Title tidak boleh kosong.");
        }

        if (title.Length > 100)
        {
            throw new Exception("Title tidak boleh lebih dari 100 karakter.");
        }

        // Isi Contructor
        string placeholder = id.ToString();
        for (int i = 0; i < 5; i++)
        {
            placeholder += random.Next(10);
        }
        id = int.Parse(placeholder);
        this.playCount = "0";

        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
        // Design Contract untuk count
        if (count > 10000000)
        {
            throw new Exception("Jumlah count tidak boleh lebih dari 10.000.000");
        }

        checked
        {
            int currentPlayCount = int.Parse(this.playCount);
            int addedPlayCount = currentPlayCount + count;
            this.playCount = addedPlayCount.ToString();
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("---TRACK DETAILS---");
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Play Count: " + this.playCount);
        Console.WriteLine("Title: " + this.title);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Less Than Zero");
        track1.IncreasePlayCount(400000000);
        track1.PrintTrackDetails();

        Console.WriteLine();

        SayaMusicTrack track2 = new SayaMusicTrack("The weight of the world");
        track2.IncreasePlayCount(1202);
        track2.PrintTrackDetails();

        Console.WriteLine();

        SayaMusicTrack track3 = new SayaMusicTrack("breathe");
        track3.IncreasePlayCount(3594);
        track3.PrintTrackDetails();
    }
}