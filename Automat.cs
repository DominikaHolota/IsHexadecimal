using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsHexadecimal {
    public class Automat {
        private readonly List<string> _States = new List<string> ();
        private readonly List<char> _Alphabet = new List<char> ();
        private readonly List<Transition> _TransitionTable = new List<Transition> ();
        private string _S0;
        private readonly List<string> _SF = new List<string> ();

        public Automat (List<string> states, List<char> alphabet, List<Transition> transitionTable, string s0, List<string> sF) {
            _States = states.ToList ();
            _Alphabet = alphabet.ToList ();

            _TransitionTable = transitionTable.ToList ();
            _S0 = s0;
            _SF = sF.ToList ();

        }

        public void Accepts (string input) {
            Writer.Neutral ("Testing: " + input);
            var currentState = _S0;
            var steps = new StringBuilder ();

            if (testAlfabet (input)) {

                foreach (var symbol in input.ToCharArray ()) {

                    var transition = _TransitionTable.Find (t => t.StartState == currentState &&
                        t.Symbol == symbol);

                    try { currentState = transition.EndState; } catch {
                        Writer.Error ("Stopped. Invalid input.");
                        return;
                    }
                    steps.Append (transition + "\n");
                }
                if (_SF.Contains (currentState)) {
                    Writer.Ok ("Accepted. Following steps:\n" + steps);
                    return;
                }
                Writer.Error ("Stopped, not accepted. " + currentState +
                    " is not a final state.");
                Writer.Error (steps.ToString ());

            }

        }

        public bool testAlfabet (string input) {

            foreach (var symbol in input.ToCharArray ().Where (symbol => !_Alphabet.Contains (symbol))) {
                Writer.Error ("Symbol:  " + symbol + " is not a valid part of the tested input.");
                return false;
            }
            return true;
        }

    }
}