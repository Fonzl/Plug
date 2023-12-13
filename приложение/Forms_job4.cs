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
    public partial class Forms_job4 : Form
    {
      public class shif
        {
            public int offset;
            public int length;
            public string next;

        }

        static public string LZ77(string g)
        {
            string rez = "";
            List<shif> ans = new List<shif>();
            string buff = null;
            Console.WriteLine("Введите слово");
            
            int posSlov = 1;


            buff = g.Substring(0, 1);
            shif H = new shif();

            H.next = g.Substring(0, 1);
            H.length = 0;
            H.offset = 0;

            ans.Add(H);
            while (posSlov < g.Length)
            {

                int l;

                for (l = Math.Min(buff.Length, g.Length - posSlov); l >= 1; l--)
                {

                    string subst = g.Substring(posSlov, l);
                    int indx = buff.IndexOf(subst);

                    if (indx != -1)
                    {
                        indx = 8 - buff.Length + indx;
                        shif sub = new shif();
                        sub.offset = indx;
                        sub.length = l;

                        if (posSlov + l > g.Length - 1)
                        {

                            if (buff.Length >= 8)
                            {
                                buff = buff.Remove(0, subst.Length);
                                // buff = s;
                            }
                            sub.offset = 0;
                            sub.length = 0;
                            sub.next = g.Substring(posSlov, 1);
                            buff = buff + sub.next;
                            ans.Add(sub);
                            posSlov = posSlov + l + 1;
                            break;
                        }

                        else
                            sub.next = g.Substring(posSlov + l, 1);
                        if (buff.Length + subst.Length >= 8)
                        {
                            buff = buff.Remove(0, 8 - (sub.next.Length + subst.Length));
                            // buff = s;
                        }
                        posSlov = posSlov + l + 1;
                        buff = buff + subst + sub.next;
                        ans.Add(sub);
                        break;

                    }
                }
                if (l == 0)
                {
                    shif r = new shif();
                    r.next = g.Substring(posSlov, 1);
                    r.length = 0;
                    r.offset = 0;
                    if (buff.Length >= 8)
                    {
                        buff = buff.Remove(0, 1);
                    }
                    ans.Add(r);
                    buff = buff + g.Substring(posSlov, 1);
                    posSlov = posSlov + 1;
                }







            }


            foreach (var s in ans)
            {
                rez = rez +$"<{s.offset},{s.length},{s.next}>";
            }
            return rez;
        }

        public class code

        {
            public string name;
            public int pov;
        }
        static public string LZ78(string g)
        {

            Console.WriteLine("Введите слово");
            string rez = "";
            string buff = null;
            List<code> cod = new List<code>();
            Dictionary<string, int> dictinory = new Dictionary<string, int>();
            int posih = 2;
            buff = buff + g.Substring(0, 1);
            dictinory.Add(g.Substring(0, 1), 1);
            code one = new code();
            one.name = g.Substring(0, 1);
            one.pov = 0;
            cod.Add(one);
            while (posih < g.Length + 1)
            {
                int l;
                for (l = Math.Min(buff.Length, g.Length - (posih - 1)); l >= 1; l--)
                {
                    string sub = g.Substring(posih - 1, l);
                    if (dictinory.ContainsKey(sub))
                    {
                        if (posih > g.Length - 1)
                        {
                            code chare = new code();
                            int b = dictinory[sub];
                            chare.pov = b;
                            cod.Add(chare);
                            dictinory.Add(" ", l + 1);
                            posih = posih + sub.Length;
                            break;
                        }
                        else
                        {
                            int b = dictinory[sub];
                            code chare = new code();
                            chare.name = g.Substring(posih - 1 + l, 1);
                            chare.pov = b;
                            cod.Add(chare);
                            dictinory.Add(sub + g.Substring(posih - 1 + l, 1), posih - 1);
                            buff = buff + sub + g.Substring(posih - 1 + l, 1);
                            posih = posih + sub.Length + 1;
                            break;
                        }


                    }
                }
                if (l == 0)
                {
                    code chare = new code();
                    dictinory.Add(g.Substring(posih - 1, 1), posih);
                    chare.name = g.Substring(posih - 1, 1);
                    chare.pov = 0;
                    cod.Add(chare);
                    buff = buff + g.Substring(posih - 1, 1);
                    posih = posih + 1;

                }
            }
            foreach (var s in cod)
            {
                rez = rez + $"<{s.pov},{s.name}>";
            }
            return rez;
        }

        static public string LZSS(string g)
        {

            List<shif> ans = new List<shif>();
            string buff = null;
            Console.WriteLine("Введите слово");

            string rez = "";
            int posSlov = 1;


            buff = buff + g.Substring(0, 1);
            shif H = new shif();

            H.next = g.Substring(0, 1);
            H.length = 0;
            H.offset = 0;

            ans.Add(H);
            while (posSlov < g.Length)
            {

                int l;

                for (l = Math.Min(buff.Length, g.Length - posSlov); l >= 1; l--)
                {

                    string subst = g.Substring(posSlov, l);
                    int indx = buff.IndexOf(subst);
                    if (indx != -1)
                    {
                        indx = 8 - buff.Length + indx;
                        shif sub = new shif();
                        sub.offset = indx;
                        sub.length = l;
                        if (posSlov + l > g.Length - 1)
                        {
                            if (buff.Length + subst.Length >= 8)
                            {
                                buff = buff.Remove(0, subst.Length);
                                // buff = s;
                            }

                            buff = buff + sub.next;
                            ans.Add(sub);
                            posSlov = posSlov + l;
                            break;
                        }
                        else
                            sub.next = g.Substring(posSlov + l, 1);
                        if (buff.Length + subst.Length >= 8)
                        {
                            buff = buff.Remove(0, subst.Length);
                            // buff = s;
                        }
                        posSlov = posSlov + l;
                        buff = buff + subst;
                        ans.Add(sub);
                        break;

                    }
                }
                if (l == 0)
                {
                    shif r = new shif();
                    r.next = g.Substring(posSlov, 1);
                    r.length = 0;
                    r.offset = 0;
                    if (buff.Length >= 8)
                    {
                        buff = buff.Remove(0, 1);
                    }
                    ans.Add(r);
                    buff = buff + g.Substring(posSlov, 1);
                    posSlov = posSlov + 1;
                }







            }


            foreach (var s in ans)
            {
                if (s.length != 0)
                {
                   rez = rez + $"1<{s.offset},{s.length}>";
                }
                else
                {
                    rez = rez + $"<'0',{s.next}>";
                }

            }
            return rez;
        }

        public Forms_job4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
               
                button1.Show();
                button2.Show();
                button3.Show();
                textBox1.Hide();
             
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string D = textBox1.Text;
          
            string g = D.Remove(D.Length - 2, 2);
            rez_text.Show();
            rez_text.Text = LZ77(g);
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string D = textBox1.Text;

            string g = D.Remove(D.Length - 2, 2);
            rez_text.Show();
            rez_text.Text = LZSS(g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string D = textBox1.Text;

            string g = D.Remove(D.Length - 2, 2);
            rez_text.Show();
            rez_text.Text = LZ78(g);
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  Приложение а = new Приложение();
            //а.Show();
            
           
            Close();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Show();
            button2.Hide();
            button3.Hide();
            button1.Hide();
            rez_text.Hide();
        }
    }
}
