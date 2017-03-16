using System;
using System.Collections.Generic;

namespace IsHexadecimal {
    internal class Program {
        private static void Main (string[] args) {
            var States = new List<string> { "s0", "s1", "s2","s3" };
            var Alphabet = new List<char> { '0','x','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f' };
            var TransitionTable = new List<Transition> {
                new Transition ("s0", '0', "s1"),
                new Transition ("s1", 'x', "s2"),
                new Transition ("s2", 'a', "s3"),
                new Transition ("s2", 'b', "s3"),
                new Transition ("s2", 'c', "s3"),
                new Transition ("s2", 'd', "s3"),
                new Transition ("s2", 'e', "s3"),
                new Transition ("s2", 'f', "s3"),
                new Transition ("s2", '1', "s3"),
                new Transition ("s2", '2', "s3"),
                new Transition ("s2", '3', "s3"),
                new Transition ("s2", '4', "s3"),
                new Transition ("s2", '5', "s3"),
                new Transition ("s2", '6', "s3"),
                new Transition ("s2", '7', "s3"),
                new Transition ("s2", '8', "s3"),
                new Transition ("s2", '9', "s3"),
                new Transition ("s2", '0', "s3"),
                new Transition ("s3", 'a', "s3"),
                new Transition ("s3", 'b', "s3"),
                new Transition ("s2", 'c', "s3"),
                new Transition ("s3", 'd', "s3"),
                new Transition ("s3", 'e', "s3"),
                new Transition ("s3", 'f', "s3"),
                new Transition ("s3", '1', "s3"),
                new Transition ("s3", '2', "s3"),
                new Transition ("s3", '3', "s3"),
                new Transition ("s3", '4', "s3"),
                new Transition ("s3", '5', "s3"),
                new Transition ("s3", '6', "s3"),
                new Transition ("s3", '7', "s3"),
                new Transition ("s3", '8', "s3"),
                new Transition ("s3", '9', "s3"),
                new Transition ("s3", '0', "s3")

            };
            var S0 = "s0";
            var SF = new List<string> { "s0", "s3" };
            var isValid = new Automat (States, Alphabet, TransitionTable, S0, SF);

            Run (isValid);

        }

        public static void Run (Automat isValid) {
            Console.WriteLine ("Give your input: ");
            isValid.Accepts (Console.ReadLine ().ToLower());
            Console.WriteLine ("Another input to test? Hit 'y' to re-run machine.");
            while (Console.ReadKey ().Key == ConsoleKey.Y) {
                Console.WriteLine ("\n");
                Run (isValid);
            }
        }
    }
}