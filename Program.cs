public class Program
{

    public static void Main(string[] args)
    {
        AnimalFactory dogFactory = new DogFactory();

        IAnimal dog = dogFactory.CreatAnimal();

        dog.Speak();

        AnimalFactory tigerFactory = new TigerFactory();

        IAnimal tiger = tigerFactory.CreatAnimal();

        tiger.Speak();
    }


}


public interface IAnimal
{
    void Speak();
}

public class Dog : IAnimal
{

    public void Speak()
    {
        Console.WriteLine("Dog Barks");
    }
}

public class Tiger : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Tiger Roars");
    }

}

public abstract class AnimalFactory
{
    public abstract IAnimal CreatAnimal();
}

public class DogFactory : AnimalFactory
{
    public override IAnimal CreatAnimal()
    {
        return new Dog();
    }
}


public class TigerFactory : AnimalFactory
{
    public override IAnimal CreatAnimal()
    {
        return new Tiger();
    }
}