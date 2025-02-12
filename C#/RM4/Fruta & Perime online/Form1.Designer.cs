namespace Fruta___Perime_online
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
            ID_groupBox = new GroupBox();
            ID_textBox = new TextBox();
            panel1 = new Panel();
            Kategoria_groupBox = new GroupBox();
            Kategoria_comboBox = new ComboBox();
            Cmimi_groupBox = new GroupBox();
            Cmimi_textBox = new TextBox();
            Emri_groupBox = new GroupBox();
            Emri_textBox = new TextBox();
            frutaperime_dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ID_groupBox.SuspendLayout();
            Kategoria_groupBox.SuspendLayout();
            Cmimi_groupBox.SuspendLayout();
            Emri_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frutaperime_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // ID_groupBox
            // 
            ID_groupBox.Controls.Add(ID_textBox);
            ID_groupBox.Location = new Point(12, 106);
            ID_groupBox.Name = "ID_groupBox";
            ID_groupBox.Size = new Size(137, 59);
            ID_groupBox.TabIndex = 0;
            ID_groupBox.TabStop = false;
            ID_groupBox.Text = "ID";
            // 
            // ID_textBox
            // 
            ID_textBox.Location = new Point(6, 26);
            ID_textBox.Name = "ID_textBox";
            ID_textBox.Size = new Size(125, 27);
            ID_textBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 100);
            panel1.TabIndex = 1;
            // 
            // Kategoria_groupBox
            // 
            Kategoria_groupBox.Controls.Add(Kategoria_comboBox);
            Kategoria_groupBox.Location = new Point(12, 165);
            Kategoria_groupBox.Name = "Kategoria_groupBox";
            Kategoria_groupBox.Size = new Size(137, 59);
            Kategoria_groupBox.TabIndex = 2;
            Kategoria_groupBox.TabStop = false;
            Kategoria_groupBox.Text = "Kategoria";
            // 
            // Kategoria_comboBox
            // 
            Kategoria_comboBox.FormattingEnabled = true;
            Kategoria_comboBox.Items.AddRange(new object[] { "Frutta", "Perime" });
            Kategoria_comboBox.Location = new Point(6, 25);
            Kategoria_comboBox.Name = "Kategoria_comboBox";
            Kategoria_comboBox.Size = new Size(125, 28);
            Kategoria_comboBox.TabIndex = 5;
            // 
            // Cmimi_groupBox
            // 
            Cmimi_groupBox.Controls.Add(Cmimi_textBox);
            Cmimi_groupBox.Location = new Point(12, 295);
            Cmimi_groupBox.Name = "Cmimi_groupBox";
            Cmimi_groupBox.Size = new Size(137, 59);
            Cmimi_groupBox.TabIndex = 3;
            Cmimi_groupBox.TabStop = false;
            Cmimi_groupBox.Text = "Cmimi";
            // 
            // Cmimi_textBox
            // 
            Cmimi_textBox.Location = new Point(6, 26);
            Cmimi_textBox.Name = "Cmimi_textBox";
            Cmimi_textBox.Size = new Size(125, 27);
            Cmimi_textBox.TabIndex = 1;
            // 
            // Emri_groupBox
            // 
            Emri_groupBox.Controls.Add(Emri_textBox);
            Emri_groupBox.Location = new Point(12, 230);
            Emri_groupBox.Name = "Emri_groupBox";
            Emri_groupBox.Size = new Size(137, 59);
            Emri_groupBox.TabIndex = 4;
            Emri_groupBox.TabStop = false;
            Emri_groupBox.Text = "Emri";
            // 
            // Emri_textBox
            // 
            Emri_textBox.Location = new Point(6, 26);
            Emri_textBox.Name = "Emri_textBox";
            Emri_textBox.Size = new Size(125, 27);
            Emri_textBox.TabIndex = 1;
            // 
            // frutaperime_dataGridView
            // 
            frutaperime_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            frutaperime_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            frutaperime_dataGridView.Location = new Point(155, 106);
            frutaperime_dataGridView.Name = "frutaperime_dataGridView";
            frutaperime_dataGridView.RowHeadersWidth = 51;
            frutaperime_dataGridView.Size = new Size(1095, 254);
            frutaperime_dataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Emri";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cmimi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kategoria";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(18, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(18, 395);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(18, 430);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(frutaperime_dataGridView);
            Controls.Add(Emri_groupBox);
            Controls.Add(Cmimi_groupBox);
            Controls.Add(Kategoria_groupBox);
            Controls.Add(panel1);
            Controls.Add(ID_groupBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ID_groupBox.ResumeLayout(false);
            ID_groupBox.PerformLayout();
            Kategoria_groupBox.ResumeLayout(false);
            Cmimi_groupBox.ResumeLayout(false);
            Cmimi_groupBox.PerformLayout();
            Emri_groupBox.ResumeLayout(false);
            Emri_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frutaperime_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ID_groupBox;
        private TextBox ID_textBox;
        private Panel panel1;
        private GroupBox Kategoria_groupBox;
        private GroupBox Cmimi_groupBox;
        private TextBox Cmimi_textBox;
        private GroupBox Emri_groupBox;
        private TextBox Emri_textBox;
        private ComboBox Kategoria_comboBox;
        private DataGridView frutaperime_dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
