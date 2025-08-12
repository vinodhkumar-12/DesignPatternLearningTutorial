public class Program
{
    public static void Main(string[] args)
    {
        IAnimal animal = AnimalSimpleFactory.GetAnimal("");

        if (animal == null)
        { 
            Console.WriteLine("No such animal not implemented"); 
        }
        else
            animal.Speak();
    }
}


public class AnimalSimpleFactory
{
    public static IAnimal GetAnimal(string AnimalName)
    {
        IAnimal animal = null;

        if (AnimalName == "Dog")
        {
            return new Dog();
        }
        else if (AnimalName == "Tiger")
        {
            return new Tiger();
        }

        return animal;
    }
}

public interface IAnimal
{
    public void Speak();
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