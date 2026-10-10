namespace WebWomen.Services
{
    public class MethodsTuto
    {

        // Instance method to display a message
        public string DisplayMessage()
        {
            string message = "Hello from the Display " + "Message method!";
             
            return message;
        }
        // Static method to calculate square of a number
        public static int Square(int number)
        {
            // Return the square of the number
            return number * number;
        }


        // value parameter
        public static string  Display(int x)
        {
            //Console.WriteLine("Value Parameter: " + x);
            return "Value Parameter: " + x; 
        }

        // reference parameter
        public static string Update(ref int y)
        {
            // Modify the original variable
            y += 5;
            //Console.WriteLine("Reference Parameter: " + y);
            return "Reference Parameter: " + y;
        }

        // output parameter
        public static void GetValues(out int z)
        {
            // Assign value to output parameter
            z = 20;
            //Console.WriteLine("Output Parameter: " + z);
        }


    }
}
