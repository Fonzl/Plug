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
    public partial class Form3 : Form
    {
        List<rebro> graf = new List<rebro>();
        public struct rebro //Создаем структуру ребра
        {
            public string beg;

            public string end;


            public void PrintR()
            {
                Console.WriteLine($" {beg}  : {end}");
            }
            public string Name()
            {
                return beg + end;
            }
        }

      
            static void PrintSmesh(Dictionary<string, List<string>> Smeh)// Выводим на экран список смежности
            {
                foreach (var R in Smeh)
                {
                    List<string> Rebro = R.Value;
                    Console.WriteLine($" {R.Key} : {String.Join(",", Rebro)}");







                }

            }
            static Dictionary<string, List<string>> SmehNapr(List<rebro> graf)// Создаем список смежности направленного и заполняем его
            {
                Dictionary<string, List<string>> smeh = new Dictionary<string, List<string>>();

                foreach (var R in graf)
                {

                    if (!smeh.ContainsKey(R.beg))
                    {
                        List<string> SmeshRebr = new List<string>();
                        SmeshRebr.Add(R.end);
                        smeh.Add(R.beg, SmeshRebr);


                    }
                    else
                    {
                        List<string> SmeshRebr = smeh[R.beg];
                        SmeshRebr.Add(R.end);

                    }


                }
                foreach (var R in graf)
                {

                    if (!smeh.ContainsKey(R.end))
                    {
                        List<string> SmeshRebr = new List<string>();

                        smeh.Add(R.end, SmeshRebr);
                    }


                }
                return smeh;
            }

            static Dictionary<string, List<string>> Smeh(List<rebro> graf)// Создаем список смежности и заполняем его
            {
                Dictionary<string, List<string>> smeh = new Dictionary<string, List<string>>();

                foreach (var R in graf)
                {

                    if (!smeh.ContainsKey(R.beg))
                    {
                        List<string> SmeshRebr = new List<string>();
                        SmeshRebr.Add(R.end);
                        smeh.Add(R.beg, SmeshRebr);


                    }
                    else
                    {
                        List<string> SmeshRebr = smeh[R.beg];
                        SmeshRebr.Add(R.end);

                    }


                }
                foreach (var R in graf)
                {

                    if (!smeh.ContainsKey(R.end))
                    {
                        List<string> SmeshRebr = new List<string>();
                        SmeshRebr.Add(R.beg);
                        smeh.Add(R.end, SmeshRebr);


                    }
                    else
                    {
                        List<string> SmeshRebr = smeh[R.end];
                        SmeshRebr.Add(R.beg);

                    }
                }
                return smeh;
            }


            static void Print(List<rebro> graf)//Вывод ребер
            {
                foreach (var R in graf)
                {
                    R.PrintR();
                }
            }
            static void matrixSmeh(Dictionary<string, List<string>> smeh)// Вывод матрицы смежности
            {
                Console.WriteLine($"{String.Join(" ", smeh.Keys)}");

                foreach (var R in smeh)
                {
                    string RouwMatr = R.Key;
                    foreach (var Koll in smeh.Keys)
                    {
                        if (R.Key == Koll)
                        {
                            RouwMatr = RouwMatr + 0 + " ";
                        }
                        else
                        {
                            if (R.Value.Contains(Koll))
                            {
                                RouwMatr = RouwMatr + 1 + " ";
                            }
                            else
                            {
                                RouwMatr = RouwMatr + 0 + " ";
                            }
                        }


                    }

                    Console.WriteLine(RouwMatr);
                }

            }


            void matrixIncel(Dictionary<string, List<string>> smeh, List<rebro> input)
            {
                string ReberList = " ";
                foreach (var R in input)
                {
                    ReberList = ReberList + R.Name() + " ";
                }
            Rez_oren.Text = Rez_oren.Text +  "Матрица инцидентности не орентированный".ToString() + "\r\n";
            Rez_oren.Text = Rez_oren.Text +  ReberList.ToString() + "\r\n";
                foreach (var Node in smeh.Keys)
                {
                    string RouwMatr = Node;
                    foreach (var R in input)
                    {
                        if (Node == R.beg || Node == R.end)
                        {
                            RouwMatr = RouwMatr + 1 + "  ";
                        }
                        else
                        {
                            RouwMatr = RouwMatr + 0 + "  ";
                        }
                    }
                Rez_oren.Text = Rez_oren.Text +  RouwMatr.ToString() + "\r\n" ;
                }

            }

          void matrixInceOren(Dictionary<string, List<string>> smeh, List<rebro> input)
            {
                string ReberList = " ";
                foreach (var R in input)
                {
                    ReberList = ReberList + R.Name() + " ";
                }
            Rez_Neoren.Text = "Матрица инцидентности  орентированная" + "\r\n"  ;
            Rez_Neoren.Text = Rez_Neoren.Text + ReberList.ToString() + "\r\n";
                foreach (var Node in smeh.Keys)
                {
                    string RouwMatr = Node;
                    foreach (var R in input)
                    {
                        if (Node == R.beg)
                        {
                            RouwMatr = RouwMatr + 1 + "  ";
                        }
                        else if (Node == R.end)
                        {
                            RouwMatr = RouwMatr + -1 + "  ";
                        }
                        else if (Node == R.beg && Node == R.end)
                        {
                            RouwMatr = RouwMatr + 1 + "  ";
                        }
                        else
                            RouwMatr = RouwMatr + 0 + "  ";
                    }
                Rez_Neoren.Text = Rez_Neoren.Text + RouwMatr.ToString() + "\r\n";
                }


            }
         /*   static void Main()
            {
                Console.WriteLine("Введите сколько будет ребер:");

                int NumRebro = Convert.ToInt32(Console.ReadLine());
                List<rebro> smesh = input(NumRebro);
                Print(smesh);
                Console.WriteLine("Какой граф строить орентироввнный(1) или не орентированный(2):");
                int view = Convert.ToInt32(Console.ReadLine());
                switch (view)
                {
                    case 1:
                        Dictionary<string, List<string>> OrSmeh = Smeh(smesh);
                        PrintSmesh(OrSmeh);

                        matrixSmeh(OrSmeh);
                        matrixIncel(OrSmeh, smesh);
                        Console.ReadLine();
                        break;

                    case 2:
                        Dictionary<string, List<string>> OSmeh = SmehNapr(smesh);
                        PrintSmesh(OSmeh);

                        matrixSmeh(OSmeh);
                        matrixInceOren(OSmeh, smesh);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Введите цифру!!!");
                        break;

                }

            }*/


        


        public Form3()
        {
            
            InitializeComponent();
          
        }
        

        
       


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

       

        public void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public static void Rebro_Enter(object sender, EventArgs e)
        {
           
        }

    

        private void End_reb_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void Start_reb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_rebro_Click(object sender, EventArgs e)
        {
            rebro R = new rebro();
            string l = End_reb.Text;
            string g = Start_reb.Text;
            R.beg = g;
            R.end = l;
            graf.Add(R);
            End_reb.Text = "";
            Start_reb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> OrSmeh = Smeh(graf);
            PrintSmesh(OrSmeh);

            matrixSmeh(OrSmeh);
            Rez_oren.Show();
            matrixIncel(OrSmeh,graf);
            Console.ReadLine();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<rebro> g = new List<rebro>();
            graf = g;
            Rez_Neoren.Hide();
            Rez_oren.Hide();
            Rez_oren.Text = "";
            Rez_Neoren.Text = "";
            End_reb.Text = "";
            Start_reb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> OSmeh = SmehNapr(graf);
            PrintSmesh(OSmeh);
            Rez_Neoren.Show();
            matrixSmeh(OSmeh);
            matrixInceOren(OSmeh, graf);
            Console.ReadLine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

          
        }
    }
}
