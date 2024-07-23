namespace PRL
{
    partial class NhaCC
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
            panel2 = new Panel();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 337);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(791, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 337);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1098, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // NhaCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 688);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NhaCC";
            Text = "NhaCC";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel2;
        private Panel panel1;
    }
}