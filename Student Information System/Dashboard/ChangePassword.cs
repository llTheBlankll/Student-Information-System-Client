using MySql.Data.MySqlClient;

namespace Student_Information_System.Dashboard
{
    public partial class ChangePassword : Form
    {
        public ChangePassword ()
        {
            InitializeComponent();
        }

        private void btn_change_Click ( object sender, EventArgs e )
        {
            // Validate Fields if they are empty.
            if ( txtbox_currentPassword.Text == "" )
            {
                MessageBox.Show( @"Current Password Cannot be empty.", @"Cannot be empty", MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }

            if ( txtbox_newPassword.Text == "" )
            {
                MessageBox.Show( @"New Password Cannot be empty.", @"Cannot be empty", MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }

            if ( txtbox_retypePassword.Text == "" )
            {
                MessageBox.Show( @"Type your password again.", @"Password is not the same", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            if ( txtbox_newPassword.Text != txtbox_retypePassword.Text )
            {
                MessageBox.Show( @"New Password does not match.", @"Password does not match", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            try
            {
                // Check if the Current Password is indeed correct
                if ( is_valid() )
                {
                    // Check if the current password is the same as the new password.
                    if ( txtbox_currentPassword.Text == txtbox_newPassword.Text )
                    {
                        MessageBox.Show( "Current Password should not be the same as the New Password.", "Same Password not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        return;
                    }

                    // Change the password.
                    MySqlConnection connection = Connection.GetMySqlConnection();
                    connection.Open();

                    MySqlCommand command =
                        new MySqlCommand(
                            "UPDATE students_account SET password = @password WHERE student_number = @student_number" );
                    command.Parameters.AddWithValue( "@password", txtbox_newPassword.Text );
                    command.Parameters.AddWithValue( "@student_number", "1" );

                    command.ExecuteNonQuery();
                }
            }
            catch ( MySqlException mysqlException )
            {
                MessageBox.Show( mysqlException.Message );
            }
        }

        private void btn_cancel_Click ( object sender, EventArgs e )
        {
            this.Close();
            new Dashboard().Show();
        }

        private void txtbox_retypePassword_KeyPress ( object sender, KeyPressEventArgs e )
        {
            // If Enter is pressed, Click the Submit button.
            if ( e.KeyChar == (char) Keys.Enter )
            {
                btn_change.PerformClick();
            }
        }

        // Check if the student account password is the same as the current password field.
        // Return true if it is the same, otherwise 'false'
        private bool is_valid ()
        {
            MySqlConnection connection = Connection.GetMySqlConnection();
            connection.Open();

            MySqlCommand command = new MySqlCommand( @"" );
            MySqlDataReader reader = command.ExecuteReader();

            // Read the data.
            while ( reader.Read() )
            {
                // Compare the two
                if ( (string) reader ["password"] == txtbox_currentPassword.Text )
                {
                    return true;
                }
            }

            // Close Everything.
            connection.Close();
            reader.Close();
            return false;
        }
    }
}