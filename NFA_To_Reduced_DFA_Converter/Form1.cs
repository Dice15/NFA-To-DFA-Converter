using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using NFA_To_Reduced_DFA_Converter.MyLibrary;

namespace NFA_To_Reduced_DFA_Converter
{
    public partial class Form1 : Form
    {
        public Form1()  // key word 입력 불가 : epsilon, undefined
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Q.Text = "";
            textBox_Sigma.Text = "";
            dataGridView_delta.Rows.Clear();
            textBox_q0.Text = "";
            textBox_F.Text = "";

            //Example1();  // NFA -> Reduced DFA
            //Example2();  // NFA -> Reduced DFA (inaccessible state is exsit)
            //Example3();  // NFA -> Reduced DFA (epsilon input is exsit)
            //Example4();  // DFA -> Reduced DFA (중간고사 기출 문제)
            //Example5();  // NFA -> Reduced DFA (중간고사 기출 문제)
            //Example6();  // NFA -> Reduced DFA (예제1)
            //Example7();  // NFA -> Reduced DFA (예제2)
        }


        private void button_Converter_Click(object sender, EventArgs e)
        {
            // empty check
            if (textBox_Q.Text == "" || textBox_Sigma.Text == "" || dataGridView_delta.Rows.Count == 1 || textBox_q0.Text == "" || textBox_F.Text == "")
            {
                MessageBox.Show("빈칸이 있습니다!!");
                return;
            }

            NFA nfa = new NFA();

            foreach (var item in TextSpilt(textBox_Q.Text)) nfa.Q.Add(item);
            foreach (var item in TextSpilt(textBox_Sigma.Text)) nfa.Sigma.Add(item);
            foreach (DataGridViewRow row in dataGridView_delta.Rows)
            {
                if (row.Cells["state"].Value == null || row.Cells["input"].Value == null || row.Cells["result"].Value == null) continue;

                string state = TextSpilt(row.Cells["state"].Value.ToString())[0];
                string input = TextSpilt(row.Cells["input"].Value.ToString())[0];
                Set nextState = new Set();
                foreach (var item in TextSpilt(row.Cells["result"].Value.ToString())) nextState.Add(item);

                nfa.delta[state, input] = nextState;
            }

            if (textBox_q0.Text != "") nfa.q0 = TextSpilt(textBox_q0.Text)[0];
            foreach (var item in TextSpilt(textBox_F.Text)) nfa.F.Add(item);

            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA reduced_dfa = Converter.Reduced_DFA(dfa);


            Form2 form2 = new Form2(reduced_dfa);
            form2.Show();
        }
  

        private void WriteExample(NFA nfa)
        {
            textBox_Q.Text = "";
            textBox_Sigma.Text = "";
            dataGridView_delta.Rows.Clear();
            textBox_q0.Text = "";
            textBox_F.Text = "";

            foreach (var item in nfa.Q) textBox_Q.Text += textBox_Q.Text == "" ? item : ", " + item;
            foreach (var item in nfa.Sigma) textBox_Sigma.Text += textBox_Sigma.Text == "" ? item : ", " + item;
            foreach(var state in nfa.delta.Keys)
            {
                foreach (var input in nfa.delta[state].Keys)
                {
                    string[] row = new string[] { state.ToStr(), input, nfa.delta[state, input].ToStr() };
                    dataGridView_delta.Rows.Add(row);
                }
            }
            textBox_q0.Text = nfa.q0;
            foreach (var item in nfa.F) textBox_F.Text += textBox_F.Text == "" ? item : ", " + item;
        }

        private void button_ex1_Click(object sender, EventArgs e)
        {
            NFA nfa = new NFA
            {
                Q = new Set { "p", "q", "r" },
                Sigma = new Set { "a", "b" },
                delta = new Map2D()
                {
                    ["p", "a"] = new Set { "q", "r" },
                    ["p", "b"] = new Set { "q" },
                    ["q", "b"] = new Set { "p" },
                    ["r", "a"] = new Set { "p" },
                    ["r", "b"] = new Set { "p", "r" },
                },
                q0 = "p",
                F = new Set { "r" }
            };
            WriteExample(nfa);
        }

