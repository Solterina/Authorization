﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string correctLogin = "admin";
        private string correctPassword = "123";
        private int correcterror = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredLogin = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            if (correcterror <= 0)
            {
                lblResult.Text = "У вас закончились попытки входа!";
                lblResult.ForeColor = Color.Red;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }
            else if (enteredLogin == correctLogin && enteredPassword == correctPassword)
            {
                lblResult.Text = "Успешная авторизация";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
                correcterror = 3;
            }
            else
            {
                lblResult.Text = $"Неверный логин или пароль. Попробуйте снова.\n Попыток осталось {correcterror}";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
                correcterror--;
            }
            txtLogin.Clear();
            txtPassword.Clear();

            txtLogin.Focus();
            lblResult.Left = (this.ClientSize.Width - lblResult.Width) / 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var form = new FormRegister();
            form.Show();
        }
    }
}
