public class Program
{

    public static void Main(string[] args)
    {

        IAnimalFactory wildanimalFactory = new WildAnimalFactory();

        IHerbivore wildDeer =   wildanimalFactory.createHerbivore();

        wildDeer.EatPlants();

        ICarnivore wildTiger = wildanimalFactory.createCarnivore();

        wildTiger.EatMeats();
    }


}


public interface IHerbivore
{
    void EatPlants();
}

public interface ICarnivore
{
    void EatMeats();
}


public class WildDeer : IHerbivore
{
    public void EatPlants()
    {
        Console.WriteLine("Wild Deer eats grass");
    }
}

public class DomesticCow : IHerbivore
{
    public void EatPlants()
    {
        Console.WriteLine("Domestic cow eats grass");
    }
}

public class WildTiger : ICarnivore
{
    public void EatMeats()
    {
        Console.WriteLine("Wild Tiger eats meats");
    }
}

public class DomesticDog : ICarnivore
{
    public void EatMeats()
    {
        Console.WriteLine("Domestic Dog eats meats");
    }
}


public interface IAnimalFactory
{
    IHerbivore createHerbivore();
    ICarnivore createCarnivore();
}

public class WildAnimalFactory : IAnimalFactory
{
    public IHerbivore createHerbivore()
    {
        return new WildDeer();
    }

    public ICarnivore createCarnivore()
    {
        return new WildTiger();
    }
}

public class DomesticAnimalFactory : IAnimalFactory
{
    public IHerbivore createHerbivore()
    {
        return new DomesticCow();
    }

    public ICarnivore createCarnivore()
    {
        return new DomesticDog();
    }
}