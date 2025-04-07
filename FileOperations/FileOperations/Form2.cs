using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FileOperations
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ProductList.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while(!sr.EndOfStream)
            {
                listBox1.Items.Add(sr.ReadLine());
            }

            sr.Close();
            fs.Close();
        }
    }
}
