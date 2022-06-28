namespace NFA_To_Reduced_DFA_Converter
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_delta = new System.Windows.Forms.DataGridView();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.textBox_q0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Sigma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_delta
            // 
            this.dataGridView_delta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_delta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_delta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_delta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_delta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.state,
            this.input,
            this.result});
            this.dataGridView_delta.Location = new System.Drawing.Point(59, 193);
            this.dataGridView_delta.Name = "dataGridView_delta";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView_delta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_delta.RowTemplate.Height = 30;
            this.dataGridView_delta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_delta.Size = new System.Drawing.Size(445, 376);
            this.dataGridView_delta.TabIndex = 31;
            // 
            // state
            // 
            this.state.FillWeight = 25F;
            this.state.HeaderText = "state";
            this.state.Name = "state";
            // 
            // input
            // 
            this.input.FillWeight = 25F;
            this.input.HeaderText = "input";
            this.input.Name = "input";
            // 
            // result
            // 
            this.result.FillWeight = 75F;
            this.result.HeaderText = "result";
            this.result.Name = "result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(25, 645);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "F";
            // 
            // textBox_F
            // 
            this.textBox_F.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_F.Location = new System.Drawing.Point(56, 641);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(445, 32);
            this.textBox_F.TabIndex = 29;
            // 
            // textBox_q0
            // 
            this.textBox_q0.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_q0.Location = new System.Drawing.Point(56, 587);
            this.textBox_q0.Name = "textBox_q0";
            this.textBox_q0.Size = new System.Drawing.Size(445, 32);
            this.textBox_q0.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(19, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "q0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(21, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "δ";
            // 
            // textBox_Sigma
            // 
            this.textBox_Sigma.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sigma.Location = new System.Drawing.Point(59, 142);
            this.textBox_Sigma.Name = "textBox_Sigma";
            this.textBox_Sigma.Size = new System.Drawing.Size(445, 32);
            this.textBox_Sigma.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Σ";
            // 
            // textBox_Q
            // 
            this.textBox_Q.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Q.Location = new System.Drawing.Point(59, 91);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(445, 32);
            this.textBox_Q.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(148, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "Reduced DFA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 712);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_delta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_F);
            this.Controls.Add(this.textBox_q0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Sigma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Reduced DFA";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_delta;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn input;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.TextBox textBox_q0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Sigma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}