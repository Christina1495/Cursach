namespace Cursach
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.p_resort = new System.Windows.Forms.Panel();
            this.l_amount = new System.Windows.Forms.Label();
            this.l_de = new System.Windows.Forms.Label();
            this.l_ds = new System.Windows.Forms.Label();
            this.l_resort = new System.Windows.Forms.Label();
            this.b_Find = new System.Windows.Forms.Button();
            this.l_amde = new System.Windows.Forms.Label();
            this.l_amds = new System.Windows.Forms.Label();
            this.nud_countdayE = new System.Windows.Forms.NumericUpDown();
            this.nud_countdayS = new System.Windows.Forms.NumericUpDown();
            this.l_pre = new System.Windows.Forms.Label();
            this.tb_priceMax = new System.Windows.Forms.TextBox();
            this.l_pr = new System.Windows.Forms.Label();
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
            this.p_main = new System.Windows.Forms.Panel();
            this.l_cabinet = new System.Windows.Forms.Label();
            this.l_Client = new System.Windows.Forms.Label();
            this.p_resort2 = new System.Windows.Forms.Panel();
            this.p_3 = new System.Windows.Forms.Panel();
            this.l_datenow = new System.Windows.Forms.Label();
            this.tc_form1 = new System.Windows.Forms.TabControl();
            this.tp_tour = new System.Windows.Forms.TabPage();
            this.tp_Sale = new System.Windows.Forms.TabPage();
            this.p_sale = new System.Windows.Forms.Panel();
            this.l_amount2 = new System.Windows.Forms.Label();
            this.nud_amount2 = new System.Windows.Forms.NumericUpDown();
            this.lb_sale = new System.Windows.Forms.ListBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_resort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).BeginInit();
            this.p_main.SuspendLayout();
            this.p_resort2.SuspendLayout();
            this.p_3.SuspendLayout();
            this.tc_form1.SuspendLayout();
            this.tp_tour.SuspendLayout();
            this.tp_Sale.SuspendLayout();
            this.p_sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount2)).BeginInit();
            this.SuspendLayout();
            // 
            // p_resort
            // 
            this.p_resort.BackColor = System.Drawing.Color.White;
            this.p_resort.Controls.Add(this.l_amount);
            this.p_resort.Controls.Add(this.l_de);
            this.p_resort.Controls.Add(this.l_ds);
            this.p_resort.Controls.Add(this.l_resort);
            this.p_resort.Controls.Add(this.b_Find);
            this.p_resort.Controls.Add(this.l_amde);
            this.p_resort.Controls.Add(this.l_amds);
            this.p_resort.Controls.Add(this.nud_countdayE);
            this.p_resort.Controls.Add(this.nud_countdayS);
            this.p_resort.Controls.Add(this.l_pre);
            this.p_resort.Controls.Add(this.tb_priceMax);
            this.p_resort.Controls.Add(this.l_pr);
            this.p_resort.Controls.Add(this.tb_priceMin);
            this.p_resort.Controls.Add(this.nud_count);
            this.p_resort.Controls.Add(this.cb_DataEnd);
            this.p_resort.Controls.Add(this.cb_DataStart);
            this.p_resort.Controls.Add(this.cb_resort);
            this.p_resort.Location = new System.Drawing.Point(3, 3);
            this.p_resort.Name = "p_resort";
            this.p_resort.Size = new System.Drawing.Size(889, 69);
            this.p_resort.TabIndex = 1;
            // 
            // l_amount
            // 
            this.l_amount.AutoSize = true;
            this.l_amount.Location = new System.Drawing.Point(13, 38);
            this.l_amount.Name = "l_amount";
            this.l_amount.Size = new System.Drawing.Size(110, 13);
            this.l_amount.TabIndex = 17;
            this.l_amount.Text = "Количество человек";
            // 
            // l_de
            // 
            this.l_de.AutoSize = true;
            this.l_de.Location = new System.Drawing.Point(235, 38);
            this.l_de.Name = "l_de";
            this.l_de.Size = new System.Drawing.Size(19, 13);
            this.l_de.TabIndex = 16;
            this.l_de.Text = "до";
            // 
            // l_ds
            // 
            this.l_ds.AutoSize = true;
            this.l_ds.Location = new System.Drawing.Point(207, 11);
            this.l_ds.Name = "l_ds";
            this.l_ds.Size = new System.Drawing.Size(47, 13);
            this.l_ds.TabIndex = 15;
            this.l_ds.Text = "Дата от";
            // 
            // l_resort
            // 
            this.l_resort.AutoSize = true;
            this.l_resort.Location = new System.Drawing.Point(13, 11);
            this.l_resort.Name = "l_resort";
            this.l_resort.Size = new System.Drawing.Size(42, 13);
            this.l_resort.TabIndex = 14;
            this.l_resort.Text = "Курорт";
            // 
            // b_Find
            // 
            this.b_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_Find.Location = new System.Drawing.Point(797, 38);
            this.b_Find.Name = "b_Find";
            this.b_Find.Size = new System.Drawing.Size(75, 23);
            this.b_Find.TabIndex = 13;
            this.b_Find.Text = "Найти";
            this.b_Find.UseVisualStyleBackColor = false;
            this.b_Find.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_amde
            // 
            this.l_amde.AutoSize = true;
            this.l_amde.Location = new System.Drawing.Point(495, 38);
            this.l_amde.Name = "l_amde";
            this.l_amde.Size = new System.Drawing.Size(19, 13);
            this.l_amde.TabIndex = 12;
            this.l_amde.Text = "до";
            // 
            // l_amds
            // 
            this.l_amds.AutoSize = true;
            this.l_amds.Location = new System.Drawing.Point(407, 11);
            this.l_amds.Name = "l_amds";
            this.l_amds.Size = new System.Drawing.Size(107, 13);
            this.l_amds.TabIndex = 11;
            this.l_amds.Text = "Количество дней от";
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
            // l_pre
            // 
            this.l_pre.AutoSize = true;
            this.l_pre.Location = new System.Drawing.Point(627, 38);
            this.l_pre.Name = "l_pre";
            this.l_pre.Size = new System.Drawing.Size(19, 13);
            this.l_pre.TabIndex = 8;
            this.l_pre.Text = "до";
            // 
            // tb_priceMax
            // 
            this.tb_priceMax.Location = new System.Drawing.Point(652, 36);
            this.tb_priceMax.Name = "tb_priceMax";
            this.tb_priceMax.Size = new System.Drawing.Size(121, 20);
            this.tb_priceMax.TabIndex = 7;
            // 
            // l_pr
            // 
            this.l_pr.AutoSize = true;
            this.l_pr.Location = new System.Drawing.Point(599, 11);
            this.l_pr.Name = "l_pr";
            this.l_pr.Size = new System.Drawing.Size(47, 13);
            this.l_pr.TabIndex = 6;
            this.l_pr.Text = "Цена от";
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
            this.b_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_Ok.Location = new System.Drawing.Point(790, 300);
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
            this.l_authoriz.BackColor = System.Drawing.Color.White;
            this.l_authoriz.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_authoriz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_authoriz.Location = new System.Drawing.Point(3, 0);
            this.l_authoriz.Name = "l_authoriz";
            this.l_authoriz.Size = new System.Drawing.Size(137, 23);
            this.l_authoriz.TabIndex = 14;
            this.l_authoriz.Text = "Авторизация ";
            this.l_authoriz.Click += new System.EventHandler(this.label5_Click);
            // 
            // l_admin
            // 
            this.l_admin.AutoSize = true;
            this.l_admin.BackColor = System.Drawing.Color.White;
            this.l_admin.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_admin.Location = new System.Drawing.Point(540, 0);
            this.l_admin.Name = "l_admin";
            this.l_admin.Size = new System.Drawing.Size(207, 23);
            this.l_admin.TabIndex = 16;
            this.l_admin.Text = "Администрирование ";
            this.l_admin.Click += new System.EventHandler(this.label7_Click);
            // 
            // p_main
            // 
            this.p_main.BackColor = System.Drawing.Color.White;
            this.p_main.Controls.Add(this.l_cabinet);
            this.p_main.Controls.Add(this.l_Client);
            this.p_main.Controls.Add(this.l_authoriz);
            this.p_main.Controls.Add(this.l_admin);
            this.p_main.Location = new System.Drawing.Point(11, 7);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(747, 23);
            this.p_main.TabIndex = 17;
            // 
            // l_cabinet
            // 
            this.l_cabinet.AutoSize = true;
            this.l_cabinet.BackColor = System.Drawing.Color.White;
            this.l_cabinet.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cabinet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_cabinet.Location = new System.Drawing.Point(579, 0);
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
            // p_resort2
            // 
            this.p_resort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.p_resort2.Controls.Add(this.lb_tourlist);
            this.p_resort2.Location = new System.Drawing.Point(3, 76);
            this.p_resort2.Name = "p_resort2";
            this.p_resort2.Size = new System.Drawing.Size(889, 219);
            this.p_resort2.TabIndex = 19;
            // 
            // p_3
            // 
            this.p_3.Controls.Add(this.l_datenow);
            this.p_3.Location = new System.Drawing.Point(12, 36);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(387, 43);
            this.p_3.TabIndex = 18;
            // 
            // l_datenow
            // 
            this.l_datenow.AutoSize = true;
            this.l_datenow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_datenow.Location = new System.Drawing.Point(3, 5);
            this.l_datenow.Name = "l_datenow";
            this.l_datenow.Size = new System.Drawing.Size(0, 25);
            this.l_datenow.TabIndex = 18;
            // 
            // tc_form1
            // 
            this.tc_form1.Controls.Add(this.tp_tour);
            this.tc_form1.Controls.Add(this.tp_Sale);
            this.tc_form1.Location = new System.Drawing.Point(11, 80);
            this.tc_form1.Name = "tc_form1";
            this.tc_form1.SelectedIndex = 0;
            this.tc_form1.Size = new System.Drawing.Size(905, 355);
            this.tc_form1.TabIndex = 20;
            // 
            // tp_tour
            // 
            this.tp_tour.Controls.Add(this.p_resort);
            this.tp_tour.Controls.Add(this.b_Ok);
            this.tp_tour.Controls.Add(this.p_resort2);
            this.tp_tour.Location = new System.Drawing.Point(4, 22);
            this.tp_tour.Name = "tp_tour";
            this.tp_tour.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tour.Size = new System.Drawing.Size(897, 329);
            this.tp_tour.TabIndex = 0;
            this.tp_tour.Text = "Туры";
            this.tp_tour.UseVisualStyleBackColor = true;
            // 
            // tp_Sale
            // 
            this.tp_Sale.Controls.Add(this.p_sale);
            this.tp_Sale.Location = new System.Drawing.Point(4, 22);
            this.tp_Sale.Name = "tp_Sale";
            this.tp_Sale.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Sale.Size = new System.Drawing.Size(897, 329);
            this.tp_Sale.TabIndex = 1;
            this.tp_Sale.Text = "Акции";
            this.tp_Sale.UseVisualStyleBackColor = true;
            this.tp_Sale.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // p_sale
            // 
            this.p_sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.p_sale.Controls.Add(this.l_amount2);
            this.p_sale.Controls.Add(this.nud_amount2);
            this.p_sale.Controls.Add(this.lb_sale);
            this.p_sale.Location = new System.Drawing.Point(3, 3);
            this.p_sale.Name = "p_sale";
            this.p_sale.Size = new System.Drawing.Size(891, 320);
            this.p_sale.TabIndex = 0;
            // 
            // l_amount2
            // 
            this.l_amount2.AutoSize = true;
            this.l_amount2.Location = new System.Drawing.Point(3, 298);
            this.l_amount2.Name = "l_amount2";
            this.l_amount2.Size = new System.Drawing.Size(110, 13);
            this.l_amount2.TabIndex = 19;
            this.l_amount2.Text = "Количество человек";
            // 
            // nud_amount2
            // 
            this.nud_amount2.Location = new System.Drawing.Point(119, 296);
            this.nud_amount2.Name = "nud_amount2";
            this.nud_amount2.Size = new System.Drawing.Size(45, 20);
            this.nud_amount2.TabIndex = 18;
            this.nud_amount2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lb_sale
            // 
            this.lb_sale.FormattingEnabled = true;
            this.lb_sale.Location = new System.Drawing.Point(3, 3);
            this.lb_sale.Name = "lb_sale";
            this.lb_sale.Size = new System.Drawing.Size(885, 290);
            this.lb_sale.TabIndex = 0;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Cursach.Properties.Resources.logo;
            this.panel1.Location = new System.Drawing.Point(764, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 93);
            this.panel1.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tc_form1);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Турфирма \"Ривьера-Сочи\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_resort.ResumeLayout(false);
            this.p_resort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_countdayS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_count)).EndInit();
            this.p_main.ResumeLayout(false);
            this.p_main.PerformLayout();
            this.p_resort2.ResumeLayout(false);
            this.p_3.ResumeLayout(false);
            this.p_3.PerformLayout();
            this.tc_form1.ResumeLayout(false);
            this.tp_tour.ResumeLayout(false);
            this.tp_Sale.ResumeLayout(false);
            this.p_sale.ResumeLayout(false);
            this.p_sale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_resort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_resort;
        private System.Windows.Forms.ComboBox cb_DataStart;
        private System.Windows.Forms.ComboBox cb_DataEnd;
        private System.Windows.Forms.NumericUpDown nud_count;
        private System.Windows.Forms.Label l_amde;
        private System.Windows.Forms.Label l_amds;
        private System.Windows.Forms.NumericUpDown nud_countdayE;
        private System.Windows.Forms.NumericUpDown nud_countdayS;
        private System.Windows.Forms.Label l_pre;
        private System.Windows.Forms.TextBox tb_priceMax;
        private System.Windows.Forms.Label l_pr;
        private System.Windows.Forms.TextBox tb_priceMin;
        private System.Windows.Forms.Button b_Find;
        private System.Windows.Forms.ListBox lb_tourlist;
        private System.Windows.Forms.Button b_Ok;
        private System.Windows.Forms.Label l_authoriz;
        private System.Windows.Forms.Label l_admin;
        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.Label l_Client;
        private System.Windows.Forms.Label l_amount;
        private System.Windows.Forms.Label l_de;
        private System.Windows.Forms.Label l_ds;
        private System.Windows.Forms.Label l_resort;
        private System.Windows.Forms.Panel p_resort2;
        private System.Windows.Forms.Panel p_3;
        private System.Windows.Forms.Label l_datenow;
        private System.Windows.Forms.TabControl tc_form1;
        private System.Windows.Forms.TabPage tp_tour;
        private System.Windows.Forms.TabPage tp_Sale;
        private System.Windows.Forms.Panel p_sale;
        private System.Windows.Forms.ListBox lb_sale;
        private System.Windows.Forms.Label l_amount2;
        private System.Windows.Forms.NumericUpDown nud_amount2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label l_cabinet;
        private System.Windows.Forms.Panel panel1;
    }
}

