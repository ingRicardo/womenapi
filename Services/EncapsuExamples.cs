using WebWomen.Models;

namespace WebWomen.Services
{
    public class EncapsuExamples
    {

        public static List<Object> getEncapsulationExample()
        {
            List<Object> list = new List<Object>();

            Programmer programmer = new Programmer();
            programmer.Name = "Alfred";

            list.Add(programmer.Name);

            return list;
        }
    }
}
