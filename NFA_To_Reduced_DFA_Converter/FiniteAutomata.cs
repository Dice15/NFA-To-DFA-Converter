using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using NFA_To_Reduced_DFA_Converter.MyLibrary;

namespace NFA_To_Reduced_DFA_Converter
{
    public class FiniteAutomata
    {
        public Set Q = new Set();                 // finite, non-empty set of states
        public Set Sigma = new Set();             // finite input alphabet
        public Map2D delta = new Map2D();         // mapping function
        public string q0 = "";                    // start(or initial) state
        public Set F = new Set();                 // set of final states

        public FiniteAutomata() { }
        public FiniteAutomata(Set Q, Set Sigma, Map2D delta, string q0, Set F) : this() { this.Q = Q; this.Sigma = Sigma; this.delta = delta; this.q0 = q0; this.F = F; }
    }

    public class NFA : FiniteAutomata
    {
        public NFA() : base() { }
        public NFA(Set Q, Set Sigma, Map2D delta, string q0, Set F) : base(Q, Sigma, delta, q0, F) { }
    }

    public class DFA : FiniteAutomata
    {
        public DFA() : base() { }
        public DFA(Set Q, Set Sigma, Map2D delta, string q0, Set F) : base(Q, Sigma, delta, q0, F) { }
    }
}
