namespace Cursach
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.l_fio = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.p_password = new System.Windows.Forms.Panel();
            this.p_ginpassword = new System.Windows.Forms.Panel();
            this.b_ginpassword = new System.Windows.Forms.Button();
            this.b_use = new System.Windows.Forms.Button();
            this.tb_ginpassword = new System.Windows.Forms.TextBox();
            this.l_password2 = new System.Windows.Forms.Label();
            this.l_password1 = new System.Windows.Forms.Label();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.tb_password1 = new System.Windows.Forms.TextBox();
            this.l_password = new System.Windows.Forms.Label();
            this.b_register = new System.Windows.Forms.Button();
            this.p_password.SuspendLayout();
            this.p_ginpassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_fio
            // 
            this.tb_fio.Location = new System.Drawing.Point(12, 29);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(509, 20);
            this.tb_fio.TabIndex = 2;
            // 
            // l_fio
            // 
            this.l_fio.AutoSize = true;
            this.l_fio.BackColor = System.Drawing.Color.White;
            this.l_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_fio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_fio.Location = new System.Drawing.Point(12, 9);
            this.l_fio.Name = "l_fio";
            this.l_fio.Size = new System.Drawing.Size(42, 17);
            this.l_fio.TabIndex = 3;
            this.l_fio.Text = "ФИО";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 76);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(509, 20);
            this.tb_email.TabIndex = 4;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.BackColor = System.Drawing.Color.White;
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_email.Location = new System.Drawing.Point(12, 56);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(182, 17);
            this.l_email.TabIndex = 5;
            this.l_email.Text = "Адрес электронной почты";
            // 
            // p_password
            // 
            this.p_password.BackColor = System.Drawing.Color.White;
            this.p_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_password.Controls.Add(this.p_ginpassword);
            this.p_password.Controls.Add(this.l_password2);
            this.p_password.Controls.Add(this.l_password1);
            this.p_password.Controls.Add(this.tb_password2);
            this.p_password.Controls.Add(this.tb_password1);
            this.p_password.Location = new System.Drawing.Point(12, 128);
            this.p_password.Name = "p_password";
            this.p_password.Size = new System.Drawing.Size(509, 193);
            this.p_password.TabIndex = 6;
            // 
            // p_ginpassword
            // 
            this.p_ginpassword.BackColor = System.Drawing.Color.White;
            this.p_ginpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_ginpassword.Controls.Add(this.b_ginpassword);
            this.p_ginpassword.Controls.Add(this.b_use);
            this.p_ginpassword.Controls.Add(this.tb_ginpassword);
            this.p_ginpassword.Location = new System.Drawing.Point(19, 79);
            this.p_ginpassword.Name = "p_ginpassword";
            this.p_ginpassword.Size = new System.Drawing.Size(267, 100);
            this.p_ginpassword.TabIndex = 15;
            // 
            // b_ginpassword
            // 
            this.b_ginpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_ginpassword.Location = new System.Drawing.Point(19, 12);
            this.b_ginpassword.Name = "b_ginpassword";
            this.b_ginpassword.Size = new System.Drawing.Size(163, 23);
            this.b_ginpassword.TabIndex = 14;
            this.b_ginpassword.Text = "Сгенерировать пароль";
            this.b_ginpassword.UseVisualStyleBackColor = false;
            this.b_ginpassword.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_use
            // 
            this.b_use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_use.Location = new System.Drawing.Point(19, 67);
            this.b_use.Name = "b_use";
            this.b_use.Size = new System.Drawing.Size(163, 23);
            this.b_use.TabIndex = 13;
            this.b_use.Text = "Использовать";
            this.b_use.UseVisualStyleBackColor = false;
            this.b_use.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_ginpassword
            // 
            this.tb_ginpassword.Location = new System.Drawing.Point(19, 41);
            this.tb_ginpassword.Name = "tb_ginpassword";
            this.tb_ginpassword.Size = new System.Drawing.Size(234, 20);
            this.tb_ginpassword.TabIndex = 8;
            // 
            // l_password2
            // 
            this.l_password2.AutoSize = true;
            this.l_password2.Location = new System.Drawing.Point(256, 28);
            this.l_password2.Name = "l_password2";
            this.l_password2.Size = new System.Drawing.Size(115, 13);
            this.l_password2.TabIndex = 12;
            this.l_password2.Text = "Подтвердите пароль:";
            // 
            // l_password1
            // 
            this.l_password1.AutoSize = true;
            this.l_password1.Location = new System.Drawing.Point(16, 28);
            this.l_password1.Name = "l_password1";
            this.l_password1.Size = new System.Drawing.Size(48, 13);
            this.l_password1.TabIndex = 11;
            this.l_password1.Text = "Пароль:";
            this.l_password1.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_password2
            // 
            this.tb_password2.Location = new System.Drawing.Point(259, 44);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.Size = new System.Drawing.Size(234, 20);
            this.tb_password2.TabIndex = 9;
            // 
            // tb_password1
            // 
            this.tb_password1.Location = new System.Drawing.Point(19, 44);
            this.tb_password1.Name = "tb_password1";
            this.tb_password1.Size = new System.Drawing.Size(234, 20);
            this.tb_password1.TabIndex = 10;
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.BackColor = System.Drawing.Color.White;
            this.l_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_password.Location = new System.Drawing.Point(12, 108);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(57, 17);
            this.l_password.TabIndex = 7;
            this.l_password.Text = "Пароль";
            // 
            // b_register
            // 
            this.b_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_register.Location = new System.Drawing.Point(358, 327);
            this.b_register.Name = "b_register";
            this.b_register.Size = new System.Drawing.Size(163, 23);
            this.b_register.TabIndex = 8;
            this.b_register.Text = "Зарегистрироваться ";
            this.b_register.UseVisualStyleBackColor = false;
            this.b_register.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 355);
            this.Controls.Add(this.b_register);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.p_password);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.l_fio);
            this.Controls.Add(this.tb_fio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.Text = "Регистрация ";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.p_password.ResumeLayout(false);
            this.p_password.PerformLayout();
            this.p_ginpassword.ResumeLayout(false);
            this.p_ginpassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.Label l_fio;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Panel p_password;
        private System.Windows.Forms.Label l_password2;
        private System.Windows.Forms.Label l_password1;
        private System.Windows.Forms.TextBox tb_ginpassword;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.TextBox tb_password1;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Button b_ginpassword;
        private System.Windows.Forms.Button b_use;
        private System.Windows.Forms.Button b_register;
        private System.Windows.Forms.Panel p_ginpassword;
    }
}