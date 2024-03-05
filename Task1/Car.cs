namespace Task1;

public class Car : IVehicle
{
    int _fuel;
    public Car(int fuel)
    {
        _fuel = fuel;
    }
    public void Drive()
    {
        if (_fuel > 0)System.Console.WriteLine("Driving");
    }

    public bool Refuel(int gas)
    {
        _fuel+=gas;
        return true;
    }
}
