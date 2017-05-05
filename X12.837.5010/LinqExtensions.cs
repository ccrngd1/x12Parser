using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
   
        public static class LinqExtensions
        {
            public static double StdDev(this IEnumerable<int> values)
            {
                double ret = 0;
                int count = values.Count();
                if (count > 1)
                {
                    //Compute the Average
                    double avg = values.Average();

                    //Perform the Sum of (value-avg)^2
                    double sum = values.Sum(d => (d - avg) * (d - avg));

                    //Put it all together
                    ret = Math.Sqrt(sum / count);
                }
                return ret;
            }
            public static double Median(this IEnumerable<int> values)
            {
                var sorted = values.ToList();
                sorted.Sort();
                var count = values.Count() ;
                var half = count >> 1;
                if ((count & 0x01) != 0)
                {
                    return values.OrderBy(a => a).Skip(half - 1).Take(2).Average();
                }
                else
                    return values.OrderBy(a => a).ElementAt(half);
                
            }
        
        
    }
}
