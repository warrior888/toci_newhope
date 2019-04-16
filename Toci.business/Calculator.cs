// <copyright file="Calculator.cs" company="Rolls-Royce plc">
//   Copyright (c) 2018 Rolls-Royce plc
// </copyright>

namespace Toci.business
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}