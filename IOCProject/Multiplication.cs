﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOCProject
{
    public class Multiplication : ICalculate
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}
