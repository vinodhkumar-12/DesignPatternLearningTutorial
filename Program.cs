public class Program
{
    public static void Main(string[] args)
    {

        Context context = new Context();

        context.SetChoice(new Choice1());

        context.ShowChoice();
    }
}


public class Context
{
    IChoice _choice;
    public void SetChoice(IChoice choice)
    {
        _choice = choice;
    }

    public void ShowChoice()
    {
        _choice.Mychoice();
    }

}

public interface IChoice
{

    public void Mychoice();

}

public class Choice1 : IChoice
{
    public void Mychoice()
    {
        Console.WriteLine("I Want to have snacks");
    }
}



public class Choice2 : IChoice
{
    public void Mychoice()
    {
        Console.WriteLine("I Want to have juice");
    }
}
