namespace Pytagoras
{
    partial class MailDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailDialog));
            this.labelNadpis = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.labelSprava = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPredmet = new System.Windows.Forms.TextBox();
            this.textBoxSprava = new System.Windows.Forms.TextBox();
            this.tlacidloPoslat = new System.Windows.Forms.Button();
            this.labelVypis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNadpis
            // 
            this.labelNadpis.AutoSize = true;
            this.labelNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNadpis.Location = new System.Drawing.Point(12, 9);
            this.labelNadpis.Name = "labelNadpis";
            this.labelNadpis.Size = new System.Drawing.Size(107, 20);
            this.labelNadpis.TabIndex = 0;
            this.labelNadpis.Text = "Poslať email";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(32, 44);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(76, 26);
            this.labelAdresa.TabIndex = 1;
            this.labelAdresa.Text = "Vaša emailová\r\nadresa";
            this.labelAdresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.Location = new System.Drawing.Point(65, 80);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(46, 13);
            this.labelPredmet.TabIndex = 2;
            this.labelPredmet.Text = "Predmet";
            this.labelPredmet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSprava
            // 
            this.labelSprava.AutoSize = true;
            this.labelSprava.Location = new System.Drawing.Point(70, 108);
            this.labelSprava.Name = "labelSprava";
            this.labelSprava.Size = new System.Drawing.Size(41, 13);
            this.labelSprava.TabIndex = 3;
            this.labelSprava.Text = "Správa";
            this.labelSprava.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(127, 48);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(292, 20);
            this.textBoxAdresa.TabIndex = 4;
            this.textBoxAdresa.TextChanged += new System.EventHandler(this.zmazlabelVypis);
            // 
            // textBoxPredmet
            // 
            this.textBoxPredmet.Location = new System.Drawing.Point(127, 77);
            this.textBoxPredmet.Name = "textBoxPredmet";
            this.textBoxPredmet.Size = new System.Drawing.Size(292, 20);
            this.textBoxPredmet.TabIndex = 5;
            this.textBoxPredmet.TextChanged += new System.EventHandler(this.zmazlabelVypis);
            // 
            // textBoxSprava
            // 
            this.textBoxSprava.Location = new System.Drawing.Point(127, 105);
            this.textBoxSprava.Multiline = true;
            this.textBoxSprava.Name = "textBoxSprava";
            this.textBoxSprava.Size = new System.Drawing.Size(292, 61);
            this.textBoxSprava.TabIndex = 6;
            this.textBoxSprava.TextChanged += new System.EventHandler(this.zmazlabelVypis);
            // 
            // tlacidloPoslat
            // 
            this.tlacidloPoslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tlacidloPoslat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlacidloPoslat.Location = new System.Drawing.Point(301, 172);
            this.tlacidloPoslat.Name = "tlacidloPoslat";
            this.tlacidloPoslat.Size = new System.Drawing.Size(118, 38);
            this.tlacidloPoslat.TabIndex = 13;
            this.tlacidloPoslat.Text = "Poslať";
            this.tlacidloPoslat.UseVisualStyleBackColor = true;
            this.tlacidloPoslat.Click += new System.EventHandler(this.tlacidloPoslat_Click);
            // 
            // labelVypis
            // 
            this.labelVypis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVypis.Location = new System.Drawing.Point(16, 179);
            this.labelVypis.Name = "labelVypis";
            this.labelVypis.Size = new System.Drawing.Size(279, 26);
            this.labelVypis.TabIndex = 14;
            this.labelVypis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 220);
            this.Controls.Add(this.labelVypis);
            this.Controls.Add(this.tlacidloPoslat);
            this.Controls.Add(this.textBoxSprava);
            this.Controls.Add(this.textBoxPredmet);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.labelSprava);
            this.Controls.Add(this.labelPredmet);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelNadpis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 258);
            this.Name = "MailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poslať email - Pytagoras";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MailDialog_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNadpis;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelPredmet;
        private System.Windows.Forms.Label labelSprava;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxPredmet;
        private System.Windows.Forms.TextBox textBoxSprava;
        private System.Windows.Forms.Button tlacidloPoslat;
        private System.Windows.Forms.Label labelVypis;
    }
}