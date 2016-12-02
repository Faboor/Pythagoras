using System;
using System.Windows.Forms;

namespace Pytagoras
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void linkFacebook_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/FaboorsStudio");
        }
        private void SendMail_Clicked(object sender, EventArgs e)
        {
            MailDialog frame4 = new MailDialog();
            frame4.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Licence frame5 = new Licence();
            frame5.Show();
        }
        private void LinkMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void LinkMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
