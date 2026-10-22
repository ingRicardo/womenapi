using System.Text;

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


            // StringBuilder in C#
            // StringBuilder is a mutable sequence of characters provided by the System.Text namespace in C#.
            lt.Add(" ==== STRING BUILDER ===");
            StringBuilder sb = new StringBuilder("Riky");
            lt.Add("Initial StringBuilder: " + sb);
            sb.Append(" is awesome!");
            lt.Add("After append: " + sb);


            //StringBuilder Constructors
            // different constructors of StringBuilder.
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Hello");
            lt.Add("sb1: " + sb1);

            StringBuilder sb2 = new StringBuilder(50);
            sb2.Append("Initial capacity is 50");
            lt.Add("sb2: " + sb2);

            StringBuilder sb3 = new StringBuilder("Rik");
            sb3.Append("Mac");
            lt.Add("sb3: " + sb3);
            StringBuilder sb4 = new StringBuilder("C#", 30);
            sb4.Append(" Programming");
            lt.Add("sb4: " + sb4);

            //Capacity and Length of StringBuilder

            StringBuilder sbNew = new StringBuilder(20);

            sbNew.Append("RikyMacOlv");
            lt.Add("Initial StringBuilder: " + sbNew);

            lt.Add("Capacity: " + sbNew.Capacity);
            lt.Add("Length: " + sbNew.Length);

            sbNew.Append(" Programming");

            lt.Add("Updated Length: " + sbNew.Length);

            //Commonly Used Methods in StringBuilder
            StringBuilder sbC= new StringBuilder("GeeksForGeeks");

            lt.Add("Initial: " + sbC);

            sbC.Append(" C#");
            lt.Add("After append: " + sbC);

            sbC.Insert(13, " Programming");
            lt.Add("After insert: " + sbC);

            sbC.Replace("C#", "CSharp");
            lt.Add("After replace: " + sbC);

            sbC.Remove(13, 12);
            lt.Add("After remove: " + sbC);

            sbC.Append("123");

            char[] chars = sbC.ToString().ToCharArray();
            Array.Reverse(chars);
            sbC = new StringBuilder(new string(chars));

            lt.Add("After reverse: " + sbC);
            lt.Add("Capacity: " + sbC.Capacity);
            lt.Add("Length: " + sbC.Length);
            lt.Add("Character at index 0: " + sbC[0]);

            sbC[0] = 'X';
            lt.Add("After character update: " + sbC);

            lt.Add("Index of 's': " + sbC.ToString().IndexOf('s'));

            string resultC = sbC.ToString();
            lt.Add("Final String: " + resultC);
       



            return lt;
        }


    }
}
