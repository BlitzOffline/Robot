using Robot.Planets;

namespace Robot.Robots;

public class Robot : IRobot
{
    public Planet Planet { get; set; }
    public bool Active { get; private set; }

    public void Initialize()
    {
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }

    public override string ToString()
    {
        return $"Robot[Active = {Active}, Planet = {Planet}]";
    }
}