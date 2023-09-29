﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovaEA.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {

            double result = Math.Pow((x + 1) / (x - 1), x) + 18 * x * y * y;
            return Math.Round(result,3);

        }

    }
}