        private void button_ex2_Click(object sender, EventArgs e)
        {
            NFA nfa = new NFA
            {
                Q = new Set { "A", "B", "C", "D", "E", "F" },
                Sigma = new Set { "a", "b" },
                delta = new Map2D()
                {
                    ["A", "a"] = new Set { "F" },
                    ["A", "b"] = new Set { "B" },
                    ["B", "a"] = new Set { "E" },
                    ["B", "b"] = new Set { "D" },
                    ["C", "a"] = new Set { "C" },
                    ["C", "b"] = new Set { "F" },
                    ["D", "a"] = new Set { "D" },
                    ["D", "b"] = new Set { "A" },
                    ["E", "a"] = new Set { "B" },
                    ["E", "b"] = new Set { "C" },
                    ["F", "a"] = new Set { "A" },
                    ["F", "b"] = new Set { "E" },
                },
                q0 = "A",
                F = new Set { "A", "F" }
            };

            WriteExample(nfa);
        }

        private void button_ex3_Click(object sender, EventArgs e)
        {
            NFA nfa = new NFA
            {
                Q = new Set { "A", "B", "C", "D", "E", "F" },
                Sigma = new Set { "0", "1" },
                delta = new Map2D()
                {
                    ["A", "0"] = new Set { "B" },
                    ["A", "1"] = new Set { "C" },
                    ["B", "0"] = new Set { "E" },
                    ["B", "1"] = new Set { "F" },
                    ["C", "0"] = new Set { "A" },
                    ["C", "1"] = new Set { "A" },
                    ["D", "0"] = new Set { "F" },
                    ["D", "1"] = new Set { "E" },
                    ["E", "0"] = new Set { "D" },
                    ["E", "1"] = new Set { "F" },
                    ["F", "0"] = new Set { "D" },
                    ["F", "1"] = new Set { "E" },
                },
                q0 = "A",
                F = new Set { "E", "F" }
            };

            WriteExample(nfa);
        }


        private void button_ex4_Click(object sender, EventArgs e)
        {
            NFA nfa = new NFA
            {
                Q = new Set { "1", "2", "3", "4" },
                Sigma = new Set { "epsilon", "a", "b", "c" },
                delta = new Map2D()
                {
                    ["1", "epsilon"] = new Set { "3" },
                    ["1", "a"] = new Set { "2" },
                    ["2", "b"] = new Set { "4" },
                    ["3", "epsilon"] = new Set { "4" },
                    ["3", "c"] = new Set { "3" }
                },
                q0 = "1",
                F = new Set { "4" }
            };

            WriteExample(nfa);
        }


        //*********************** 편의성 메서드 ****************************//

        private void ShowMessageBox(object obj)
        {
            MessageBox.Show(obj.ToString());
        }

