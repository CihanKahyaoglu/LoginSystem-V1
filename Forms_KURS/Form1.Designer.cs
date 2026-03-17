namespace Forms_KURS
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
            silindir = new GroupBox();
            lblKURS = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            silindir.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // silindir
            // 
            silindir.BackColor = Color.SteelBlue;
            silindir.Controls.Add(lblKURS);
            silindir.Location = new Point(-3, -5);
            silindir.Name = "silindir";
            silindir.Size = new Size(359, 77);
            silindir.TabIndex = 0;
            silindir.TabStop = false;
            // 
            // lblKURS
            // 
            lblKURS.AutoSize = true;
            lblKURS.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblKURS.Location = new Point(0, 14);
            lblKURS.Name = "lblKURS";
            lblKURS.Size = new Size(294, 45);
            lblKURS.TabIndex = 1;
            lblKURS.Text = "KURS PROGRAMI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(12, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 237);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullancı Girişi";
            // 
            // button2
            // 
            button2.Location = new Point(186, 146);
            button2.Name = "button2";
            button2.Size = new Size(93, 30);
            button2.TabIndex = 5;
            button2.Text = "GİRİŞ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 146);
            button1.Name = "button1";
            button1.Size = new Size(93, 30);
            button1.TabIndex = 4;
            button1.Text = "KAYIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 88);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre::";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 42);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı::";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(348, 333);
            Controls.Add(groupBox2);
            Controls.Add(silindir);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing_1;
            silindir.ResumeLayout(false);
            silindir.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox silindir;
        private Label lblKURS;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}
