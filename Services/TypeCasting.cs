
using System;
using System.Collections.Generic;


namespace WebWomen.Services
{
    public class TypeCasting
    {
        public List<Object> getcasting()
        {

            List<Object> casting = new List<Object>();

            int num = 10;
            casting.Add(num);
            // int is converted to double (implicit type casting)
            double d = num;
            casting.Add(d);

            double dd = 9.8;

            // explicit casting
            int x = (int)dd;
            casting.Add(dd);
            casting.Add(x);


            int i = 12;
            double ddo = 765.12;
            float ff = 56.123F;

            // Using Built- In Type Conversion Methods & Displaying Result
            casting.Add(Convert.ToString(ff));
            casting.Add(Convert.ToInt32(ddo));
            casting.Add(Convert.ToUInt32(ff));
            casting.Add(Convert.ToDouble(i));
            casting.Add("Riky Mac");

            return casting;
        }
    }
}
