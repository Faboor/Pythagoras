namespace Pytagoras
{
    partial class Nacrt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nacrt));
            this.background = new System.Windows.Forms.Panel();
            this.tlacidloOK = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.V3 = new System.Windows.Forms.Label();
            this.s3 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.Label();
            this.V2 = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.Control;
            this.background.Controls.Add(this.tlacidloOK);
            this.background.Controls.Add(this.canvas);
            resources.ApplyResources(this.background, "background");
            this.background.Name = "background";
            // 
            // tlacidloOK
            // 
            resources.ApplyResources(this.tlacidloOK, "tlacidloOK");
            this.tlacidloOK.Name = "tlacidloOK";
            this.tlacidloOK.UseVisualStyleBackColor = true;
            this.tlacidloOK.Click += new System.EventHandler(this.tlacidloOK_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Controls.Add(this.V3);
            this.canvas.Controls.Add(this.s3);
            this.canvas.Controls.Add(this.s2);
            this.canvas.Controls.Add(this.V1);
            this.canvas.Controls.Add(this.s1);
            this.canvas.Controls.Add(this.V2);
            this.canvas.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.canvas, "canvas");
            this.canvas.Name = "canvas";
            // 
            // V3
            // 
            resources.ApplyResources(this.V3, "V3");
            this.V3.Name = "V3";
            // 
            // s3
            // 
            resources.ApplyResources(this.s3, "s3");
            this.s3.BackColor = System.Drawing.Color.Transparent;
            this.s3.Name = "s3";
            // 
            // s2
            // 
            resources.ApplyResources(this.s2, "s2");
            this.s2.BackColor = System.Drawing.Color.Transparent;
            this.s2.Name = "s2";
            // 
            // V1
            // 
            resources.ApplyResources(this.V1, "V1");
            this.V1.Name = "V1";
            // 
            // s1
            // 
            resources.ApplyResources(this.s1, "s1");
            this.s1.BackColor = System.Drawing.Color.Transparent;
            this.s1.Name = "s1";
            // 
            // V2
            // 
            resources.ApplyResources(this.V2, "V2");
            this.V2.Name = "V2";
            // 
            // Nacrt
            // 
            this.AcceptButton = this.tlacidloOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.background);
            this.Name = "Nacrt";
            this.ResizeEnd += new System.EventHandler(this.Nacrt_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Nacrt_Paint);
            this.Resize += new System.EventHandler(this.Nacrt_Resize);
            this.background.ResumeLayout(false);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        public System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label s3;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.Label V3;
        private System.Windows.Forms.Label V2;
        private System.Windows.Forms.Label V1;
        private System.Windows.Forms.Button tlacidloOK;
    }
}