﻿using System;
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
    public partial class FormHub : Form
    {
        public FormHub(string userLogin)
        {
            InitializeComponent();
            label1.Text = $"Пользователь: {userLogin}";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
