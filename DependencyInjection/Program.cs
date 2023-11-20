// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Car car = new Car(new HondaEngine(new Cylinder(new Piston(),new CrankShaft(new Transmitter()))));

class Car 
{
    public Car(IEngineVendor honda)
    {
        
    }
}

interface IEngineVendor { }
class HondaEngine:IEngineVendor
{
    public HondaEngine(Cylinder cylinder)
    {
        
    }
}

class Piston
{
    public Piston()
    {
        
    }
}

class Cylinder
{
    public Cylinder(Piston piston, CrankShaft crankShaft)
    {
        
    }
}
class CrankShaft 
{
    public CrankShaft(Transmitter transmitter)
    {
        
    }
}
class Transmitter
{

}