using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace NaktergalCodeTest.Services
{
    public class NaktergalenService
    {

        public void PrintOddNumbers()
        {
            //Det står alla nummer mellan 1 och 99 vilket inte egentligen innefattar 1 och 99 
            //Men jag väljer ändå att tolka de som om vi vill ha med 1 och 99
            for(int i = 1; i <= 99; i+=2)
            {
                Console.WriteLine(i);
                Debug.WriteLine(i);
            }
        }
        public int LargestNumber(int[] array)
        {          
            var max = array.Max();
            return max;
        }

    }
}