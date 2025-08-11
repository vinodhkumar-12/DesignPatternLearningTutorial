public class Program
{

    public static void Main(string[] args)
    {
        SingleTon singleTon = SingleTon.Instance;

    }

}


public class SingleTon
{
    private static SingleTon _instance = null;
    private static readonly object _instanceLock = new object();

    private static int counter = 0;

    public static SingleTon Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingleTon();
                    }
                }
            }
            return _instance;
        }
    }
    private SingleTon()
    {
        counter++;
        Console.WriteLine("Instance Counter is {0}", counter++);
    }
}