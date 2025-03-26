namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = login_username_textBox.Text;
            string password = login_password_textBox.Text;

            bool login = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            { 
                if (!row.IsNewRow)
                {
                    string dataGrid_username = row.Cells[0].Value.ToString();
                    string dataGrid_passwrod = row.Cells[1].Value.ToString();

                    if (username == dataGrid_username && password == dataGrid_passwrod)
                    {
                        MessageBox.Show("Welcome Back " + username + " ! ", "LogIn Success");
                        login = true;
                        break;
                    }
                }
            }

            if(login == false)
            {
                MessageBox.Show("Pleas check your credential !", "Login Error");
            }

            login_username_textBox.Clear();
            login_password_textBox.Clear();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            string username = signup_username_textBox.Text;
            string password = signup_password_textBox.Text;

            dataGridView1.Rows.Add(username, password);

            signup_username_textBox.Clear();
            signup_password_textBox.Clear();
        }
    }
}
