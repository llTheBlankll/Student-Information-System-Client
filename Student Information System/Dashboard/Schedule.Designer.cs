namespace Student_Information_System.Dashboard
{
    partial class Schedule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 =  new Panel() ;
            txtbox_courseName =  new TextBox() ;
            label7 =  new Label() ;
            label6 =  new Label() ;
            label5 =  new Label() ;
            label4 =  new Label() ;
            label3 =  new Label() ;
            label2 =  new Label() ;
            label1 =  new Label() ;
            table_schedule =  new DataGridView() ;
            section =  new DataGridViewTextBoxColumn() ;
            subject_code =  new DataGridViewTextBoxColumn() ;
            description =  new DataGridViewTextBoxColumn() ;
            room =  new DataGridViewTextBoxColumn() ;
            units =  new DataGridViewTextBoxColumn() ;
            day =  new DataGridViewTextBoxColumn() ;
            time =  new DataGridViewTextBoxColumn() ;
            faculty =  new DataGridViewTextBoxColumn() ;
            panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)  table_schedule  ).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor =  Color.White ;
            panel1.Controls.Add( txtbox_courseName );
            panel1.Controls.Add( label7 );
            panel1.Controls.Add( label6 );
            panel1.Controls.Add( label5 );
            panel1.Controls.Add( label4 );
            panel1.Controls.Add( label3 );
            panel1.Controls.Add( label2 );
            panel1.Controls.Add( label1 );
            panel1.Controls.Add( table_schedule );
            panel1.Dock =  DockStyle.Fill ;
            panel1.Location =  new Point( 0, 0 ) ;
            panel1.Name =  "panel1" ;
            panel1.Size =  new Size( 984, 411 ) ;
            panel1.TabIndex =  0 ;
            // 
            // txtbox_courseName
            // 
            txtbox_courseName.BorderStyle =  BorderStyle.FixedSingle ;
            txtbox_courseName.Font =  new Font( "Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point ) ;
            txtbox_courseName.Location =  new Point( 86, 20 ) ;
            txtbox_courseName.MaxLength =  1000 ;
            txtbox_courseName.Name =  "txtbox_courseName" ;
            txtbox_courseName.ReadOnly =  true ;
            txtbox_courseName.Size =  new Size( 390, 23 ) ;
            txtbox_courseName.TabIndex =  10 ;
            // 
            // label7
            // 
            label7.AutoSize =  true ;
            label7.Font =  new Font( "Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label7.Location =  new Point( 880, 21 ) ;
            label7.Name =  "label7" ;
            label7.Size =  new Size( 48, 20 ) ;
            label7.TabIndex =  9 ;
            label7.Text =  "Purity" ;
            // 
            // label6
            // 
            label6.AutoSize =  true ;
            label6.Font =  new Font( "Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label6.Location =  new Point( 558, 21 ) ;
            label6.Name =  "label6" ;
            label6.Size =  new Size( 28, 20 ) ;
            label6.TabIndex =  8 ;
            label6.Text =  "1st" ;
            // 
            // label5
            // 
            label5.AutoSize =  true ;
            label5.Font =  new Font( "Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label5.Location =  new Point( 713, 21 ) ;
            label5.Name =  "label5" ;
            label5.Size =  new Size( 78, 20 ) ;
            label5.TabIndex =  7 ;
            label5.Text =  "2022-2023" ;
            // 
            // label4
            // 
            label4.AutoSize =  true ;
            label4.Font =  new Font( "Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label4.Location =  new Point( 819, 21 ) ;
            label4.Name =  "label4" ;
            label4.Size =  new Size( 67, 20 ) ;
            label4.TabIndex =  6 ;
            label4.Text =  "Section:" ;
            // 
            // label3
            // 
            label3.AutoSize =  true ;
            label3.Font =  new Font( "Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label3.Location =  new Point( 618, 21 ) ;
            label3.Name =  "label3" ;
            label3.Size =  new Size( 98, 20 ) ;
            label3.TabIndex =  5 ;
            label3.Text =  "School Year:" ;
            // 
            // label2
            // 
            label2.AutoSize =  true ;
            label2.Font =  new Font( "Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label2.Location =  new Point( 482, 21 ) ;
            label2.Name =  "label2" ;
            label2.Size =  new Size( 79, 20 ) ;
            label2.TabIndex =  4 ;
            label2.Text =  "Semester:" ;
            // 
            // label1
            // 
            label1.AutoSize =  true ;
            label1.Font =  new Font( "Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point ) ;
            label1.Location =  new Point( 15, 20 ) ;
            label1.Name =  "label1" ;
            label1.Size =  new Size( 65, 20 ) ;
            label1.TabIndex =  2 ;
            label1.Text =  "Course:" ;
            // 
            // table_schedule
            // 
            table_schedule.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.Fill ;
            table_schedule.AutoSizeRowsMode =  DataGridViewAutoSizeRowsMode.AllCells ;
            table_schedule.BackgroundColor =  Color.White ;
            table_schedule.ColumnHeadersBorderStyle =  DataGridViewHeaderBorderStyle.Single ;
            dataGridViewCellStyle1.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle1.BackColor =  SystemColors.Control ;
            dataGridViewCellStyle1.Font =  new Font( "Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle1.ForeColor =  SystemColors.WindowText ;
            dataGridViewCellStyle1.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle1.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle1.WrapMode =  DataGridViewTriState.True ;
            table_schedule.ColumnHeadersDefaultCellStyle =  dataGridViewCellStyle1 ;
            table_schedule.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
            table_schedule.Columns.AddRange( new DataGridViewColumn [] { section, subject_code, description, room, units, day, time, faculty } );
            dataGridViewCellStyle2.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle2.BackColor =  Color.White ;
            dataGridViewCellStyle2.Font =  new Font( "Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle2.ForeColor =  SystemColors.ControlText ;
            dataGridViewCellStyle2.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle2.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle2.WrapMode =  DataGridViewTriState.False ;
            table_schedule.DefaultCellStyle =  dataGridViewCellStyle2 ;
            table_schedule.EditMode =  DataGridViewEditMode.EditProgrammatically ;
            table_schedule.GridColor =  Color.Black ;
            table_schedule.Location =  new Point( 12, 59 ) ;
            table_schedule.Name =  "table_schedule" ;
            table_schedule.RowHeadersBorderStyle =  DataGridViewHeaderBorderStyle.Single ;
            dataGridViewCellStyle3.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle3.BackColor =  Color.White ;
            dataGridViewCellStyle3.Font =  new Font( "Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle3.ForeColor =  SystemColors.WindowText ;
            dataGridViewCellStyle3.Padding =  new Padding( 3 ) ;
            dataGridViewCellStyle3.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle3.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle3.WrapMode =  DataGridViewTriState.True ;
            table_schedule.RowHeadersDefaultCellStyle =  dataGridViewCellStyle3 ;
            table_schedule.RowHeadersVisible =  false ;
            dataGridViewCellStyle4.Padding =  new Padding( 3 ) ;
            table_schedule.RowsDefaultCellStyle =  dataGridViewCellStyle4 ;
            table_schedule.RowTemplate.Height =  25 ;
            table_schedule.Size =  new Size( 960, 340 ) ;
            table_schedule.TabIndex =  0 ;
            // 
            // section
            // 
            section.HeaderText =  "Section" ;
            section.Name =  "section" ;
            section.ReadOnly =  true ;
            // 
            // subject_code
            // 
            subject_code.HeaderText =  "Subject Code" ;
            subject_code.Name =  "subject_code" ;
            subject_code.ReadOnly =  true ;
            // 
            // description
            // 
            description.HeaderText =  "Description" ;
            description.Name =  "description" ;
            description.ReadOnly =  true ;
            // 
            // room
            // 
            room.HeaderText =  "Room" ;
            room.Name =  "room" ;
            room.ReadOnly =  true ;
            // 
            // units
            // 
            units.HeaderText =  "Units" ;
            units.Name =  "units" ;
            units.ReadOnly =  true ;
            // 
            // day
            // 
            day.HeaderText =  "Day" ;
            day.Name =  "day" ;
            day.ReadOnly =  true ;
            // 
            // time
            // 
            time.HeaderText =  "Time" ;
            time.Name =  "time" ;
            time.ReadOnly =  true ;
            // 
            // faculty
            // 
            faculty.HeaderText =  "Faculty" ;
            faculty.Name =  "faculty" ;
            faculty.ReadOnly =  true ;
            // 
            // Schedule
            // 
            AutoScaleDimensions =  new SizeF( 7F, 15F ) ;
            AutoScaleMode =  AutoScaleMode.Font ;
            ClientSize =  new Size( 984, 411 ) ;
            Controls.Add( panel1 );
            Name =  "Schedule" ;
            StartPosition =  FormStartPosition.CenterScreen ;
            Text =  "Schedule" ;
            panel1.ResumeLayout( false );
            panel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)  table_schedule  ).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView table_schedule;
        private TextBox txtbox_courseName;
        private DataGridViewTextBoxColumn section;
        private DataGridViewTextBoxColumn subject_code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn units;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn faculty;
    }
}