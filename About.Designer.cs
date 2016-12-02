namespace Pytagoras
{
    partial class About
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
            System.Windows.Forms.LinkLabel linkFb;
            System.Windows.Forms.LinkLabel linkEmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picturePytagorasLogo = new System.Windows.Forms.PictureBox();
            this.Nazov = new System.Windows.Forms.Label();
            this.Verzia = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.labelFb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxPopis = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxKontakty = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureEmail = new System.Windows.Forms.PictureBox();
            this.pictureFb = new System.Windows.Forms.PictureBox();
            linkFb = new System.Windows.Forms.LinkLabel();
            linkEmail = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePytagorasLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxPopis.SuspendLayout();
            this.boxKontakty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFb)).BeginInit();
            this.SuspendLayout();
            // 
            // linkFb
            // 
            linkFb.ActiveLinkColor = System.Drawing.Color.Blue;
            linkFb.AutoSize = true;
            linkFb.DisabledLinkColor = System.Drawing.Color.Blue;
            linkFb.Location = new System.Drawing.Point(244, 37);
            linkFb.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            linkFb.Name = "linkFb";
            linkFb.Size = new System.Drawing.Size(111, 26);
            linkFb.TabIndex = 9;
            linkFb.TabStop = true;
            linkFb.Text = "http://facebook.com/\r\nFaboorsStudio";
            linkFb.VisitedLinkColor = System.Drawing.Color.Blue;
            linkFb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFacebook_LinkClicked);
            // 
            // linkEmail
            // 
            linkEmail.ActiveLinkColor = System.Drawing.Color.Blue;
            linkEmail.AutoSize = true;
            linkEmail.DisabledLinkColor = System.Drawing.Color.Blue;
            linkEmail.Location = new System.Drawing.Point(49, 42);
            linkEmail.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            linkEmail.Name = "linkEmail";
            linkEmail.Size = new System.Drawing.Size(133, 13);
            linkEmail.TabIndex = 12;
            linkEmail.TabStop = true;
            linkEmail.Text = "peter.kovary@hotmail.com";
            linkEmail.VisitedLinkColor = System.Drawing.Color.Blue;
            linkEmail.Click += new System.EventHandler(this.SendMail_Clicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picturePytagorasLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 108);
            this.panel1.TabIndex = 1;
            // 
            // picturePytagorasLogo
            // 
            this.picturePytagorasLogo.Image = global::Pytagoras.Properties.Resources.Pytagoras_logo;
            this.picturePytagorasLogo.Location = new System.Drawing.Point(11, 11);
            this.picturePytagorasLogo.Name = "picturePytagorasLogo";
            this.picturePytagorasLogo.Size = new System.Drawing.Size(388, 84);
            this.picturePytagorasLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePytagorasLogo.TabIndex = 0;
            this.picturePytagorasLogo.TabStop = false;
            // 
            // Nazov
            // 
            this.Nazov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazov.Location = new System.Drawing.Point(11, 14);
            this.Nazov.Name = "Nazov";
            this.Nazov.Size = new System.Drawing.Size(388, 34);
            this.Nazov.TabIndex = 2;
            this.Nazov.Text = "Pytagoras";
            this.Nazov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Verzia
            // 
            this.Verzia.Location = new System.Drawing.Point(11, 48);
            this.Verzia.Name = "Verzia";
            this.Verzia.Size = new System.Drawing.Size(388, 27);
            this.Verzia.TabIndex = 3;
            this.Verzia.Text = "Verzia";
            this.Verzia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(11, 75);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(388, 26);
            this.Autor.TabIndex = 4;
            this.Autor.Text = "© 2012 by Peter Kőváry ";
            this.Autor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFb
            // 
            this.labelFb.Location = new System.Drawing.Point(244, 13);
            this.labelFb.Name = "labelFb";
            this.labelFb.Size = new System.Drawing.Size(108, 24);
            this.labelFb.TabIndex = 6;
            this.labelFb.Text = "Facebook stránka:";
            this.labelFb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFb.MouseEnter += new System.EventHandler(this.LinkMouseEnter);
            this.labelFb.MouseLeave += new System.EventHandler(this.LinkMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.groupBoxPopis);
            this.panel2.Controls.Add(this.boxKontakty);
            this.panel2.Controls.Add(this.Nazov);
            this.panel2.Controls.Add(this.Autor);
            this.panel2.Controls.Add(this.Verzia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 286);
            this.panel2.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(-1, 249);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(412, 18);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Zobraz licenciu";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBoxPopis
            // 
            this.groupBoxPopis.Controls.Add(this.textBox1);
            this.groupBoxPopis.Location = new System.Drawing.Point(24, 181);
            this.groupBoxPopis.Name = "groupBoxPopis";
            this.groupBoxPopis.Size = new System.Drawing.Size(364, 65);
            this.groupBoxPopis.TabIndex = 8;
            this.groupBoxPopis.TabStop = false;
            this.groupBoxPopis.Text = "Popis programu";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(340, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Pytagoras je náučný program, ktorý slúži na precvičovanie a overovanie správnosti" +
                " výsledku príkladov zameraných na precvičovanie, taktiež aj rozvýjanie znalostí " +
                "študendov o Pytagorovej vete.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxKontakty
            // 
            this.boxKontakty.Controls.Add(linkEmail);
            this.boxKontakty.Controls.Add(this.labelEmail);
            this.boxKontakty.Controls.Add(this.pictureEmail);
            this.boxKontakty.Controls.Add(linkFb);
            this.boxKontakty.Controls.Add(this.pictureFb);
            this.boxKontakty.Controls.Add(this.labelFb);
            this.boxKontakty.Location = new System.Drawing.Point(24, 104);
            this.boxKontakty.Name = "boxKontakty";
            this.boxKontakty.Size = new System.Drawing.Size(364, 71);
            this.boxKontakty.TabIndex = 7;
            this.boxKontakty.TabStop = false;
            this.boxKontakty.Text = "Kontakty";
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(49, 18);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(108, 24);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmail.Click += new System.EventHandler(this.SendMail_Clicked);
            this.labelEmail.MouseEnter += new System.EventHandler(this.LinkMouseEnter);
            this.labelEmail.MouseLeave += new System.EventHandler(this.LinkMouseLeave);
            // 
            // pictureEmail
            // 
            this.pictureEmail.ErrorImage = null;
            this.pictureEmail.Image = ((System.Drawing.Image)(resources.GetObject("pictureEmail.Image")));
            this.pictureEmail.Location = new System.Drawing.Point(12, 26);
            this.pictureEmail.Name = "pictureEmail";
            this.pictureEmail.Size = new System.Drawing.Size(30, 30);
            this.pictureEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEmail.TabIndex = 10;
            this.pictureEmail.TabStop = false;
            this.pictureEmail.Click += new System.EventHandler(this.SendMail_Clicked);
            this.pictureEmail.MouseEnter += new System.EventHandler(this.LinkMouseEnter);
            this.pictureEmail.MouseLeave += new System.EventHandler(this.LinkMouseLeave);
            // 
            // pictureFb
            // 
            this.pictureFb.ErrorImage = null;
            this.pictureFb.Image = global::Pytagoras.Properties.Resources.fb;
            this.pictureFb.Location = new System.Drawing.Point(201, 21);
            this.pictureFb.Name = "pictureFb";
            this.pictureFb.Size = new System.Drawing.Size(36, 36);
            this.pictureFb.TabIndex = 8;
            this.pictureFb.TabStop = false;
            this.pictureFb.Click += new System.EventHandler(this.linkFacebook_LinkClicked);
            this.pictureFb.MouseEnter += new System.EventHandler(this.LinkMouseEnter);
            this.pictureFb.MouseLeave += new System.EventHandler(this.LinkMouseLeave);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(428, 432);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 432);
            this.Name = "About";
            this.Text = "Pytagoras - O programe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePytagorasLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxPopis.ResumeLayout(false);
            this.groupBoxPopis.PerformLayout();
            this.boxKontakty.ResumeLayout(false);
            this.boxKontakty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturePytagorasLogo;
        private System.Windows.Forms.Label Nazov;
        private System.Windows.Forms.Label Verzia;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Label labelFb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox boxKontakty;
        private System.Windows.Forms.PictureBox pictureFb;
        private System.Windows.Forms.PictureBox pictureEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxPopis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}