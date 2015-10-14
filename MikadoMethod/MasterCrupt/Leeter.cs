using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MasterCrupt
{
    public class Leeter
    {
        public static String Leet(string message, int customerType)
        {
            var result = message;

            result = result.Replace('e', '3').Replace('E', '3');

            if (customerType == 2)
            {
                result = result.Replace('s', '5').Replace('S', '5');
            }

            return result;
        }
    }
}
