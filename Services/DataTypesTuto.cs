using System;
using System.Collections.Generic;

namespace WebWomen.Services
{
    public class DataTypesTuto
    {

        public List<Object> getDataTypes()
        {
            unsafe
            {
            int x = 10;
            float f = 3.5f;
            double d = 5.6;
            char c = 'A';
            bool b = true;
            string s = "Hello";
            object obj = 10;   // boxing
            int[] arr = { 1, 2, 3 };

      
                int n = 10;
                int* p = &n;
                //Console.WriteLine(n);
            

            List<Object> dataTypes = new List<Object>();
            dataTypes.Add(x);
            dataTypes.Add(f);
            dataTypes.Add(d);
            dataTypes.Add(c);
            dataTypes.Add(b);
            dataTypes.Add(s);
            dataTypes.Add(obj);
            dataTypes.Add(arr);
            dataTypes.Add(n);
            dataTypes.Add(*p);

           
            return dataTypes;
            }
        }

    }
}
