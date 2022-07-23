using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 2, 4, 5, 8, 12, 16, 17, 20, 3, 7, 9, 30, 1, 13 };
            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0 && sayilar[i] >= 10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
