
namespace CPMS
{
    partial class CPMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPMS));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button7 = new Button();
            textBox7 = new TextBox();
            button8 = new Button();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            button5 = new Button();
            textBox8 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(465, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(541, 234);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.Location = new Point(24, 41);
            button1.Name = "button1";
            button1.Size = new Size(102, 56);
            button1.TabIndex = 1;
            button1.Text = "Add Project";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.Location = new Point(24, 438);
            button2.Name = "button2";
            button2.Size = new Size(102, 102);
            button2.TabIndex = 2;
            button2.Text = "Delete Project &Team Related";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.Location = new Point(24, 116);
            button3.Name = "button3";
            button3.Size = new Size(98, 86);
            button3.TabIndex = 3;
            button3.Text = "Update Project Progress";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 10.8F);
            textBox1.Location = new Point(294, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe Print", 10.8F);
            textBox2.Location = new Point(294, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe Print", 10.8F);
            textBox3.Location = new Point(294, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 39);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Aquamarine;
            comboBox1.Font = new Font("Segoe Print", 10.8F);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "InProgress", "Preaper", "End" });
            comboBox1.Location = new Point(294, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 39);
            comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe Print", 9F);
            dateTimePicker1.Location = new Point(230, 291);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 34);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe Print", 9F);
            dateTimePicker2.Location = new Point(230, 348);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 34);
            dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 10.8F);
            label1.Location = new Point(156, 41);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 10;
            label1.Text = "ProjectName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10.8F);
            label2.Location = new Point(156, 102);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 11;
            label2.Text = "Budget";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 10.8F);
            label3.Location = new Point(156, 166);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 12;
            label3.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 10.8F);
            label4.Location = new Point(156, 221);
            label4.Name = "label4";
            label4.Size = new Size(79, 31);
            label4.TabIndex = 13;
            label4.Text = " Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 10.8F);
            label5.Location = new Point(128, 294);
            label5.Name = "label5";
            label5.Size = new Size(104, 31);
            label5.TabIndex = 14;
            label5.Text = "StartDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 10.8F);
            label6.Location = new Point(128, 348);
            label6.Name = "label6";
            label6.Size = new Size(92, 31);
            label6.TabIndex = 15;
            label6.Text = "EndDate";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(465, 371);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(541, 205);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button7
            // 
            button7.BackColor = Color.Moccasin;
            button7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button7.Location = new Point(555, 5);
            button7.Name = "button7";
            button7.Size = new Size(96, 103);
            button7.TabIndex = 26;
            button7.Text = "Search Project and Teams";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox7
            // 
            textBox7.AccessibleDescription = "";
            textBox7.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Font = new Font("Segoe Print", 10.8F);
            textBox7.Location = new Point(657, 33);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(64, 39);
            textBox7.TabIndex = 27;
            // 
            // button8
            // 
            button8.BackColor = Color.LightPink;
            button8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button8.Location = new Point(453, 41);
            button8.Name = "button8";
            button8.Size = new Size(96, 56);
            button8.TabIndex = 28;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 10.8F);
            label9.Location = new Point(198, 509);
            label9.Name = "label9";
            label9.Size = new Size(103, 31);
            label9.TabIndex = 30;
            label9.Text = "Project Id";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightCoral;
            textBox6.Font = new Font("Segoe Print", 10.8F);
            textBox6.Location = new Point(175, 458);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(145, 39);
            textBox6.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(143, 540);
            label10.Name = "label10";
            label10.Size = new Size(221, 17);
            label10.TabIndex = 31;
            label10.Text = "Enter The Project Id first ,then Button";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(20, 218);
            label11.MaximumSize = new Size(140, 60);
            label11.Name = "label11";
            label11.Size = new Size(133, 51);
            label11.TabIndex = 32;
            label11.Text = "Enter The Project Name & Progress first ,then Update";
            // 
            // button5
            // 
            button5.BackColor = Color.LightPink;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button5.Location = new Point(766, 19);
            button5.Name = "button5";
            button5.Size = new Size(96, 80);
            button5.TabIndex = 33;
            button5.Text = "Search By Project ID";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox8
            // 
            textBox8.AccessibleDescription = "";
            textBox8.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox8.Cursor = Cursors.IBeam;
            textBox8.Font = new Font("Segoe Print", 10.8F);
            textBox8.Location = new Point(894, 41);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(64, 39);
            textBox8.TabIndex = 34;
            // 
            // button6
            // 
            button6.BackColor = Color.Moccasin;
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button6.Location = new Point(20, 294);
            button6.Name = "button6";
            button6.Size = new Size(102, 56);
            button6.TabIndex = 35;
            button6.Text = "Add Team";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // CPMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1048, 615);
            Controls.Add(button6);
            Controls.Add(textBox8);
            Controls.Add(button5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(button8);
            Controls.Add(textBox7);
            Controls.Add(button7);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CPMS";
            Text = "CPMS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button7;
        private TextBox textBox7;
        private Button button8;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private Label label11;
        private Button button5;
        private TextBox textBox8;
        private Button button6;
    }
}
