namespace Robot.Planets;

public interface IPlanet
{
    public string Name { get; }
    
    bool ContainsLife();
}