using System;
using WebWomen.Models;
namespace WebWomen.Services
{
    public class PropertyTuto
    {
        /*
         * A property is a member of a class that provides a flexible way to read, write, 
         * or compute the value of a field. It uses accessors to control how a value is accessed or modified.
         */

        public static List<String> propertymethod()
        {
            List<String> lt = new List<String>();
            StudentPro s = new StudentPro();
            
            lt.Add("Private field");
            s.Age = 24;
            lt.Add("Age: " + s.Age);
            s.Age = -5;
            lt.Add("Age: " + s.Age);

            lt.Add("C1 No private");
            C1 obj = new C1();
            obj.rn = 10000;
            obj.name = "Raul";
            lt.Add("Name: " + obj.name);
            lt.Add("Roll No: " + obj.rn);
            lt.Add("Marks: " + obj.GetMarks());

            lt.Add("Read-Only Property");
            C2 obj2 = new C2();
            lt.Add("Roll No: " + obj2.RollNo);

            lt.Add("Write-Only Property");
            C3W obj3 = new C3W(147);
            lt.Add("Current Roll No: " + obj3.RollNo);
            obj3.RollNo = 357;
            lt.Add("Changed Roll No: " + obj3.RollNo);

            lt.Add("Accessor Accessibility");
            StudentTwo objT = new StudentTwo(147);
            lt.Add("Roll No: " + objT.RollNo);
            objT.RollNo = 123;
            lt.Add("Changed Roll No: " + objT.RollNo);

            lt.Add("Auto-Implemented Property");
            StudentAuto sauto = new StudentAuto();
            lt.Add("Name: " + sauto.Name);
            sauto.Name = "Riky";
            lt.Add  ("Changed Name: " + sauto.Name);

            return lt;
        }

    }
}
