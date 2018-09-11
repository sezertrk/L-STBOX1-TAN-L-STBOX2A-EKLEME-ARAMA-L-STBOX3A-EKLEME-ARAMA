using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deger = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            deger = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == textBox1.Text)
                {
                    deger = i;
                }
            }
            
            if (deger == -1)
            {
                MessageBox.Show("Girilen Değer Bulunamadı");
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;

            }


        }  
        

        private void button2_Click(object sender, EventArgs e)
        {

            listBox2.Items.Add(listBox1.Items[deger].ToString());
            listBox1.Items.RemoveAt(deger);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox1.Items[deger].ToString());
            listBox1.Items.RemoveAt(deger);
        }
    }
}
