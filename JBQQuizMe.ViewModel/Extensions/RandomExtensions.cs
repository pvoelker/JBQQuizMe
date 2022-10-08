using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBQQuizMe.ViewModel.Extensions
{
    public static class RandomExtensions
    {
        public static double NextDoubleLinear(this Random random, double minValue, double maxValue)
        {
            var sample = random.NextDouble();
            return (maxValue * sample) + (minValue * (1d - sample));
        }
    }
}
