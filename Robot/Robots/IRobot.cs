using Robot.Objects;

namespace Robot.Robots;

public interface IRobot : IObject
{
    void Initialize();
    void Deactivate();
}