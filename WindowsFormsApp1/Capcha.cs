using CaptchaApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Capcha : Form
    {
        public Capcha()
        {
            InitializeComponent();
        }
        private string captcha;
        private bool isCaptchaCorrect;
        Login login = new Login();

        private void button1_Click(object sender, EventArgs e)
        {
            if (isCaptchaCorrect)
            {
                string password = textBox1.Text;
                // Далее можно добавить логику для проверки пароля или открытия другой формы
                MessageBox.Show("Пароль введен!");
            }
            else
            {
                MessageBox.Show("Неправильная капча! Попробуйте еще раз.");
                textBox1.Clear();
                GenerateCaptcha();
            }
        }
        private void AddNoiseToCaptcha()
        {
            Bitmap captchaImage = new Bitmap(label1.Width, label1.Height);
            Graphics g = Graphics.FromImage(captchaImage);

            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(captchaImage.Width);
                int y = random.Next(captchaImage.Height);
                captchaImage.SetPixel(x, y, Color.Black);
            }

            label1.Image = captchaImage;
        }
        private void GenerateCaptcha()
        {
            Random random = new Random();
            captcha = random.Next(1000, 9999).ToString();
            label1.Text = captcha;
        }

        private void Capcha_Load(object sender, EventArgs e)
        {
            AddNoiseToCaptcha();
            GenerateCaptcha();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == captcha)
            {
                isCaptchaCorrect = true;
                this.Hide();
                login.ShowDialog();

            }
            else
            {
                isCaptchaCorrect = false;

            }
        }
    }
}

