using MailKit.Security;
using MimeKit;
using System.Net;
using System.Net.Mail;
using System.Text;
using MailKit.Net.Pop3;

/*
 * 1.0 - Release
 * 1.1 - UI changes
 * 1.2 - English (US) language support
 * 1.3 - Media and annex support
 * 1.4 - Email reader support
 */

namespace WinFormsEnviarEmails
{
    public partial class Form1Sender : Form
    {
        static string[] languages = { "portuguese", "english" };
        static string actualLanguage = languages[0];
        static bool hasMedia = false;
        static bool hasAnnex = false;
        List<string> listaAnexos = new List<string>();
        public Form1Sender()
        {
            InitializeComponent();
            portuguêsBrasilToolStripMenuItem.Checked = true;
        }

        private void buttonEnviaEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);                                          // SMTP client required.
                smtpClient.EnableSsl = true;                                                                            // Enables SSL encrypt.
                smtpClient.UseDefaultCredentials = false;                                                               // Blocks Windows credentials.
                smtpClient.Credentials = new NetworkCredential("anEmail@email.com", "pass");                            // Login and pass.
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;                                                 // Delivery method

                MailMessage mailMessage = new MailMessage();                                        // Creates the email.
                mailMessage.From = new MailAddress("anEmail@email.com");                            // Sender
                mailMessage.To.Add(new MailAddress("anEmail@email.com"));                           // Recipient
                if (textBoxSubject.Text == "" || textBoxSubject.Text is null)
                {
                    if (actualLanguage == languages[0])
                    {
                        MessageBox.Show("Insira um título para o email!");
                        textBoxSubject.Focus();
                        return;

                    }
                    else if (actualLanguage == languages[1])
                    {
                        MessageBox.Show("Please insert a subject to send your email!");
                        textBoxSubject.Focus();
                        return;
                    }
                }
                else
                {
                    mailMessage.Subject = textBoxSubject.Text;   // Email subject.
                }
                mailMessage.Body = richTextBoxCorpo.Text;        // Email body.
                if (checkBoxContemHTML.Checked)
                {
                    mailMessage.IsBodyHtml = true;               // Actives HTML resource.
                    if (buttonMidia.Enabled)
                    {
                        if (hasMedia)
                        {
                            LinkedResource imagem = new LinkedResource(openFileMidia.FileName);
                            imagem.ContentId = "media";
                            AlternateView html = AlternateView.CreateAlternateViewFromString($"{mailMessage.Body}<br><img src=cid:media><br>", null, "text/html");
                            html.LinkedResources.Add(imagem);
                            mailMessage.AlternateViews.Add(html);
                        }
                    }
                    if (hasAnnex)
                    {
                        for (int i = 0; i < listaAnexos.Count; i++)
                        {
                            Attachment anexo = new Attachment(listaAnexos[i]);
                            mailMessage.Attachments.Add(anexo);
                        }
                    }
                }
                else
                {
                    mailMessage.IsBodyHtml = false;
                }
                smtpClient.Send(mailMessage);                   // Sends the email.
                buttonEnviaEmail.Enabled = false;
                if (actualLanguage == languages[0])
                {
                    Thread.Sleep(1000);
                    buttonEnviaEmail.Text = "Enviando";
                    MessageBox.Show("Email enviado com sucesso.", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonEnviaEmail.Text = "Enviar email";
                }
                else if (actualLanguage == languages[1])
                {
                    Thread.Sleep(1000);
                    buttonEnviaEmail.Text = "Sending";
                    MessageBox.Show("Email sent successfully.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonEnviaEmail.Text = "Send email";
                }
                buttonEnviaEmail.Enabled = true;
            }
            catch (Exception ex)
            {
                if (actualLanguage == languages[0])
                {
                    MessageBox.Show("Não foi possível enviar o email: " + ex.Message, "Erro ao enviar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (actualLanguage == languages[1])
                {
                    MessageBox.Show("It wasn't possible send your email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAnexo_Click(object sender, EventArgs e)
        {
            openFileAnexo.InitialDirectory = "C:\\";
            openFileAnexo.Filter = "All files|*.*";
            if (openFileAnexo.ShowDialog() == DialogResult.OK)
            {
                if (portuguêsBrasilToolStripMenuItem.Checked)
                {
                    labelAnexo.Text = $"Contém {listaAnexos.Count + 1} anexo(s).";
                }
                else if (englishUSToolStripMenuItem.Checked)
                {
                    labelAnexo.Text = $"Contains {listaAnexos.Count + 1} attachment(s).";
                }
                //labelAnexo.Text = System.IO.Path.GetFileName(openFileAnexo.FileName);  // Use este se quiser apenas o nome do arquivo sem o diretório.
                listaAnexos.Add(openFileAnexo.FileName);
                hasAnnex = true;
            }
        }

        private void buttonMidia_Click(object sender, EventArgs e)
        {
            openFileMidia.InitialDirectory = "C:\\";
            openFileMidia.Filter = "Media files|*.jpg;*.jpeg;*.bmp;*.png;*.gif;*.mpeg;*.wmv;*.mp4;*.mp3;*.wma";
            if (openFileMidia.ShowDialog() == DialogResult.OK)
            {
                labelMedia.Text = openFileMidia.FileName;
                hasMedia = true;
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            if (richTextBoxCorpo.SelectedText is not null)
            {
                richTextBoxCorpo.SelectedText = "<b>" + richTextBoxCorpo.SelectedText + "</b>";
            }
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            if (richTextBoxCorpo.SelectedText is not null)
            {
                richTextBoxCorpo.SelectedText = "<i>" + richTextBoxCorpo.SelectedText + "</i>";
            }
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBoxCorpo.SelectedText is not null)
            {
                richTextBoxCorpo.SelectedText = "<u>" + richTextBoxCorpo.SelectedText + "</u>";
            }
        }

        private void checkBoxContemHTML_Click(object sender, EventArgs e)
        {
            if (checkBoxContemHTML.Checked)
            {
                buttonBold.Enabled = true;
                buttonItalic.Enabled = true;
                buttonUnderline.Enabled = true;
                buttonMidia.Enabled = true;
                labelMedia.Enabled = true;
            }
            else
            {
                buttonBold.Enabled = false;
                buttonItalic.Enabled = false;
                buttonUnderline.Enabled = false;
                buttonMidia.Enabled = false;
                labelMedia.Enabled = false;
            }
        }

        private void buttonBold_MouseHover(object sender, EventArgs e)
        {
            toolTipDica.Show("Bold", buttonBold);
        }

        private void buttonItalic_MouseHover(object sender, EventArgs e)
        {
            toolTipDica.Show("Italic", buttonItalic);
        }

        private void buttonUnderline_MouseHover(object sender, EventArgs e)
        {
            toolTipDica.Show("Underlined", buttonUnderline);
        }

        private void buttonMidia_MouseHover(object sender, EventArgs e)
        {
            toolTipDica.Show("Unavailable", buttonMidia);
        }

        private void portuguêsBrasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portuguêsBrasilToolStripMenuItem.Checked = true;
            englishUSToolStripMenuItem.Checked = false;
            actualLanguage = languages[0];
            arquivoToolStripMenuItem.Text = "Arquivo";
            idiomaToolStripMenuItem.Text = "Idioma";
            sairToolStripMenuItem.Text = "Sair";

            labelSubject.Text = "Assunto:";
            groupBoxCorpo.Text = "Corpo";
            checkBoxContemHTML.Text = "Este email contém HTML";
            buttonAnexo.Text = "Anexo";
            buttonEnviaEmail.Text = "Enviar email";
            groupBoxElements.Text = "Inserir elementos";
            //labelAnexo.Text = "<Nenhum arquivo selecionado>";
            buttonMidia.Text = "Mídia...";
            buttonReadLastEmail.Text = "Ler último email";
        }

        private void englishUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portuguêsBrasilToolStripMenuItem.Checked = false;
            englishUSToolStripMenuItem.Checked = true;
            actualLanguage = languages[1];
            arquivoToolStripMenuItem.Text = "File";
            idiomaToolStripMenuItem.Text = "Language";
            sairToolStripMenuItem.Text = "Exit";

            labelSubject.Text = "Subject:";
            groupBoxCorpo.Text = "Body";
            checkBoxContemHTML.Text = "This email contains HTML";
            buttonAnexo.Text = "Annex";
            buttonEnviaEmail.Text = "Send email";
            groupBoxElements.Text = "Insert elements";
            //labelAnexo.Text = "<Any file selected>";
            buttonMidia.Text = "Media...";
            buttonReadLastEmail.Text = "Read last email";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (actualLanguage == languages[0])
            {
                result = MessageBox.Show("Você tem certeza que quer sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else if (actualLanguage == languages[1])
            {
                result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void buttonReadLastEmail_Click(object sender, EventArgs e)
        {
            Pop3Client pop3Client = new Pop3Client();
            try
            {
                // server, port, enableSSL
                pop3Client.Connect("pop.gmail.com", 995, SecureSocketOptions.SslOnConnect);
                pop3Client.AuthenticationMechanisms.Clear();
                pop3Client.Authenticate("email@email.com", "password");
                int messageCounter = pop3Client.GetMessageCount();           // Returns messages number available.
                MimeMessage emailMessage = pop3Client.GetMessage(0);         // Returns x messages.
                if (emailMessage.HtmlBody is not null)                       // Returns if an email has multiparts: HTML feature p.e.
                {
                    richTextBoxCorpo.Text = emailMessage.HtmlBody;
                }
                else
                {
                    richTextBoxCorpo.Text = emailMessage.TextBody;
                }
                textBoxSubject.Text = emailMessage.Subject;
                labelSender.Visible = true;
                labelSender.Text = emailMessage.From.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            pop3Client.Disconnect(true);
        }

        private void buttonEraseLastEmail_Click(object sender, EventArgs e)
        {
            Pop3Client pop3Client = new Pop3Client();
            try
            {
                // server, port, enableSSL
                pop3Client.Connect("pop.gmail.com", 995, SecureSocketOptions.SslOnConnect);
                pop3Client.AuthenticationMechanisms.Clear();
                pop3Client.Authenticate("email@email.com", "password");
                int messageCounter = pop3Client.GetMessageCount();
                MimeMessage emailMessage = pop3Client.GetMessage(0);
                pop3Client.DeleteMessage(messageCounter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (portuguêsBrasilToolStripMenuItem.Checked)
            {
                MessageBox.Show("Último email apagado com sucesso.");
            }else if (englishUSToolStripMenuItem.Checked)
            {
                MessageBox.Show("Last email has erased successfully.");
            }
            pop3Client.Disconnect(true);
        }
    }
}
