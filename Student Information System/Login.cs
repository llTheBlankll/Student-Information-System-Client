using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (this.txtbox_username.Text.Equals(""))
            {
                MessageBox.Show(@"Username field cannot be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (this.txtbox_password.Text.Equals(""))
            {
                MessageBox.Show(@"Username field cannot be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MySqlConnection connection = Connection.GetMySqlConnection();
                connection.Open();

                const string statement =
                    "SELECT * FROM users WHERE BINARY username = @username AND BINARY password = @password";
                MySqlCommand command = new MySqlCommand(statement, connection);
                command.Parameters.AddWithValue("@username", txtbox_username.Text);
                command.Parameters.AddWithValue("@password", txtbox_password.Text);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetString("username").Equals(txtbox_username.Text) &&
                            reader.GetString("password").Equals(txtbox_password.Text))
                        {
                            new Dashboard.Dashboard().Show();
                        }
                    }
                }
                
                connection.Close();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void txtbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_signin.PerformClick();
            }
            
        }
    }
}