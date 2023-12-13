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

    public partial class Form_job3 : Form
    {
        
            public class tree
            {
                static public Node root;
                public class Node

                {
                    public Node left;
                    public string shifr;
                    public Node right;
                    public string Name;
                    public Node parent;
                    public double ver;
                    public int preor = 0;
                }
                static public void FilTree(Dictionary<string, double> Ver)
                {
                    Dictionary<string, Node> Ner = new Dictionary<string, Node>();
                    foreach (var n in Ver)
                    {
                        Node a = new Node();
                        a.ver = n.Value;
                        Ner.Add(n.Key, a);
                    }


                    Dictionary<string, Node> Mer = new Dictionary<string, Node>();
                    while (Ner.Count != 1)
                    {


                        var r = Ner.Values.ToArray<Node>();
                        var l = Ner.Keys.ToArray<string>();
                        if (Mer.ContainsKey(l[1]) && Mer.ContainsKey(l[0]))
                        {
                            Node Left = Mer[l[0]];
                            Node Right = Mer[l[1]];
                            Node Parent = new Node();
                            Left.Name = l[0];
                            Right.Name = l[1];
                            Left.ver = r[0].ver;
                            Right.ver = r[1].ver;
                            Left.shifr = "0";
                            Right.shifr = "1";

                            Parent.Name = Left.Name + Right.Name;
                            Parent.ver = Left.ver + Right.ver;
                            Left.parent = Parent;
                            Right.parent = Parent;
                            Parent.left = Left;
                            Parent.right = Right;
                            tree.root = Parent;
                            Mer.Add(Parent.Name, Parent);
                            Ner.Remove(Left.Name);
                            Ner.Remove(Right.Name);
                            Ner.Add(Parent.Name, Parent);

                            var sortedDict = Ner.OrderBy(x => x.Value.ver).ToDictionary(x => x.Key, x => x.Value);
                            Ner = sortedDict;
                            continue;
                        }
                        if (Mer.ContainsKey(l[1]))
                        {
                            Node Left = new Node();
                            Node Right = Mer[l[1]];
                            Node Parent = new Node();
                            Left.Name = l[0];
                            Right.Name = l[1];
                            Left.ver = r[0].ver;
                            Right.ver = r[1].ver;
                            Left.shifr = "0";
                            Right.shifr = "1";
                            Parent.Name = Left.Name + Right.Name;
                            Parent.ver = Left.ver + Right.ver;
                            Left.parent = Parent;
                            Right.parent = Parent;
                            Parent.left = Left;
                            Parent.right = Right;
                            tree.root = Parent;
                            Mer.Add(Parent.Name, Parent);
                            Ner.Remove(Left.Name);
                            Ner.Remove(Right.Name);
                            Ner.Add(Parent.Name, Parent);

                            var sortedDict = Ner.OrderBy(x => x.Value.ver).ToDictionary(x => x.Key, x => x.Value);
                            Ner = sortedDict;
                            continue;
                        }
                        if (Mer.ContainsKey(l[0]))
                        {
                            Node Left = Mer[l[0]];
                            Node Right = new Node();
                            Node Parent = new Node();
                            Left.Name = l[0];
                            Right.Name = l[1];
                            Left.ver = r[0].ver;
                            Right.ver = r[1].ver;
                            Left.shifr = "0";
                            Right.shifr = "1";
                            Parent.Name = Left.Name + Right.Name;
                            Parent.ver = Left.ver + Right.ver;
                            Left.parent = Parent;
                            Right.parent = Parent;
                            Parent.left = Left;
                            Parent.right = Right;
                            tree.root = Parent;
                            Mer.Add(Parent.Name, Parent);
                            Ner.Remove(Left.Name);
                            Ner.Remove(Right.Name);
                            Ner.Add(Parent.Name, Parent);

                            var sortedDict = Ner.OrderBy(x => x.Value.ver).ToDictionary(x => x.Key, x => x.Value);
                            Ner = sortedDict;
                            continue;
                        }
                        if (!Mer.ContainsKey(l[1]) && !Mer.ContainsKey(l[0]))
                        {
                            Node Left = new Node();
                            Node Right = new Node();
                            Node Parent = new Node();
                            Left.Name = l[0];
                            Right.Name = l[1];
                            Left.ver = r[0].ver;
                            Right.ver = r[1].ver;
                            Left.shifr = "0";
                            Right.shifr = "1";
                            Parent.Name = Left.Name + Right.Name;
                            Parent.ver = Left.ver + Right.ver;
                            Left.parent = Parent;
                            Right.parent = Parent;
                            Parent.left = Left;
                            Parent.right = Right;
                            tree.root = Parent;
                            Mer.Add(Parent.Name, Parent);
                            Ner.Remove(Left.Name);
                            Ner.Remove(Right.Name);
                            Ner.Add(Parent.Name, Parent);

                            var sortedDict = Ner.OrderBy(x => x.Value.ver).ToDictionary(x => x.Key, x => x.Value);
                            Ner = sortedDict;
                            continue;
                        }

                    }

                }
                /*   static private Node SercTree(Node p,string n)
                   {
                       if(p.Name == n)
                       {
                           return p ;
                       }
                       if(p.left != null )
                       {
                           SercTree(p.left, n);
                       }
                       if(p.right != null)
                       {
                           SercTree(p.right, n);
                       }
                   }*/
                static private string SercTree(Node node, string n, string b)// Обход в глубину
                {
                    if (node.left != null && node.right != null)
                    {
                        if (node.left.Name.IndexOf(n) != -1)
                        {
                            b = b + node.left.shifr;
                            return SercTree(node.left, n, b);
                        }
                        else
                            b = b + node.right.shifr;
                        return SercTree(node.right, n, b);

                    }
                    else
                        return b;


                }

                static public Dictionary<string, string> ShifHF(Dictionary<string, double> Ver)
                {
                    Dictionary<string, string> Hf = new Dictionary<string, string>();
                    foreach (var n in Ver.Keys)
                    {
                        string b = null;
                        string cod = tree.SercTree(root, n, b);
                        Hf.Add(n, cod);

                    }
                    return Hf;

                }


            }





            public class Shifr
            {
                public string shifr;
                public string name;
                public double ver;
            }
            static Dictionary<string, double> AddDictSH(Dictionary<string, double> Ver)
            {
                Console.WriteLine("Введите букву");

                string l = Console.ReadLine();
                Console.WriteLine("Введите вероятность");

                double g = Convert.ToDouble(Console.ReadLine());
                Ver.Add(l, g);


                var sortedDict = Ver.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(String.Join(", ", sortedDict));
                return sortedDict;
            }
            static Dictionary<string, double> AddDictHF(Dictionary<string, double> Ver)
            {
                

                string l = Console.ReadLine();
                Console.WriteLine("Введите вероятность");

                double g = Convert.ToDouble(Console.ReadLine());
                Ver.Add(l, g);


                var sortedDict = Ver.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(String.Join(", ", sortedDict));
                return sortedDict;
            }
            static List<Shifr> ShifrDictShennon(Dictionary<string, double> Ver)
            {

                List<Shifr> Shif = new List<Shifr>();


                foreach (var Name in Ver.Keys)
                {
                    Shifr shi = new Shifr();
                    shi.name = Name;
                    shi.ver = Ver[Name];
                    Shif.Add(shi);
                }

                for (int i = 0; i < Ver.Count; i++)
                {
                    if (i == 0)
                    {

                        Shif[i].shifr = "0";
                    }
                    if (i + 1 == Ver.Count)
                    {
                        for (int g = 1; g < Ver.Count; g++)
                        {
                            Shif[i].shifr = Shif[i].shifr + "1";

                        }

                    }
                    if (i != 0 && i + 1 != Ver.Count)
                    {
                        Shif[i].shifr = "1" + Shif[i - 1].shifr;

                    }

                }
                for (int i = 0; i < Shif.Count; i++)
                {
                    Console.WriteLine(Shif[i].name);
                    Console.WriteLine(Shif[i].shifr);
                }
                return Shif;
            }
            static string Shennonslov(List<Shifr> ShifrDict,string g)
            {
                string Shifres = "";
                
               
                for (int i = 0; i < g.Length; i++)
                {
                    for (int k = 0; k < ShifrDict.Count; k++)
                    {
                        if (g.Substring(i, 1) == ShifrDict[k].name)
                        {
                        Shifres = Shifres  + ShifrDict[k].shifr;
                            continue;
                        }

                    }
                }

                return Shifres; ;







        }
                static void ShennonDict()
                {
                    Dictionary<string, double> Ver = new Dictionary<string, double>();
                    List<Shifr> Shif = new List<Shifr>();
                    Dictionary<string, double> VerSort = new Dictionary<string, double>();
                    Console.WriteLine("Добавить букву - 1.Закадировать список - 2.Ввести слово для кодировки - 3.Выход - другая любая клавиша");
                go:
                    int l = Convert.ToInt32(Console.ReadLine());

                    switch (l)
                    {
                        case 1:
                            VerSort = AddDictSH(Ver);
                            goto go;
                        case 2:

                            Shif = ShifrDictShennon(VerSort);

                            goto go;
                        case 3:
                           // Shennonslov(Shif);
                            goto go;

                        default:

                            break;
                    }
                }

           /* static void HafmenDict()
            {
                Dictionary<string, double> Ver = new Dictionary<string, double>();
                Dictionary<string, string> Shif = new Dictionary<string, string>();
                Dictionary<string, double> VerSort = new Dictionary<string, double>();
                Console.WriteLine("Добавить букву - 1.Закадировать список - 2.Ввести слово для кодировки - 3.Выход - другая любая клавиша");
            go:
                int l = Convert.ToInt32(Console.ReadLine());

                switch (l)
                {
                    case 1:
                        VerSort = AddDictHF(Ver); ;
                        goto go;
                    case 2:

                        Shif = ShifrDictHafmen(VerSort);

                        goto go;
                    case 3:
                        HafmenSlovo(Shif);
                        goto go;

                    default:

                        break;
                }
            }
            */
            static string HafmenSlovo(Dictionary<string, string> haf,string g)
            {
                 string Shifrs = "";
              
                
                for (int i = 0; i < g.Length; i++)
                {
                    foreach (var n in haf)
                    {
                        if (g.Substring(i, 1) == n.Key)
                        {
                            Shifrs= Shifrs + n.Value;
                            continue;
                        }

                    }
                }

                return Shifrs;
            }
            static Dictionary<string, string> ShifrDictHafmen(Dictionary<string, double> Ver)
            {
                Dictionary<string, string> F = new Dictionary<string, string>();
                /* double i = 0;
                 int g = 0;
                 foreach (var ver in Ver.Values)
                 {
                     if(i >= 0.5)
                     {
                         break;
                     }
                     else
                     {
                         i = i + ver;
                         g++;
                     }
                 }*/

                tree TreeHaf = new tree();
                //tree.Addroot(Ver);
                tree.FilTree(Ver);

                F = tree.ShifHF(Ver);

                Console.WriteLine(String.Join(", ", F));

                return F;
            }

            /*  static void FilDict()
              {



                  Console.WriteLine("Метод Шеннона-Фэно - 1.Метод Хаффмена - 2.Выход - другая любая клавиша");
              go:
                  int l = Convert.ToInt32(Console.ReadLine());
                  switch (l)
                  {
                      case 1:
                          ShennonDict();
                          goto go;
                      case 2:
                          HafmenDict();


                          goto go;


                      default:

                          break;
                  }



              }*/
        
        Dictionary<string, double> Ver = new Dictionary<string, double>();
        Dictionary<string, string> Shif = new Dictionary<string, string>();
        Dictionary<string, double> VerSort = new Dictionary<string, double>();
        List<Shifr> Shifrs = new List<Shifr>();
        double a = 0;
        int r;
        public Form_job3()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void but_hafmen_Click(object sender, EventArgs e)
        {
           
            r = 1;
            RichText_name.Text = "Введите название";
            RichText_name.Show();
            RichText_ver.Show();
            Text_name.Show();
            Text_ver.Show();
            Butt_add.Show();
            but_shenon.Hide();

            

        }

        private void Butt_add_Click(object sender, EventArgs e)
        {
            but_cod.Show();
            if (a <= 1)
            {
                string n = Text_name.Text;
                string v = Text_ver.Text;
                double g = Convert.ToDouble(v);
                a = a + g;
                Ver.Add(n, g);
                var sortedDict = Ver.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                VerSort = sortedDict;
                Text_name.Text = "";
                Text_ver.Text = "";
            }
            else
            {
                Err_add.Show();
                Text_name.Text = "";
                Text_ver.Text = "";
            }

        }

        private void but_cod_Click(object sender, EventArgs e)
        {

            if (r == 1)
            {
                Shif = ShifrDictHafmen(VerSort);
                RichText_name.Text = "Введите слово для кодировки";
                RichText_ver.Hide();
                Text_name.Hide();
                Text_ver.Hide();
                but_cod.Hide();
                Butt_add.Hide();
                Text_slovo.Show();
            }
            if(r ==2)
            {
                Shifrs = ShifrDictShennon(VerSort);
                RichText_name.Text = "Введите слово для кодировки";
                RichText_ver.Hide();
                Text_name.Hide();
                Text_ver.Hide();
                but_cod.Hide();
                Butt_add.Hide();
                Text_slovo.Show();
            }
        }

        private void Text_slovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                if(r == 1)
                    {


                    string h = Text_slovo.Text;
                    Text_Zacod.Text = HafmenSlovo(Shif, h);
                    Text_Zacod.Show();
                    ZacodRichText.Show();
                }
                if(r == 2)
                {
                    string h = Text_slovo.Text;
                    Text_Zacod.Text = Shennonslov(Shifrs,h);
                    Text_Zacod.Show();
                    ZacodRichText.Show();
                }
            }
        }

        private void but_shenon_Click(object sender, EventArgs e)
        {
            
            r = 2;
            RichText_name.Text = "Введите название";
            RichText_name.Show();
            RichText_ver.Show();
            Text_name.Show();
            Text_ver.Show();
            Text_slovo.Hide();
            Text_Zacod.Hide();
            ZacodRichText.Hide();
            Butt_add.Show();
            but_hafmen.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> Ve = new Dictionary<string, double>();
            Dictionary<string, string> Shifrses = new Dictionary<string, string>();
            Dictionary<string, double> VerSor = new Dictionary<string, double>();
            List<Shifr> Shi = new List<Shifr>();
            Ver = Ve;
            Shif = Shifrses;
            VerSort = VerSor;
            Shifrs = Shi;
            RichText_name.Text = "Введите слово для кодировки";
            RichText_name.Hide();
            RichText_ver.Hide();
            Text_name.Hide();
            Text_ver.Hide();
            Text_slovo.Hide();
            Text_Zacod.Hide();
            ZacodRichText.Hide();
            Butt_add.Hide();
            but_hafmen.Show();
            but_shenon.Show();
            a = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
