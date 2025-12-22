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
            labelBody = new Label();
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
            groupBoxElements.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            checkBoxContemHTML.Location = new Point(18, 98);
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
            buttonMidia.Location = new Point(270, 94);
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
            groupBoxElements.Text = "Inserir elementos";
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
            richTextBoxCorpo.Location = new Point(12, 123);
            richTextBoxCorpo.Name = "richTextBoxCorpo";
            richTextBoxCorpo.Size = new Size(734, 331);
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
            // labelBody
            // 
            labelBody.AutoSize = true;
            labelBody.Font = new Font("Segoe UI", 9F);
            labelBody.Location = new Point(12, 80);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(43, 15);
            labelBody.TabIndex = 9;
            labelBody.Text = "Corpo:";
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
            buttonBold.Location = new Point(182, 94);
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
            buttonItalic.Location = new Point(209, 94);
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
            buttonUnderline.Location = new Point(237, 94);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 560);
            Controls.Add(buttonUnderline);
            Controls.Add(buttonItalic);
            Controls.Add(labelSubject);
            Controls.Add(buttonMidia);
            Controls.Add(buttonBold);
            Controls.Add(labelBody);
            Controls.Add(textBoxSubject);
            Controls.Add(richTextBoxCorpo);
            Controls.Add(groupBoxElements);
            Controls.Add(checkBoxContemHTML);
            Controls.Add(buttonEnviaEmail);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(774, 599);
            Name = "Form1";
            Text = "Form1";
            groupBoxElements.ResumeLayout(false);
            groupBoxElements.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label labelBody;
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
    }
}
