using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers){
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
        }

        public static int Triple (ref int x)
        {
            return x *= 3;
        }


        public static int Quadruple (int number, out int result)
        {
            return result = number * 4;
        }

    }
}
