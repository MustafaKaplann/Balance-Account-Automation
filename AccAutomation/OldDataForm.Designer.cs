namespace AccAutomation
{
    partial class OldDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldDataForm));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(525, 350);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(428, 447);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Goldenrod;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Lato", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(525, 41);
            label1.TabIndex = 7;
            label1.Text = "PREVIOUS MONTHS' BALANCE SHEET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(12, 447);
            button2.Name = "button2";
            button2.Size = new Size(109, 37);
            button2.TabIndex = 8;
            button2.Text = "Clear Datas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OldDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(23, 15, 51);
            ClientSize = new Size(556, 503);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OldDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OldDataForm";
            Load += OldDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}