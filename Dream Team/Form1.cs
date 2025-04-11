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
            string usersName = textBox1.Text;
            string password = textBox2.Text;

            Form2 frmquiz = new Form2();

            if (string.IsNullOrEmpty(usersName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }


            if(Users.CorrectPass(usersName,password))
            {
                frmquiz.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Either your Username or Password is wrong");
            }

     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usersName = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(usersName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }


            if (Users.IsExistUsers(usersName))
            {
                string storedpassword = Users.GetPasswordByUserName(usersName);

                
                 MessageBox.Show($"The user {usersName} is available.You cannot create same user.Your password is {storedpassword}");
                 return;
      
            }
            else
            {
                Users.CreateNewUsers(usersName, password);
                MessageBox.Show("New User Created");
            }

            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
