namespace Student_Information_System.Dashboard
{
    partial class Grades
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel_body =  new Panel() ;
            panel_bodyheader =  new Panel() ;
            table_grades =  new DataGridView() ;
            subject_code =  new DataGridViewTextBoxColumn() ;
            description =  new DataGridViewTextBoxColumn() ;
            units =  new DataGridViewTextBoxColumn() ;
            grade =  new DataGridViewTextBoxColumn() ;
            remarks =  new DataGridViewTextBoxColumn() ;
            faculty =  new DataGridViewTextBoxColumn() ;
            section =  new DataGridViewTextBoxColumn() ;
            label1 =  new Label() ;
            textBox1 =  new TextBox() ;
            textBox2 =  new TextBox() ;
            label2 =  new Label() ;
            textBox3 =  new TextBox() ;
            label3 =  new Label() ;
            textBox4 =  new TextBox() ;
            label4 =  new Label() ;
            textBox5 =  new TextBox() ;
            label5 =  new Label() ;
            textBox6 =  new TextBox() ;
            label6 =  new Label() ;
            panel_body.SuspendLayout();
            panel_bodyheader.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)  table_grades  ).BeginInit();
            SuspendLayout();
            // 
            // panel_body
            // 
            panel_body.BackColor =  Color.White ;
            panel_body.Controls.Add( panel_bodyheader );
            panel_body.Controls.Add( table_grades );
            panel_body.Dock =  DockStyle.Fill ;
            panel_body.Font =  new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            panel_body.Location =  new Point( 0, 0 ) ;
            panel_body.Name =  "panel_body" ;
            panel_body.Size =  new Size( 984, 711 ) ;
            panel_body.TabIndex =  0 ;
            // 
            // panel_bodyheader
            // 
            panel_bodyheader.Controls.Add( textBox6 );
            panel_bodyheader.Controls.Add( label6 );
            panel_bodyheader.Controls.Add( textBox5 );
            panel_bodyheader.Controls.Add( label5 );
            panel_bodyheader.Controls.Add( textBox4 );
            panel_bodyheader.Controls.Add( label4 );
            panel_bodyheader.Controls.Add( textBox3 );
            panel_bodyheader.Controls.Add( label3 );
            panel_bodyheader.Controls.Add( textBox2 );
            panel_bodyheader.Controls.Add( label2 );
            panel_bodyheader.Controls.Add( textBox1 );
            panel_bodyheader.Controls.Add( label1 );
            panel_bodyheader.Location =  new Point( 12, 12 ) ;
            panel_bodyheader.Name =  "panel_bodyheader" ;
            panel_bodyheader.Size =  new Size( 960, 189 ) ;
            panel_bodyheader.TabIndex =  1 ;
            // 
            // table_grades
            // 
            dataGridViewCellStyle7.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            table_grades.AlternatingRowsDefaultCellStyle =  dataGridViewCellStyle7 ;
            table_grades.Anchor =     AnchorStyles.Left  |  AnchorStyles.Right   ;
            table_grades.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.Fill ;
            table_grades.ColumnHeadersBorderStyle =  DataGridViewHeaderBorderStyle.Single ;
            dataGridViewCellStyle8.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle8.BackColor =  SystemColors.Control ;
            dataGridViewCellStyle8.Font =  new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle8.ForeColor =  SystemColors.WindowText ;
            dataGridViewCellStyle8.Padding =  new Padding( 3 ) ;
            dataGridViewCellStyle8.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle8.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle8.WrapMode =  DataGridViewTriState.True ;
            table_grades.ColumnHeadersDefaultCellStyle =  dataGridViewCellStyle8 ;
            table_grades.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
            table_grades.Columns.AddRange( new DataGridViewColumn [] { subject_code, description, units, grade, remarks, faculty, section } );
            dataGridViewCellStyle9.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle9.BackColor =  SystemColors.Window ;
            dataGridViewCellStyle9.Font =  new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle9.ForeColor =  SystemColors.ControlText ;
            dataGridViewCellStyle9.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle9.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle9.WrapMode =  DataGridViewTriState.False ;
            table_grades.DefaultCellStyle =  dataGridViewCellStyle9 ;
            table_grades.GridColor =  Color.Black ;
            table_grades.Location =  new Point( 12, 207 ) ;
            table_grades.Name =  "table_grades" ;
            table_grades.ReadOnly =  true ;
            table_grades.RowHeadersBorderStyle =  DataGridViewHeaderBorderStyle.Single ;
            table_grades.RowHeadersVisible =  false ;
            table_grades.RowTemplate.Height =  25 ;
            table_grades.Size =  new Size( 960, 492 ) ;
            table_grades.TabIndex =  0 ;
            // 
            // subject_code
            // 
            subject_code.HeaderText =  "Subject Code" ;
            subject_code.MaxInputLength =  48 ;
            subject_code.Name =  "subject_code" ;
            subject_code.ReadOnly =  true ;
            // 
            // description
            // 
            description.HeaderText =  "Description" ;
            description.Name =  "description" ;
            description.ReadOnly =  true ;
            // 
            // units
            // 
            units.HeaderText =  "Units" ;
            units.MaxInputLength =  128 ;
            units.Name =  "units" ;
            units.ReadOnly =  true ;
            // 
            // grade
            // 
            grade.HeaderText =  "Grade" ;
            grade.MaxInputLength =  128 ;
            grade.Name =  "grade" ;
            grade.ReadOnly =  true ;
            // 
            // remarks
            // 
            remarks.HeaderText =  "Remarks" ;
            remarks.MaxInputLength =  128 ;
            remarks.Name =  "remarks" ;
            remarks.ReadOnly =  true ;
            // 
            // faculty
            // 
            faculty.HeaderText =  "Faculty" ;
            faculty.MaxInputLength =  128 ;
            faculty.Name =  "faculty" ;
            faculty.ReadOnly =  true ;
            // 
            // section
            // 
            section.HeaderText =  "Section" ;
            section.MaxInputLength =  128 ;
            section.Name =  "section" ;
            section.ReadOnly =  true ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Location =  new Point( 14, 12 ) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size( 94, 21 ) ;
            label1.TabIndex =  0 ;
            label1.Text =  "School Year:" ;
            // 
            // textBox1
            // 
            textBox1.Location =  new Point( 14, 36 ) ;
            textBox1.Name =  "textBox1" ;
            textBox1.Size =  new Size( 248, 29 ) ;
            textBox1.TabIndex =  1 ;
            // 
            // textBox2
            // 
            textBox2.Location =  new Point( 14, 99 ) ;
            textBox2.Name =  "textBox2" ;
            textBox2.Size =  new Size( 248, 29 ) ;
            textBox2.TabIndex =  3 ;
            // 
            // label2
            // 
            label2.AutoSize =  true ;
            label2.Location =  new Point( 14, 75 ) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size( 132, 21 ) ;
            label2.TabIndex =  2 ;
            label2.Text =  "Admission Status:" ;
            // 
            // textBox3
            // 
            textBox3.Location =  new Point( 378, 36 ) ;
            textBox3.Name =  "textBox3" ;
            textBox3.Size =  new Size( 248, 29 ) ;
            textBox3.TabIndex =  5 ;
            // 
            // label3
            // 
            label3.AutoSize =  true ;
            label3.Location =  new Point( 378, 12 ) ;
            label3.Name =  "label3" ;
            label3.Size =  new Size( 102, 21 ) ;
            label3.TabIndex =  4 ;
            label3.Text =  "Course Code:" ;
            // 
            // textBox4
            // 
            textBox4.Location =  new Point( 378, 99 ) ;
            textBox4.Name =  "textBox4" ;
            textBox4.Size =  new Size( 248, 29 ) ;
            textBox4.TabIndex =  7 ;
            // 
            // label4
            // 
            label4.AutoSize =  true ;
            label4.Location =  new Point( 378, 75 ) ;
            label4.Name =  "label4" ;
            label4.Size =  new Size( 78, 21 ) ;
            label4.TabIndex =  6 ;
            label4.Text =  "Semester:" ;
            // 
            // textBox5
            // 
            textBox5.Location =  new Point( 698, 36 ) ;
            textBox5.Name =  "textBox5" ;
            textBox5.Size =  new Size( 248, 29 ) ;
            textBox5.TabIndex =  9 ;
            textBox5.Text =  "Campus:" ;
            // 
            // label5
            // 
            label5.AutoSize =  true ;
            label5.Location =  new Point( 698, 12 ) ;
            label5.Name =  "label5" ;
            label5.Size =  new Size( 94, 21 ) ;
            label5.TabIndex =  8 ;
            label5.Text =  "School Year:" ;
            // 
            // textBox6
            // 
            textBox6.Location =  new Point( 698, 99 ) ;
            textBox6.Name =  "textBox6" ;
            textBox6.Size =  new Size( 248, 29 ) ;
            textBox6.TabIndex =  11 ;
            // 
            // label6
            // 
            label6.AutoSize =  true ;
            label6.Location =  new Point( 698, 75 ) ;
            label6.Name =  "label6" ;
            label6.Size =  new Size( 145, 21 ) ;
            label6.TabIndex =  10 ;
            label6.Text =  "Course Description:" ;
            // 
            // Grades
            // 
            AutoScaleDimensions =  new SizeF( 7F, 15F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            BackColor =  Color.White ;
            ClientSize =  new Size( 984, 711 ) ;
            Controls.Add( panel_body );
            FormBorderStyle =  FormBorderStyle.FixedSingle ;
            MaximizeBox =  false ;
            MinimizeBox =  false ;
            Name =  "Grades" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Grades" ;
            panel_body.ResumeLayout( false );
            panel_bodyheader.ResumeLayout( false );
            panel_bodyheader.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)  table_grades  ).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private Panel panel_body;
        private Panel panel_bodyheader;
        private DataGridView table_grades;
        private DataGridViewTextBoxColumn subject_code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn units;
        private DataGridViewTextBoxColumn grade;
        private DataGridViewTextBoxColumn remarks;
        private DataGridViewTextBoxColumn faculty;
        private DataGridViewTextBoxColumn section;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}