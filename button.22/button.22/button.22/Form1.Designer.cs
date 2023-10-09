namespace button._22
{
    partial class Form1
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
            this.rbYok = new System.Windows.Forms.RadioButton();
            this.rbindrim5 = new System.Windows.Forms.RadioButton();
            this.rbindirim40 = new System.Windows.Forms.RadioButton();
            this.rbindirim30 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbYok
            // 
            this.rbYok.AutoSize = true;
            this.rbYok.Location = new System.Drawing.Point(6, 43);
            this.rbYok.Name = "rbYok";
            this.rbYok.Size = new System.Drawing.Size(74, 17);
            this.rbYok.TabIndex = 0;
            this.rbYok.TabStop = true;
            this.rbYok.Text = "indirim yok\r\n";
            this.rbYok.UseVisualStyleBackColor = true;
            // 
            // rbindrim5
            // 
            this.rbindrim5.AutoSize = true;
            this.rbindrim5.Location = new System.Drawing.Point(6, 83);
            this.rbindrim5.Name = "rbindrim5";
            this.rbindrim5.Size = new System.Drawing.Size(71, 17);
            this.rbindrim5.TabIndex = 1;
            this.rbindrim5.TabStop = true;
            this.rbindrim5.Text = "%5 indirim";
            this.rbindrim5.UseVisualStyleBackColor = true;
            // 
            // rbindirim40
            // 
            this.rbindirim40.AutoSize = true;
            this.rbindirim40.Location = new System.Drawing.Point(6, 167);
            this.rbindirim40.Name = "rbindirim40";
            this.rbindirim40.Size = new System.Drawing.Size(77, 17);
            this.rbindirim40.TabIndex = 2;
            this.rbindirim40.TabStop = true;
            this.rbindirim40.Text = "%40 indirim";
            this.rbindirim40.UseVisualStyleBackColor = true;
            // 
            // rbindirim30
            // 
            this.rbindirim30.AutoSize = true;
            this.rbindirim30.Location = new System.Drawing.Point(6, 125);
            this.rbindirim30.Name = "rbindirim30";
            this.rbindirim30.Size = new System.Drawing.Size(77, 17);
            this.rbindirim30.TabIndex = 3;
            this.rbindirim30.TabStop = true;
            this.rbindirim30.Text = "%30 indirim";
            this.rbindirim30.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbindrim5);
            this.groupBox1.Controls.Add(this.rbYok);
            this.groupBox1.Controls.Add(this.rbindirim30);
            this.groupBox1.Controls.Add(this.rbindirim40);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiyat Seçin";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(193, 187);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(57, 13);
            this.lblOdenecek.TabIndex = 7;
            this.lblOdenecek.Text = "Ödenecek";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(277, 51);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblOdenecek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbYok;
        private System.Windows.Forms.RadioButton rbindrim5;
        private System.Windows.Forms.RadioButton rbindirim40;
        private System.Windows.Forms.RadioButton rbindirim30;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button button1;
    }
}

