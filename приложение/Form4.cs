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
    public partial class Form_Job2 : Form
    {
        public class Tree
        {

            public Node root;
            public void Addroot(int n)//Дабовляем корневой узел
            {
                root = new Node();

                root.number = n;

            }
            public class Node

            {
                public Node left;

                public Node right;
                public int number;
                public Node parent;


            }
            public void SerAddNode(int n, Node korn)// Автоматическая сортировка и добавлене в дерево
            {
                if (n < korn.number)
                {

                    if (korn.left == null)
                    {
                        korn.left = new Node();
                        korn.left.parent = korn;
                        korn.left.number = n;
                    }

                    else
                    {

                        SerAddNode(n, korn.left);
                    }

                }
                else
                {
                    if (korn.right == null)
                    {
                        korn.right = new Node();
                        korn.right.parent = korn;
                        korn.right.number = n;
                    }

                    else
                    {

                        SerAddNode(n, korn.right);
                    }

                }
            }

            /*public void AddNode(Form_Job2 g)//Добавление узла
             {
             link:
                 string s = g.Text_Add.Text;
                 int n = Convert.ToInt32(s);


                 Node node = NodeFind(n);//Проверка через обход в глубину
                 if (node != null)
                 {
                     g.Err_Add.Show();
                     g.Text_Add.Text = "";


                 }
                 g.Err_Add.Hide();
                 SerAddNode(n, root);

                 g.Text_Add.Text = "";

             }*/
            public Node widthSerc(int n)// Обход в ширину
            {

                List<Node> width = new List<Node>();
                width.Add(root);
                for (int g = 0; g < width.Count; g++)
                {
                    if (width[g].right != null)
                    {
                        width.Add(width[g].right);

                    }
                    if (width[g].left != null)
                    {
                        width.Add(width[g].left);
                    }
                }

                for (int k = 0; k < width.Count; k++)
                {
                    if (width[k].number == n)
                    {
                        return width[k];
                    }
                }

                return null;
            }


            public void DelNode()
            {
            link:
                Console.WriteLine("Введите номер узла для удаления ");//Удаление узла
                int n = Convert.ToInt32(Console.ReadLine());
                Node node = widthSerc(n);//Проверка через обход в ширину
                if (node == null)
                {
                    Console.WriteLine("Такого узла нет  ");
                    goto link;
                }

                if (node.left == null && node.right == null && node.parent.left == node)
                {
                    node.parent.left = null;


                }
                if (node.left == null && node.right == null && node.parent.right == node)
                {
                    node.parent.right = null;

                }
                if (node.left != null && node.right == null && node.parent.left == node)
                {
                    node.parent.left = node.left;
                    node.left.parent = node.parent;
                }
                if (node.left != null && node.right == null && node.parent.right == node)
                {
                    node.parent.right = node.left;
                    node.left.parent = node.parent;
                };
                if (node.left == null && node.right != null && node.parent.left == node)
                {
                    node.parent.left = node.right;
                    node.right.parent = node.parent;
                }
                if (node.left == null && node.right != null && node.parent.right == node)
                {
                    node.parent.right = node.right;
                    node.right.parent = node.parent;
                }
                if (node.left != null && node.right != null)
                {
                    Node Min = MinSerc(node.right);
                    if (node.parent.left == node)
                    {
                        if (Min.right != null)
                        {
                            Min.parent.left = Min.right;//Связали левое под дерево мин с его родителем
                            Min.right.parent = Min.parent;
                            node.parent.left = Min;//связали родителя удоляемого с минимальным
                            Min.parent = node.parent;
                            Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                            node.left.parent = Min;
                            Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                            node.right.parent = Min;

                        }
                        else
                        {
                            node.parent.left = Min;//связали родителя удоляемого с минимальным
                            Min.parent = node.parent;
                            Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                            node.left.parent = Min;
                            Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                            node.right.parent = Min;
                        }

                    }
                    if (node.parent.right == node)
                    {
                        if (Min.right != null)
                        {
                            Min.parent.left = Min.right;//Связали левое под дерево мин с его родителем
                            Min.right.parent = Min.parent;
                            node.parent.right = Min;//связали родителя удоляемого с минимальным
                            Min.parent = node.parent;
                            Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                            node.left.parent = Min;
                            Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                            node.right.parent = Min;

                        }
                        else
                        {
                            node.parent.right = Min;//связали родителя удоляемого с минимальным
                            Min.parent = node.parent;
                            Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                            node.left.parent = Min;
                            Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                            node.right.parent = Min;
                        }

                    }


                }

            }

            public string PrintwidthSerc()// Распечетка в ширину
            {
                string l ="";

                List<Node> width = new List<Node>();
                width.Add(root);
                for (int g = 0; g < width.Count; g++)
                {
                    if (width[g].left != null)
                    {
                        width.Add(width[g].left);
                    }
                    if (width[g].right != null)
                    {
                        width.Add(width[g].right);

                    }

                }
            

                for (int k = 0; k < width.Count; k++)
                {
                   l = l + width[k].number+ " ";
                }

                return l;

            }

            public Node MinSerc(Node One)//Поиск минмального
            {
                while (One.left != null)
                {
                    One = One.left;
                }
                return One;
            }


            public Node NodeFind(int n)
            {
                Node find = RecTree(root, n);



                return find;
            }
            private Node RecTree(Node node, int n)// Обход в глубину
            {

                if (node.number == n)
                {
                    return node;
                }
                if (node.left == null)
                {
                    
                        if (node.right != null)
                        {
                            return RecTree(node.right, n);
                        }

                        return null;
                    }
                else
                {

                    Node node1 = RecTree(node.left, n);
                    if (node1 == null && node.right != null)
                    {
                        return RecTree(node.right, n);

                    }
                    else
                        return node1;


                }




            }
            /*public string PrinPublRecTree(Node node,string s)
            {
               
               return PrinRecTree(node,s);
            }
            */
            public void PrinRecTree(Node node,Form_Job2 s)// Обход в глубину
            {

                s.Print_tree.Text = s.Print_tree.Text + node.number + " ";

                if (node.left != null)
                {
                    PrinRecTree(node.left,s);
                }
                if(node.right != null)
                {
                    PrinRecTree(node.right,s);

                }

               
            }
            




        }
        /*   public void Completion_Tree()//Добавляем и удаляем узлы
          {

              Tree tree = new Tree();//Создали дерево
              Tree.Addroot();//Добавляем корень



              Console.WriteLine("Добавить узел - 1.Удалить узел - 2.Обход в ширину - 3.Обход в глубину - 4.Выход - другая любая клавиша");
          go:
              int l = Convert.ToInt32(Console.ReadLine());
              switch (l)
              {
                  case 1:
                      Tree.AddNode();
                      goto go;
                  case 2:
                      Tree.DelNode();
                      goto go;
                  case 3:
                      Tree.PrintwidthSerc();
                      goto go;
                  case 4:
                      Tree.PrinPublRecTree(Tree.root);
                      goto go;

                  default:

                      break;
              }
          }*/


        Tree tree = new Tree();//Создали дерево
        public Form_Job2()
        {
            InitializeComponent();
        }

        private void Add_Node_Click(object sender, EventArgs e)
        {
            Err_Add.Hide();
            richTextBox2.Show();
            richTextBox2.Text = "Введите номер узла для дабавления ";
            Print_tree.Hide();
            End_norml.Hide();
            richTextBox2.Show();
            Del_Node.Hide();
            Text_Add.Show();
            Text_Add.Text = "";
        }

        private void Text_Add_Enter(object sender, EventArgs e)
        {




        }

        public void Add_root_Enter(object sender, EventArgs e)
        {


        }

        private void Add_root_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == '\r')
            {
                string s = Add_root.Text;
                int n = Convert.ToInt32(s);

                tree.Addroot(n);//Добавляем корень
                richTextBox3.Hide();
                Add_root.Hide();
                Add_Node.Show();
                button2.Show();
                button3.Show();
                button4.Show();



            }
        }

        private void Text_Add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                {

                    string s = Text_Add.Text;
                    int n = Convert.ToInt32(s);


                    Tree.Node node = tree.NodeFind(n);//Проверка через обход в глубину
                    if (node != null)
                    {
                        Err_Add.Text = "Узел с таким номером уже есть";
                        Err_Add.Show();
                        Text_Add.Text = "";
                        return;



                    }
                    Err_Add.Hide();
                    tree.SerAddNode(n, tree.root);

                    Text_Add.Text = "";

                }



                End_norml.Text = "Успешно добавлен узел";
                End_norml.Show();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Err_Add.Hide();
            Print_tree.Hide();
            End_norml.Hide();
            richTextBox2.Text = "Введите номер узла для удаления ";//Удаление узла
            richTextBox2.Show(); 

            Text_Add.Hide();
            Del_Node.Show();
            Del_Node.Text = "";

        }



        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Hide();
            Err_Add.Hide();
            End_norml.Hide();
            Del_Node.Hide();
            Text_Add.Hide();
            Print_tree.Text = "Обход в ширину\r\n";
            Print_tree.Text = Print_tree.Text + tree.PrintwidthSerc();
            Print_tree.Show();
            End_norml.Text = "Обход успешно выполнен";
            End_norml.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Hide();
            Err_Add.Hide();
            End_norml.Hide();
            Del_Node.Hide();
            Text_Add.Hide();
          var  s =this;
            Print_tree.Text = "Обход в Глубину\r\n";
            tree.PrinRecTree(tree.root,s);
            Print_tree.Show();
            End_norml.Text = "Обход успешно выполнен";
            End_norml.Show();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Del_Node_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string s = Del_Node.Text;
                int n = Convert.ToInt32(s);
                Tree.Node node = tree.widthSerc(n);//Проверка через обход в ширину
                    if (node == null)
                {
                    Err_Add.Text = "Узел с таким номером нет";
                    Err_Add.Show();
                    Del_Node.Text = "";
                    return;
                }
                Err_Add.Hide();
                Del_Node.Text = "";

                if (node.left == null && node.right == null && node.parent.left == node)
                    {
                        node.parent.left = null;


                    }
                    if (node.left == null && node.right == null && node.parent.right == node)
                    {
                        node.parent.right = null;

                    }
                    if (node.left != null && node.right == null && node.parent.left == node)
                    {
                        node.parent.left = node.left;
                        node.left.parent = node.parent;
                    }
                    if (node.left != null && node.right == null && node.parent.right == node)
                    {
                        node.parent.right = node.left;
                        node.left.parent = node.parent;
                    };
                    if (node.left == null && node.right != null && node.parent.left == node)
                    {
                        node.parent.left = node.right;
                        node.right.parent = node.parent;
                    }
                    if (node.left == null && node.right != null && node.parent.right == node)
                    {
                        node.parent.right = node.right;
                        node.right.parent = node.parent;
                    }
                    if (node.left != null && node.right != null)
                    {
                        Tree.Node Min = tree.MinSerc(node.right);
                        if (node.parent.left == node)
                        {
                            if (Min.right != null)
                            {
                                Min.parent.left = Min.right;//Связали левое под дерево мин с его родителем
                                Min.right.parent = Min.parent;
                                node.parent.left = Min;//связали родителя удоляемого с минимальным
                                Min.parent = node.parent;
                                Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                                node.left.parent = Min;
                                Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                                node.right.parent = Min;

                            }
                            else
                            {
                                node.parent.left = Min;//связали родителя удоляемого с минимальным
                                Min.parent = node.parent;
                                Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                                node.left.parent = Min;
                                Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                                node.right.parent = Min;
                            }

                        }
                        if (node.parent.right == node)
                        {
                            if (Min.right != null)
                            {
                                Min.parent.left = Min.right;//Связали левое под дерево мин с его родителем
                                Min.right.parent = Min.parent;
                                node.parent.right = Min;//связали родителя удоляемого с минимальным
                                Min.parent = node.parent;
                                Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                                node.left.parent = Min;
                                Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                                node.right.parent = Min;

                            }
                            else
                            {
                                node.parent.right = Min;//связали родителя удоляемого с минимальным
                                Min.parent = node.parent;
                                Min.left = node.left;//связали левое под дерево удоляемого с минимальным
                                node.left.parent = Min;
                                Min.right = node.right;//связали правое под дерево удоляемого с минимальным
                                node.right.parent = Min;
                            }

                        }


                    }
                End_norml.Text = "Узел успешно удалён";
                End_norml.Show();
            }
          
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
       
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Tree g = new Tree();
            tree = g;
            Add_root.Show();
            Add_Node.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            End_norml.Hide();
            Add_root.Text = "";
            richTextBox3.Show();
            Print_tree.Hide();
        }
    }
}

