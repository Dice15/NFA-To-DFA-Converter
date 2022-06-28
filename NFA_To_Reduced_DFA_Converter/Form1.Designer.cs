namespace NFA_To_Reduced_DFA_Converter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Sigma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_q0 = new System.Windows.Forms.TextBox();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_delta = new System.Windows.Forms.DataGridView();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_ex1 = new System.Windows.Forms.Button();
            this.button_ex3 = new System.Windows.Forms.Button();
            this.button_ex2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ex4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Q";
            // 
            // textBox_Q
            // 
            this.textBox_Q.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Q.Location = new System.Drawing.Point(55, 111);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(445, 32);
            this.textBox_Q.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(17, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Σ";
            // 
            // textBox_Sigma
            // 
            this.textBox_Sigma.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Sigma.Location = new System.Drawing.Point(55, 162);
            this.textBox_Sigma.Name = "textBox_Sigma";
            this.textBox_Sigma.Size = new System.Drawing.Size(445, 32);
            this.textBox_Sigma.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "δ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(15, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "q0";
            // 
            // textBox_q0
            // 
            this.textBox_q0.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_q0.Location = new System.Drawing.Point(52, 607);
            this.textBox_q0.Name = "textBox_q0";
            this.textBox_q0.Size = new System.Drawing.Size(445, 32);
            this.textBox_q0.TabIndex = 7;
            // 
            // textBox_F
            // 
            this.textBox_F.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_F.Location = new System.Drawing.Point(52, 661);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(445, 32);
            this.textBox_F.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(21, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(619, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "ex) q0, q1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(619, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "ex) 0, 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(619, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 84);
            this.label8.TabIndex = 12;
            this.label8.Text = "ex)\r\nstate      input      result\r\nq0         0          q1, q2\r\nq0         1    " +
    "      q1, q3, q4";
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
            this.dataGridView_delta.Location = new System.Drawing.Point(55, 213);
            this.dataGridView_delta.Name = "dataGridView_delta";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView_delta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_delta.RowTemplate.Height = 30;
            this.dataGridView_delta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_delta.Size = new System.Drawing.Size(445, 376);
            this.dataGridView_delta.TabIndex = 13;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(619, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "ex) q0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(619, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "ex) q3, q4";
            // 
            // button_ex1
            // 
            this.button_ex1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ex1.Location = new System.Drawing.Point(55, 30);
            this.button_ex1.Name = "button_ex1";
            this.button_ex1.Size = new System.Drawing.Size(96, 50);
            this.button_ex1.TabIndex = 16;
            this.button_ex1.Text = "예제1";
            this.button_ex1.UseVisualStyleBackColor = true;
            this.button_ex1.Click += new System.EventHandler(this.button_ex1_Click);
            // 
            // button_ex3
            // 
            this.button_ex3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ex3.Location = new System.Drawing.Point(289, 30);
            this.button_ex3.Name = "button_ex3";
            this.button_ex3.Size = new System.Drawing.Size(96, 50);
            this.button_ex3.TabIndex = 17;
            this.button_ex3.Text = "예제3";
            this.button_ex3.UseVisualStyleBackColor = true;
            this.button_ex3.Click += new System.EventHandler(this.button_ex3_Click);
            // 
            // button_ex2
            // 
            this.button_ex2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ex2.Location = new System.Drawing.Point(174, 30);
            this.button_ex2.Name = "button_ex2";
            this.button_ex2.Size = new System.Drawing.Size(96, 50);
            this.button_ex2.TabIndex = 18;
            this.button_ex2.Text = "예제2";
            this.button_ex2.UseVisualStyleBackColor = true;
            this.button_ex2.Click += new System.EventHandler(this.button_ex2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(510, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 582);
            this.button1.TabIndex = 20;
            this.button1.Text = "변환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Converter_Click);
            // 
            // button_ex4
            // 
            this.button_ex4.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ex4.Location = new System.Drawing.Point(404, 30);
            this.button_ex4.Name = "button_ex4";
            this.button_ex4.Size = new System.Drawing.Size(96, 50);
            this.button_ex4.TabIndex = 21;
            this.button_ex4.Text = "예제4";
            this.button_ex4.UseVisualStyleBackColor = true;
            this.button_ex4.Click += new System.EventHandler(this.button_ex4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 721);
            this.Controls.Add(this.button_ex4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_ex2);
            this.Controls.Add(this.button_ex3);
            this.Controls.Add(this.button_ex1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView_delta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_F);
            this.Controls.Add(this.textBox_q0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Sigma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Converter (NFA -> Reduced DFA)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_q0;
        private System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Sigma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_delta;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn input;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_ex1;
        private System.Windows.Forms.Button button_ex3;
        private System.Windows.Forms.Button button_ex2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ex4;
    }
}

