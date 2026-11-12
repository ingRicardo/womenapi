using System;
using System.Collections.Generic;
using System.Linq;
using WebWomen.Models;

namespace WebWomen.Services
{
    public class ListService
    {
        public static List<Object> GetListExamples()
        {
            List<Object> generallist = new List<Object>();

            // Creating a List of strings
            List<string> li = new List<string>();
            // Adding elements
            li.Add("Java");
            li.Add("Python");
            li.Add("DSA");
            li.Add("C++");
            
            // Iterating through the list
            foreach (string s in li)
            {
                generallist.Add(s);
            }


            //1. Adding Elements
            generallist.Add("1. Adding Elements");
            List<string> al = new List<string>();
            al.Add("Riky");
            al.Add("Riky");
            // Insert element at index 1
            al.Insert(1, "For");

            generallist.Add(al);

            //2. Updating Elements
            generallist.Add("2. Updating Elements");
            List<string> al2 = new List<string>();

            al2.Add("Alfred");
            al2.Add("Alfred");
            al2.Add("Alfred");

            // Update element at index 1
            al2[1] = "For";

            generallist.Add(al2);

            //3. Removing Elements
            generallist.Add("3. Removing Elements");
            List<string> al3 = new List<string>();

            al3.Add("Alfred");
            al3.Add("Alfred");
            al3.Insert(1, "For");

            List<string> al3temp = new List<string>(al3);
            generallist.Add(al3temp);

            List<string> al3temp2 = new List<string>(al3temp);

            //Remove by index 
            al3temp2.RemoveAt(1);
            generallist.Add(al3temp2);

            List<string> al3temp3 = new List<string>(al3temp2);

            // Remove by value
            al3temp3.Remove("Alfred");

            generallist.Add(al3temp3);

            //4. Searching Elements
            generallist.Add("4. Searching Elements");
            List<int> ltsearch = new List<int>();
            ltsearch.Add(1);
            ltsearch.Add(2);
            ltsearch.Add(3);
            ltsearch.Add(2);

            int first = ltsearch.IndexOf(2);
            int last = ltsearch.LastIndexOf(2);

            generallist.Add("First Occurrence of 2 is at Index: " + first);
            generallist.Add("Last Occurrence of 2 is at Index: " + last);

            //5. Accessing Elements
            generallist.Add("5. Accessing Elements");
            List<string> ltaccess = new List<string>();
            ltaccess.Add("Riky");
            ltaccess.Add("For");
            ltaccess.Add("Riky");
            string firststr = ltaccess[0];
            string secondstr = ltaccess[1];
            string thirdstr = ltaccess[2];
            generallist.Add(firststr);
            generallist.Add(secondstr);
            generallist.Add(thirdstr);

            //6. Checking Whether an Element Exists
            generallist.Add("6. Checking Whether an Element Exists");

            List<string> ltexists = new List<string>();
            ltexists.Add("Riky");
            ltexists.Add("For");
            ltexists.Add("Riky");
            bool isPresent = ltexists.Contains("Riky");
            generallist.Add("Is 'Riky' present in the list? " + isPresent );

            //Iterating Over List
            generallist.Add("7. Iterating Over List");
            List<string> ltiterate = new List<string>();
            ltiterate.Add("Riky");
            ltiterate.Add("Riky");
            ltiterate.Insert(1, "For");
            generallist.Add("Using for loop");
            // Using for loop
            for (int i = 0; i < ltiterate.Count; i++)
            {
                generallist.Add(ltiterate[i]);
            }
            // Using foreach loop
            generallist.Add("Using foreach loop");
            foreach (string s in ltiterate)
            {
                generallist.Add(s);
            }

            return generallist;
        }
    }
}
