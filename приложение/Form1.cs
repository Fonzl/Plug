using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace приложение
{
    public partial class Приложение : Form
    {
        public Приложение()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 job_1 = new Form3();
            job_1.ShowDialog();
            Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Job2 job_2 = new Form_Job2();
            job_2.ShowDialog();
            Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form_job3 job_3 = new Form_job3();
            job_3.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms_job4 g = new Forms_job4() ;
            Hide();
            g.ShowDialog();
            Show();
        }

    

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
             Close();
        }
    }
}
