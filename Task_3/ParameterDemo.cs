using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ParameterDemo
    {
        public int Increase(ref int num)
        {
            num = 20;
            num += 10;
            return num;
        }
        public String GetFullName(out String fullName)
        {
             fullName = "ROhan poudel";
            return fullName;
        }

        public int SumAll(params int[] nums)
        {
            return nums.Sum();
        }
    }
}
