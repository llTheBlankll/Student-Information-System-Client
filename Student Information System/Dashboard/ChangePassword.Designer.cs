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
            textBox1 =  new TextBox() ;
            textBox2 =  new TextBox() ;
            label3 =  new Label() ;
            textBox3 =  new TextBox() ;
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
            // textBox1
            // 
            textBox1.BorderStyle =  BorderStyle.FixedSingle ;
            textBox1.Location =  new Point( 37, 126 ) ;
            textBox1.Name =  "textBox1" ;
            textBox1.Size =  new Size( 315, 32 ) ;
            textBox1.TabIndex =  2 ;
            // 
            // textBox2
            // 
            textBox2.BorderStyle =  BorderStyle.FixedSingle ;
            textBox2.Location =  new Point( 37, 199 ) ;
            textBox2.Name =  "textBox2" ;
            textBox2.Size =  new Size( 315, 32 ) ;
            textBox2.TabIndex =  4 ;
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
            // textBox3
            // 
            textBox3.BorderStyle =  BorderStyle.FixedSingle ;
            textBox3.Location =  new Point( 37, 270 ) ;
            textBox3.Name =  "textBox3" ;
            textBox3.Size =  new Size( 315, 32 ) ;
            textBox3.TabIndex =  6 ;
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
            Controls.Add( textBox3 );
            Controls.Add( label4 );
            Controls.Add( textBox2 );
            Controls.Add( label3 );
            Controls.Add( textBox1 );
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button btn_change;
        private Button btn_cancel;
    }
}