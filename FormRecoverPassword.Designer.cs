namespace WindowsFormsApp2
{
    partial class FormRecoverPassword
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.blQuestion = new System.Windows.Forms.TextBox();
            this.txtawt1 = new System.Windows.Forms.Label();
            this.txtRecoverLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblRecoveredPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Location = new System.Drawing.Point(102, 216);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(244, 27);
            this.lblQuestion.TabIndex = 35;
            this.lblQuestion.Text = "Контрольный вопрос";
            this.lblQuestion.Visible = false;
            // 
            // blQuestion
            // 
            this.blQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blQuestion.ForeColor = System.Drawing.Color.Black;
            this.blQuestion.Location = new System.Drawing.Point(107, 246);
            this.blQuestion.Name = "blQuestion";
            this.blQuestion.Size = new System.Drawing.Size(273, 35);
            this.blQuestion.TabIndex = 34;
            this.blQuestion.UseSystemPasswordChar = true;
            this.blQuestion.Visible = false;
            // 
            // txtawt1
            // 
            this.txtawt1.AutoSize = true;
            this.txtawt1.BackColor = System.Drawing.Color.Transparent;
            this.txtawt1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtawt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtawt1.Location = new System.Drawing.Point(191, 35);
            this.txtawt1.Name = "txtawt1";
            this.txtawt1.Size = new System.Drawing.Size(404, 41);
            this.txtawt1.TabIndex = 33;
            this.txtawt1.Text = "Востановление пароля";
            // 
            // txtRecoverLogin
            // 
            this.txtRecoverLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRecoverLogin.ForeColor = System.Drawing.Color.Black;
            this.txtRecoverLogin.Location = new System.Drawing.Point(255, 115);
            this.txtRecoverLogin.Name = "txtRecoverLogin";
            this.txtRecoverLogin.Size = new System.Drawing.Size(273, 35);
            this.txtRecoverLogin.TabIndex = 29;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin.Location = new System.Drawing.Point(250, 85);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(173, 27);
            this.lblLogin.TabIndex = 28;
            this.lblLogin.Text = "Введите логин";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(330, 165);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 36);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(313, 305);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(158, 36);
            this.btnSubmitAnswer.TabIndex = 39;
            this.btnSubmitAnswer.Text = "Проверить";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Visible = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblRecoveredPassword
            // 
            this.lblRecoveredPassword.AutoSize = true;
            this.lblRecoveredPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRecoveredPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoveredPassword.ForeColor = System.Drawing.Color.Transparent;
            this.lblRecoveredPassword.Location = new System.Drawing.Point(201, 375);
            this.lblRecoveredPassword.Name = "lblRecoveredPassword";
            this.lblRecoveredPassword.Size = new System.Drawing.Size(145, 27);
            this.lblRecoveredPassword.TabIndex = 40;
            this.lblRecoveredPassword.Text = "Ваш пароль";
            this.lblRecoveredPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(404, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 27);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ответ на контрольный вопрос";
            this.label2.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(409, 246);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(273, 35);
            this.txtAnswer.TabIndex = 41;
            this.txtAnswer.UseSystemPasswordChar = true;
            this.txtAnswer.Visible = false;
            // 
            // FormRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._80824ca68c16f57fec97e144c6518cc23ff4820b;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblRecoveredPassword);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.blQuestion);
            this.Controls.Add(this.txtawt1);
            this.Controls.Add(this.txtRecoverLogin);
            this.Controls.Add(this.lblLogin);
            this.Name = "FormRecoverPassword";
            this.Text = "FormRecoverPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox blQuestion;
        private System.Windows.Forms.Label txtawt1;
        private System.Windows.Forms.TextBox txtRecoverLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblRecoveredPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}