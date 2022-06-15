namespace librarysoft
{
    partial class Frmodunc
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
            this.txtoduncid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuyeid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkitapid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAldigi = new System.Windows.Forms.DateTimePicker();
            this.dtverdigi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uyesec = new System.Windows.Forms.Button();
            this.kitapsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoduncid
            // 
            this.txtoduncid.Location = new System.Drawing.Point(154, 40);
            this.txtoduncid.Name = "txtoduncid";
            this.txtoduncid.ReadOnly = true;
            this.txtoduncid.Size = new System.Drawing.Size(250, 22);
            this.txtoduncid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "odunc id";
            // 
            // txtuyeid
            // 
            this.txtuyeid.Location = new System.Drawing.Point(154, 68);
            this.txtuyeid.Name = "txtuyeid";
            this.txtuyeid.ReadOnly = true;
            this.txtuyeid.Size = new System.Drawing.Size(250, 22);
            this.txtuyeid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uye id";
            // 
            // txtkitapid
            // 
            this.txtkitapid.Location = new System.Drawing.Point(154, 96);
            this.txtkitapid.Name = "txtkitapid";
            this.txtkitapid.ReadOnly = true;
            this.txtkitapid.Size = new System.Drawing.Size(250, 22);
            this.txtkitapid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aldığı tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Teslim tarih";
            // 
            // dtAldigi
            // 
            this.dtAldigi.Location = new System.Drawing.Point(154, 129);
            this.dtAldigi.Name = "dtAldigi";
            this.dtAldigi.Size = new System.Drawing.Size(250, 22);
            this.dtAldigi.TabIndex = 2;
            // 
            // dtverdigi
            // 
            this.dtverdigi.CustomFormat = "";
            this.dtverdigi.Location = new System.Drawing.Point(154, 157);
            this.dtverdigi.Name = "dtverdigi";
            this.dtverdigi.Size = new System.Drawing.Size(250, 22);
            this.dtverdigi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(286, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uyesec
            // 
            this.uyesec.Location = new System.Drawing.Point(428, 63);
            this.uyesec.Name = "uyesec";
            this.uyesec.Size = new System.Drawing.Size(106, 27);
            this.uyesec.TabIndex = 5;
            this.uyesec.Text = "Uye seç";
            this.uyesec.UseVisualStyleBackColor = true;
            this.uyesec.Click += new System.EventHandler(this.uyesec_Click);
            // 
            // kitapsec
            // 
            this.kitapsec.Location = new System.Drawing.Point(428, 96);
            this.kitapsec.Name = "kitapsec";
            this.kitapsec.Size = new System.Drawing.Size(106, 27);
            this.kitapsec.TabIndex = 6;
            this.kitapsec.Text = "kitap seç";
            this.kitapsec.UseVisualStyleBackColor = true;
            this.kitapsec.Click += new System.EventHandler(this.kitapsec_Click);
            // 
            // Frmodunc
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(561, 271);
            this.Controls.Add(this.kitapsec);
            this.Controls.Add(this.uyesec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtverdigi);
            this.Controls.Add(this.dtAldigi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkitapid);
            this.Controls.Add(this.txtuyeid);
            this.Controls.Add(this.txtoduncid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmodunc";
            this.Text = "frmodunc";
            this.Load += new System.EventHandler(this.Frmodunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoduncid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuyeid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkitapid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtAldigi;
        private System.Windows.Forms.DateTimePicker dtverdigi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button uyesec;
        private System.Windows.Forms.Button kitapsec;
    }
}