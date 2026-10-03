using System;

namespace WebWomen.Services
{
    public class ReturnDelegateDemo
    {

        public delegate int Operation(int x, int y);

        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;


    }
}
