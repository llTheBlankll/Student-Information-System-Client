namespace Student_Information_System.Dashboard
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            panel1 =  new Panel() ;
            label1 =  new Label() ;
            label2 =  new Label() ;
            txtbox_currentPassword =  new TextBox() ;
            txtbox_newPassword =  new TextBox() ;
            label3 =  new Label() ;
            txtbox_retypePassword =  new TextBox() ;
            label4 =  new Label() ;
            btn_change =  new Button() ;
            btn_cancel =  new Button() ;
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor =  Color.FromArgb(     221  ,     247  ,     227   ) ;
            panel1.Controls.Add( label1 );
            panel1.Dock =  DockStyle.Top ;
            panel1.Location =  new Point( 0, 0 ) ;
            panel1.Margin =  new Padding( 5, 5, 5, 5 ) ;
            panel1.Name =  "panel1" ;
            panel1.Size =  new Size( 384, 76 ) ;
            panel1.TabIndex =  0 ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font( "Impact", 24F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label1.Location =  new Point( 68, 20 ) ;
            label1.Margin =  new Padding( 5, 0, 5, 0 ) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size( 266, 39 ) ;
            label1.TabIndex =  0 ;
            label1.Text =  "CHANGE PASSWORD" ;
            // 
            // label2
            // 
            label2.AutoSize =  true ;
            label2.Location =  new Point( 122, 98 ) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size( 160, 25 ) ;
            label2.TabIndex =  1 ;
            label2.Text =  "Current Password" ;
            // 
            // txtbox_currentPassword
            // 
            txtbox_currentPassword.Font =  new Font( "FantasqueSansMono NFM", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            txtbox_currentPassword.Location =  new Point( 37, 126 ) ;
            txtbox_currentPassword.MaxLength =  32 ;
            txtbox_currentPassword.Name =  "txtbox_currentPassword" ;
            txtbox_currentPassword.PasswordChar =  '*' ;
            txtbox_currentPassword.PlaceholderText =  "Enter your Current Password" ;
            txtbox_currentPassword.Size =  new Size( 315, 23 ) ;
            txtbox_currentPassword.TabIndex =  0 ;
            txtbox_currentPassword.TextAlign =  HorizontalAlignment.Center ;
            // 
            // txtbox_newPassword
            // 
            txtbox_newPassword.Font =  new Font( "FantasqueSansMono NFM", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            txtbox_newPassword.Location =  new Point( 37, 199 ) ;
            txtbox_newPassword.MaxLength =  32 ;
            txtbox_newPassword.Name =  "txtbox_newPassword" ;
            txtbox_newPassword.PasswordChar =  '*' ;
            txtbox_newPassword.PlaceholderText =  "Enter your New Password" ;
            txtbox_newPassword.Size =  new Size( 315, 23 ) ;
            txtbox_newPassword.TabIndex =  1 ;
            txtbox_newPassword.TextAlign =  HorizontalAlignment.Center ;
            // 
            // label3
            // 
            label3.AutoSize =  true ;
            label3.Location =  new Point( 135, 171 ) ;
            label3.Name =  "label3" ;
            label3.Size =  new Size( 134, 25 ) ;
            label3.TabIndex =  3 ;
            label3.Text =  "New Password" ;
            // 
            // txtbox_retypePassword
            // 
            txtbox_retypePassword.Font =  new Font( "FantasqueSansMono NFM", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            txtbox_retypePassword.Location =  new Point( 37, 270 ) ;
            txtbox_retypePassword.MaxLength =  32 ;
            txtbox_retypePassword.Name =  "txtbox_retypePassword" ;
            txtbox_retypePassword.PasswordChar =  '*' ;
            txtbox_retypePassword.PlaceholderText =  "Re-type your New Password" ;
            txtbox_retypePassword.Size =  new Size( 315, 23 ) ;
            txtbox_retypePassword.TabIndex =  2 ;
            txtbox_retypePassword.TextAlign =  HorizontalAlignment.Center ;
            // 
            // label4
            // 
            label4.AutoSize =  true ;
            label4.Location =  new Point( 122, 242 ) ;
            label4.Name =  "label4" ;
            label4.Size =  new Size( 160, 25 ) ;
            label4.TabIndex =  5 ;
            label4.Text =  "Re-type Password" ;
            // 
            // btn_change
            // 
            btn_change.BackColor =  Color.FromArgb(     83  ,     145  ,     101   ) ;
            btn_change.FlatAppearance.BorderSize =  0 ;
            btn_change.FlatStyle =  FlatStyle.Popup ;
            btn_change.Font =  new Font( "Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            btn_change.ForeColor =  Color.White ;
            btn_change.Location =  new Point( 205, 324 ) ;
            btn_change.Name =  "btn_change" ;
            btn_change.Size =  new Size( 120, 36 ) ;
            btn_change.TabIndex =  7 ;
            btn_change.Text =  "Submit" ;
            btn_change.UseVisualStyleBackColor =  false ;
            btn_change.Click +=  btn_change_Click ;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor =  Color.FromArgb(     241  ,     103  ,     103   ) ;
            btn_cancel.FlatAppearance.BorderSize =  0 ;
            btn_cancel.FlatStyle =  FlatStyle.Popup ;
            btn_cancel.Font =  new Font( "Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            btn_cancel.ForeColor =  Color.White ;
            btn_cancel.Location =  new Point( 79, 324 ) ;
            btn_cancel.Name =  "btn_cancel" ;
            btn_cancel.Size =  new Size( 120, 36 ) ;
            btn_cancel.TabIndex =  8 ;
            btn_cancel.Text =  "Cancel" ;
            btn_cancel.UseVisualStyleBackColor =  false ;
            btn_cancel.Click +=  btn_cancel_Click ;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions =  new SizeF( 11F, 25F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  Color.White ;
            ClientSize =  new Size( 384, 386 ) ;
            ControlBox =  false ;
            Controls.Add( btn_cancel );
            Controls.Add( btn_change );
            Controls.Add( txtbox_retypePassword );
            Controls.Add( label4 );
            Controls.Add( txtbox_newPassword );
            Controls.Add( label3 );
            Controls.Add( txtbox_currentPassword );
            Controls.Add( label2 );
            Controls.Add( panel1 );
            Font =  new Font( "Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point ) ;
            Margin =  new Padding( 5, 5, 5, 5 ) ;
            Name =  "ChangePassword" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Change Password" ;
            panel1.ResumeLayout( false );
            panel1.PerformLayout();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtbox_currentPassword;
        private TextBox txtbox_newPassword;
        private Label label3;
        private TextBox txtbox_retypePassword;
        private Label label4;
        private Button btn_change;
        private Button btn_cancel;
    }
}