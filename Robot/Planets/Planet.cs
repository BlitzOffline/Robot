using System;
using System.Collections.Generic;
using System.Linq;
using Robot.Objects;

namespace Robot.Planets;

public class Planet : IPlanet
{
    public static Planet Venus = new Planet("Venus", new HashSet<IEntity>());
    public static Planet Earth = new Planet("Earth", CreateEarthEntities());
    public static Planet Mars = new Planet("Mars", new HashSet<IEntity>());

    public string Name { get; }
    public HashSet<IEntity> Entities { get; }
    
    private Planet(string name, HashSet<IEntity> entities)
    {
        Name = name;
        Entities = entities;
    }

    public bool ContainsLife()
    {
        return Entities.OfType<LivingEntity>().Any();
    }

    public void RemoveEntity(IEntity entity)
    {
        Entities.Remove(entity);
    }

    public override string ToString()
    {
        return $"Planet[Name = {Name}, Entities = {{{string.Join(", ", Entities)}}}]";
    }

    private static HashSet<IEntity> CreateEarthEntities()
    {
        var set = new HashSet<IEntity>
        {
            new Human("Andrei", 20, 35),
            new Human("Alexandra", 20, 72),
            new Human("Ruben", 20, 20),
            new Human("Mihai", 20, 12),
            new SuperHero("Batman", 30, 40),
            new Animal(AnimalType.Elephant, 40),
            new Animal(AnimalType.Lion, 30),
            new Animal(AnimalType.Donkey, 10)
        };

        return set;
    }
}