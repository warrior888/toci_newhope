// <copyright file="Glass.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

namespace Jagodka
{
    public class Glass
    {
        public bool Clean(Robot robot,Tower tower)
        {
            robot.Wash(tower);
            return true;

        }
    }
}