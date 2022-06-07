using System.Collections.Generic;
using Robot.Objects;

namespace Robot.Planets;

public interface IPlanet
{
    public string Name { get; }
    public HashSet<IEntity> Entities { get; }


    bool ContainsLife();
}