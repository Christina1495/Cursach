namespace Cursach
{
    partial class FormDescription
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
            this.l_name = new System.Windows.Forms.Label();
            this.l_discription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_name.Location = new System.Drawing.Point(12, 9);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(51, 20);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "label1";
            this.l_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_discription
            // 
            this.l_discription.AutoSize = true;
            this.l_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_discription.Location = new System.Drawing.Point(13, 42);
            this.l_discription.Name = "l_discription";
            this.l_discription.Size = new System.Drawing.Size(46, 18);
            this.l_discription.TabIndex = 1;
            this.l_discription.Text = "label2";
            // 
            // FormDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(673, 101);
            this.Controls.Add(this.l_discription);
            this.Controls.Add(this.l_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDescription";
            this.Text = "Описание Экскурсий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_discription;
    }
}