using System.Net;
using System.Net.Mail;
using System.Text;

namespace WinFormsEnviarEmails
{
    public partial class Form1 : Form
    {
        static string[] languages = { "portuguese", "english" };
        static string actualLanguage = languages[0];
        public Form1()
        {
            InitializeComponent();
            portuguêsBrasilToolStripMenuItem.Checked = true;
            buttonAnexo.Enabled = false;
        }

        private void buttonEnviaEmail_Click(object sender, EventArgs e)
        {
            try
            {
                // Para enviar um email, é necessário criar uma instância SMTP (importe de System.Net) e inserir o host e a porta.
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;                                                                            // Ativa certificados SSL para criptografar a conexão.
                smtpClient.UseDefaultCredentials = false;                                                               // Impede de usar credenciais do Windows.
                smtpClient.Credentials = new NetworkCredential("anEmail@email.com", "pass"); // Login e senha
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;                                                 // O método de entrega.

                MailMessage mailMessage = new MailMessage();                                            // Cria o email a ser entregue.
                mailMessage.From = new MailAddress("anEmail@email.com");                    // O remetente.
                mailMessage.To.Add(new MailAddress("anEmail@email.com"));                           // O destinatário.
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
                    mailMessage.Subject = textBoxSubject.Text;                                              // Assunto do email.
                }
                mailMessage.Body = richTextBoxCorpo.Text;                                               // Corpo do email.
                if (checkBoxContemHTML.Checked)
                {
                    mailMessage.IsBodyHtml = true;                                                          // Define se o email está em hmtl.
                }
                else
                {
                    mailMessage.IsBodyHtml = false;
                }
                if (buttonMidia.Enabled)
                {
                    if (richTextBoxCorpo.Text.Contains("contemImagem"))
                    {
                        LinkedResource imagem = new LinkedResource(openFileMidia.FileName);
                        imagem.ContentId = "exemplo";
                        AlternateView html = AlternateView.CreateAlternateViewFromString($"<br><img src=cid:exemplo><br>", null, "text/html");
                        html.LinkedResources.Add(imagem);
                    }
                }
                smtpClient.Send(mailMessage);                                                           // Envia a mensagem.
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
                labelAnexo.Text = openFileAnexo.FileName;
                //labelAnexo.Text = System.IO.Path.GetFileName(openFileAnexo.FileName);  // Use este se quiser apenas o nome do arquivo sem o diretório.
            }
        }

        private void buttonMidia_Click(object sender, EventArgs e)
        {
            openFileMidia.InitialDirectory = "C:\\";
            openFileMidia.Filter = "Media files|*.jpg;*.jpeg;*.bmp;*.png;*.gif;*.mpeg;*.wmv;*.mp4;*.mp3;*.wma";
            if (openFileMidia.ShowDialog() == DialogResult.OK)
            {
                richTextBoxCorpo.Text += "\ncontemImagem";
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
                //buttonMidia.Enabled = true;
            }
            else
            {
                buttonBold.Enabled = false;
                buttonItalic.Enabled = false;
                buttonUnderline.Enabled = false;
                buttonMidia.Enabled = false;
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
            labelBody.Text = "Corpo";
            checkBoxContemHTML.Text = "Este email contém HTML";
            buttonAnexo.Text = "Anexo";
            buttonEnviaEmail.Text = "Enviar email";
            groupBoxElements.Text = "Inserir elementos";
            labelAnexo.Text = "<Nenhum arquivo selecionado>";
            buttonMidia.Text = "Mídia...";
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
            labelBody.Text = "Body";
            checkBoxContemHTML.Text = "This email contains HTML";
            buttonAnexo.Text = "Annex";
            buttonEnviaEmail.Text = "Send email";
            groupBoxElements.Text = "Insert elements";
            labelAnexo.Text = "<Any element selected>";
            buttonMidia.Text = "Media...";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (actualLanguage == languages[0])
            {
                result = MessageBox.Show("Você tem certeza que quer sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }else if (actualLanguage == languages[1])
            {
                result = MessageBox.Show("Are you sure?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
    }
}
