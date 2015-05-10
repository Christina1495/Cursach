namespace Cursach
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.b_Find = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_countdayE = new System.Windows.Forms.NumericUpDown();
            this.nud_countdayS = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_priceMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_priceMin = new System.Windows.Forms.TextBox();
            this.nud_count = new System.Windows.Forms.NumericUpDown();
            this.cb_DataEnd = new System.Windows.Forms.ComboBox();
            this.cb_DataStart = new System.Windows.Forms.ComboBox();
            this.cb_resort = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_tourlist = new System.Windows.Forms.ListBox();
            this.b_Ok = new System.Windows.Forms.Button();
            this.l_authoriz = new System.Windows.Forms.Label();
            this.l_admin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_cabinet = new System.Windows.Forms.Label();
            this.l_Client = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.l_datenow = new System.Windows.Forms.Label();
            this.tc_form1 = new System.Windows.Forms.TabControl();
            this.tp_tour = new System.Windows.Forms.TabPage();
            this.tp_Sale = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tc_form1.SuspendLayout();
            this.tp_tour.SuspendLayout();
            this.tp_Sale.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.b_Find);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nud_countdayE);
            this.panel1.Controls.Add(this.nud_countdayS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_priceMax);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_priceMin);
            this.panel1.Controls.Add(this.nud_count);
            this.panel1.Controls.Add(this.cb_DataEnd);
            this.panel1.Controls.Add(this.cb_DataStart);
            this.panel1.Controls.Add(this.cb_resort);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 69);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Количество человек";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Дата от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Курорт";
            // 
            // b_Find
            // 
            this.b_Find.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_Find.Location = new System.Drawing.Point(797, 38);
            this.b_Find.Name = "b_Find";
            this.b_Find.Size = new System.Drawing.Size(75, 23);
            this.b_Find.TabIndex = 13;
            this.b_Find.Text = "Найти";
            this.b_Find.UseVisualStyleBackColor = false;
            this.b_Find.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество дней от";
            // 
            // nud_countdayE
            // 
            this.nud_countdayE.Location = new System.Drawing.Point(520, 34);
            this.nud_countdayE.Name = "nud_countdayE";
            this.nud_countdayE.Size = new System.Drawing.Size(45, 20);
            this.nud_countdayE.TabIndex = 10;
            this.nud_countdayE.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nud_countdayS
            // 
            this.nud_countdayS.Location = new System.Drawing.Point(520, 8);
            this.nud_countdayS.Name = "nud_countdayS";
            this.nud_countdayS.Size = new System.Drawing.Size(45, 20);
            this.nud_countdayS.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "до";
            // 
            // tb_priceMax
            // 
            this.tb_priceMax.Location = new System.Drawing.Point(652, 36);
            this.tb_priceMax.Name = "tb_priceMax";
            this.tb_priceMax.Size = new System.Drawing.Size(121, 20);
            this.tb_priceMax.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цена от";
            // 
            // tb_priceMin
            // 
            this.tb_priceMin.Location = new System.Drawing.Point(652, 8);
            this.tb_priceMin.Name = "tb_priceMin";
            this.tb_priceMin.Size = new System.Drawing.Size(121, 20);
            this.tb_priceMin.TabIndex = 5;
            // 
            // nud_count
            // 
            this.nud_count.Location = new System.Drawing.Point(129, 36);
            this.nud_count.Name = "nud_count";
            this.nud_count.Size = new System.Drawing.Size(45, 20);
            this.nud_count.TabIndex = 4;
            this.nud_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cb_DataEnd
            // 
            this.cb_DataEnd.FormattingEnabled = true;
            this.cb_DataEnd.Location = new System.Drawing.Point(260, 35);
            this.cb_DataEnd.Name = "cb_DataEnd";
            this.cb_DataEnd.Size = new System.Drawing.Size(121, 21);
            this.cb_DataEnd.TabIndex = 2;
            this.cb_DataEnd.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // cb_DataStart
            // 
            this.cb_DataStart.FormattingEnabled = true;
            this.cb_DataStart.Location = new System.Drawing.Point(260, 8);
            this.cb_DataStart.Name = "cb_DataStart";
            this.cb_DataStart.Size = new System.Drawing.Size(121, 21);
            this.cb_DataStart.TabIndex = 1;
            // 
            // cb_resort
            // 
            this.cb_resort.FormattingEnabled = true;
            this.cb_resort.Location = new System.Drawing.Point(61, 8);
            this.cb_resort.Name = "cb_resort";
            this.cb_resort.Size = new System.Drawing.Size(121, 21);
            this.cb_resort.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lb_tourlist
            // 
            this.lb_tourlist.FormattingEnabled = true;
            this.lb_tourlist.Location = new System.Drawing.Point(3, 3);
            this.lb_tourlist.Name = "lb_tourlist";
            this.lb_tourlist.Size = new System.Drawing.Size(883, 212);
            this.lb_tourlist.TabIndex = 3;
            // 
            // b_Ok
            // 
            this.b_Ok.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_Ok.Location = new System.Drawing.Point(780, 2);
            this.b_Ok.Name = "b_Ok";
            this.b_Ok.Size = new System.Drawing.Size(99, 23);
            this.b_Ok.TabIndex = 4;
            this.b_Ok.Text = "Оформить";
            this.b_Ok.UseVisualStyleBackColor = false;
            this.b_Ok.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // l_authoriz
            // 
            this.l_authoriz.AutoSize = true;
            this.l_authoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.l_authoriz.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_authoriz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_authoriz.Location = new System.Drawing.Point(10, 0);
            this.l_authoriz.Name = "l_authoriz";
            this.l_authoriz.Size = new System.Drawing.Size(137, 23);
            this.l_authoriz.TabIndex = 14;
            this.l_authoriz.Text = "Авторизация ";
            this.l_authoriz.Click += new System.EventHandler(this.label5_Click);
            // 
            // l_admin
            // 
            this.l_admin.AutoSize = true;
            this.l_admin.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_admin.Location = new System.Drawing.Point(695, 0);
            this.l_admin.Name = "l_admin";
            this.l_admin.Size = new System.Drawing.Size(207, 23);
            this.l_admin.TabIndex = 16;
            this.l_admin.Text = "Администрирование ";
            this.l_admin.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.l_cabinet);
            this.panel2.Controls.Add(this.l_Client);
            this.panel2.Controls.Add(this.l_authoriz);
            this.panel2.Controls.Add(this.l_admin);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 23);
            this.panel2.TabIndex = 17;
            // 
            // l_cabinet
            // 
            this.l_cabinet.AutoSize = true;
            this.l_cabinet.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cabinet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_cabinet.Location = new System.Drawing.Point(737, 0);
            this.l_cabinet.Name = "l_cabinet";
            this.l_cabinet.Size = new System.Drawing.Size(168, 23);
            this.l_cabinet.TabIndex = 19;
            this.l_cabinet.Text = "Личный Кабинет ";
            this.l_cabinet.Click += new System.EventHandler(this.label14_Click);
            // 
            // l_Client
            // 
            this.l_Client.AutoSize = true;
            this.l_Client.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_Client.Location = new System.Drawing.Point(146, 0);
            this.l_Client.Name = "l_Client";
            this.l_Client.Size = new System.Drawing.Size(0, 23);
            this.l_Client.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(671, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Отчет";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.lb_tourlist);
            this.panel3.Location = new System.Drawing.Point(3, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 219);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.l_datenow);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.b_Ok);
            this.panel4.Location = new System.Drawing.Point(12, 362);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 25);
            this.panel4.TabIndex = 18;
            // 
            // l_datenow
            // 
            this.l_datenow.AutoSize = true;
            this.l_datenow.Location = new System.Drawing.Point(3, 5);
            this.l_datenow.Name = "l_datenow";
            this.l_datenow.Size = new System.Drawing.Size(0, 13);
            this.l_datenow.TabIndex = 18;
            // 
            // tc_form1
            // 
            this.tc_form1.Controls.Add(this.tp_tour);
            this.tc_form1.Controls.Add(this.tp_Sale);
            this.tc_form1.Location = new System.Drawing.Point(12, 31);
            this.tc_form1.Name = "tc_form1";
            this.tc_form1.SelectedIndex = 0;
            this.tc_form1.Size = new System.Drawing.Size(905, 325);
            this.tc_form1.TabIndex = 20;
            // 
            // tp_tour
            // 
            this.tp_tour.Controls.Add(this.panel1);
            this.tp_tour.Controls.Add(this.panel3);
            this.tp_tour.Location = new System.Drawing.Point(4, 22);
            this.tp_tour.Name = "tp_tour";
            this.tp_tour.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tour.Size = new System.Drawing.Size(897, 299);
            this.tp_tour.TabIndex = 0;
            this.tp_tour.Text = "Туры";
            this.tp_tour.UseVisualStyleBackColor = true;
            // 
            // tp_Sale
            // 
            this.tp_Sale.Controls.Add(this.panel5);
            this.tp_Sale.Location = new System.Drawing.Point(4, 22);
            this.tp_Sale.Name = "tp_Sale";
            this.tp_Sale.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Sale.Size = new System.Drawing.Size(897, 299);
            this.tp_Sale.TabIndex = 1;
            this.tp_Sale.Text = "Акции";
            this.tp_Sale.UseVisualStyleBackColor = true;
            this.tp_Sale.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.numericUpDown4);
            this.panel5.Controls.Add(this.listBox2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(891, 293);
            this.panel5.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Количество человек";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(130, 264);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown4.TabIndex = 18;
            this.numericUpDown4.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(885, 251);
            this.listBox2.TabIndex = 0;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 396);
            this.Controls.Add(this.tc_form1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tc_form1.ResumeLayout(false);
            this.tp_tour.ResumeLayout(false);
            this.tp_Sale.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_resort;
        private System.Windows.Forms.ComboBox cb_DataStart;
        private System.Windows.Forms.ComboBox cb_DataEnd;
        private System.Windows.Forms.NumericUpDown nud_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_countdayE;
        private System.Windows.Forms.NumericUpDown nud_countdayS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_priceMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_priceMin;
        private System.Windows.Forms.Button b_Find;
        private System.Windows.Forms.ListBox lb_tourlist;
        private System.Windows.Forms.Button b_Ok;
        private System.Windows.Forms.Label l_authoriz;
        private System.Windows.Forms.Label l_admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_Client;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label l_datenow;
        private System.Windows.Forms.TabControl tc_form1;
        private System.Windows.Forms.TabPage tp_tour;
        private System.Windows.Forms.TabPage tp_Sale;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label l_cabinet;
    }
}

