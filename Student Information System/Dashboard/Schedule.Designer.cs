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
            panel1 =  new Panel() ;
            dataGridView1 =  new DataGridView() ;
            label1 =  new Label() ;
            label2 =  new Label() ;
            label3 =  new Label() ;
            label4 =  new Label() ;
            label5 =  new Label() ;
            label6 =  new Label() ;
            label7 =  new Label() ;
            txtbox_courseName =  new TextBox() ;
            panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)  dataGridView1  ).BeginInit();
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
            panel1.Controls.Add( dataGridView1 );
            panel1.Dock =  DockStyle.Fill ;
            panel1.Location =  new Point( 0, 0 ) ;
            panel1.Name =  "panel1" ;
            panel1.Size =  new Size( 984, 411 ) ;
            panel1.TabIndex =  0 ;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor =  Color.White ;
            dataGridView1.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.AutoSize ;
            dataGridViewCellStyle1.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle1.BackColor =  Color.White ;
            dataGridViewCellStyle1.Font =  new Font( "Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle1.ForeColor =  SystemColors.ControlText ;
            dataGridViewCellStyle1.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle1.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle1.WrapMode =  DataGridViewTriState.False ;
            dataGridView1.DefaultCellStyle =  dataGridViewCellStyle1 ;
            dataGridView1.GridColor =  Color.Black ;
            dataGridView1.Location =  new Point( 12, 59 ) ;
            dataGridView1.Name =  "dataGridView1" ;
            dataGridView1.RowHeadersBorderStyle =  DataGridViewHeaderBorderStyle.Single ;
            dataGridViewCellStyle2.Alignment =  DataGridViewContentAlignment.MiddleCenter ;
            dataGridViewCellStyle2.BackColor =  SystemColors.Control ;
            dataGridViewCellStyle2.Font =  new Font( "Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point ) ;
            dataGridViewCellStyle2.ForeColor =  SystemColors.WindowText ;
            dataGridViewCellStyle2.SelectionBackColor =  SystemColors.Highlight ;
            dataGridViewCellStyle2.SelectionForeColor =  SystemColors.HighlightText ;
            dataGridViewCellStyle2.WrapMode =  DataGridViewTriState.True ;
            dataGridView1.RowHeadersDefaultCellStyle =  dataGridViewCellStyle2 ;
            dataGridView1.RowHeadersVisible =  false ;
            dataGridView1.RowTemplate.Height =  25 ;
            dataGridView1.Size =  new Size( 960, 340 ) ;
            dataGridView1.TabIndex =  0 ;
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
            // txtbox_courseName
            // 
            txtbox_courseName.BorderStyle =  BorderStyle.FixedSingle ;
            txtbox_courseName.Font =  new Font( "Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point ) ;
            txtbox_courseName.Location =  new Point( 86, 20 ) ;
            txtbox_courseName.MaxLength =  1000 ;
            txtbox_courseName.Name =  "txtbox_courseName" ;
            txtbox_courseName.Size =  new Size( 390, 23 ) ;
            txtbox_courseName.TabIndex =  10 ;
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
            ( (System.ComponentModel.ISupportInitialize)  dataGridView1  ).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox txtbox_courseName;
    }
}