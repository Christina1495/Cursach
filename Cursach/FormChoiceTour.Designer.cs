namespace Cursach
{
    partial class FormChoiceTour
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoiceTour));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.b_exdel = new System.Windows.Forms.Button();
            this.b_doc = new System.Windows.Forms.Button();
            this.lb_hotel = new System.Windows.Forms.ListBox();
            this.cms_ex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьОтельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_ex = new System.Windows.Forms.Button();
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ex = new System.Windows.Forms.ListBox();
            this.cms_hotel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОбЭкскурсииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭкскурсиюВТурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_marks = new System.Windows.Forms.NumericUpDown();
            this.b_marks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.cms_ex.SuspendLayout();
            this.cms_hotel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.b_exdel);
            this.panel1.Controls.Add(this.b_doc);
            this.panel1.Controls.Add(this.lb_hotel);
            this.panel1.Controls.Add(this.tb_info);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.b_ex);
            this.panel1.Controls.Add(this.cb_day);
            this.panel1.Controls.Add(this.cb_month);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 226);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата вылета:";
            // 
            // b_exdel
            // 
            this.b_exdel.Location = new System.Drawing.Point(90, 190);
            this.b_exdel.Name = "b_exdel";
            this.b_exdel.Size = new System.Drawing.Size(129, 23);
            this.b_exdel.TabIndex = 12;
            this.b_exdel.Text = "Удалить экскурсии";
            this.b_exdel.UseVisualStyleBackColor = true;
            this.b_exdel.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_doc
            // 
            this.b_doc.Location = new System.Drawing.Point(295, 190);
            this.b_doc.Name = "b_doc";
            this.b_doc.Size = new System.Drawing.Size(75, 23);
            this.b_doc.TabIndex = 7;
            this.b_doc.Text = "Документы";
            this.b_doc.UseVisualStyleBackColor = true;
            this.b_doc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_hotel
            // 
            this.lb_hotel.ContextMenuStrip = this.cms_ex;
            this.lb_hotel.FormattingEnabled = true;
            this.lb_hotel.Location = new System.Drawing.Point(456, 81);
            this.lb_hotel.Name = "lb_hotel";
            this.lb_hotel.Size = new System.Drawing.Size(221, 134);
            this.lb_hotel.TabIndex = 9;
            // 
            // cms_ex
            // 
            this.cms_ex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьОтельToolStripMenuItem});
            this.cms_ex.Name = "contextMenuStrip2";
            this.cms_ex.Size = new System.Drawing.Size(156, 26);
            this.cms_ex.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // выбратьОтельToolStripMenuItem
            // 
            this.выбратьОтельToolStripMenuItem.Name = "выбратьОтельToolStripMenuItem";
            this.выбратьОтельToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.выбратьОтельToolStripMenuItem.Text = "Выбрать отель";
            this.выбратьОтельToolStripMenuItem.Click += new System.EventHandler(this.выбратьОтельToolStripMenuItem_Click);
            // 
            // tb_info
            // 
            this.tb_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_info.Location = new System.Drawing.Point(9, 81);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_info.Size = new System.Drawing.Size(422, 103);
            this.tb_info.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(482, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество человек";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(261, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Продолжительность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Курорт";
            // 
            // b_ex
            // 
            this.b_ex.Location = new System.Drawing.Point(9, 190);
            this.b_ex.Name = "b_ex";
            this.b_ex.Size = new System.Drawing.Size(75, 23);
            this.b_ex.TabIndex = 10;
            this.b_ex.Text = "Экскурсии";
            this.b_ex.UseVisualStyleBackColor = true;
            this.b_ex.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_day
            // 
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Location = new System.Drawing.Point(508, 3);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(42, 21);
            this.cb_day.TabIndex = 3;
            // 
            // cb_month
            // 
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(556, 3);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(121, 21);
            this.cb_month.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // lb_ex
            // 
            this.lb_ex.ContextMenuStrip = this.cms_hotel;
            this.lb_ex.FormattingEnabled = true;
            this.lb_ex.Location = new System.Drawing.Point(12, 244);
            this.lb_ex.Name = "lb_ex";
            this.lb_ex.Size = new System.Drawing.Size(715, 134);
            this.lb_ex.TabIndex = 9;
            // 
            // cms_hotel
            // 
            this.cms_hotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОбЭкскурсииToolStripMenuItem,
            this.добавитьЭкскурсиюВТурToolStripMenuItem});
            this.cms_hotel.Name = "contextMenuStrip1";
            this.cms_hotel.Size = new System.Drawing.Size(226, 70);
            this.cms_hotel.Opening += new System.ComponentModel.CancelEventHandler(this.cms_hotel_Opening);
            // 
            // информацияОбЭкскурсииToolStripMenuItem
            // 
            this.информацияОбЭкскурсииToolStripMenuItem.Name = "информацияОбЭкскурсииToolStripMenuItem";
            this.информацияОбЭкскурсииToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.информацияОбЭкскурсииToolStripMenuItem.Text = "Информация об экскурсии";
            this.информацияОбЭкскурсииToolStripMenuItem.Click += new System.EventHandler(this.информацияОбЭкскурсииToolStripMenuItem_Click);
            // 
            // добавитьЭкскурсиюВТурToolStripMenuItem
            // 
            this.добавитьЭкскурсиюВТурToolStripMenuItem.Name = "добавитьЭкскурсиюВТурToolStripMenuItem";
            this.добавитьЭкскурсиюВТурToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.добавитьЭкскурсиюВТурToolStripMenuItem.Text = "Добавить экскурсию в тур";
            this.добавитьЭкскурсиюВТурToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭкскурсиюВТурToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nud_marks);
            this.panel2.Controls.Add(this.b_marks);
            this.panel2.Location = new System.Drawing.Point(12, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 27);
            this.panel2.TabIndex = 17;
            // 
            // nud_marks
            // 
            this.nud_marks.Location = new System.Drawing.Point(76, 4);
            this.nud_marks.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_marks.Name = "nud_marks";
            this.nud_marks.Size = new System.Drawing.Size(38, 20);
            this.nud_marks.TabIndex = 18;
            this.nud_marks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // b_marks
            // 
            this.b_marks.Location = new System.Drawing.Point(3, 3);
            this.b_marks.Name = "b_marks";
            this.b_marks.Size = new System.Drawing.Size(67, 21);
            this.b_marks.TabIndex = 18;
            this.b_marks.Text = "Оценить ";
            this.b_marks.UseVisualStyleBackColor = true;
            this.b_marks.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Для выбора отеля и просмотра экскурсий нажмите на названии правой кнопкой мыши.";
            // 
            // FormChoiceTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(739, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_ex);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChoiceTour";
            this.Text = "Выбор тура";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChoiceTour_FormClosing);
            this.Load += new System.EventHandler(this.FormChoiceTour_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cms_ex.ResumeLayout(false);
            this.cms_hotel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_day;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.ListBox lb_ex;
        private System.Windows.Forms.Button b_ex;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_marks;
        private System.Windows.Forms.NumericUpDown nud_marks;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.ContextMenuStrip cms_hotel;
        private System.Windows.Forms.ToolStripMenuItem информацияОбЭкскурсииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭкскурсиюВТурToolStripMenuItem;
        private System.Windows.Forms.ListBox lb_hotel;
        private System.Windows.Forms.ContextMenuStrip cms_ex;
        private System.Windows.Forms.ToolStripMenuItem выбратьОтельToolStripMenuItem;
        private System.Windows.Forms.Button b_exdel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}