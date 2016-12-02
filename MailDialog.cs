using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Pytagoras
{
    public partial class MailDialog : Form
    {
        public MailDialog()
        {
            InitializeComponent();
        }

        private void tlacidloPoslat_Click(object sender, EventArgs e)
        {
            if (   textBoxAdresa.Text.Contains("@")
                && textBoxAdresa.Text.Contains(".")
                && !(textBoxAdresa.Text.Contains(" "))
                && textBoxPredmet.TextLength > 0
                && textBoxSprava.TextLength > 0 )
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    NetworkCredential cred = new NetworkCredential("peter.kovary@hotmail.com", "22051191922");

                    MailMessage msg = new MailMessage();
                    msg.To.Add("peter.kovary@hotmail.com"); msg.To.Add("pytagoras@inbox.com");
                    msg.From = new MailAddress("peter.kovary@hotmail.com");
                    msg.Subject = "Pytagoras - " + textBoxPredmet.Text;
                    msg.Body = "Odoslal:\n " + textBoxAdresa.Text + "\n\nSpráva:\n";

                    SmtpClient client = new SmtpClient("smtp.live.com", 25);
                    client.Credentials = cred;
                    client.EnableSsl = true;
                    client.Send(msg);

                    this.Cursor = Cursors.Default;
                    this.labelVypis.Text = "Email úspešne odoslaný";
                }
                catch
                {
                    MessageBox.Show("Pri odosielaní emailu sa vyskytla chyba. Prosím kontaktujte autora zo svojho osobného emailového účtu");
                    this.Close();
                }
            }
            else if (textBoxAdresa.TextLength == 0)
                this.labelVypis.Text = "Adresa nesmie zostať prázdna";
            else if (!(textBoxAdresa.Text.Contains("@")) || !(textBoxAdresa.Text.Contains(".")))
                this.labelVypis.Text = "Neplatná emailová adresa";
            else if (textBoxPredmet.TextLength == 0)
                this.labelVypis.Text = "Predmet nesmie zostať prázdny";
            else if (textBoxSprava.TextLength == 0)
                this.labelVypis.Text = "Správa nesmie zostať prázdna";
        }
        private void zmazlabelVypis(object sender, EventArgs e)
        {
            labelVypis.Text = "";
        }
        private void MailDialog_Paint(object sender, PaintEventArgs e)
        {
            if (labelVypis.Text == "Email úspešne odoslaný")
            {
                System.Threading.Thread.Sleep(2000);
                this.Close();
            }
        }
    }
}
