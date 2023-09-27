using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovaEA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            // 360/12=30 градусов на один час, значит в одном градусе 2 минуты
            double a = f * 2 / 60;
            double hour = Math.Truncate(a);
            return (int)hour;
        }
    }
}
