namespace Forms_KURS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bulundu = false;
            if (textBox2.Text == string.Empty || textBox1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Doldurunuz!");
            }
            else
            {
                for (int i = 0; i < Liste.kullanici.Count; i++)
                {
                    if (textBox1.Text == Liste.kullanici[i] && textBox2.Text == Liste.şifre[i])
                    {

                        Form3 ekran = new Form3();
                        ekran.Show();
                        this.Hide();

                        MessageBox.Show("Giriş Başarılı.");

                        ekran.FormClosed += (s, args) => this.Show();

                        bulundu = true;
                        break;
                    }
                }

                if (!bulundu)
                {
                    MessageBox.Show("Kullanıcı veya Şifre Hatalı!");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ekran = new Form2();
            ekran.Show();
            this.Hide();

            ekran.FormClosed += (s, args) => this.Show();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
        }
    }
}
