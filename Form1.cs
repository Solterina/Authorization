using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredLogin = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredLogin == correctLogin && enteredPassword == correctPassword)
            {
                lblResult.Text = "Успешная авторизация";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }
            else
            {
                lblResult.Text = "Неверный логин или пароль. Попробуйте снова.";
                lblResult.ForeColor = Color.White;
                lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
            }
            txtLogin.Clear();
            txtPassword.Clear();

            txtLogin.Focus();
            lblResult.Left = (this.ClientSize.Width - lblResult.Width)/2;
        }
    }
}
