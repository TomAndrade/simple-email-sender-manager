namespace WinFormsEnviarEmails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonEnviaEmail = new Button();
            checkBoxContemHTML = new CheckBox();
            buttonMidia = new Button();
            groupBoxElements = new GroupBox();
            labelAnexo = new Label();
            buttonAnexo = new Button();
            richTextBoxCorpo = new RichTextBox();
            textBoxSubject = new TextBox();
            labelSubject = new Label();
            openFileAnexo = new OpenFileDialog();
            buttonBold = new Button();
            buttonItalic = new Button();
            buttonUnderline = new Button();
            toolTipDica = new ToolTip(components);
            openFileMidia = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            idiomaToolStripMenuItem = new ToolStripMenuItem();
            portuguêsBrasilToolStripMenuItem = new ToolStripMenuItem();
            englishUSToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            groupBoxCorpo = new GroupBox();
            labelMedia = new Label();
            groupBoxElements.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBoxCorpo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEnviaEmail
            // 
            buttonEnviaEmail.Location = new Point(646, 526);
            buttonEnviaEmail.Name = "buttonEnviaEmail";
            buttonEnviaEmail.Size = new Size(100, 23);
            buttonEnviaEmail.TabIndex = 0;
            buttonEnviaEmail.Text = "Enviar email";
            buttonEnviaEmail.UseVisualStyleBackColor = true;
            buttonEnviaEmail.Click += buttonEnviaEmail_Click;
            // 
            // checkBoxContemHTML
            // 
            checkBoxContemHTML.AutoSize = true;
            checkBoxContemHTML.Location = new Point(10, 26);
            checkBoxContemHTML.Name = "checkBoxContemHTML";
            checkBoxContemHTML.Size = new Size(158, 19);
            checkBoxContemHTML.TabIndex = 3;
            checkBoxContemHTML.Text = "Este email contém HTML";
            checkBoxContemHTML.UseVisualStyleBackColor = true;
            checkBoxContemHTML.Click += checkBoxContemHTML_Click;
            // 
            // buttonMidia
            // 
            buttonMidia.Enabled = false;
            buttonMidia.Location = new Point(262, 22);
            buttonMidia.Name = "buttonMidia";
            buttonMidia.Size = new Size(75, 23);
            buttonMidia.TabIndex = 5;
            buttonMidia.Text = "Mídia...";
            buttonMidia.UseVisualStyleBackColor = true;
            buttonMidia.Click += buttonMidia_Click;
            buttonMidia.MouseHover += buttonMidia_MouseHover;
            // 
            // groupBoxElements
            // 
            groupBoxElements.Controls.Add(labelAnexo);
            groupBoxElements.Controls.Add(buttonAnexo);
            groupBoxElements.Location = new Point(12, 460);
            groupBoxElements.Name = "groupBoxElements";
            groupBoxElements.Size = new Size(734, 60);
            groupBoxElements.TabIndex = 6;
            groupBoxElements.TabStop = false;
            groupBoxElements.Text = "Adicionar anexo(s)";
            // 
            // labelAnexo
            // 
            labelAnexo.AutoSize = true;
            labelAnexo.Location = new Point(115, 26);
            labelAnexo.Name = "labelAnexo";
            labelAnexo.Size = new Size(179, 15);
            labelAnexo.TabIndex = 7;
            labelAnexo.Text = "<Nenhum arquivo selecionado>";
            // 
            // buttonAnexo
            // 
            buttonAnexo.Location = new Point(6, 22);
            buttonAnexo.Name = "buttonAnexo";
            buttonAnexo.Size = new Size(75, 23);
            buttonAnexo.TabIndex = 6;
            buttonAnexo.Text = "Anexo...";
            buttonAnexo.UseVisualStyleBackColor = true;
            buttonAnexo.Click += buttonAnexo_Click;
            // 
            // richTextBoxCorpo
            // 
            richTextBoxCorpo.Location = new Point(6, 51);
            richTextBoxCorpo.Name = "richTextBoxCorpo";
            richTextBoxCorpo.Size = new Size(722, 320);
            richTextBoxCorpo.TabIndex = 7;
            richTextBoxCorpo.Text = "";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(12, 48);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(734, 23);
            textBoxSubject.TabIndex = 8;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(12, 30);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(53, 15);
            labelSubject.TabIndex = 10;
            labelSubject.Text = "Assunto:";
            // 
            // buttonBold
            // 
            buttonBold.Enabled = false;
            buttonBold.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            buttonBold.Location = new Point(174, 22);
            buttonBold.Name = "buttonBold";
            buttonBold.Size = new Size(27, 23);
            buttonBold.TabIndex = 11;
            buttonBold.Text = "B";
            buttonBold.UseVisualStyleBackColor = true;
            buttonBold.Click += buttonBold_Click;
            buttonBold.MouseHover += buttonBold_MouseHover;
            // 
            // buttonItalic
            // 
            buttonItalic.Enabled = false;
            buttonItalic.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            buttonItalic.Location = new Point(201, 22);
            buttonItalic.Name = "buttonItalic";
            buttonItalic.Size = new Size(27, 23);
            buttonItalic.TabIndex = 11;
            buttonItalic.Text = "I";
            buttonItalic.UseVisualStyleBackColor = true;
            buttonItalic.Click += buttonItalic_Click;
            buttonItalic.MouseHover += buttonItalic_MouseHover;
            // 
            // buttonUnderline
            // 
            buttonUnderline.Enabled = false;
            buttonUnderline.Font = new Font("Times New Roman", 9F, FontStyle.Underline);
            buttonUnderline.Location = new Point(229, 22);
            buttonUnderline.Name = "buttonUnderline";
            buttonUnderline.Size = new Size(27, 23);
            buttonUnderline.TabIndex = 11;
            buttonUnderline.Text = "U";
            buttonUnderline.UseVisualStyleBackColor = true;
            buttonUnderline.Click += buttonUnderline_Click;
            buttonUnderline.MouseHover += buttonUnderline_MouseHover;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { idiomaToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // idiomaToolStripMenuItem
            // 
            idiomaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { portuguêsBrasilToolStripMenuItem, englishUSToolStripMenuItem });
            idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            idiomaToolStripMenuItem.Size = new Size(111, 22);
            idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // portuguêsBrasilToolStripMenuItem
            // 
            portuguêsBrasilToolStripMenuItem.CheckOnClick = true;
            portuguêsBrasilToolStripMenuItem.Name = "portuguêsBrasilToolStripMenuItem";
            portuguêsBrasilToolStripMenuItem.Size = new Size(167, 22);
            portuguêsBrasilToolStripMenuItem.Text = "Português (Brasil)";
            portuguêsBrasilToolStripMenuItem.Click += portuguêsBrasilToolStripMenuItem_Click;
            // 
            // englishUSToolStripMenuItem
            // 
            englishUSToolStripMenuItem.CheckOnClick = true;
            englishUSToolStripMenuItem.Name = "englishUSToolStripMenuItem";
            englishUSToolStripMenuItem.Size = new Size(167, 22);
            englishUSToolStripMenuItem.Text = "English (US)";
            englishUSToolStripMenuItem.Click += englishUSToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(111, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // groupBoxCorpo
            // 
            groupBoxCorpo.Controls.Add(labelMedia);
            groupBoxCorpo.Controls.Add(buttonBold);
            groupBoxCorpo.Controls.Add(buttonUnderline);
            groupBoxCorpo.Controls.Add(checkBoxContemHTML);
            groupBoxCorpo.Controls.Add(buttonItalic);
            groupBoxCorpo.Controls.Add(richTextBoxCorpo);
            groupBoxCorpo.Controls.Add(buttonMidia);
            groupBoxCorpo.Location = new Point(12, 77);
            groupBoxCorpo.Name = "groupBoxCorpo";
            groupBoxCorpo.Size = new Size(734, 377);
            groupBoxCorpo.TabIndex = 13;
            groupBoxCorpo.TabStop = false;
            groupBoxCorpo.Text = "Corpo:";
            // 
            // labelMedia
            // 
            labelMedia.AutoSize = true;
            labelMedia.Enabled = false;
            labelMedia.Location = new Point(343, 27);
            labelMedia.Name = "labelMedia";
            labelMedia.Size = new Size(79, 15);
            labelMedia.TabIndex = 12;
            labelMedia.Text = "<Sem mídia>";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 560);
            Controls.Add(groupBoxCorpo);
            Controls.Add(labelSubject);
            Controls.Add(textBoxSubject);
            Controls.Add(groupBoxElements);
            Controls.Add(buttonEnviaEmail);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(774, 599);
            Name = "Form1";
            Text = "Email Sender Manager";
            groupBoxElements.ResumeLayout(false);
            groupBoxElements.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxCorpo.ResumeLayout(false);
            groupBoxCorpo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnviaEmail;
        private CheckBox checkBoxContemHTML;
        private Button buttonMidia;
        private GroupBox groupBoxElements;
        private Button buttonAnexo;
        private RichTextBox richTextBoxCorpo;
        private Label labelAnexo;
        private TextBox textBoxSubject;
        private Label labelSubject;
        private OpenFileDialog openFileAnexo;
        private Button buttonItalic;
        private Button buttonBold;
        private Button buttonUnderline;
        private ToolTip toolTipDica;
        private OpenFileDialog openFileMidia;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem idiomaToolStripMenuItem;
        private ToolStripMenuItem portuguêsBrasilToolStripMenuItem;
        private ToolStripMenuItem englishUSToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private GroupBox groupBoxCorpo;
        private Label labelMedia;
    }
}
