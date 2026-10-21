namespace WebWomen.Services
{
    public class StringTutorial
    {

        /*
         * 
         * A String is an object used to store a sequence of characters enclosed in double quotes.
         * It belongs to the System namespace and is represented by the String class.
            Strings are immutable, meaning their value cannot be changed after creation
            Provides various methods for manipulating, comparing, searching, and concatenating strings.
         * 
         */
        public static List<object> stringbasictuto()
        {
            List<object> lt = new List<object>();

            // Creating a string using the new keyword
            string str = new string("Geeks".ToCharArray());

            lt.Add(str);

            string str1 = "Hello";

            //Immutable String
            string result = string.Concat(str1, " World");

            lt.Add(str1);
            lt.Add(result);

            /*
             * In C#, a verbatim string literal is created by prefixing a string with the @ symbol. It allows backslashes 
             * and line breaks to be included in a string without interpreting backslashes as escape sequences.
                No Escape Sequences: Backslashes (\) are treated as literal characters instead of escape sequences.
                Multi-line Strings: Strings can span multiple lines while preserving line breaks and indentation.
             * 
             **/
            // Using a verbatim string for a file path
            string str3 = @"C:\Users";
            lt.Add("File Path: " + str3);
            // Using double quotes inside a verbatim
            string str4 = @"Hello ""Geeks"" ";
            Console.WriteLine("Using Double Quotes: " + str4);

            // Using a multi-line verbatim strin
            string str5 = @" 
                This is 
                multi line 
                String";
            Console.WriteLine("Multi Line: " + str5);

            //  @ Symbol: Verbatim Identifiers

            string[] @for = { "C#", "Java", "Python" };

            foreach (string @class in @for)
            {
                lt.Add(@class);
            }


            return lt;
        }


    }
}
