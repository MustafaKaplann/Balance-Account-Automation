namespace AccAutomation
{
    partial class EnterDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterDataForm));
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            panel1 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            label12 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            button4 = new Button();
            textBox5 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            button6 = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button7 = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(483, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(70, 107);
            label6.Name = "label6";
            label6.Size = new Size(2, 25);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 4;
            label5.Text = "Today:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(77, 72);
            label4.Name = "label4";
            label4.Size = new Size(2, 25);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(58, 37);
            label2.Name = "label2";
            label2.Size = new Size(2, 25);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 0;
            label1.Text = "Year:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(260, 61);
            maskedTextBox1.Mask = "00000000000000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(185, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Location = new Point(11, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 177);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(144, 122);
            button1.Name = "button1";
            button1.Size = new Size(192, 39);
            button1.TabIndex = 9;
            button1.Text = "Add to Chart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 44);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 64);
            textBox3.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(316, 5);
            label10.Name = "label10";
            label10.Size = new Size(72, 23);
            label10.TabIndex = 6;
            label10.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(62, 2);
            label9.Name = "label9";
            label9.Size = new Size(96, 23);
            label9.TabIndex = 5;
            label9.Text = "Description";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(6, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(809, 267);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Revenue Description";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 269;
            // 
            // Column2
            // 
            Column2.HeaderText = "Net Revenue Amount ($)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 269;
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 215;
            // 
            // button2
            // 
            button2.Location = new Point(6, 335);
            button2.Name = "button2";
            button2.Size = new Size(150, 57);
            button2.TabIndex = 8;
            button2.Text = "Delete Selected";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(162, 335);
            button3.Name = "button3";
            button3.Size = new Size(150, 57);
            button3.TabIndex = 9;
            button3.Text = "Delete All Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(365, 13);
            label12.Name = "label12";
            label12.Size = new Size(90, 32);
            label12.TabIndex = 10;
            label12.Text = "CHART";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 480);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(821, 403);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(318, 335);
            button5.Name = "button5";
            button5.Size = new Size(165, 57);
            button5.TabIndex = 11;
            button5.Text = "Create Balance Sheet\r\nFor This Month\r\n";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(maskedTextBox2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(11, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 177);
            panel2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(239, 65);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 11;
            label7.Text = "-";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(260, 62);
            maskedTextBox2.Mask = "00000000000000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(185, 27);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.Location = new Point(144, 134);
            button4.Name = "button4";
            button4.Size = new Size(192, 39);
            button4.TabIndex = 9;
            button4.Text = "Add to Chart";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(28, 43);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 64);
            textBox5.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(304, 8);
            label14.Name = "label14";
            label14.Size = new Size(96, 23);
            label14.TabIndex = 6;
            label14.Text = "Amount (-)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(62, 4);
            label15.Name = "label15";
            label15.Size = new Size(96, 23);
            label15.TabIndex = 5;
            label15.Text = "Description";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4 });
            dataGridView2.Location = new Point(483, 217);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(351, 208);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column4
            // 
            Column4.HeaderText = "This Month's Balance ($)";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 295;
            // 
            // button6
            // 
            button6.Location = new Point(724, 889);
            button6.Name = "button6";
            button6.Size = new Size(109, 37);
            button6.TabIndex = 16;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label17
            // 
            label17.BackColor = Color.LightGreen;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(11, 21);
            label17.Name = "label17";
            label17.Size = new Size(459, 35);
            label17.TabIndex = 17;
            label17.Text = "ADD REVENUE";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = Color.Firebrick;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(11, 255);
            label18.Name = "label18";
            label18.Size = new Size(459, 35);
            label18.TabIndex = 18;
            label18.Text = "ADD EXPENSE";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = Color.Goldenrod;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(483, 179);
            label19.Name = "label19";
            label19.Size = new Size(350, 35);
            label19.TabIndex = 19;
            label19.Text = "BALANCE SHEET";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.Location = new Point(483, 431);
            button7.Name = "button7";
            button7.Size = new Size(350, 43);
            button7.TabIndex = 20;
            button7.Text = "Enter Data";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // EnterDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(23, 15, 51);
            ClientSize = new Size(846, 939);
            Controls.Add(button7);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(button6);
            Controls.Add(dataGridView2);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EnterDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Data";
            Load += EnterDataForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label12;
        private GroupBox groupBox2;
        private Panel panel2;
        private Button button4;
        private TextBox textBox5;
        private Label label14;
        private Label label15;
        private MaskedTextBox maskedTextBox2;
        private Button button5;
        private DataGridView dataGridView2;
        private Button button6;
        private DataGridViewTextBoxColumn Column4;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label7;
    }
}