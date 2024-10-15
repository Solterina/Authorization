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
    public partial class FormRecoverPassword : Form
    {
        private string userLogin;
        private string userQuestion;
        private string userAnswer;
        private string userPassword;
        public FormRecoverPassword(string userLogin, string userPassword, string userQuestion, string userAnswer)
        {
            InitializeComponent();
            this.userLogin = userLogin;
            this.userQuestion = userQuestion;
            this.userAnswer = userAnswer;
            this.userPassword = userPassword;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtRecoverLogin.Text == userLogin)
            {
                blQuestion.Text = userQuestion;
                blQuestion.Visible = true;
                txtAnswer.Visible = true;
                btnSubmitAnswer.Visible = true;
            }
            else
            {
                MessageBox.Show("Неверный логин. Попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == userAnswer)
            {
                lblRecoveredPassword.Text = $"Ваш пароль: {userPassword}";
                lblRecoveredPassword.Visible = true;
            }
           else
            {
                MessageBox.Show("Неверный ответ на контрольный вопрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
