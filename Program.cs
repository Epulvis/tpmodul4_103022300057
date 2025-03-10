internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine(kodePos.GetKodePos("Batununggal") + "\n");

        DoorMachine door = new DoorMachine();
        door.UnlockDoor();
        door.LockDoor();
        door.UnlockDoor();
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

public interface IDoorState
{
    void HandleState(DoorMachine door);
}

public class LockedState : IDoorState
{
    public void HandleState(DoorMachine door)
    {
        Console.WriteLine("Pintu terkunci");
    }
}

public class UnlockedState : IDoorState
{
    public void HandleState(DoorMachine door)
    {
        Console.WriteLine("Pintu tidak terkunci");
    }
}

public class DoorMachine
{
    private IDoorState _currentState;

    public DoorMachine()
    {
        _currentState = new LockedState();
        _currentState.HandleState(this);
    }

    public void SetState(IDoorState newState)
    {
        _currentState = newState;
        _currentState.HandleState(this);
    }

    public void LockDoor()
    {
        SetState(new LockedState());
    }

    public void UnlockDoor()
    {
        SetState(new UnlockedState());
    }
}