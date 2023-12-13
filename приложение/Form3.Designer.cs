namespace приложение
{
    partial class Form3
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Start_reb = new System.Windows.Forms.TextBox();
            this.End_reb = new System.Windows.Forms.TextBox();
            this.Add_rebro = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Rez_oren = new System.Windows.Forms.TextBox();
            this.Rez_Neoren = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox2.Size = new System.Drawing.Size(702, 48);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "Графы";
            // 
            // Start_reb
            // 
            this.Start_reb.Location = new System.Drawing.Point(407, 89);
            this.Start_reb.Multiline = true;
            this.Start_reb.Name = "Start_reb";
            this.Start_reb.Size = new System.Drawing.Size(295, 40);
            this.Start_reb.TabIndex = 10;
            this.Start_reb.TextChanged += new System.EventHandler(this.Start_reb_TextChanged);
            // 
            // End_reb
            // 
            this.End_reb.Location = new System.Drawing.Point(408, 135);
            this.End_reb.Multiline = true;
            this.End_reb.Name = "End_reb";
            this.End_reb.Size = new System.Drawing.Size(294, 40);
            this.End_reb.TabIndex = 8;
            this.End_reb.TextChanged += new System.EventHandler(this.End_reb_TextChanged);
            // 
            // Add_rebro
            // 
            this.Add_rebro.Location = new System.Drawing.Point(12, 181);
            this.Add_rebro.Name = "Add_rebro";
            this.Add_rebro.Size = new System.Drawing.Size(133, 33);
            this.Add_rebro.TabIndex = 13;
            this.Add_rebro.Text = "Добавить";
            this.Add_rebro.UseVisualStyleBackColor = true;
            this.Add_rebro.Click += new System.EventHandler(this.Add_rebro_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox4.Location = new System.Drawing.Point(12, 135);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(390, 40);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "Введите конечная точку ребра";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(12, 89);
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(390, 40);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "Введите начальную точку ребра";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Орентироввнный";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Не орентироввнный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(690, 48);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Какой граф строить?";
            // 
            // Rez_oren
            // 
            this.Rez_oren.BackColor = System.Drawing.SystemColors.Window;
            this.Rez_oren.Location = new System.Drawing.Point(12, 322);
            this.Rez_oren.Multiline = true;
            this.Rez_oren.Name = "Rez_oren";
            this.Rez_oren.Size = new System.Drawing.Size(295, 133);
            this.Rez_oren.TabIndex = 18;
            this.Rez_oren.Visible = false;
            this.Rez_oren.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Rez_Neoren
            // 
            this.Rez_Neoren.BackColor = System.Drawing.SystemColors.Window;
            this.Rez_Neoren.Location = new System.Drawing.Point(419, 322);
            this.Rez_Neoren.Multiline = true;
            this.Rez_Neoren.Name = "Rez_Neoren";
            this.Rez_Neoren.ReadOnly = true;
            this.Rez_Neoren.Size = new System.Drawing.Size(295, 133);
            this.Rez_Neoren.TabIndex = 19;
            this.Rez_Neoren.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 33);
            this.button3.TabIndex = 20;
            this.button3.Text = "Заново";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 33);
            this.button4.TabIndex = 21;
            this.button4.Text = "Вернуться в меню";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 498);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rez_Neoren);
            this.Controls.Add(this.Rez_oren);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_rebro);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.End_reb);
            this.Controls.Add(this.Start_reb);
            this.Name = "Form3";
            this.Text = "ПР №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox Start_reb;
        private System.Windows.Forms.TextBox End_reb;
        private System.Windows.Forms.Button Add_rebro;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Rez_oren;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Rez_Neoren;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}