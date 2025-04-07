using System.IO;
namespace FileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            prd.name = comboBox1.Text;
            prd.amount = Convert.ToDouble(textBox2.Text);
            prd.unitPrice = Convert.ToDouble(textBox3.Text);
            textBox4.Text = prd.totalPrice().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productText;
            productText=comboBox1.Text+" "+textBox2.Text + " "+textBox3.Text+" = "+textBox4.Text;
            FileStream fs = new FileStream("ProductList.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(productText);


           

            fs.Flush();
            sw.Flush();
            sw.Close();
            fs.Close();

            

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
                
            MessageBox.Show("One record was added");
        }
    }
}
