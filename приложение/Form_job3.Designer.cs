namespace приложение
{
    partial class Form_job3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.but_hafmen = new System.Windows.Forms.Button();
            this.but_shenon = new System.Windows.Forms.Button();
            this.RichText_name = new System.Windows.Forms.RichTextBox();
            this.RichText_ver = new System.Windows.Forms.RichTextBox();
            this.Text_name = new System.Windows.Forms.TextBox();
            this.Text_ver = new System.Windows.Forms.TextBox();
            this.Butt_add = new System.Windows.Forms.Button();
            this.but_cod = new System.Windows.Forms.Button();
            this.Err_add = new System.Windows.Forms.RichTextBox();
            this.Text_slovo = new System.Windows.Forms.TextBox();
            this.Text_Zacod = new System.Windows.Forms.TextBox();
            this.ZacodRichText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(276, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(179, 36);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Вероятности";
            // 
            // but_hafmen
            // 
            this.but_hafmen.Location = new System.Drawing.Point(12, 54);
            this.but_hafmen.Name = "but_hafmen";
            this.but_hafmen.Size = new System.Drawing.Size(175, 62);
            this.but_hafmen.TabIndex = 1;
            this.but_hafmen.Text = "Метод Хафмена";
            this.but_hafmen.UseVisualStyleBackColor = true;
            this.but_hafmen.Click += new System.EventHandler(this.but_hafmen_Click);
            // 
            // but_shenon
            // 
            this.but_shenon.Location = new System.Drawing.Point(539, 54);
            this.but_shenon.Name = "but_shenon";
            this.but_shenon.Size = new System.Drawing.Size(175, 62);
            this.but_shenon.TabIndex = 2;
            this.but_shenon.Text = "Метод Шенона";
            this.but_shenon.UseVisualStyleBackColor = true;
            this.but_shenon.Click += new System.EventHandler(this.but_shenon_Click);
            // 
            // RichText_name
            // 
            this.RichText_name.BackColor = System.Drawing.SystemColors.Control;
            this.RichText_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichText_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichText_name.Location = new System.Drawing.Point(12, 149);
            this.RichText_name.Name = "RichText_name";
            this.RichText_name.ReadOnly = true;
            this.RichText_name.Size = new System.Drawing.Size(702, 36);
            this.RichText_name.TabIndex = 3;
            this.RichText_name.Text = "Введите название";
            this.RichText_name.Visible = false;
            this.RichText_name.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // RichText_ver
            // 
            this.RichText_ver.BackColor = System.Drawing.SystemColors.Control;
            this.RichText_ver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichText_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichText_ver.Location = new System.Drawing.Point(12, 245);
            this.RichText_ver.Name = "RichText_ver";
            this.RichText_ver.ReadOnly = true;
            this.RichText_ver.Size = new System.Drawing.Size(301, 36);
            this.RichText_ver.TabIndex = 4;
            this.RichText_ver.Text = "Введите вероятность";
            this.RichText_ver.Visible = false;
            // 
            // Text_name
            // 
            this.Text_name.Location = new System.Drawing.Point(12, 191);
            this.Text_name.Multiline = true;
            this.Text_name.Name = "Text_name";
            this.Text_name.Size = new System.Drawing.Size(127, 48);
            this.Text_name.TabIndex = 5;
            this.Text_name.Visible = false;
            // 
            // Text_ver
            // 
            this.Text_ver.Location = new System.Drawing.Point(12, 287);
            this.Text_ver.Multiline = true;
            this.Text_ver.Name = "Text_ver";
            this.Text_ver.Size = new System.Drawing.Size(127, 47);
            this.Text_ver.TabIndex = 6;
            this.Text_ver.Visible = false;
            // 
            // Butt_add
            // 
            this.Butt_add.Location = new System.Drawing.Point(12, 350);
            this.Butt_add.Name = "Butt_add";
            this.Butt_add.Size = new System.Drawing.Size(175, 62);
            this.Butt_add.TabIndex = 7;
            this.Butt_add.Text = "Добавить";
            this.Butt_add.UseVisualStyleBackColor = true;
            this.Butt_add.Visible = false;
            this.Butt_add.Click += new System.EventHandler(this.Butt_add_Click);
            // 
            // but_cod
            // 
            this.but_cod.Location = new System.Drawing.Point(219, 350);
            this.but_cod.Name = "but_cod";
            this.but_cod.Size = new System.Drawing.Size(175, 62);
            this.but_cod.TabIndex = 8;
            this.but_cod.Text = "Закодировать ";
            this.but_cod.UseVisualStyleBackColor = true;
            this.but_cod.Visible = false;
            this.but_cod.Click += new System.EventHandler(this.but_cod_Click);
            // 
            // Err_add
            // 
            this.Err_add.BackColor = System.Drawing.SystemColors.Control;
            this.Err_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Err_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Err_add.ForeColor = System.Drawing.Color.Red;
            this.Err_add.Location = new System.Drawing.Point(145, 287);
            this.Err_add.Name = "Err_add";
            this.Err_add.ReadOnly = true;
            this.Err_add.Size = new System.Drawing.Size(249, 47);
            this.Err_add.TabIndex = 9;
            this.Err_add.Text = "Лимит превышен";
            this.Err_add.Visible = false;
            this.Err_add.WordWrap = false;
            // 
            // Text_slovo
            // 
            this.Text_slovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_slovo.Location = new System.Drawing.Point(12, 191);
            this.Text_slovo.Multiline = true;
            this.Text_slovo.Name = "Text_slovo";
            this.Text_slovo.Size = new System.Drawing.Size(702, 90);
            this.Text_slovo.TabIndex = 10;
            this.Text_slovo.Visible = false;
            this.Text_slovo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_slovo_KeyPress);
            // 
            // Text_Zacod
            // 
            this.Text_Zacod.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Zacod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Zacod.Location = new System.Drawing.Point(12, 363);
            this.Text_Zacod.Multiline = true;
            this.Text_Zacod.Name = "Text_Zacod";
            this.Text_Zacod.ReadOnly = true;
            this.Text_Zacod.Size = new System.Drawing.Size(702, 90);
            this.Text_Zacod.TabIndex = 11;
            this.Text_Zacod.Visible = false;
            // 
            // ZacodRichText
            // 
            this.ZacodRichText.BackColor = System.Drawing.SystemColors.Control;
            this.ZacodRichText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZacodRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZacodRichText.Location = new System.Drawing.Point(12, 321);
            this.ZacodRichText.Name = "ZacodRichText";
            this.ZacodRichText.ReadOnly = true;
            this.ZacodRichText.Size = new System.Drawing.Size(257, 36);
            this.ZacodRichText.TabIndex = 12;
            this.ZacodRichText.Text = "Код";
            this.ZacodRichText.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Заново";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(581, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 33);
            this.button5.TabIndex = 23;
            this.button5.Text = "Вернуться в меню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form_job3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 498);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ZacodRichText);
            this.Controls.Add(this.Text_Zacod);
            this.Controls.Add(this.Text_slovo);
            this.Controls.Add(this.Err_add);
            this.Controls.Add(this.but_cod);
            this.Controls.Add(this.Butt_add);
            this.Controls.Add(this.Text_ver);
            this.Controls.Add(this.Text_name);
            this.Controls.Add(this.RichText_ver);
            this.Controls.Add(this.RichText_name);
            this.Controls.Add(this.but_shenon);
            this.Controls.Add(this.but_hafmen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form_job3";
            this.Text = "Form_job3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button but_hafmen;
        private System.Windows.Forms.Button but_shenon;
        private System.Windows.Forms.RichTextBox RichText_name;
        private System.Windows.Forms.RichTextBox RichText_ver;
        private System.Windows.Forms.TextBox Text_name;
        private System.Windows.Forms.TextBox Text_ver;
        private System.Windows.Forms.Button Butt_add;
        private System.Windows.Forms.Button but_cod;
        private System.Windows.Forms.RichTextBox Err_add;
        private System.Windows.Forms.TextBox Text_slovo;
        private System.Windows.Forms.TextBox Text_Zacod;
        private System.Windows.Forms.RichTextBox ZacodRichText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}