// <copyright file="Woman.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

namespace Jagodka
{
    public class Woman: Man
    {
        public override Human HaveSex(Human human)
        {
             base.HaveSex(human);
            return new Woman();
        }
    }
}