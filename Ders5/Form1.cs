using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5
{
    public partial class Form1 : Form
    {
        int tut_say;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz ?", "DİKKAT!", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Close();
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int tut_say = rast.Next(1, 5);
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (tahmin<tut_say) label1.Text = "Girdiğiniz sayı küçüktür";
            if (tahmin>tut_say) label1.Text = "Girdiğiniz sayı büyüktür";
            if (tahmin == tut_say) label1.Text = "Bildiniz";
            label2.Text = Convert.ToString(tut_say);
            

            
        }
    }
}
