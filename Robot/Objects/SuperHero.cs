namespace Robot.Objects;

public class SuperHero : Human
{
    public SuperHero(string name, int maxHealth, int age) : base(name, maxHealth, age)
    {
    }
    
    public override string ToString()
    {
        return $"SuperHero[Name = {Name}, Age = {Age}, Health = {Health}, MaxHealth = {MaxHealth}, IsAlive = {IsAlive}]";
    }
}