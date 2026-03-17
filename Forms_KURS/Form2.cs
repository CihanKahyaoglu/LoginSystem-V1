using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_KURS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Liste.kullanici.Contains(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı Zaten Var!");
            }
            else if(textBox2.Text == string.Empty || textBox1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Doldurunuz!");
            }
            else
            {
                Liste.kullanici.Add(textBox1.Text);
                Liste.şifre.Add(textBox2.Text);
                MessageBox.Show("Kayıt Yapıldı.");
            }
        }
    }
}
