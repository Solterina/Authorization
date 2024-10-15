namespace WindowsFormsApp2
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtawt1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConfirmRegister = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtawt1
            // 
            this.txtawt1.AutoSize = true;
            this.txtawt1.BackColor = System.Drawing.Color.Transparent;
            this.txtawt1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtawt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtawt1.Location = new System.Drawing.Point(283, 33);
            this.txtawt1.Name = "txtawt1";
            this.txtawt1.Size = new System.Drawing.Size(231, 41);
            this.txtawt1.TabIndex = 13;
            this.txtawt1.Text = "Регистрация";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(386, 284);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(68, 193);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(170, 27);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Новый пароль";
            // 
            // btnConfirmRegister
            // 
            this.btnConfirmRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmRegister.Location = new System.Drawing.Point(491, 394);
            this.btnConfirmRegister.Name = "btnConfirmRegister";
            this.btnConfirmRegister.Size = new System.Drawing.Size(280, 42);
            this.btnConfirmRegister.TabIndex = 10;
            this.btnConfirmRegister.Text = "Зарегистрироваться";
            this.btnConfirmRegister.UseVisualStyleBackColor = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(73, 223);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(273, 35);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewLogin.ForeColor = System.Drawing.Color.Black;
            this.txtNewLogin.Location = new System.Drawing.Point(73, 144);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.Size = new System.Drawing.Size(273, 35);
            this.txtNewLogin.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin.Location = new System.Drawing.Point(68, 114);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(153, 27);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Новый логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(443, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Контрольный вопрос";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuestion.ForeColor = System.Drawing.Color.Black;
            this.txtQuestion.Location = new System.Drawing.Point(448, 144);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(273, 35);
            this.txtQuestion.TabIndex = 14;
            this.txtQuestion.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(443, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ответ на контрольный вопрос";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(448, 223);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(273, 35);
            this.txtAnswer.TabIndex = 16;
            this.txtAnswer.UseSystemPasswordChar = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._80824ca68c16f57fec97e144c6518cc23ff4820b;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtawt1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnConfirmRegister);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewLogin);
            this.Controls.Add(this.lblLogin);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtawt1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConfirmRegister;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}