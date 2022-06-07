using System;
using Robot.Objects.Animals;
using Robot.Objects.Humans;
using Robot.Planets;
using Robot.Robots;

namespace Robot
{
  internal class Program
  {
    public static void Main()
    {
      var robot = new GiantKillerRobot();
      robot.Initialize();

      robot.Planet = Planet.Earth;
      
      robot.EyeLaserIntensity = Intensity.Kill;
      robot.AddTargetTypes(typeof(Animal), typeof(Human), typeof(SuperHero));
      
      Console.WriteLine(robot);

      while (robot.Active && robot.Planet.ContainsLife())
      {
        if (robot.CurrentTarget is {IsAlive: true})
        {
          robot.FireLaser();
        }
        else
        {
          robot.AcquireNextTarget();
        }
      }


      Console.WriteLine();
      Console.WriteLine(robot);
    }
  }
}