using System;
using System.Windows.Forms;

namespace Pytagoras
{
    public partial class Main : Form
    {
        Texts T = new Texts();
        Pomoc frame1 = new Pomoc();
        public static float a, b, c;
        public static double α, β, γ;
        public Main()
        {
            InitializeComponent();
            uhlyanoMenuItem.Checked = Properties.Settings.Default.settingUhly;
            uhlynieMenuItem.Checked = Properties.Settings.Default.settingUhly ? false : true;
            obvodobsahanoMenuItem.Checked = Properties.Settings.Default.settingObvodObsah;
            obvodobsahnieMenuItem.Checked = Properties.Settings.Default.settingObvodObsah ? false : true;
        }
        
      #region Metódy
        public static double RadiansToDegrees(double uhol)
        {
            return uhol * (180.0 / Math.PI);
        }
        public static double DegreesToRadians(double uhol)
        {
            return Math.PI * uhol / 180.0;
        }
        public static string AngleCoordToDegMinString(double coord)
        {
            int sec = (int)Math.Round(coord * 3600);
            int deg = sec / 3600;
            sec = Math.Abs(sec % 3600);
            int min = sec / 60;
            sec %= 60;
            if (sec >= 30)
                min++;
            return (deg.ToString() + "° " + min.ToString() + "'");
        }
        private float StringToFloat(string input, int l)
        {
            float x = 0;
            if (input == "")
                return x = 0;
            else
            {
                try
                {
                    x = Convert.ToSingle(input);
                    if (x < 0)
                    { x = -2; vypisCh(l, T.chyba); }
                    return x;
                }
                catch
                { vypisCh(l, T.chyba); return -1;}
            }
        }
        private void Checker(int s)
        {
            switch (s)
            {
                case 1 :
                    uhlyanoMenuItem.Checked = true;
                    uhlynieMenuItem.Checked = false;
                    Properties.Settings.Default.settingUhly = true;
                    break;
                case 2 :
                    uhlyanoMenuItem.Checked = false;
                    uhlynieMenuItem.Checked = true;
                    Properties.Settings.Default.settingUhly = false;
                    break;
                case 3 :
                    obvodobsahanoMenuItem.Checked = true;
                    obvodobsahnieMenuItem.Checked = false;
                    Properties.Settings.Default.settingObvodObsah = true;
                    break;
                case 4:
                    obvodobsahanoMenuItem.Checked = false;
                    obvodobsahnieMenuItem.Checked = true;
                    Properties.Settings.Default.settingObvodObsah = false;
                    break;
            }
            Properties.Settings.Default.Save();
        }
        private bool nerovnost(float a, float b, float c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            { vypisCh(5, T.nerovnost); return false; }
            else
            { vypisCh(5, ""); return true; }
        }
        private double uhol(float x, float y, float Z)
        {
            double α = ((x * x) + (y * y) - (Z * Z)) / (2 * x * y);
            α = RadiansToDegrees(Math.Acos(α));
            return α;
        }
        private int prepona(float x, float y, float z)
        {
            return 0;
        }
        private void vypis(float a, float b, float c, int N)
        {   
            panel1.Visible = false;
            panel2.Visible = true;
            potvrditMenuItem.Visible = false;
            zobrazMenuItem.Visible = true;
            noveMenuItem.Visible = true;

            outA.Text = "a = " + Math.Round(a, 3).ToString() + " cm";
            outB.Text = "b = " + Math.Round(b, 3).ToString() + " cm";
            outC.Text = "c = " + Math.Round(c, 3).ToString() + " cm";

            switch (N)
            {
                case 0:
                    outA.ForeColor = System.Drawing.SystemColors.ControlText;
                    outB.ForeColor = System.Drawing.SystemColors.ControlText;
                    outC.ForeColor = System.Drawing.SystemColors.ControlText;
                    break;
                case 1:
                    outA.ForeColor = System.Drawing.Color.Red;
                    outB.ForeColor = System.Drawing.SystemColors.ControlText;
                    outC.ForeColor = System.Drawing.SystemColors.ControlText;
                    break;
                case 2:
                    outA.ForeColor = System.Drawing.SystemColors.ControlText;
                    outB.ForeColor = System.Drawing.Color.Red;
                    outC.ForeColor = System.Drawing.SystemColors.ControlText;
                    break;
                case 3:
                    outA.ForeColor = System.Drawing.SystemColors.ControlText;
                    outB.ForeColor = System.Drawing.SystemColors.ControlText;
                    outC.ForeColor = System.Drawing.Color.Red;
                    break;
            }

            α = uhol(b, c, a);
            β = uhol(a, c, b);
            γ = 180 - α - β;
            if (uhlyanoMenuItem.Checked == true)
            {
                outAlpha.Text= "α = " + AngleCoordToDegMinString(α);
                outBeta.Text = "β = " + AngleCoordToDegMinString(β);
                outGama.Text = "γ = " + AngleCoordToDegMinString(γ);
                boxUhly.Visible = true;
                boxStrany.Size = new System.Drawing.Size(145, 90);
            }
            else
            {
                boxUhly.Visible = false;
                boxStrany.Size = new System.Drawing.Size(296, 90);
            }

            if (obvodobsahanoMenuItem.Checked == true)
            {
                double o = Math.Round((a + b + c), 4);
                double s = o / 2;
                double S = Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 3);
                outO.Text = "o = " + o.ToString() + " cm";
                outS.Text = "S = " + S.ToString() + " cm²";
                boxStats.Visible = true;
                boxStats.Location = new System.Drawing.Point(21, 147);
                boxPravouhlost.Location = new System.Drawing.Point(21, 196);

            }
            else
            {
                boxStats.Visible = false;
                boxPravouhlost.Location = new System.Drawing.Point(21, 147);
            }

