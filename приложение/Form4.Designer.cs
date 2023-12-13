namespace приложение
{
    partial class Form_Job2
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
            this.Add_Node = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Text_Add = new System.Windows.Forms.TextBox();
            this.Err_Add = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Add_root = new System.Windows.Forms.TextBox();
            this.Del_Node = new System.Windows.Forms.TextBox();
            this.End_norml = new System.Windows.Forms.RichTextBox();
            this.Print_tree = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(710, 41);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Дерево";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Add_Node
            // 
            this.Add_Node.Location = new System.Drawing.Point(12, 59);
            this.Add_Node.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.Add_Node.Name = "Add_Node";
            this.Add_Node.Size = new System.Drawing.Size(122, 44);
            this.Add_Node.TabIndex = 1;
            this.Add_Node.Text = "Добавить узел";
            this.Add_Node.UseVisualStyleBackColor = true;
            this.Add_Node.Visible = false;
            this.Add_Node.Click += new System.EventHandler(this.Add_Node_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обход в глубину ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 59);
            this.button3.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обход в ширину";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 59);
            this.button4.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить узел";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 109);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(580, 51);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "Введите номер узла для добавления ";
            this.richTextBox2.Visible = false;
            // 
            // Text_Add
            // 
            this.Text_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Add.Location = new System.Drawing.Point(12, 166);
            this.Text_Add.Multiline = true;
            this.Text_Add.Name = "Text_Add";
            this.Text_Add.Size = new System.Drawing.Size(122, 44);
            this.Text_Add.TabIndex = 6;
            this.Text_Add.Visible = false;
            this.Text_Add.Enter += new System.EventHandler(this.Text_Add_Enter);
            this.Text_Add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Add_KeyPress);
            // 
            // Err_Add
            // 
            this.Err_Add.BackColor = System.Drawing.SystemColors.Control;
            this.Err_Add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Err_Add.ForeColor = System.Drawing.Color.Red;
            this.Err_Add.Location = new System.Drawing.Point(140, 166);
            this.Err_Add.Name = "Err_Add";
            this.Err_Add.Size = new System.Drawing.Size(176, 44);
            this.Err_Add.TabIndex = 7;
            this.Err_Add.Text = "Узел с таким номером уже есть";
            this.Err_Add.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(12, 57);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(580, 51);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "Введите номер корня";
            // 
            // Add_root
            // 
            this.Add_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_root.Location = new System.Drawing.Point(12, 109);
            this.Add_root.Multiline = true;
            this.Add_root.Name = "Add_root";
            this.Add_root.Size = new System.Drawing.Size(122, 44);
            this.Add_root.TabIndex = 9;
            this.Add_root.Enter += new System.EventHandler(this.Add_root_Enter);
            this.Add_root.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Add_root_KeyPress);
            // 
            // Del_Node
            // 
            this.Del_Node.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_Node.Location = new System.Drawing.Point(12, 166);
            this.Del_Node.Multiline = true;
            this.Del_Node.Name = "Del_Node";
            this.Del_Node.Size = new System.Drawing.Size(122, 44);
            this.Del_Node.TabIndex = 10;
            this.Del_Node.Visible = false;
            this.Del_Node.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Del_Node_KeyPress);
            // 
            // End_norml
            // 
            this.End_norml.BackColor = System.Drawing.SystemColors.Control;
            this.End_norml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.End_norml.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.End_norml.ForeColor = System.Drawing.Color.SeaGreen;
            this.End_norml.Location = new System.Drawing.Point(12, 216);
            this.End_norml.Name = "End_norml";
            this.End_norml.ReadOnly = true;
            this.End_norml.Size = new System.Drawing.Size(580, 41);
            this.End_norml.TabIndex = 11;
            this.End_norml.Text = "Успешно добавлен узел";
            this.End_norml.Visible = false;
            // 
            // Print_tree
            // 
            this.Print_tree.BackColor = System.Drawing.SystemColors.Window;
            this.Print_tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Print_tree.Location = new System.Drawing.Point(12, 263);
            this.Print_tree.Multiline = true;
            this.Print_tree.Name = "Print_tree";
            this.Print_tree.ReadOnly = true;
            this.Print_tree.Size = new System.Drawing.Size(701, 144);
            this.Print_tree.TabIndex = 12;
            this.Print_tree.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Заново";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(580, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 33);
            this.button5.TabIndex = 22;
            this.button5.Text = "Вернуться в меню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form_Job2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 498);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Print_tree);
            this.Controls.Add(this.End_norml);
            this.Controls.Add(this.Del_Node);
            this.Controls.Add(this.Add_root);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Err_Add);
            this.Controls.Add(this.Text_Add);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_Node);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_Job2";
            this.Text = "ПР №2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Add_Node;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox Text_Add;
        private System.Windows.Forms.RichTextBox Err_Add;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox Add_root;
        private System.Windows.Forms.TextBox Del_Node;
        private System.Windows.Forms.RichTextBox End_norml;
        private System.Windows.Forms.TextBox Print_tree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}