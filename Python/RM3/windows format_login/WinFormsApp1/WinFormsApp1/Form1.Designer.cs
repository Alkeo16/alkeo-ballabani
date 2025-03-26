namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            login_username_groupBox1 = new GroupBox();
            login_username_textBox = new TextBox();
            login_password_groupBox2 = new GroupBox();
            login_password_textBox = new TextBox();
            LOG_IN_button1 = new Button();
            sign_up = new Button();
            signup_password_groupBox = new GroupBox();
            signup_password_textBox = new TextBox();
            signup_username_groupBox = new GroupBox();
            signup_username_textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            login_username_groupBox1.SuspendLayout();
            login_password_groupBox2.SuspendLayout();
            signup_password_groupBox.SuspendLayout();
            signup_username_groupBox.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 100);
            label1.Name = "label1";
            label1.Size = new Size(270, 40);
            label1.TabIndex = 0;
            label1.Text = "WELCOME BACK";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 180);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 1;
            label2.Text = "LOG IN";
            // 
            // login_username_groupBox1
            // 
            login_username_groupBox1.Controls.Add(login_username_textBox);
            login_username_groupBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login_username_groupBox1.Location = new Point(365, 271);
            login_username_groupBox1.Name = "login_username_groupBox1";
            login_username_groupBox1.Size = new Size(270, 100);
            login_username_groupBox1.TabIndex = 2;
            login_username_groupBox1.TabStop = false;
            login_username_groupBox1.Text = "Username";
            // 
            // login_username_textBox
            // 
            login_username_textBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login_username_textBox.Location = new Point(10, 40);
            login_username_textBox.Name = "login_username_textBox";
            login_username_textBox.Size = new Size(250, 30);
            login_username_textBox.TabIndex = 4;
            // 
            // login_password_groupBox2
            // 
            login_password_groupBox2.Controls.Add(login_password_textBox);
            login_password_groupBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login_password_groupBox2.Location = new Point(365, 395);
            login_password_groupBox2.Name = "login_password_groupBox2";
            login_password_groupBox2.Size = new Size(270, 100);
            login_password_groupBox2.TabIndex = 3;
            login_password_groupBox2.TabStop = false;
            login_password_groupBox2.Text = "Password";
            // 
            // login_password_textBox
            // 
            login_password_textBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login_password_textBox.Location = new Point(10, 40);
            login_password_textBox.Name = "login_password_textBox";
            login_password_textBox.Size = new Size(250, 30);
            login_password_textBox.TabIndex = 5;
            // 
            // LOG_IN_button1
            // 
            LOG_IN_button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LOG_IN_button1.Location = new Point(365, 526);
            LOG_IN_button1.Name = "LOG_IN_button1";
            LOG_IN_button1.Size = new Size(270, 29);
            LOG_IN_button1.TabIndex = 4;
            LOG_IN_button1.Text = "LOG IN";
            LOG_IN_button1.UseVisualStyleBackColor = true;
            LOG_IN_button1.Click += button1_Click;
            // 
            // sign_up
            // 
            sign_up.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_up.Location = new Point(254, 524);
            sign_up.Name = "sign_up";
            sign_up.Size = new Size(270, 29);
            sign_up.TabIndex = 9;
            sign_up.Text = "SIGN UP";
            sign_up.UseVisualStyleBackColor = true;
            sign_up.Click += sign_up_Click;
            // 
            // signup_password_groupBox
            // 
            signup_password_groupBox.Controls.Add(signup_password_textBox);
            signup_password_groupBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signup_password_groupBox.Location = new Point(254, 393);
            signup_password_groupBox.Name = "signup_password_groupBox";
            signup_password_groupBox.Size = new Size(270, 100);
            signup_password_groupBox.TabIndex = 8;
            signup_password_groupBox.TabStop = false;
            signup_password_groupBox.Text = "Password";
            // 
            // signup_password_textBox
            // 
            signup_password_textBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signup_password_textBox.Location = new Point(10, 40);
            signup_password_textBox.Name = "signup_password_textBox";
            signup_password_textBox.Size = new Size(250, 30);
            signup_password_textBox.TabIndex = 5;
            // 
            // signup_username_groupBox
            // 
            signup_username_groupBox.Controls.Add(signup_username_textBox);
            signup_username_groupBox.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signup_username_groupBox.Location = new Point(254, 269);
            signup_username_groupBox.Name = "signup_username_groupBox";
            signup_username_groupBox.Size = new Size(270, 100);
            signup_username_groupBox.TabIndex = 7;
            signup_username_groupBox.TabStop = false;
            signup_username_groupBox.Text = "Username";
            // 
            // signup_username_textBox
            // 
            signup_username_textBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signup_username_textBox.Location = new Point(10, 40);
            signup_username_textBox.Name = "signup_username_textBox";
            signup_username_textBox.Size = new Size(250, 30);
            signup_username_textBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 178);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 6;
            label3.Text = "SIGN UP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(254, 98);
            label4.Name = "label4";
            label4.Size = new Size(270, 40);
            label4.TabIndex = 5;
            label4.Text = "WELCOME BACK";
            // 
            // panel1
            // 
            panel1.Controls.Add(LOG_IN_button1);
            panel1.Controls.Add(login_password_groupBox2);
            panel1.Controls.Add(login_username_groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 584);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(sign_up);
            panel2.Controls.Add(signup_password_groupBox);
            panel2.Controls.Add(signup_username_groupBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(900, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 583);
            panel2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            dataGridView1.Location = new Point(654, 674);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(426, 245);
            dataGridView1.TabIndex = 12;
            // 
            // Column2
            // 
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            login_username_groupBox1.ResumeLayout(false);
            login_username_groupBox1.PerformLayout();
            login_password_groupBox2.ResumeLayout(false);
            login_password_groupBox2.PerformLayout();
            signup_password_groupBox.ResumeLayout(false);
            signup_password_groupBox.PerformLayout();
            signup_username_groupBox.ResumeLayout(false);
            signup_username_groupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox login_username_groupBox1;
        private GroupBox login_password_groupBox2;
        private TextBox login_username_textBox;
        private TextBox login_password_textBox;
        private Button LOG_IN_button1;
        private Button sign_up;
        private GroupBox signup_password_groupBox;
        private TextBox signup_password_textBox;
        private GroupBox signup_username_groupBox;
        private TextBox signup_username_textBox;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
