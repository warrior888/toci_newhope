// <copyright file="Man.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using System.Threading;

namespace Jagodka
{
    public class Man : Human 
    {
        public override Human HaveSex(Human human)
        {
            if (age < 18)
            {
                throw new AbandonedMutexException("Nie mozna się bzykac");

            }
            return new Man();
        }

    }
            
        
   
}