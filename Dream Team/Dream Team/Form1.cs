namespace Dream_Team
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usersName = textBox1.Text;
            string password = textBox2.Text;

            if (File.Exists("UsersList.txt"))
            {
                string[] lines = File.ReadAllLines("UsersList.txt");

                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (lines[i] == usersName)
                    {
                        MessageBox.Show($"The user {usersName} is available.You cannot create same user.Your password is {lines[i + 1]}");
                        return;
                    }
                }
            }

            FileStream fs = new FileStream("UsersList.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(usersName);
            sw.WriteLine(password);

            MessageBox.Show("New User Created");

            textBox1.Clear();
            textBox2.Clear();


            sw.Close();
            fs.Close();

        }
    }
}
