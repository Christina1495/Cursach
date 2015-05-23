namespace Cursach
{
    partial class FormPersonal
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
            this.l_nameclient = new System.Windows.Forms.Label();
            this.lb_tour = new System.Windows.Forms.ListBox();
            this.b_pay = new System.Windows.Forms.Button();
            this.b_listthings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_nameclient
            // 
            this.l_nameclient.AutoSize = true;
            this.l_nameclient.Location = new System.Drawing.Point(12, 9);
            this.l_nameclient.Name = "l_nameclient";
            this.l_nameclient.Size = new System.Drawing.Size(35, 13);
            this.l_nameclient.TabIndex = 0;
            this.l_nameclient.Text = "label1";
            // 
            // lb_tour
            // 
            this.lb_tour.FormattingEnabled = true;
            this.lb_tour.Location = new System.Drawing.Point(12, 25);
            this.lb_tour.Name = "lb_tour";
            this.lb_tour.Size = new System.Drawing.Size(960, 173);
            this.lb_tour.TabIndex = 1;
            // 
            // b_pay
            // 
            this.b_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_pay.Location = new System.Drawing.Point(12, 204);
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(75, 23);
            this.b_pay.TabIndex = 2;
            this.b_pay.Text = "Оплата";
            this.b_pay.UseVisualStyleBackColor = false;
            this.b_pay.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_listthings
            // 
            this.b_listthings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_listthings.Location = new System.Drawing.Point(93, 204);
            this.b_listthings.Name = "b_listthings";
            this.b_listthings.Size = new System.Drawing.Size(171, 23);
            this.b_listthings.TabIndex = 3;
            this.b_listthings.Text = "Сформировать список вещей";
            this.b_listthings.UseVisualStyleBackColor = false;
            this.b_listthings.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 232);
            this.Controls.Add(this.b_listthings);
            this.Controls.Add(this.b_pay);
            this.Controls.Add(this.lb_tour);
            this.Controls.Add(this.l_nameclient);
            this.Name = "FormPersonal";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nameclient;
        private System.Windows.Forms.ListBox lb_tour;
        private System.Windows.Forms.Button b_pay;
        private System.Windows.Forms.Button b_listthings;
    }
}