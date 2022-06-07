using Robot.Objects;

namespace Robot.Robots;

/**
 * Represents a robot.
 */
public interface IRobot : IEntity
{
    void Initialize();
    void Deactivate();
}