        private string[] TextSpilt(string text)
        {
            return text.Split(new char[] { ' ', ',', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
        }


        //*********************** Test Example Code ****************************//

        public void Example1()
        {
            Set Q = new Set { "q0", "q1", "q2", "q3", "qf" };
            Set Sigma = new Set { "0", "1" };
            Map2D delta = new Map2D()
            {
                ["q0", "0"] = new Set { "q1", "q2" },
                ["q0", "1"] = new Set { "q1", "q3" },
                ["q1", "0"] = new Set { "q1", "q2" },
                ["q1", "1"] = new Set { "q1", "q3" },
                ["q2", "0"] = new Set { "qf" },
                ["q3", "1"] = new Set { "qf" },
                ["qf", "0"] = new Set { "qf" },
                ["qf", "1"] = new Set { "qf" }
            };
            string q0 = "q0";
            Set F = new Set { "qf" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }


        public void Example2()
        {
            Set Q = new Set { "q0", "q1"};
            Set Sigma = new Set { "0", "1" };
            Map2D delta = new Map2D()
            {
                ["q0", "0"] = new Set { "q0", "q1" },
                ["q0", "1"] = new Set { "q0" },
                ["q1", "0"] = new Set { },
                ["q1", "1"] = new Set { "q0", "q1" }
            };
            string q0 = "q0";
            Set F = new Set { "q1" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }


        public void Example3()
        {
            Set Q = new Set { "1", "2", "3", "4" };
            Set Sigma = new Set { "epsilon", "a", "b", "c" };
            Map2D delta = new Map2D()
            {
                ["1", "epsilon"] = new Set { "3" },
                ["1", "a"] = new Set { "2" },
                ["2", "b"] = new Set { "4" },
                ["3", "epsilon"] = new Set { "4" },
                ["3", "c"] = new Set { "3" }
            };
            string q0 = "1";
            Set F = new Set { "4" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }


        public void Example4()
        {
            Set Q = new Set { "A", "B", "C", "D", "E" };
            Set Sigma = new Set { "a", "b" };
            Map2D delta = new Map2D()
            {
                ["A", "a"] = new Set { "C" },
                ["A", "b"] = new Set { "B" },
                ["B", "b"] = new Set { "A" },
                ["C", "a"] = new Set { "A" },
                ["C", "b"] = new Set { "D" },
                ["D", "a"] = new Set { "E" },
                ["D", "b"] = new Set { "E" },
                ["E", "a"] = new Set { "E" },
                ["E", "b"] = new Set { "E" },
            };
            string q0 = "A";
            Set F = new Set { "C", "D", "E" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }


        public void Example5()
        {
            Set Q = new Set { "p", "q", "r" };
            Set Sigma = new Set { "a", "b" };
            Map2D delta = new Map2D()
            {
                ["p", "a"] = new Set { "q", "r" },
                ["p", "b"] = new Set { "q" },
                ["q", "b"] = new Set { "p" },
                ["r", "a"] = new Set { "p" },
                ["r", "b"] = new Set { "p", "r" },
            };
            string q0 = "p";
            Set F = new Set { "r" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }


        public void Example6()
        {
            Set Q = new Set { "A", "B", "C", "D", "E", "F" };
            Set Sigma = new Set { "a", "b" };
            Map2D delta = new Map2D()
            {
                ["A", "a"] = new Set { "F" },
                ["A", "b"] = new Set { "B" },
                ["B", "a"] = new Set { "E" },
                ["B", "b"] = new Set { "D" },
                ["C", "a"] = new Set { "C" },
                ["C", "b"] = new Set { "F" },
                ["D", "a"] = new Set { "D" },
                ["D", "b"] = new Set { "A" },
                ["E", "a"] = new Set { "B" },
                ["E", "b"] = new Set { "C" },
                ["F", "a"] = new Set { "A" },
                ["F", "b"] = new Set { "E" },
            };
            string q0 = "A";
            Set F = new Set { "A", "F" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }


        public void Example7()
        {
            Set Q = new Set { "A", "B", "C", "D", "E", "F" };
            Set Sigma = new Set { "0", "1" };
            Map2D delta = new Map2D()
            {
                ["A", "0"] = new Set { "B" },
                ["A", "1"] = new Set { "C" },
                ["B", "0"] = new Set { "E" },
                ["B", "1"] = new Set { "F" },
                ["C", "0"] = new Set { "A" },
                ["C", "1"] = new Set { "A" },
                ["D", "0"] = new Set { "F" },
                ["D", "1"] = new Set { "E" },
                ["E", "0"] = new Set { "D" },
                ["E", "1"] = new Set { "F" },
                ["F", "0"] = new Set { "D" },
                ["F", "1"] = new Set { "E" },
            };
            string q0 = "A";
            Set F = new Set { "E", "F" };

            NFA nfa = new NFA(Q, Sigma, delta, q0, F);
            DFA dfa = Converter.NFA_To_DFA(nfa);
            DFA red = Converter.Reduced_DFA(dfa);

            Form2 form2 = new Form2(red);
            form2.Show();
        }
    }
}
