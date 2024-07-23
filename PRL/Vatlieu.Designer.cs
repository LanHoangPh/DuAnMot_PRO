namespace PRL
{
    partial class Vatlieu
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
            groupBox1 = new GroupBox();
            tb_timkiemvl = new TextBox();
            label3 = new Label();
            textBox_tenVl = new TextBox();
            panel1 = new Panel();
            btn_deletevl = new Button();
            btn_updatevl = new Button();
            btn_addvl = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_maVl = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 192, 192);
            groupBox1.Controls.Add(tb_timkiemvl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_tenVl);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_maVl);
            groupBox1.Location = new Point(22, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1088, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // tb_timkiemvl
            // 
            tb_timkiemvl.Location = new Point(187, 225);
            tb_timkiemvl.Multiline = true;
            tb_timkiemvl.Name = "tb_timkiemvl";
            tb_timkiemvl.Size = new Size(332, 44);
            tb_timkiemvl.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 232);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 5;
            label3.Text = "Tìm Kiếm";
            // 
            // textBox_tenVl
            // 
            textBox_tenVl.Location = new Point(187, 131);
            textBox_tenVl.Multiline = true;
            textBox_tenVl.Name = "textBox_tenVl";
            textBox_tenVl.Size = new Size(332, 44);
            textBox_tenVl.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_deletevl);
            panel1.Controls.Add(btn_updatevl);
            panel1.Controls.Add(btn_addvl);
            panel1.Location = new Point(596, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 246);
            panel1.TabIndex = 3;
            // 
            // btn_deletevl
            // 
            btn_deletevl.Location = new Point(111, 171);
            btn_deletevl.Name = "btn_deletevl";
            btn_deletevl.Size = new Size(265, 61);
            btn_deletevl.TabIndex = 2;
            btn_deletevl.Text = "Delete";
            btn_deletevl.UseVisualStyleBackColor = true;
            // 
            // btn_updatevl
            // 
            btn_updatevl.Location = new Point(111, 91);
            btn_updatevl.Name = "btn_updatevl";
            btn_updatevl.Size = new Size(265, 61);
            btn_updatevl.TabIndex = 1;
            btn_updatevl.Text = "Update";
            btn_updatevl.UseVisualStyleBackColor = true;
            // 
            // btn_addvl
            // 
            btn_addvl.Location = new Point(111, 12);
            btn_addvl.Name = "btn_addvl";
            btn_addvl.Size = new Size(265, 61);
            btn_addvl.TabIndex = 0;
            btn_addvl.Text = "Add";
            btn_addvl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(61, 141);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên Vật Liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(61, 35);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "MaVatLieu";
            // 
            // textBox_maVl
            // 
            textBox_maVl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_maVl.Location = new Point(187, 23);
            textBox_maVl.Multiline = true;
            textBox_maVl.Name = "textBox_maVl";
            textBox_maVl.Size = new Size(332, 44);
            textBox_maVl.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(22, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1088, 373);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 300);
            dataGridView1.TabIndex = 0;
            // 
            // Vatlieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 688);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Vatlieu";
            Text = "Vatlieu";
            Load += Vatlieu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox_maVl;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox tb_timkiemvl;
        private Label label3;
        private TextBox textBox_tenVl;
        private Panel panel1;
        private Button btn_deletevl;
        private Button btn_updatevl;
        private Button btn_addvl;
    }
}