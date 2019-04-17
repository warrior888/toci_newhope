// <copyright file="Human.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

namespace Jagodka
{
    public abstract class Human
    {
        public double age { get; set; }
        public abstract Human HaveSex(Human human);


    }
}