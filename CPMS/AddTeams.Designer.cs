namespace CPMS
{
    partial class AddTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeams));
            label9 = new Label();
            textBox6 = new TextBox();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 10.8F);
            label9.Location = new Point(50, 286);
            label9.Name = "label9";
            label9.Size = new Size(103, 31);
            label9.TabIndex = 38;
            label9.Text = "Project Id";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Font = new Font("Segoe Print", 10.8F);
            textBox6.Location = new Point(166, 286);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(145, 39);
            textBox6.TabIndex = 37;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(437, 114);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(550, 364);
            dataGridView2.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 10.8F);
            label7.Location = new Point(28, 230);
            label7.Name = "label7";
            label7.Size = new Size(116, 31);
            label7.TabIndex = 35;
            label7.Text = " Supervisor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 10.8F);
            label8.Location = new Point(28, 169);
            label8.Name = "label8";
            label8.Size = new Size(126, 31);
            label8.TabIndex = 34;
            label8.Text = " TeamName";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe Print", 10.8F);
            textBox4.Location = new Point(166, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 39);
            textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe Print", 10.8F);
            textBox5.Location = new Point(166, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 39);
            textBox5.TabIndex = 32;
            // 
            // button4
            // 
            button4.BackColor = Color.Moccasin;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.Location = new Point(185, 340);
            button4.Name = "button4";
            button4.Size = new Size(102, 56);
            button4.TabIndex = 31;
            button4.Text = "Add Team";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.Location = new Point(185, 432);
            button1.Name = "button1";
            button1.Size = new Size(102, 56);
            button1.TabIndex = 39;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddTeams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(999, 512);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTeams";
            Text = "AddTeams";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox textBox6;
        private DataGridView dataGridView2;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button4;
        private Button button1;
    }
}