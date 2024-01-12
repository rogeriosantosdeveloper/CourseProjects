using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAverage
{
    internal class SchoolAvg
    {
        public string Name;
        public double[] Avg = new double [3];
        public double FinalAvg;

        public double CalcAvg()
        {
            return FinalAvg /= Avg.Length;
        }

        public override string ToString()
        {
            return "Your final average is: " + CalcAvg();
        }

    }
}
