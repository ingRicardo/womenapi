using System;
using System.Text;

namespace WebWomen.Services
{
    public class Recursion
    {

        public static void PrintHello(int n, StringBuilder sb)
        {
            // Base Case
            if (n == 0) return;
 
            sb.AppendLine("Hello");

            PrintHello(n - 1, sb);
        }

        public static void F(int n, StringBuilder sb)
        {
            sb.AppendLine($"F({n})'s Stack Frame Pushed");

            if (n > 1)
            {
                F(n - 1, sb);
                F(n - 1, sb);
            }

            sb.AppendLine($"F({n})'s Stack Frame Removed");
        }
    }
}
