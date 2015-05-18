namespace Cursach
{
    partial class FormPayment
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
            this.tb_summa = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.l_summa = new System.Windows.Forms.Label();
            this.l_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_summa
            // 
            this.tb_summa.Location = new System.Drawing.Point(70, 37);
            this.tb_summa.Name = "tb_summa";
            this.tb_summa.Size = new System.Drawing.Size(187, 20);
            this.tb_summa.TabIndex = 1;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(263, 35);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 2;
            this.b_ok.Text = "Оплатить";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_summa
            // 
            this.l_summa.AutoSize = true;
            this.l_summa.Location = new System.Drawing.Point(20, 40);
            this.l_summa.Name = "l_summa";
            this.l_summa.Size = new System.Drawing.Size(44, 13);
            this.l_summa.TabIndex = 7;
            this.l_summa.Text = "Сумма:";
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_info.Location = new System.Drawing.Point(12, 9);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(114, 25);
            this.l_info.TabIndex = 8;
            this.l_info.Text = "К оплате: ";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(361, 69);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.l_summa);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.tb_summa);
            this.Name = "FormPayment";
            this.Text = "Клиен-Банк";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_summa;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Label l_summa;
        private System.Windows.Forms.Label l_info;
    }
}