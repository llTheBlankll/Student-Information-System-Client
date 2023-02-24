namespace Student_Information_System
{
    public partial class Login_Form : Form
    {
        public Login_Form ()
        {
            InitializeComponent();
        }

        private void btn_signin_Click ( object sender, EventArgs e )
        {
            
        }

        private void txtbox_password_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                btn_signin.PerformClick();
            }
        }
    }
}