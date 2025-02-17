namespace EntityFramework_Day3_Lab.Presentation
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            label8 = new Label();
            comboBox4 = new ComboBox();
            button2 = new Button();
            label14 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1062, 332);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 1;
            label1.Text = "Tasks";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(148, 430);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(70, 433);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(38, 478);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(60, 521);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 5;
            label4.Text = "DueDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(70, 563);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 6;
            label5.Text = "Priority";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(80, 605);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 7;
            label6.Text = "Status";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox2.Location = new Point(148, 475);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 30);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 521);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });
            comboBox1.Location = new Point(148, 558);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox2.Location = new Point(148, 605);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(60, 658);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 12;
            label7.Text = "Catagory";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(148, 653);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkTurquoise;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(193, 706);
            button1.Name = "button1";
            button1.Size = new Size(134, 48);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.AliceBlue;
            button3.Location = new Point(1067, 465);
            button3.Name = "button3";
            button3.Size = new Size(143, 48);
            button3.TabIndex = 28;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(994, 610);
            button4.Name = "button4";
            button4.Size = new Size(323, 48);
            button4.TabIndex = 29;
            button4.Text = "Press to Filter and Manage Tasks";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox4.Location = new Point(660, 435);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 30);
            textBox4.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label13.Location = new Point(582, 438);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 16;
            label13.Text = "Title";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label12.Location = new Point(550, 483);
            label12.Name = "label12";
            label12.Size = new Size(102, 23);
            label12.TabIndex = 17;
            label12.Text = "Description";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.Location = new Point(572, 526);
            label11.Name = "label11";
            label11.Size = new Size(80, 23);
            label11.TabIndex = 18;
            label11.Text = "DueDate";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Location = new Point(582, 568);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 19;
            label10.Text = "Priority";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Location = new Point(592, 610);
            label9.Name = "label9";
            label9.Size = new Size(60, 23);
            label9.TabIndex = 20;
            label9.Text = "Status";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox3.Location = new Point(660, 480);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 30);
            textBox3.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(660, 526);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 22;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });
            comboBox6.Location = new Point(660, 563);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(250, 28);
            comboBox6.TabIndex = 23;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox5.Location = new Point(660, 610);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(250, 28);
            comboBox5.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(572, 663);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 25;
            label8.Text = "Catagory";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(660, 658);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(250, 28);
            comboBox4.TabIndex = 26;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.AntiqueWhite;
            button2.Location = new Point(710, 708);
            button2.Name = "button2";
            button2.Size = new Size(126, 48);
            button2.TabIndex = 27;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1021, 531);
            label14.Name = "label14";
            label14.Size = new Size(246, 20);
            label14.TabIndex = 30;
            label14.Text = "Press here if you went to delete task";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.AntiqueWhite;
            button5.Location = new Point(994, 706);
            button5.Name = "button5";
            button5.Size = new Size(323, 48);
            button5.TabIndex = 31;
            button5.Text = "Press to show notify";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 834);
            Controls.Add(button5);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox4);
            Controls.Add(label8);
            Controls.Add(comboBox5);
            Controls.Add(comboBox6);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Index";
            Text = "Index";
            Load += Index_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private ComboBox comboBox3;
        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private Label label8;
        private ComboBox comboBox4;
        private Button button2;
        private Label label14;
        private Button button5;
    }
}