using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pytagoras
{
    public partial class Nacrt : Form
    {
        public const int DifX = 15; public const int DifY = 35;
        public const int buttonDisX = 72; public const int buttonDisY = 49;
        public const int panelDis = 30; public const int canvasDis = 40;
        public float left, down; int rot; public double angle;
        public Point A, B, C;
        public Pen pen = new Pen(Color.Black, 2);
        Texts t = new Texts();

        public Nacrt(int r)
        {
            InitializeComponent();
            Size = Properties.Settings.Default.settingNacrtSize;
            rot = r;
        }
        private void Nacrt_ResizeEnd(object sender, EventArgs e)
        {
            Properties.Settings.Default.settingNacrtSize = Size;
            Properties.Settings.Default.Save();
        }
        private void Nacrt_Resize(object sender, EventArgs e)
        { 
            background.Size = new Size(this.Width - DifX,
                                       this.Height - DifY );
            canvas.Size = new Size(background.Width - panelDis * 2,
                                   background.Height - panelDis * 2 );
            tlacidloOK.Location = new Point(background.Width - buttonDisX,
                                            background.Height - buttonDisY);

            Invalidate();
        }
        private void Nacrt_Paint(object sender, PaintEventArgs e)
        {
            switch (rot)
            {
                case 0 :
                    left = Main.b; down = Main.c; angle = Main.α;
                    break;
                case 1 :
                    left = Main.a; down = Main.b; angle = Main.γ;
                    break;
                case 2 :
                    left = Main.c; down = Main.a; angle = Main.β;
                    break;
            }
            Graphics g = canvas.CreateGraphics();
            g.Clear(Color.White);
            trojuholnik(g);
        }
        private void trojuholnik(Graphics g)
        {
            float k; double v = Math.Sin(Main.DegreesToRadians(angle)) * left;
            int W = canvas.Width - 2 * canvasDis;
            int H = canvas.Height - 2 * canvasDis;
            
            if ((W / down) <= (H / v))
                k = Convert.ToSingle(W / down);
            else
                k = Convert.ToSingle(H / v);

            A = new Point(
                W / 2 - Convert.ToInt16((down / 2) * k) + canvasDis,
                H / 2 + Convert.ToInt32((v / 2) * k) + canvasDis);
            B = new Point(
                W / 2 + Convert.ToInt16((down / 2) * k) + canvasDis,
                A.Y);
            C = new Point(
                A.X + Convert.ToInt32((Math.Cos(Main.DegreesToRadians(angle)) * left) * k),
                H / 2 - Convert.ToInt32((v / 2) * k) + canvasDis);
            
            popis();
            g.DrawLine(pen, A, B); g.DrawLine(pen, A, C); g.DrawLine(pen, B, C);
        }
        private void popis()
        {
            switch (rot)
            {
                case 0:
                    V1.Text = t.p[0]; V2.Text = t.p[1]; V3.Text = t.p[2];
                    s1.Text = t.p[3]; s2.Text = t.p[4]; s3.Text = t.p[5];
                    break;
                case 1:
                    V1.Text = t.p[2]; V2.Text = t.p[0]; V3.Text = t.p[1];
                    s1.Text = t.p[5]; s2.Text = t.p[3]; s3.Text = t.p[4];
                    break;
                case 2:
                    V1.Text = t.p[1]; V2.Text = t.p[2]; V3.Text = t.p[0];
                    s1.Text = t.p[4]; s2.Text = t.p[5]; s3.Text = t.p[3];
                    break;
            }
            V1.Location = new Point(A.X - V1.Width, A.Y + 8);
            V2.Location = new Point(B.X + 8, B.Y + 8);
            V3.Location = new Point(C.X - (V3.Width / 2), C.Y - canvasDis + V3.Height);

            s1.Location = new Point(((A.X + B.X) / 2) - s1.Width / 2, A.Y + 4);
            s2.Location = new Point(((B.X + C.X) / 2) + s2.Width, ((B.Y + C.Y) / 2) - s2.Height);
            s3.Location = new Point(((A.X + C.X) / 2) - s3.Width - 4, ((A.Y + C.Y) / 2) - s3.Height);
        }
        private void tlacidloOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}