using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard ()
        {
            InitializeComponent();
        }

        private void btn_logout_Click ( object sender, EventArgs e )
        {
            this.Dispose();
            new LoginForm().ShowDialog();
        }

        private void btn_grades_Click ( object sender, EventArgs e )
        {
            new Grades().Show();
        }

        private void btn_password_Click ( object sender, EventArgs e )
        {
            new ChangePassword().ShowDialog();
       }

        private void btn_schedule_Click ( object sender, EventArgs e )
        {
            new Schedule().ShowDialog();
        }

        private void Dashboard_Load ( object sender, EventArgs e )
        {
            try
            {
                MySqlConnection connection = Connection.GetMySqlConnection();
            }
            catch ( MySqlException exception )
            {
                MessageBox.Show( exception.Message );
            }
        }
    }
}
