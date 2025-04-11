namespace Dream_Team
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            button1 = new Button();
            label6 = new Label();
            label8 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(864, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 45);
            label1.TabIndex = 1;
            label1.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(864, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 45);
            label2.TabIndex = 2;
            label2.Text = "Score List";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(823, 246);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(608, 374);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(823, 636);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 45);
            label3.TabIndex = 4;
            label3.Text = "Total";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 357);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(676, 387);
            button1.TabIndex = 5;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1170, 75);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 37);
            label6.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1152, 636);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 37);
            label8.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(29, 357);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(676, 387);
            button2.TabIndex = 9;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 231);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(675, 66);
            textBox1.TabIndex = 10;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 62);
            label5.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 65);
            label4.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(462, 79);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 62);
            label9.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(726, 708);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(640, 32);
            label7.TabIndex = 15;
            label7.Text = "*After typing the correct answer, press the Enter key.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 793);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Button button1;
        private Label label6;
        private Label label8;
        private Button button2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label7;
    }
}