using System.Net.Mail;
using System.Net;
using OpenPop.Pop3;

namespace EmailClientApp
{
    public partial class EmailApp : Form
    {
        public EmailApp()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUsername = "your_gmail_address_name_@gmail.com";
                // Email sending configuration
                string smtpPassword = "google_app_password";

                string to = txtRecipient.Text;
                string subject = txtSubject.Text;
                string body = txtBody.Text;

                MailMessage mail = new MailMessage(smtpUsername, to, subject, body);
                SmtpClient client = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                    EnableSsl = true
                };

                client.Send(mail);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                string pop3Server = "pop.gmail.com";
                int pop3Port = 995;
                string pop3Username = "your_gmail_address_name_@gmail.com";
                // Email receiving configuration
                string pop3Password = "google_app_password";

                using (Pop3Client pop3Client = new Pop3Client())
                {
                    pop3Client.Connect(pop3Server, pop3Port, true);
                    pop3Client.Authenticate(pop3Username, pop3Password);

                    int messageCount = pop3Client.GetMessageCount();

                    lstEmails.Items.Clear(); // Clear the ListBox

                    for (int i = 1; i <= messageCount; i++)
                    {
                        var message = pop3Client.GetMessage(i);
                        string emailDetails = $"{message.Headers.From.Address} - {message.Headers.Subject}";
                        lstEmails.Items.Add(emailDetails);
                    }

                    MessageBox.Show($"You have {messageCount} messages.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}