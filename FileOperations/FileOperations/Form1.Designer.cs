namespace FileOperations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 142);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Product Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 276);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 1;
            label2.Text = "Unit Price: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 214);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 2;
            label3.Text = "Amount: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 440);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 3;
            label4.Text = "Total: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(311, 433);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(795, 158);
            button1.Name = "button1";
            button1.Size = new Size(176, 72);
            button1.TabIndex = 8;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(795, 302);
            button2.Name = "button2";
            button2.Size = new Size(176, 64);
            button2.TabIndex = 9;
            button2.Text = "Record";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Orange", "Apple", "Tomatoe", "Potatoe", "Banana" });
            comboBox1.Location = new Point(311, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Choose Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 214);
            label5.Name = "label5";
            label5.Size = new Size(42, 32);
            label5.TabIndex = 11;
            label5.Text = "Kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 280);
            label6.Name = "label6";
            label6.Size = new Size(68, 32);
            label6.TabIndex = 12;
            label6.Text = "Zloty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 440);
            label7.Name = "label7";
            label7.Size = new Size(68, 32);
            label7.TabIndex = 13;
            label7.Text = "Zloty";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Location = new Point(126, 354);
            button3.Name = "button3";
            button3.Size = new Size(491, 46);
            button3.TabIndex = 14;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1056, 672);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
    }
}
