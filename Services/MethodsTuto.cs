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


    }
}
