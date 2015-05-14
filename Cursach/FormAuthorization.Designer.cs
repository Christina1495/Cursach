namespace Cursach
{
    partial class FormAuthorization
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.l_helpreg = new System.Windows.Forms.Label();
            this.p_auth = new System.Windows.Forms.Panel();
            this.ll_reg = new System.Windows.Forms.LinkLabel();
            this.b_start = new System.Windows.Forms.Button();
            this.p_auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(21, 46);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(327, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(21, 108);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(327, 20);
            this.tb_password.TabIndex = 2;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_email.Location = new System.Drawing.Point(18, 25);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(191, 18);
            this.l_email.TabIndex = 3;
            this.l_email.Text = "Адрес электронной почты";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_password.Location = new System.Drawing.Point(18, 87);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(61, 18);
            this.l_password.TabIndex = 4;
            this.l_password.Text = "Пароль";
            // 
            // l_helpreg
            // 
            this.l_helpreg.AutoSize = true;
            this.l_helpreg.Location = new System.Drawing.Point(104, 144);
            this.l_helpreg.Name = "l_helpreg";
            this.l_helpreg.Size = new System.Drawing.Size(129, 13);
            this.l_helpreg.TabIndex = 5;
            this.l_helpreg.Text = ", чтобы войти в систему";
            // 
            // p_auth
            // 
            this.p_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.p_auth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_auth.Controls.Add(this.tb_email);
            this.p_auth.Controls.Add(this.ll_reg);
            this.p_auth.Controls.Add(this.l_password);
            this.p_auth.Controls.Add(this.l_email);
            this.p_auth.Controls.Add(this.l_helpreg);
            this.p_auth.Controls.Add(this.tb_password);
            this.p_auth.Location = new System.Drawing.Point(27, 26);
            this.p_auth.Name = "p_auth";
            this.p_auth.Size = new System.Drawing.Size(367, 165);
            this.p_auth.TabIndex = 6;
            // 
            // ll_reg
            // 
            this.ll_reg.AutoSize = true;
            this.ll_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.ll_reg.Cursor = System.Windows.Forms.Cursors.No;
            this.ll_reg.LinkColor = System.Drawing.Color.Black;
            this.ll_reg.Location = new System.Drawing.Point(3, 144);
            this.ll_reg.Name = "ll_reg";
            this.ll_reg.Size = new System.Drawing.Size(109, 13);
            this.ll_reg.TabIndex = 5;
            this.ll_reg.TabStop = true;
            this.ll_reg.Text = "Зарегистрируйтесь,";
            this.ll_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(297, 191);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(97, 23);
            this.b_start.TabIndex = 7;
            this.b_start.Text = "Начать работу";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(426, 226);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.p_auth);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.p_auth.ResumeLayout(false);
            this.p_auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_helpreg;
        private System.Windows.Forms.Panel p_auth;
        private System.Windows.Forms.LinkLabel ll_reg;
        private System.Windows.Forms.Button b_start;
    }
}