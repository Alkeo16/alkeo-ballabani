using MySql.Data.MySqlClient;
namespace Fruta___Perime_online
{
    public partial class Form1 : Form
    {
        public string connectionString = "Server=localhost;Database=frutta,perime;User=root";
        public Form1()
        {
            InitializeComponent();
            GetAllFruttaPerime();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetAllFruttaPerime()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM produkti ; ";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader != null)
                                {
                                    string id = reader[0].ToString();
                                    string emri = reader[1].ToString();
                                    string cmimi = reader[2].ToString();
                                    string kategoria = reader[3].ToString();
                                    frutaperime_dataGridView.Rows.Add(id, emri, cmimi, kategoria);
                                }
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exeption : " + ex.ToString());
            }
        }
    }
}
