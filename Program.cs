public class Program
{
    public static void Main()
    {

        Television tv = new Television();
        Remote remote = new Remote();
        Light light = new Light();  
        HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(tv, remote, light);

        homeTheaterFacade.WatchMovie();
        homeTheaterFacade.EndMovie();


    }
}


public class HomeTheaterFacade
{
    Television _tv;
    Remote _remote;
    Light _light;
    public HomeTheaterFacade(Television tv, Remote remote, Light light)
    {
        this._tv = tv;
        this._remote = remote;
        this._light = light;
    }

    public void WatchMovie()
    {
        _light.Bright();
        _tv.On();
        _remote.On();
        _remote.SetVolume(50);
    }


    public void EndMovie()
    {
        _tv.Off();
        _light.Dim();
    }
}

public class Television
{
    public void On()
    {
        Console.WriteLine("Television is ON");
    }

    public void Off()
    {
        Console.WriteLine("Television is OFF");
    }

}


public class Remote
{
    public void On()
    {
        Console.WriteLine("Remote is On");
    }

    public void SetVolume(int i)
    {
        Console.WriteLine("Set the Volume with value {0}", i);
    }
}

public class Light
{
    public void Dim()
    {
        Console.WriteLine("Make the light dim");
    }

    public void Bright()
    {
        Console.WriteLine("Make the light bright");
    }
}
