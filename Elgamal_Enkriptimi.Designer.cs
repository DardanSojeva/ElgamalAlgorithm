﻿namespace CryptographyAlgorithms
{
    partial class Elgamal_Enkriptimi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Algoritmi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.elgamalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCryptographyAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.txtboxMesazhi = new System.Windows.Forms.TextBox();
            this.LabelPublicKey = new System.Windows.Forms.Label();
            this.LabelFirstPartOfThePublicKey = new System.Windows.Forms.Label();
            this.LabelSecondPartOfThePublicKey = new System.Windows.Forms.Label();
            this.LabelThirdPartOfThePublicKey = new System.Windows.Forms.Label();
            this.txtboxPjesaPareQelesitPublik = new System.Windows.Forms.TextBox();
            this.txtboxPjesaDyteQelesitPublik = new System.Windows.Forms.TextBox();
            this.txtboxPjesaTreteQelesitPublik = new System.Windows.Forms.TextBox();
            this.LabelCiphertext = new System.Windows.Forms.Label();
            this.btn_Enkripto = new System.Windows.Forms.Button();
            this.LabelCiphertextOutput = new System.Windows.Forms.Label();
            this.txtboxQelesi_Session = new System.Windows.Forms.TextBox();
            this.LabelSessionKey = new System.Windows.Forms.Label();
            this.checkbox_Qelesi_Session = new System.Windows.Forms.CheckBox();
            this.LabelNameForm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Algoritmi_toolstrip_menu,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Algoritmi_toolstrip_menu
            // 
            this.Algoritmi_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elgamalToolStripMenuItem});
            this.Algoritmi_toolstrip_menu.Name = "Algoritmi_toolstrip_menu";
            this.Algoritmi_toolstrip_menu.Size = new System.Drawing.Size(69, 20);
            this.Algoritmi_toolstrip_menu.Text = "Algoritmi";
            // 
            // elgamalToolStripMenuItem
            // 
            this.elgamalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyGenerationToolStripMenuItem,
            this.EncryptionToolStripMenuItem,
            this.DecryptionToolStripMenuItem});
            this.elgamalToolStripMenuItem.Name = "elgamalToolStripMenuItem";
            this.elgamalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.elgamalToolStripMenuItem.Text = "Elgamal";
            // 
            // KeyGenerationToolStripMenuItem
            // 
            this.KeyGenerationToolStripMenuItem.Name = "KeyGenerationToolStripMenuItem";
            this.KeyGenerationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.KeyGenerationToolStripMenuItem.Text = "Gjenerimi i qelesave";
            this.KeyGenerationToolStripMenuItem.Click += new System.EventHandler(this.KeyGenerationToolStripMenuItem_Click);
            // 
            // EncryptionToolStripMenuItem
            // 
            this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
            this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.EncryptionToolStripMenuItem.Text = "Enkriptimi";
            // 
            // DecryptionToolStripMenuItem
            // 
            this.DecryptionToolStripMenuItem.Name = "DecryptionToolStripMenuItem";
            this.DecryptionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.DecryptionToolStripMenuItem.Text = "Dekriptimi";
            this.DecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutCryptographyAlgorithmsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // AboutCryptographyAlgorithmsToolStripMenuItem
            // 
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Name = "AboutCryptographyAlgorithmsToolStripMenuItem";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Text = "Rreth algoritmeve kriptografike";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Click += new System.EventHandler(this.AboutCryptographyAlgorithmsToolStripMenuItem_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(98, 80);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(410, 24);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "mesazhi (ndonje numer (1, numri_i_thjeshte - 1)";
            // 
            // txtboxMesazhi
            // 
            this.txtboxMesazhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMesazhi.Location = new System.Drawing.Point(102, 120);
            this.txtboxMesazhi.Name = "txtboxMesazhi";
            this.txtboxMesazhi.Size = new System.Drawing.Size(409, 29);
            this.txtboxMesazhi.TabIndex = 2;
            // 
            // LabelPublicKey
            // 
            this.LabelPublicKey.AutoSize = true;
            this.LabelPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPublicKey.Location = new System.Drawing.Point(24, 185);
            this.LabelPublicKey.Name = "LabelPublicKey";
            this.LabelPublicKey.Size = new System.Drawing.Size(119, 24);
            this.LabelPublicKey.TabIndex = 3;
            this.LabelPublicKey.Text = "Qelesi publik";
            // 
            // LabelFirstPartOfThePublicKey
            // 
            this.LabelFirstPartOfThePublicKey.AutoSize = true;
            this.LabelFirstPartOfThePublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstPartOfThePublicKey.Location = new System.Drawing.Point(95, 225);
            this.LabelFirstPartOfThePublicKey.Name = "LabelFirstPartOfThePublicKey";
            this.LabelFirstPartOfThePublicKey.Size = new System.Drawing.Size(115, 24);
            this.LabelFirstPartOfThePublicKey.TabIndex = 4;
            this.LabelFirstPartOfThePublicKey.Text = "Pjesa e pare";
            // 
            // LabelSecondPartOfThePublicKey
            // 
            this.LabelSecondPartOfThePublicKey.AutoSize = true;
            this.LabelSecondPartOfThePublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSecondPartOfThePublicKey.Location = new System.Drawing.Point(98, 256);
            this.LabelSecondPartOfThePublicKey.Name = "LabelSecondPartOfThePublicKey";
            this.LabelSecondPartOfThePublicKey.Size = new System.Drawing.Size(112, 24);
            this.LabelSecondPartOfThePublicKey.TabIndex = 5;
            this.LabelSecondPartOfThePublicKey.Text = "Pjesa e dyte";
            // 
            // LabelThirdPartOfThePublicKey
            // 
            this.LabelThirdPartOfThePublicKey.AutoSize = true;
            this.LabelThirdPartOfThePublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThirdPartOfThePublicKey.Location = new System.Drawing.Point(98, 289);
            this.LabelThirdPartOfThePublicKey.Name = "LabelThirdPartOfThePublicKey";
            this.LabelThirdPartOfThePublicKey.Size = new System.Drawing.Size(113, 24);
            this.LabelThirdPartOfThePublicKey.TabIndex = 6;
            this.LabelThirdPartOfThePublicKey.Text = "Pjesa e trete";
            // 
            // txtboxPjesaPareQelesitPublik
            // 
            this.txtboxPjesaPareQelesitPublik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPjesaPareQelesitPublik.Location = new System.Drawing.Point(232, 218);
            this.txtboxPjesaPareQelesitPublik.Name = "txtboxPjesaPareQelesitPublik";
            this.txtboxPjesaPareQelesitPublik.Size = new System.Drawing.Size(164, 29);
            this.txtboxPjesaPareQelesitPublik.TabIndex = 7;
            // 
            // txtboxPjesaDyteQelesitPublik
            // 
            this.txtboxPjesaDyteQelesitPublik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPjesaDyteQelesitPublik.Location = new System.Drawing.Point(232, 253);
            this.txtboxPjesaDyteQelesitPublik.Name = "txtboxPjesaDyteQelesitPublik";
            this.txtboxPjesaDyteQelesitPublik.Size = new System.Drawing.Size(164, 29);
            this.txtboxPjesaDyteQelesitPublik.TabIndex = 8;
            // 
            // txtboxPjesaTreteQelesitPublik
            // 
            this.txtboxPjesaTreteQelesitPublik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPjesaTreteQelesitPublik.Location = new System.Drawing.Point(232, 289);
            this.txtboxPjesaTreteQelesitPublik.Name = "txtboxPjesaTreteQelesitPublik";
            this.txtboxPjesaTreteQelesitPublik.Size = new System.Drawing.Size(164, 29);
            this.txtboxPjesaTreteQelesitPublik.TabIndex = 9;
            // 
            // LabelCiphertext
            // 
            this.LabelCiphertext.AutoSize = true;
            this.LabelCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCiphertext.Location = new System.Drawing.Point(24, 517);
            this.LabelCiphertext.Name = "LabelCiphertext";
            this.LabelCiphertext.Size = new System.Drawing.Size(156, 24);
            this.LabelCiphertext.TabIndex = 10;
            this.LabelCiphertext.Text = "Teskti i enkriptuar";
            // 
            // btn_Enkripto
            // 
            this.btn_Enkripto.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Enkripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enkripto.Location = new System.Drawing.Point(161, 454);
            this.btn_Enkripto.Name = "btn_Enkripto";
            this.btn_Enkripto.Size = new System.Drawing.Size(235, 31);
            this.btn_Enkripto.TabIndex = 11;
            this.btn_Enkripto.Text = "Enkripto";
            this.btn_Enkripto.UseVisualStyleBackColor = false;
            this.btn_Enkripto.Click += new System.EventHandler(this.ButtonEncryption_Click);
            // 
            // LabelCiphertextOutput
            // 
            this.LabelCiphertextOutput.AutoSize = true;
            this.LabelCiphertextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCiphertextOutput.Location = new System.Drawing.Point(211, 517);
            this.LabelCiphertextOutput.Name = "LabelCiphertextOutput";
            this.LabelCiphertextOutput.Size = new System.Drawing.Size(0, 24);
            this.LabelCiphertextOutput.TabIndex = 12;
            // 
            // txtboxQelesi_Session
            // 
            this.txtboxQelesi_Session.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQelesi_Session.Location = new System.Drawing.Point(232, 365);
            this.txtboxQelesi_Session.Name = "txtboxQelesi_Session";
            this.txtboxQelesi_Session.Size = new System.Drawing.Size(164, 29);
            this.txtboxQelesi_Session.TabIndex = 13;
            // 
            // LabelSessionKey
            // 
            this.LabelSessionKey.AutoSize = true;
            this.LabelSessionKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSessionKey.Location = new System.Drawing.Point(95, 368);
            this.LabelSessionKey.Name = "LabelSessionKey";
            this.LabelSessionKey.Size = new System.Drawing.Size(115, 24);
            this.LabelSessionKey.TabIndex = 14;
            this.LabelSessionKey.Text = "Qelesi i rastit";
            // 
            // checkbox_Qelesi_Session
            // 
            this.checkbox_Qelesi_Session.AutoSize = true;
            this.checkbox_Qelesi_Session.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Qelesi_Session.Location = new System.Drawing.Point(99, 411);
            this.checkbox_Qelesi_Session.Name = "checkbox_Qelesi_Session";
            this.checkbox_Qelesi_Session.Size = new System.Drawing.Size(388, 28);
            this.checkbox_Qelesi_Session.TabIndex = 15;
            this.checkbox_Qelesi_Session.Text = "Gjenero qelesin e rastit ne menyre rastsore";
            this.checkbox_Qelesi_Session.UseVisualStyleBackColor = true;
            // 
            // LabelNameForm
            // 
            this.LabelNameForm.AutoSize = true;
            this.LabelNameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameForm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelNameForm.Location = new System.Drawing.Point(205, 35);
            this.LabelNameForm.Name = "LabelNameForm";
            this.LabelNameForm.Size = new System.Drawing.Size(234, 31);
            this.LabelNameForm.TabIndex = 16;
            this.LabelNameForm.Text = "Elgamal enkriptimi";
            // 
            // Elgamal_Enkriptimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(653, 570);
            this.Controls.Add(this.LabelNameForm);
            this.Controls.Add(this.checkbox_Qelesi_Session);
            this.Controls.Add(this.LabelSessionKey);
            this.Controls.Add(this.txtboxQelesi_Session);
            this.Controls.Add(this.LabelCiphertextOutput);
            this.Controls.Add(this.btn_Enkripto);
            this.Controls.Add(this.LabelCiphertext);
            this.Controls.Add(this.txtboxPjesaTreteQelesitPublik);
            this.Controls.Add(this.txtboxPjesaDyteQelesitPublik);
            this.Controls.Add(this.txtboxPjesaPareQelesitPublik);
            this.Controls.Add(this.LabelThirdPartOfThePublicKey);
            this.Controls.Add(this.LabelSecondPartOfThePublicKey);
            this.Controls.Add(this.LabelFirstPartOfThePublicKey);
            this.Controls.Add(this.LabelPublicKey);
            this.Controls.Add(this.txtboxMesazhi);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Elgamal_Enkriptimi";
            this.Text = "Cryptography Algorithms";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Algoritmi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem elgamalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutCryptographyAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.TextBox txtboxMesazhi;
        private System.Windows.Forms.Label LabelPublicKey;
        private System.Windows.Forms.Label LabelFirstPartOfThePublicKey;
        private System.Windows.Forms.Label LabelSecondPartOfThePublicKey;
        private System.Windows.Forms.Label LabelThirdPartOfThePublicKey;
        private System.Windows.Forms.TextBox txtboxPjesaPareQelesitPublik;
        private System.Windows.Forms.TextBox txtboxPjesaDyteQelesitPublik;
        private System.Windows.Forms.TextBox txtboxPjesaTreteQelesitPublik;
        private System.Windows.Forms.Label LabelCiphertext;
        private System.Windows.Forms.Button btn_Enkripto;
        private System.Windows.Forms.Label LabelCiphertextOutput;
        private System.Windows.Forms.TextBox txtboxQelesi_Session;
        private System.Windows.Forms.Label LabelSessionKey;
        private System.Windows.Forms.CheckBox checkbox_Qelesi_Session;
        private System.Windows.Forms.Label LabelNameForm;
    }
}