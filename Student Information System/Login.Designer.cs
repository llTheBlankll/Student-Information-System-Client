namespace Student_Information_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            label1 =  new Label() ;
            panel1 =  new Panel() ;
            label2 =  new Label() ;
            txtbox_username =  new TextBox() ;
            txtbox_password =  new TextBox() ;
            label3 =  new Label() ;
            btn_signin =  new Button() ;
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font( "Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point ) ;
            label1.ForeColor =  Color.White ;
            label1.Location =  new Point( 153, 27 ) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size( 118, 38 ) ;
            label1.TabIndex =  0 ;
            label1.Text =  "Sign in" ;
            // 
            // panel1
            // 
            panel1.BackColor =  Color.Gray ;
            panel1.Controls.Add( label1 );
            panel1.Dock =  DockStyle.Top ;
            panel1.Location =  new Point( 0, 0 ) ;
            panel1.Name =  "panel1" ;
            panel1.Size =  new Size( 434, 96 ) ;
            panel1.TabIndex =  1 ;
            // 
            // label2
            // 
            label2.AutoSize =  true ;
            label2.Location =  new Point( 160, 167 ) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size( 101, 22 ) ;
            label2.TabIndex =  2 ;
            label2.Text =  "Username" ;
            // 
            // txtbox_username
            // 
            txtbox_username.Location =  new Point( 64, 205 ) ;
            txtbox_username.MaxLength =  32 ;
            txtbox_username.Name =  "txtbox_username" ;
            txtbox_username.PlaceholderText =  "Enter your username" ;
            txtbox_username.Size =  new Size( 300, 31 ) ;
            txtbox_username.TabIndex =  3 ;
            txtbox_username.TextAlign =  HorizontalAlignment.Center ;
            // 
            // txtbox_password
            // 
            txtbox_password.Font =  new Font( "Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            txtbox_password.Location =  new Point( 64, 305 ) ;
            txtbox_password.MaxLength =  32 ;
            txtbox_password.Name =  "txtbox_password" ;
            txtbox_password.PasswordChar =  '*' ;
            txtbox_password.PlaceholderText =  "Enter your password" ;
            txtbox_password.Size =  new Size( 300, 30 ) ;
            txtbox_password.TabIndex =  5 ;
            txtbox_password.TextAlign =  HorizontalAlignment.Center ;
            txtbox_password.KeyPress +=  txtbox_password_KeyPress ;
            // 
            // label3
            // 
            label3.AutoSize =  true ;
            label3.Location =  new Point( 166, 267 ) ;
            label3.Name =  "label3" ;
            label3.Size =  new Size( 95, 22 ) ;
            label3.TabIndex =  4 ;
            label3.Text =  "Password" ;
            // 
            // btn_signin
            // 
            btn_signin.Font =  new Font( "Leelawadee", 14.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            btn_signin.Location =  new Point( 153, 353 ) ;
            btn_signin.Name =  "btn_signin" ;
            btn_signin.Size =  new Size( 111, 34 ) ;
            btn_signin.TabIndex =  6 ;
            btn_signin.Text =  "Sign in" ;
            btn_signin.UseVisualStyleBackColor =  true ;
            btn_signin.Click +=  btn_signin_Click ;
            // 
            // LoginForm
            // 
            AutoScaleDimensions =  new SizeF( 11F, 22F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  Color.White ;
            ClientSize =  new Size( 434, 461 ) ;
            Controls.Add( btn_signin );
            Controls.Add( txtbox_password );
            Controls.Add( label3 );
            Controls.Add( txtbox_username );
            Controls.Add( label2 );
            Controls.Add( panel1 );
            Font =  new Font( "Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Margin =  new Padding( 5 ) ;
            Name =  "LoginForm" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Form1" ;
            panel1.ResumeLayout( false );
            panel1.PerformLayout();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtbox_username;
        private TextBox txtbox_password;
        private Label label3;
        private Button btn_signin;
    }
}