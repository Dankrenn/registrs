using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace practic_avtoriz_win_forms
{
    public partial class FormAvtoriz : Form
    {
        private Timer unlockTimer = new Timer();
        int failedLoginAttempts = 0;
        string connectionString = "Host=localhost;Database=UserRegistr;Username=postgres;Password=0211";
        public FormAvtoriz()
        {
            InitializeComponent();
            unlockTimer.Interval = 20000; // 20 секунд в миллисекундах

            unlockTimer.Tick += timer_Tick;
        }

        private void buttonAvtoriz_Click(object sender, EventArgs e)
        {
            if (buttonRegistr.Enabled)
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;

                try
                {
                    connection.Open();

                    // Используйте параметризованный запрос для безопасности
                    string sql = "SELECT * FROM users WHERE login = @Login AND password = @Password";
                    NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Пользователь успешно авторизирован");
                        this.Hide();
                        new FormHub().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        failedLoginAttempts++;

                        // Если количество неудачных попыток превысило 3, блокируем кнопку
                        if (failedLoginAttempts >= 3)
                        {
                            this.Hide();
                            new Capcha().ShowDialog();
                            //buttonRegistr.Enabled = false;
                            //buttonRegistr.BackColor = Color.Red;
                            //unlockTimer.Start();
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при авторизации пользователя: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }


        private void labelRegistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistr().ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void timer_Tick(object sender, EventArgs e)
        {
            // Проверяем, прошло ли 20 секунд
            buttonRegistr.Enabled = true;
            buttonRegistr.BackColor = Color.Green;
            failedLoginAttempts = 0;

            // Останавливаем таймер
            unlockTimer.Stop();
        }
    }
}
