using Npgsql;
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
    public partial class FormRegistr : Form
    {
        string connectionString = "Host=localhost;Database=UserRegistr;Username=postgres;Password=0211";
        public FormRegistr()
        {
            InitializeComponent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            string insertQuery = "INSERT INTO users (name, login, password) VALUES (@Name, @Login, @Password)";
            NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, connection);

             insertCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
            insertCommand.Parameters.AddWithValue("@Login", textBoxLogin.Text);
            insertCommand.Parameters.AddWithValue("@Password", textBoxPassword.Text);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь зарегистрирован успешно!");
                this.Hide();
                new FormHub().ShowDialog();
            }
            catch (Exception ex)
            {
                // Обработка ошибок подключения
                MessageBox.Show("Ошибка при регистрации пользователя: " + ex.Message);

            }
            finally
            {
                // Закрытие подключения
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void labelAvtoriz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAvtoriz().ShowDialog();
        }
    }
}
