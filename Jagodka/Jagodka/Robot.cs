// <copyright file="Robot.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

namespace Jagodka
{
    public class Robot: Doktor
    {
        public bool Wash(Tower tower)
        {
            foreach (Glass Window in tower.Windows)
            {
                Window.Clean(this,tower);

            }

            return false;

        }
    }
}