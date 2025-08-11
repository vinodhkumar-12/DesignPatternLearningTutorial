using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        ElectronicGoods tv = new Television();
        tv.State  = new OnState();

        tv.MoveToCurrentState();

        tv.State = new OffState();

        tv.MoveToCurrentState();
    }
}



public interface IState
{
    public void MoveState();
}


public class OnState : IState
{
    public void MoveState()
    {
        Console.WriteLine("On State");
    }
}

public class OffState : IState
{
    public void MoveState()
    {
        Console.WriteLine("Off State");
    }
}


public abstract class ElectronicGoods
{
    protected IState state;

    public IState State
    {
        get { return state; }
        set { state = value; }
    }

    public abstract void MoveToCurrentState();
}

public class Television : ElectronicGoods
{
    public override void MoveToCurrentState()
    {
        state.MoveState();
    }
}


public class AC : ElectronicGoods
{
    public override void MoveToCurrentState()
    {
        state.MoveState();
    }
}