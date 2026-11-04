using System;

using WebWomen.Services;

namespace WebWomen.Models
{
    public class StudentKeywordTwo
    {
        public int id = 101;

        public StudentKeywordTwo Get()
        {
            return this;
        }

        public int Display(StudentKeywordTwo s)
        {
           return s.id;
        }

        public int Show()
        {
            return Display(this);
        }
    }
}
