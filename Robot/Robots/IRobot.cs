using Robot.Objects;

namespace Robot.Robots;

public interface IRobot : IEntity
{
    void Initialize();
    void Deactivate();
}