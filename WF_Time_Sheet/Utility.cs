using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Time_Sheet
{
    public class Utility
    {
        //static fields  
        public static double result;
        public static double CalculateRate(double hours, double hourRate)
        {             
            result = hours * hourRate;
            return result;
        }
    }
}
