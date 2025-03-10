internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine(kodePos.GetKodePos("Batununggal"));
    }

}

public class KodePos
{
    private Dictionary<string, string> kodePosData;

    public KodePos()
    {
        kodePosData = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    public string GetKodePos(string kelurahan)
    {
        if (kodePosData.ContainsKey(kelurahan))
        {
            return kodePosData[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}