using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sayi = { 1.3, 4.5, 8.45 };
            label1.Text = sayi[2].ToString();
            char[] harf = { 'a','w','f','r','x' };
            label2.Text = harf[3].ToString();
        }
    }
}
