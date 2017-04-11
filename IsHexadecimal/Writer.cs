using System;

namespace IsHexadecimal
{
    public class Writer
    {
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Write(message);
        }

        public static void Ok(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Write(message);
        }

        public static void Neutral(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Write(message);
        }

        private static void Write(string message)
        {
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}