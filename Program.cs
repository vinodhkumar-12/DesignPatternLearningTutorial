public class Program
{

    public static void Main(string[] args)
    {
        ObserverType1 observerType1 = new ObserverType1("Vinodh");
        ObserverType2 observerType2 = new ObserverType2("kumar");

        Subject sub = new Subject();

        sub.Register(observerType1);
        sub.Register(observerType2);

        sub.Flag = 1;
    }
}



public interface IObserver
{
    void Update(int i);
}

public class ObserverType1 : IObserver
{
    public string name;
    public ObserverType1(string name)
    {
        this.name = name;
    }

    public void Update(int i)
    {
        Console.WriteLine("{0} of Observer Type 1 with value {1} is alerted", name, i);
    }
}


public class ObserverType2 : IObserver
{
    public string name;
    public ObserverType2(string name)
    {
        this.name = name;
    }

    public void Update(int i)
    {
        Console.WriteLine("{0} of Observer Type 2 with value {1} is notified", name, i);
    }
}


public interface ISubject
{
    void Register(IObserver observer);
    void UnRegister(IObserver observer);
    void NotifyRegisteredUser();
}
public class Subject : ISubject
{

    public int flag;

    public int Flag { set { flag = value; NotifyRegisteredUser(); } }


    List<IObserver> observerlist = new List<IObserver>();

    public void Register(IObserver observer)
    {
        observerlist.Add(observer);
    }

    public void UnRegister(IObserver observer)
    {
        observerlist.Remove(observer);
    }

    public void NotifyRegisteredUser()
    {
        foreach (IObserver observer in observerlist)
        {
            observer.Update(flag);
        }
    }
}