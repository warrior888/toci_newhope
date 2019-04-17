// <copyright file="Doktor.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

namespace Jagodka
{
    public class Doktor: Human
    {
        public override Human HaveSex(Human human)
        {
            return new Woman();
        }
    }
}