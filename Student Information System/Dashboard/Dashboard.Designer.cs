namespace Student_Information_System.Dashboard
{
    partial class Dashboard
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
            btn_schedule =  new Button() ;
            picturebox_profile =  new PictureBox() ;
            txtbox_id =  new TextBox() ;
            panel2 =  new Panel() ;
            panelheader_personalInformation =  new Panel() ;
            label1 =  new Label() ;
            label2 =  new Label() ;
            txtbox_campus =  new TextBox() ;
            txtbox_course =  new TextBox() ;
            label3 =  new Label() ;
            txt_yearLevel =  new TextBox() ;
            label4 =  new Label() ;
            btn_grades =  new Button() ;
            btn_password =  new Button() ;
            btn_logout =  new Button() ;
            panel_personalInformation =  new Panel() ;
            txtbox_lastName =  new TextBox() ;
            label5 =  new Label() ;
            txtbox_firstName =  new TextBox() ;
            label6 =  new Label() ;
            txtbox_middleName =  new TextBox() ;
            label7 =  new Label() ;
            txtbox_studentNumber =  new TextBox() ;
            label8 =  new Label() ;
            txtbox_gender =  new TextBox() ;
            label9 =  new Label() ;
            txtbox_birthday =  new TextBox() ;
            label10 =  new Label() ;
            txtbox_religion =  new TextBox() ;
            label11 =  new Label() ;
            txtbox_contactNumber =  new TextBox() ;
            label12 =  new Label() ;
            txtbox_emailAddress =  new TextBox() ;
            label13 =  new Label() ;
            linkLabel1 =  new LinkLabel() ;
            panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)  picturebox_profile  ).BeginInit();
            panel2.SuspendLayout();
            panelheader_personalInformation.SuspendLayout();
            panel_personalInformation.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor =  Color.White ;
            panel1.BorderStyle =  BorderStyle.FixedSingle ;
            panel1.Controls.Add( linkLabel1 );
            panel1.Controls.Add( panel2 );
            panel1.Controls.Add( txtbox_id );
            panel1.Controls.Add( picturebox_profile );
            panel1.Location =  new Point( 12, 55 ) ;
            panel1.Name =  "panel1" ;
            panel1.Size =  new Size( 907, 394 ) ;
            panel1.TabIndex =  0 ;
            // 
            // btn_schedule
            // 
            btn_schedule.Location =  new Point( 12, 12 ) ;
            btn_schedule.Name =  "btn_schedule" ;
            btn_schedule.Size =  new Size( 99, 37 ) ;
            btn_schedule.TabIndex =  1 ;
            btn_schedule.Text =  "Schedule " ;
            btn_schedule.UseVisualStyleBackColor =  true ;
            btn_schedule.Click +=  btn_schedule_Click ;
            // 
            // picturebox_profile
            // 
            picturebox_profile.Location =  new Point( 12, 49 ) ;
            picturebox_profile.Name =  "picturebox_profile" ;
            picturebox_profile.Size =  new Size( 256, 256 ) ;
            picturebox_profile.TabIndex =  0 ;
            picturebox_profile.TabStop =  false ;
            // 
            // txtbox_id
            // 
            txtbox_id.BorderStyle =  BorderStyle.None ;
            txtbox_id.Enabled =  false ;
            txtbox_id.Location =  new Point( 12, 311 ) ;
            txtbox_id.Name =  "txtbox_id" ;
            txtbox_id.Size =  new Size( 256, 22 ) ;
            txtbox_id.TabIndex =  1 ;
            txtbox_id.Text =  "ID" ;
            txtbox_id.TextAlign =  HorizontalAlignment.Center ;
            // 
            // panel2
            // 
            panel2.BorderStyle =  BorderStyle.FixedSingle ;
            panel2.Controls.Add( panel_personalInformation );
            panel2.Controls.Add( txt_yearLevel );
            panel2.Controls.Add( label4 );
            panel2.Controls.Add( txtbox_course );
            panel2.Controls.Add( label3 );
            panel2.Controls.Add( txtbox_campus );
            panel2.Controls.Add( label2 );
            panel2.Controls.Add( panelheader_personalInformation );
            panel2.Location =  new Point( 274, 13 ) ;
            panel2.Name =  "panel2" ;
            panel2.Size =  new Size( 628, 376 ) ;
            panel2.TabIndex =  2 ;
            // 
            // panelheader_personalInformation
            // 
            panelheader_personalInformation.BackColor =  Color.FromArgb(     221  ,     247  ,     227   ) ;
            panelheader_personalInformation.Controls.Add( label1 );
            panelheader_personalInformation.Dock =  DockStyle.Top ;
            panelheader_personalInformation.Location =  new Point( 0, 0 ) ;
            panelheader_personalInformation.Name =  "panelheader_personalInformation" ;
            panelheader_personalInformation.Size =  new Size( 626, 50 ) ;
            panelheader_personalInformation.TabIndex =  0 ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font( "Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label1.Location =  new Point( 8, 8 ) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size( 213, 30 ) ;
            label1.TabIndex =  0 ;
            label1.Text =  "Personal Information" ;
            // 
            // label2
            // 
            label2.AutoSize =  true ;
            label2.Location =  new Point( 8, 64 ) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size( 70, 21 ) ;
            label2.TabIndex =  1 ;
            label2.Text =  "Campus:" ;
            // 
            // txtbox_campus
            // 
            txtbox_campus.Location =  new Point( 84, 61 ) ;
            txtbox_campus.Name =  "txtbox_campus" ;
            txtbox_campus.Size =  new Size( 113, 29 ) ;
            txtbox_campus.TabIndex =  0 ;
            // 
            // txtbox_course
            // 
            txtbox_course.Location =  new Point( 271, 61 ) ;
            txtbox_course.Name =  "txtbox_course" ;
            txtbox_course.Size =  new Size( 109, 29 ) ;
            txtbox_course.TabIndex =  1 ;
            // 
            // label3
            // 
            label3.AutoSize =  true ;
            label3.Location =  new Point( 203, 64 ) ;
            label3.Name =  "label3" ;
            label3.Size =  new Size( 62, 21 ) ;
            label3.TabIndex =  3 ;
            label3.Text =  "Course:" ;
            // 
            // txt_yearLevel
            // 
            txt_yearLevel.Location =  new Point( 471, 61 ) ;
            txt_yearLevel.Name =  "txt_yearLevel" ;
            txt_yearLevel.Size =  new Size( 142, 29 ) ;
            txt_yearLevel.TabIndex =  2 ;
            // 
            // label4
            // 
            label4.AutoSize =  true ;
            label4.Location =  new Point( 382, 64 ) ;
            label4.Name =  "label4" ;
            label4.Size =  new Size( 83, 21 ) ;
            label4.TabIndex =  5 ;
            label4.Text =  "Year Level:" ;
            // 
            // btn_grades
            // 
            btn_grades.Location =  new Point( 117, 12 ) ;
            btn_grades.Name =  "btn_grades" ;
            btn_grades.Size =  new Size( 99, 37 ) ;
            btn_grades.TabIndex =  2 ;
            btn_grades.Text =  "Grades" ;
            btn_grades.UseVisualStyleBackColor =  true ;
            btn_grades.Click +=  btn_grades_Click ;
            // 
            // btn_password
            // 
            btn_password.Location =  new Point( 222, 12 ) ;
            btn_password.Name =  "btn_password" ;
            btn_password.Size =  new Size( 99, 37 ) ;
            btn_password.TabIndex =  3 ;
            btn_password.Text =  "Password" ;
            btn_password.UseVisualStyleBackColor =  true ;
            btn_password.Click +=  btn_password_Click ;
            // 
            // btn_logout
            // 
            btn_logout.Location =  new Point( 820, 12 ) ;
            btn_logout.Name =  "btn_logout" ;
            btn_logout.Size =  new Size( 99, 37 ) ;
            btn_logout.TabIndex =  4 ;
            btn_logout.Text =  "Logout" ;
            btn_logout.UseVisualStyleBackColor =  true ;
            btn_logout.Click +=  btn_logout_Click ;
            // 
            // panel_personalInformation
            // 
            panel_personalInformation.BorderStyle =  BorderStyle.FixedSingle ;
            panel_personalInformation.Controls.Add( txtbox_emailAddress );
            panel_personalInformation.Controls.Add( label13 );
            panel_personalInformation.Controls.Add( txtbox_contactNumber );
            panel_personalInformation.Controls.Add( label12 );
            panel_personalInformation.Controls.Add( txtbox_religion );
            panel_personalInformation.Controls.Add( label11 );
            panel_personalInformation.Controls.Add( txtbox_birthday );
            panel_personalInformation.Controls.Add( label10 );
            panel_personalInformation.Controls.Add( txtbox_gender );
            panel_personalInformation.Controls.Add( label9 );
            panel_personalInformation.Controls.Add( txtbox_studentNumber );
            panel_personalInformation.Controls.Add( label8 );
            panel_personalInformation.Controls.Add( txtbox_middleName );
            panel_personalInformation.Controls.Add( label7 );
            panel_personalInformation.Controls.Add( txtbox_firstName );
            panel_personalInformation.Controls.Add( label6 );
            panel_personalInformation.Controls.Add( txtbox_lastName );
            panel_personalInformation.Controls.Add( label5 );
            panel_personalInformation.Location =  new Point( -1, 99 ) ;
            panel_personalInformation.Name =  "panel_personalInformation" ;
            panel_personalInformation.Size =  new Size( 628, 276 ) ;
            panel_personalInformation.TabIndex =  7 ;
            // 
            // txtbox_lastName
            // 
            txtbox_lastName.Location =  new Point( 13, 36 ) ;
            txtbox_lastName.Name =  "txtbox_lastName" ;
            txtbox_lastName.Size =  new Size( 196, 29 ) ;
            txtbox_lastName.TabIndex =  3 ;
            // 
            // label5
            // 
            label5.AutoSize =  true ;
            label5.Location =  new Point( 69, 68 ) ;
            label5.Name =  "label5" ;
            label5.Size =  new Size( 84, 21 ) ;
            label5.TabIndex =  8 ;
            label5.Text =  "Last Name" ;
            // 
            // txtbox_firstName
            // 
            txtbox_firstName.Location =  new Point( 215, 36 ) ;
            txtbox_firstName.Name =  "txtbox_firstName" ;
            txtbox_firstName.Size =  new Size( 196, 29 ) ;
            txtbox_firstName.TabIndex =  4 ;
            // 
            // label6
            // 
            label6.AutoSize =  true ;
            label6.Location =  new Point( 267, 68 ) ;
            label6.Name =  "label6" ;
            label6.Size =  new Size( 86, 21 ) ;
            label6.TabIndex =  10 ;
            label6.Text =  "First Name" ;
            // 
            // txtbox_middleName
            // 
            txtbox_middleName.Location =  new Point( 417, 36 ) ;
            txtbox_middleName.Name =  "txtbox_middleName" ;
            txtbox_middleName.Size =  new Size( 196, 29 ) ;
            txtbox_middleName.TabIndex =  5 ;
            // 
            // label7
            // 
            label7.AutoSize =  true ;
            label7.Location =  new Point( 464, 68 ) ;
            label7.Name =  "label7" ;
            label7.Size =  new Size( 104, 21 ) ;
            label7.TabIndex =  12 ;
            label7.Text =  "Middle Name" ;
            // 
            // txtbox_studentNumber
            // 
            txtbox_studentNumber.Location =  new Point( 13, 113 ) ;
            txtbox_studentNumber.Name =  "txtbox_studentNumber" ;
            txtbox_studentNumber.Size =  new Size( 196, 29 ) ;
            txtbox_studentNumber.TabIndex =  6 ;
            // 
            // label8
            // 
            label8.AutoSize =  true ;
            label8.Location =  new Point( 53, 145 ) ;
            label8.Name =  "label8" ;
            label8.Size =  new Size( 125, 21 ) ;
            label8.TabIndex =  14 ;
            label8.Text =  "Student Number" ;
            // 
            // txtbox_gender
            // 
            txtbox_gender.Location =  new Point( 215, 113 ) ;
            txtbox_gender.Name =  "txtbox_gender" ;
            txtbox_gender.Size =  new Size( 196, 29 ) ;
            txtbox_gender.TabIndex =  7 ;
            // 
            // label9
            // 
            label9.AutoSize =  true ;
            label9.Location =  new Point( 284, 145 ) ;
            label9.Name =  "label9" ;
            label9.Size =  new Size( 61, 21 ) ;
            label9.TabIndex =  16 ;
            label9.Text =  "Gender" ;
            // 
            // txtbox_birthday
            // 
            txtbox_birthday.Location =  new Point( 417, 113 ) ;
            txtbox_birthday.Name =  "txtbox_birthday" ;
            txtbox_birthday.Size =  new Size( 196, 29 ) ;
            txtbox_birthday.TabIndex =  8 ;
            // 
            // label10
            // 
            label10.AutoSize =  true ;
            label10.Location =  new Point( 484, 145 ) ;
            label10.Name =  "label10" ;
            label10.Size =  new Size( 68, 21 ) ;
            label10.TabIndex =  18 ;
            label10.Text =  "Birthday" ;
            // 
            // txtbox_religion
            // 
            txtbox_religion.Location =  new Point( 13, 184 ) ;
            txtbox_religion.Name =  "txtbox_religion" ;
            txtbox_religion.Size =  new Size( 196, 29 ) ;
            txtbox_religion.TabIndex =  9 ;
            // 
            // label11
            // 
            label11.AutoSize =  true ;
            label11.Location =  new Point( 84, 216 ) ;
            label11.Name =  "label11" ;
            label11.Size =  new Size( 67, 21 ) ;
            label11.TabIndex =  20 ;
            label11.Text =  "Religion" ;
            // 
            // txtbox_contactNumber
            // 
            txtbox_contactNumber.Location =  new Point( 215, 184 ) ;
            txtbox_contactNumber.Name =  "txtbox_contactNumber" ;
            txtbox_contactNumber.Size =  new Size( 196, 29 ) ;
            txtbox_contactNumber.TabIndex =  10 ;
            // 
            // label12
            // 
            label12.AutoSize =  true ;
            label12.Location =  new Point( 248, 216 ) ;
            label12.Name =  "label12" ;
            label12.Size =  new Size( 125, 21 ) ;
            label12.TabIndex =  22 ;
            label12.Text =  "Contact Number" ;
            // 
            // txtbox_emailAddress
            // 
            txtbox_emailAddress.Location =  new Point( 417, 184 ) ;
            txtbox_emailAddress.Name =  "txtbox_emailAddress" ;
            txtbox_emailAddress.Size =  new Size( 196, 29 ) ;
            txtbox_emailAddress.TabIndex =  11 ;
            // 
            // label13
            // 
            label13.AutoSize =  true ;
            label13.Location =  new Point( 464, 216 ) ;
            label13.Name =  "label13" ;
            label13.Size =  new Size( 108, 21 ) ;
            label13.TabIndex =  24 ;
            label13.Text =  "Email Address" ;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor =  Color.Gold ;
            linkLabel1.AutoSize =  true ;
            linkLabel1.LinkColor =  Color.FromArgb(     101  ,     93  ,     187   ) ;
            linkLabel1.Location =  new Point( 50, 347 ) ;
            linkLabel1.Name =  "linkLabel1" ;
            linkLabel1.Size =  new Size( 185, 21 ) ;
            linkLabel1.TabIndex =  3 ;
            linkLabel1.TabStop =  true ;
            linkLabel1.Text =  "Show more information..." ;
            // 
            // Dashboard
            // 
            AutoScaleDimensions =  new SizeF( 9F, 21F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  Color.White ;
            ClientSize =  new Size( 931, 461 ) ;
            ControlBox =  false ;
            Controls.Add( btn_logout );
            Controls.Add( btn_password );
            Controls.Add( btn_grades );
            Controls.Add( btn_schedule );
            Controls.Add( panel1 );
            Font =  new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            Margin =  new Padding( 4 ) ;
            Name =  "Dashboard" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Student Information System" ;
            Load +=  Dashboard_Load ;
            panel1.ResumeLayout( false );
            panel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)  picturebox_profile  ).EndInit();
            panel2.ResumeLayout( false );
            panel2.PerformLayout();
            panelheader_personalInformation.ResumeLayout( false );
            panelheader_personalInformation.PerformLayout();
            panel_personalInformation.ResumeLayout( false );
            panel_personalInformation.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private Panel panel1;
        private PictureBox picturebox_profile;
        private Button btn_schedule;
        private Panel panel2;
        private Panel panelheader_personalInformation;
        private Label label1;
        private TextBox txtbox_id;
        private TextBox txt_yearLevel;
        private Label label4;
        private TextBox txtbox_course;
        private Label label3;
        private TextBox txtbox_campus;
        private Label label2;
        private Button btn_grades;
        private Button btn_password;
        private Button btn_logout;
        private Panel panel_personalInformation;
        private TextBox txtbox_lastName;
        private Label label5;
        private TextBox txtbox_middleName;
        private Label label7;
        private TextBox txtbox_firstName;
        private Label label6;
        private TextBox txtbox_emailAddress;
        private Label label13;
        private TextBox txtbox_contactNumber;
        private Label label12;
        private TextBox txtbox_religion;
        private Label label11;
        private TextBox txtbox_birthday;
        private Label label10;
        private TextBox txtbox_gender;
        private Label label9;
        private TextBox txtbox_studentNumber;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}