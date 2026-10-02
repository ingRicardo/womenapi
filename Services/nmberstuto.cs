using System.Collections.Generic;


namespace WebWomen.Services
{
    public class nmberstuto
    {

        public List<int> numbers1()
        {
            List<int> numbers = new List<int>();
            // Creating and initializing a variable
            int num = 3;

            // Accessing the variable
            //Console.WriteLine(num);
            numbers.Add(num);
            // Updating the value
            num = 7;
            numbers.Add(num);
            // Printing updated value
            //Console.WriteLine(num);
          
            numbers.Add(num);
            return numbers;
        }
    }
}
