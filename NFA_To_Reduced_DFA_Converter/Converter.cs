using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using NFA_To_Reduced_DFA_Converter.MyLibrary;

namespace NFA_To_Reduced_DFA_Converter
{
    public class Converter
    {
        private static string epsilon = "epsilon";    // epsilon input
        private static Set undefined = new Set();     // undefined state


        //***************************** Convert NFA to DFA *****************************//
        public static DFA NFA_To_DFA(NFA nfa)
        {
            // State의 Epsilon-Closure를 미리 구해두기
            var closure = new EpsilonClosureTable().Construct(nfa);


            // Initialization
            var startStateSet = closure.Get(nfa.q0);
            var stateSetList = new List<Set> { startStateSet };
            var stateRenaming = new StateRenaming { { startStateSet, "S0" } };
            var dfa = new DFA
            {
                Q = new Set { stateRenaming[startStateSet] },
                Sigma = nfa.Sigma.Difference(new Set { epsilon }),
                delta = new Map2D(),
                q0 = stateRenaming[startStateSet],
                F = nfa.F.Intersect(startStateSet).Empty() ? new Set() : new Set { stateRenaming[startStateSet] }
            };


            // Construct DFA
            for (int i = 0; i < stateSetList.Count; i++)
            {
                var currStateSet = stateSetList[i];

                foreach (var input in dfa.Sigma)
                {
                    var nextStateSet = new Set();

                    foreach (var state in currStateSet) nextStateSet.UnionWith(closure.Get(nfa.delta[state, input]));

                    if (nextStateSet != undefined)
                    {
                        if (!stateRenaming.ContainsKey(nextStateSet))
                        {
                            stateSetList.Add(nextStateSet);

                            stateRenaming[nextStateSet] = "S" + (stateSetList.Count - 1).ToString();
                            dfa.Q.Add(stateRenaming[nextStateSet]);

                            if (!nfa.F.Intersect(nextStateSet).Empty()) dfa.F.Add(stateRenaming[nextStateSet]);  // Final State Checking
                        }
                    }

                    dfa.delta[stateRenaming[currStateSet], input] = new Set { stateRenaming[nextStateSet] };
                }
            }
            return dfa;
        }

        public class EpsilonClosureTable : AbstractEpsilonClosureTable
        {
            public Set Get(string state) => Get(new Set { state });
            public Set Get(Set stateSet)
            {
                Set result = new Set();
                foreach (var state in stateSet) result.UnionWith(this[state]);
                return result;
            }

            public EpsilonClosureTable Construct(NFA nfa)
            {
                var visit = new Set();
                foreach (var state in nfa.Q) DFS(state, visit, nfa);
                return this;
            }

            private void DFS(string currState, Set visit, NFA nfa)
            {
                if (visit.Contains(currState)) return;

                visit.Add(currState);
                this[currState].Add(currState);

                foreach (var nextState in nfa.delta[currState, epsilon])
                {
                    DFS(nextState, visit, nfa);
                    this[currState].UnionWith(this[nextState]);
                }
            }
        }



        //***************************** Reduced DFA (Minimization DFA) *****************************//
        public static DFA Reduced_DFA(DFA dfa)
        {
            // Divide to final or nonfinal
            var fStateSet = dfa.F.Copy();
            var nStateSet = dfa.Q.Copy().Difference(fStateSet);


            // State Partiton
            var stateSetList = new List<Set> { fStateSet, nStateSet };

            while (true)   // 더 이상 Partition이 일어나지 않을 때까지 반복  
            {
                var result = StatePartiton(stateSetList, dfa);
                if (stateSetList.SequenceEqual(result)) break;
                stateSetList = result;
            }


            // State Renaming and Create Reduced DFA Object
            DFA reduced_dfa = new DFA { Sigma = dfa.Sigma.Copy(), q0 = "S0" };
            var stateRenaming = new StateRenaming();
            var stateNumbering = 0;

            foreach (var stateSet in stateSetList)
            {
                if (stateRenaming.ContainsKey(stateSet)) continue;

                stateRenaming[stateSet] = stateSet.Contains(dfa.q0) ? "S0" : "S" + (++stateNumbering).ToString();
                reduced_dfa.Q.Add(stateRenaming[stateSet]);

                if (!dfa.F.Intersect(stateSet).Empty()) reduced_dfa.F.Add(stateRenaming[stateSet]);

                if (stateSet.Count > 1)
                    foreach (var state in stateSet) stateRenaming[new Set { state }] = stateRenaming[stateSet];
            }

            foreach (var currStateSet in stateSetList)
            {
                foreach (var input in dfa.Sigma)
                {
                    var nextStateSet = new Set();

                    foreach (var state in currStateSet) nextStateSet.UnionWith(dfa.delta[state, input]);

                    reduced_dfa.delta[stateRenaming[currStateSet], input] = new Set { stateRenaming[nextStateSet] };
                }
            }

            return reduced_dfa;
        }

        private static List<Set> StatePartiton(List<Set> stateSetList, DFA dfa)
        {
            var result = new List<Set>();
            var stateToGroup = new StateToGroup();

            for (int i = 0; i < stateSetList.Count; i++)
                foreach (var state in stateSetList[i]) stateToGroup[new Set { state }] = "G" + i.ToString();

            foreach (var stateSet in stateSetList)
                result.AddRange(Sub_StatePartiton(stateSet, dfa.Sigma.GetEnumerator(), dfa, stateToGroup));

            return result;
        }

        private static List<Set> Sub_StatePartiton(Set stateSet, Set.Enumerator input, DFA dfa, StateToGroup stateToGroup)
        {
            if (!input.MoveNext()) return new List<Set> { stateSet };

            var result = new List<Set>();
            var groupToState = new GroupToState();

            foreach (var state in stateSet)
                groupToState[stateToGroup[dfa.delta[state, input.Current]]].Add(state);

            if (groupToState.Count > 1)  // input에 의해 state들이 distinguish되는 경우 partition해야 한다
            {
                foreach (var partedStates in groupToState.Values)
                    result.AddRange(Sub_StatePartiton(partedStates, input, dfa, stateToGroup));
            }
            else result.AddRange(Sub_StatePartiton(stateSet, input, dfa, stateToGroup));

            return result;
        }
    }
}