            if (AngleCoordToDegMinString(α) == "90° 0'" || AngleCoordToDegMinString(β) == "90° 0'" || AngleCoordToDegMinString(γ) == "90° 0'")
            {
                outPravouhlost.Text = "Trojuholník " + T.pravo;
            }
            else
            {
                outPravouhlost.Text = "Trojuholník nie " + T.pravo;
            }
        }
      #endregion
      #region Akcie položiek Menu
        private void pomocMenuItem_Click(object sender, EventArgs e)
        {
            frame1.Show();
        }
        private void oprogrameMenuItem_Click(object sender, EventArgs e)
        {
            About frame2 = new About();
            frame2.Show();
        }
        private void ukoncitMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }
        private void moznostiMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == uhlyanoMenuItem)
            { Checker(1); }
            else if (sender == uhlynieMenuItem)
            { Checker(2); }
            else if (sender == obvodobsahanoMenuItem)
            { Checker(3); }
            else if (sender == obvodobsahnieMenuItem)
            { Checker(4); }
        }
        private void zobrazMenuItem_Click(object sender, EventArgs e)
        {
            if (outAlpha.Text == "α = 90° 0'" || outBeta.Text == "β = 90° 0'" || outGama.Text == "γ = 90° 0'")
            {
                Nacrt frame3 = new Nacrt(1);
                frame3.Show();
            }
            else if (a >= b && a >= c)
            {
                Nacrt frame3 = new Nacrt(2);
                frame3.Show();
            }
            else if (b >= a && b >= c)
            {
                Nacrt frame3 = new Nacrt(1);
                frame3.Show();
            }
            else if (c >= a && c >= b)
            {
                Nacrt frame3 = new Nacrt(0);
                frame3.Show();
            }
        }
      #endregion
      #region Výpisy chýb
        private void vypisCh(int l, string M)
         {
             switch (l)
             {
                 case 1 :
                     chA.Text = M;
                     break;
                 case 2 :
                     chB.Text = M;
                     break;
                 case 3 :
                     chC.Text = M;
                     break;
                 case 4 :
                     ch.Text = M;
                     ch.Location = new System.Drawing.Point(17, 127);
                     break;
                 case 5 :
                     ch.Text = M;
                     ch.Location = new System.Drawing.Point(104, 127);
                     break;
             }

         }
        private void zmazChA(object sender, EventArgs e)
        { chA.Text = ""; ch.Text = "";}
        private void zmazChB(object sender, EventArgs e)
        { chB.Text = ""; ch.Text = ""; }
        private void zmazChC(object sender, EventArgs e)
        { chC.Text = ""; ch.Text = ""; 
        }
      #endregion
      #region Akcie tlačidiel
        private void tlacidloNove_Click(object sender, EventArgs e)
        {
         ///Zobrazí "panel1" miesto "panel2" a v menu polozku "Potvrdiť" miesto "Nové zadanie", zmaže vstupy pre a, b, c.
            panel2.Visible = false;
            zobrazMenuItem.Visible = false;
            inA.Text = "";
            inB.Text = "";
            inC.Text = "";
            vypisCh(5, "");
            panel1.Visible = true;
            noveMenuItem.Visible = false;
            potvrditMenuItem.Visible = true;
        }
        private void tlacidloPotvrdit_Click(object sender, EventArgs e)
        {
         ///Premení vstupy na float
            a = StringToFloat(inA.Text, 1);
            b = StringToFloat(inB.Text, 2);
            c = StringToFloat(inC.Text, 3);
         ///Zistí počet nezadaných vstupov
            int N = 0;
            bool pokracuj = true;
            int x = 0;
            if (a == 0) x++;
            if (b == 0) x++;
            if (c == 0) x++;
            if (x > 1) vypisCh(4, T.viac);

            else if (a >= 0 && b >= 0 && c >= 0)
            {
                if (x == 0)
                {
                    if (nerovnost(a, b, c) == true)
                    {
                        vypis(a, b, c, N);
                    }
                }
                else if (x == 1)
                {
                    if (a == 0)
                    {
                        if (b >= c)
                        {   vypisCh(5, T.prepona); pokracuj = false;   }
                        else
                            a = Convert.ToSingle(Math.Sqrt((c * c) - (b * b)));
                        N = 1; 
                    }
                    else if (b == 0)
                    {
                        if (a >= c)
                        {   vypisCh(5, T.prepona); pokracuj = false;   }
                        else
                            b = Convert.ToSingle(Math.Sqrt((c * c) - (a * a)));
                        N = 2;
                    }
                    else if (c == 0)
                    {
                        c = Convert.ToSingle(Math.Sqrt((a * a) + (b * b)));
                        N = 3;
                    }
                    if (pokracuj == true)
                        vypis(a, b, c, N);

                }
            }
        }
      #endregion
    }

    class Texts
    {
        public string chyba = "Chyba v zadaní!";
        public string viac = "Nezadaná môže zostať dĺžka len jednej strany.";
        public string nerovnost = "Neplatí trojuholníková nerovnosť.";
        public string prepona = "Prepona musí byť strana c.";
        public string pravo = "je pravouholný.";
        public string[] p = {"A", "B", "C", "c", "a", "b"};
    }
}
