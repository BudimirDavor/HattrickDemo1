using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HattrickDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ulog, Iznos=0;
            double koef1, koef2, koef3, koef4, koef5;
            koef1 = 1.25;
            koef2 = 1.5;
            koef3 = 2.8;
            koef4 = 1.2;
            koef5 = 1.8;

            Ulog = Convert.ToDouble(textBox1.Text);
            if (checkBox1.Checked == true)
            {
                Iznos = Ulog * koef1;
                Ulog = Iznos;
            }
            if (checkBox2.Checked == true)
            {
                Iznos = Ulog * koef2;
                Ulog = Iznos;
            }
            if (checkBox3.Checked == true)
            {
                Iznos = Ulog * koef3;
                Ulog = Iznos;
            }
            if (checkBox4.Checked == true)
            {
                Iznos = Ulog * koef4;
                Ulog = Iznos;
            }
            if (checkBox5.Checked == true)
            {
                Iznos = Ulog * koef5;
                Ulog = Iznos;
            }
            if (checkBox6.Checked == true)
            {
                Iznos = Ulog;
                Iznos = Iznos - 5; 
            }
            if (Iznos > 1000) 
            {
                MessageBox.Show("Nedozvoljeno više od 1000kn");
            }    
            textBox2.Text = Iznos.ToString();

        }
    }
}
