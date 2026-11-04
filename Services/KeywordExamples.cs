using System;
using System.Threading;
using WebWomen.Models;
namespace WebWomen.Services
{
    public class KeywordExamples
    {

        public static List<Object> GetKeywordExamples()
        {
            List<Object> examples = new List<Object>();
            //The this keyword refers to the current instance of a class or struct.
            //It is commonly used to access instance members and distinguish between class fields and parameters with the same name.

            //Access Instance Members: Refers to fields, properties, and methods of the current object.
            //Resolve Naming Conflicts: Differentiates instance variables from local variables or parameters with identical names.

            StudentKeyword s = new StudentKeyword(101, "Riky");

            examples.Add("1 - To Refer to Current Class Instance Variables");
            examples.Add(s.Display());
            examples.Add("2 - To Invoke Current Class Methods");
            RikySeven r = new RikySeven();
            examples.Add(r);
            examples.Add("3 - To Pass and Return the Current Object");
            StudentKeywordTwo obj = new StudentKeywordTwo();
            examples.Add(obj.Get().Show());
            return examples;
        }
    }
}
