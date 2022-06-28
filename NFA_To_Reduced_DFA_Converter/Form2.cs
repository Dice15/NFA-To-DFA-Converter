using System;
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
    public partial class Form2 : Form
    {
        private DFA reduced_dfa = new DFA();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DFA data)
        {
            InitializeComponent();
            reduced_dfa = data; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WriteDFA(reduced_dfa);
        }

        private void WriteDFA(DFA dfa)
        {
            textBox_Q.Text = "";
            textBox_Sigma.Text = "";
            dataGridView_delta.Rows.Clear();
            textBox_q0.Text = "";
            textBox_F.Text = "";

            foreach (var item in dfa.Q) textBox_Q.Text += textBox_Q.Text == "" ? item : ", " + item;
            foreach (var item in dfa.Sigma) textBox_Sigma.Text += textBox_Sigma.Text == "" ? item : ", " + item;
            foreach (var state in dfa.delta.Keys)
            {
                foreach (var input in dfa.delta[state].Keys)
                {
                    string[] row = new string[] { state.ToStr(), input, dfa.delta[state, input].ToStr() };

                    if (row[2] == "") row[2] = "undefined";

                    dataGridView_delta.Rows.Add(row);
                }
            }
            textBox_q0.Text = dfa.q0;
            foreach (var item in dfa.F) textBox_F.Text += textBox_F.Text == "" ? item : ", " + item;
        }
    }
}
