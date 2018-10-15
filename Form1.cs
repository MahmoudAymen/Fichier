using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichier
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        
            OpenFileDialog open = new OpenFileDialog();
            char separator = ' ';
            char s1 = '.';
            char[] s2 = { separator, s1 };
            string[] tab = null;
            int nboccurrence = 1;
            open.Filter = "Fichiers texte|*.txt" ;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetExtension(open.FileName);
                if (path == ".txt")
                {
                    textBox1.Text = File.ReadAllText(open.FileName);
                     tab = File.ReadAllText(open.FileName).Split(s2);
                 
                }
                else
                {
                    MessageBox.Show("n est pas de extension .txt");
                }
             
                for(int i=0;i<tab.Length;i++)
                {
                    labelControl1.Text = tab[i];

                    for (int j = i+1; j < tab.Length; j++)
                    {
                        if (tab[j].Equals(labelControl1.Text))
                        {
                        nboccurrence++;

                            tab[j] = "";


                        }
                      



                    }
                    if (!tab[i].Equals(""))

                    DevExpress.XtraEditors.XtraMessageBox.Show(nboccurrence.ToString());


                    nboccurrence = 1;
                    



                }


            }
        }
    }
}
