using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic_avtoriz_win_forms
{
    public partial class Capcha : Form
    {
        string text;
        public Capcha()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {

            string captchaText = GenerateRandomText();
            text = captchaText;
            Bitmap captchaImage = GenerateImage(captchaText);

            capchaImage.Image = captchaImage;
        }

        private string GenerateRandomText()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 6) // Длина капчи (6 символов)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private Bitmap GenerateImage(string text)
        {
            Bitmap image = new Bitmap(capchaImage.Width, capchaImage.Height);

            using (Graphics g = Graphics.FromImage(image))
            {
                // Заполняем фон белым цветом
                g.FillRectangle(Brushes.White, 0, 0, image.Width, image.Height);

                // Рисуем текст
                g.DrawString(text, new Font("Arial", 20), Brushes.Black, new PointF(10, 10));

                // Добавляем перечерки
                Random random = new Random();
                for (int i = 0; i < 20; i++) // 5 линий
                {
                    int x1 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int x2 = random.Next(image.Width);
                    int y2 = random.Next(image.Height);

                    g.DrawLine(Pens.Black, x1, y1, x2, y2);
                }
            }

            return image;
        }


        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != text)
            {
                GenerateCaptcha();
                textBox1.Text = "";
            }
            else
            {
                this.Hide();
                new FormAvtoriz().ShowDialog();
            }
        }
    }
}
