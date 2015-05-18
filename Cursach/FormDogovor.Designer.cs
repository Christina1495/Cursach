namespace Cursach
{
    partial class FormDogovor
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
            this.l_info1 = new System.Windows.Forms.Label();
            this.p_main = new System.Windows.Forms.Panel();
            this.b_ok = new System.Windows.Forms.Button();
            this.gb_document = new System.Windows.Forms.GroupBox();
            this.l_info2 = new System.Windows.Forms.Label();
            this.tb_bank = new System.Windows.Forms.TextBox();
            this.tb_payment = new System.Windows.Forms.TextBox();
            this.l_bank = new System.Windows.Forms.Label();
            this.l_payment = new System.Windows.Forms.Label();
            this.gb_address = new System.Windows.Forms.GroupBox();
            this.tb_numberkv = new System.Windows.Forms.TextBox();
            this.tb_numberdom = new System.Windows.Forms.TextBox();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.l_numberkv = new System.Windows.Forms.Label();
            this.l_numberdom = new System.Windows.Forms.Label();
            this.l_street = new System.Windows.Forms.Label();
            this.l_city = new System.Windows.Forms.Label();
            this.l_postindex = new System.Windows.Forms.Label();
            this.tb_postindex = new System.Windows.Forms.TextBox();
            this.p_main.SuspendLayout();
            this.gb_document.SuspendLayout();
            this.gb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_info1
            // 
            this.l_info1.AutoSize = true;
            this.l_info1.Location = new System.Drawing.Point(12, 9);
            this.l_info1.Name = "l_info1";
            this.l_info1.Size = new System.Drawing.Size(335, 13);
            this.l_info1.TabIndex = 0;
            this.l_info1.Text = "Для оформления договора и счета на оплату, заполните форму:";
            // 
            // p_main
            // 
            this.p_main.Controls.Add(this.b_ok);
            this.p_main.Controls.Add(this.gb_document);
            this.p_main.Controls.Add(this.gb_address);
            this.p_main.Location = new System.Drawing.Point(15, 25);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(510, 261);
            this.p_main.TabIndex = 1;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(153, 231);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(210, 23);
            this.b_ok.TabIndex = 2;
            this.b_ok.Text = "Составить договор и расчетный счет:";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gb_document
            // 
            this.gb_document.Controls.Add(this.l_info2);
            this.gb_document.Controls.Add(this.tb_bank);
            this.gb_document.Controls.Add(this.tb_payment);
            this.gb_document.Controls.Add(this.l_bank);
            this.gb_document.Controls.Add(this.l_payment);
            this.gb_document.Location = new System.Drawing.Point(16, 131);
            this.gb_document.Name = "gb_document";
            this.gb_document.Size = new System.Drawing.Size(472, 94);
            this.gb_document.TabIndex = 1;
            this.gb_document.TabStop = false;
            this.gb_document.Text = "Документы:";
            // 
            // l_info2
            // 
            this.l_info2.AutoSize = true;
            this.l_info2.Location = new System.Drawing.Point(6, 78);
            this.l_info2.Name = "l_info2";
            this.l_info2.Size = new System.Drawing.Size(213, 13);
            this.l_info2.TabIndex = 11;
            this.l_info2.Text = "(*) - поля обязательные для заполнения.";
            // 
            // tb_bank
            // 
            this.tb_bank.Location = new System.Drawing.Point(106, 47);
            this.tb_bank.Name = "tb_bank";
            this.tb_bank.Size = new System.Drawing.Size(356, 20);
            this.tb_bank.TabIndex = 10;
            // 
            // tb_payment
            // 
            this.tb_payment.Location = new System.Drawing.Point(106, 23);
            this.tb_payment.Name = "tb_payment";
            this.tb_payment.Size = new System.Drawing.Size(356, 20);
            this.tb_payment.TabIndex = 9;
            // 
            // l_bank
            // 
            this.l_bank.AutoSize = true;
            this.l_bank.Location = new System.Drawing.Point(61, 50);
            this.l_bank.Name = "l_bank";
            this.l_bank.Size = new System.Drawing.Size(39, 13);
            this.l_bank.TabIndex = 6;
            this.l_bank.Text = "Банк:*";
            // 
            // l_payment
            // 
            this.l_payment.AutoSize = true;
            this.l_payment.Location = new System.Drawing.Point(6, 26);
            this.l_payment.Name = "l_payment";
            this.l_payment.Size = new System.Drawing.Size(94, 13);
            this.l_payment.TabIndex = 5;
            this.l_payment.Text = "Расчетный счет:*";
            // 
            // gb_address
            // 
            this.gb_address.Controls.Add(this.tb_numberkv);
            this.gb_address.Controls.Add(this.tb_numberdom);
            this.gb_address.Controls.Add(this.tb_street);
            this.gb_address.Controls.Add(this.tb_city);
            this.gb_address.Controls.Add(this.l_numberkv);
            this.gb_address.Controls.Add(this.l_numberdom);
            this.gb_address.Controls.Add(this.l_street);
            this.gb_address.Controls.Add(this.l_city);
            this.gb_address.Controls.Add(this.l_postindex);
            this.gb_address.Controls.Add(this.tb_postindex);
            this.gb_address.Location = new System.Drawing.Point(16, 14);
            this.gb_address.Name = "gb_address";
            this.gb_address.Size = new System.Drawing.Size(472, 111);
            this.gb_address.TabIndex = 0;
            this.gb_address.TabStop = false;
            this.gb_address.Text = "Адрес:";
            // 
            // tb_numberkv
            // 
            this.tb_numberkv.Location = new System.Drawing.Point(172, 72);
            this.tb_numberkv.Name = "tb_numberkv";
            this.tb_numberkv.Size = new System.Drawing.Size(42, 20);
            this.tb_numberkv.TabIndex = 9;
            // 
            // tb_numberdom
            // 
            this.tb_numberdom.Location = new System.Drawing.Point(54, 72);
            this.tb_numberdom.Name = "tb_numberdom";
            this.tb_numberdom.Size = new System.Drawing.Size(42, 20);
            this.tb_numberdom.TabIndex = 8;
            // 
            // tb_street
            // 
            this.tb_street.Location = new System.Drawing.Point(54, 47);
            this.tb_street.Name = "tb_street";
            this.tb_street.Size = new System.Drawing.Size(408, 20);
            this.tb_street.TabIndex = 7;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(291, 19);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(171, 20);
            this.tb_city.TabIndex = 6;
            // 
            // l_numberkv
            // 
            this.l_numberkv.AutoSize = true;
            this.l_numberkv.Location = new System.Drawing.Point(108, 75);
            this.l_numberkv.Name = "l_numberkv";
            this.l_numberkv.Size = new System.Drawing.Size(58, 13);
            this.l_numberkv.TabIndex = 5;
            this.l_numberkv.Text = "Квартира:";
            // 
            // l_numberdom
            // 
            this.l_numberdom.AutoSize = true;
            this.l_numberdom.Location = new System.Drawing.Point(15, 75);
            this.l_numberdom.Name = "l_numberdom";
            this.l_numberdom.Size = new System.Drawing.Size(33, 13);
            this.l_numberdom.TabIndex = 4;
            this.l_numberdom.Text = "Дом:";
            // 
            // l_street
            // 
            this.l_street.AutoSize = true;
            this.l_street.Location = new System.Drawing.Point(6, 50);
            this.l_street.Name = "l_street";
            this.l_street.Size = new System.Drawing.Size(42, 13);
            this.l_street.TabIndex = 3;
            this.l_street.Text = "Улица:";
            // 
            // l_city
            // 
            this.l_city.AutoSize = true;
            this.l_city.Location = new System.Drawing.Point(241, 22);
            this.l_city.Name = "l_city";
            this.l_city.Size = new System.Drawing.Size(44, 13);
            this.l_city.TabIndex = 2;
            this.l_city.Text = "Город:*";
            // 
            // l_postindex
            // 
            this.l_postindex.AutoSize = true;
            this.l_postindex.Location = new System.Drawing.Point(6, 22);
            this.l_postindex.Name = "l_postindex";
            this.l_postindex.Size = new System.Drawing.Size(99, 13);
            this.l_postindex.TabIndex = 1;
            this.l_postindex.Text = "Почтовый индекс:";
            // 
            // tb_postindex
            // 
            this.tb_postindex.Location = new System.Drawing.Point(111, 19);
            this.tb_postindex.Name = "tb_postindex";
            this.tb_postindex.Size = new System.Drawing.Size(100, 20);
            this.tb_postindex.TabIndex = 0;
            // 
            // FormDogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(542, 307);
            this.Controls.Add(this.p_main);
            this.Controls.Add(this.l_info1);
            this.Name = "FormDogovor";
            this.Text = "Заполнение информации";
            this.Load += new System.EventHandler(this.FormDogovor_Load);
            this.p_main.ResumeLayout(false);
            this.gb_document.ResumeLayout(false);
            this.gb_document.PerformLayout();
            this.gb_address.ResumeLayout(false);
            this.gb_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_info1;
        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.GroupBox gb_document;
        private System.Windows.Forms.Label l_info2;
        private System.Windows.Forms.TextBox tb_bank;
        private System.Windows.Forms.TextBox tb_payment;
        private System.Windows.Forms.Label l_bank;
        private System.Windows.Forms.Label l_payment;
        private System.Windows.Forms.GroupBox gb_address;
        private System.Windows.Forms.TextBox tb_numberkv;
        private System.Windows.Forms.TextBox tb_numberdom;
        private System.Windows.Forms.TextBox tb_street;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label l_numberkv;
        private System.Windows.Forms.Label l_numberdom;
        private System.Windows.Forms.Label l_street;
        private System.Windows.Forms.Label l_city;
        private System.Windows.Forms.Label l_postindex;
        private System.Windows.Forms.TextBox tb_postindex;

    }
}