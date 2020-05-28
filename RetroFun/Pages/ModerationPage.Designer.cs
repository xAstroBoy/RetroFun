namespace RetroFun.Pages
{
    partial class ModerationPage
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameTxbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectUserLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TotUserRegistered = new System.Windows.Forms.Label();
            this.MottoTxbx = new System.Windows.Forms.TextBox();
            this.LookTxbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.BanUserForSpamBtn = new Sulakore.Components.SKoreButton();
            this.FloodBtn = new Sulakore.Components.SKoreButton();
            this.MuteUserBtn = new Sulakore.Components.SKoreButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnmuteUserBtn = new Sulakore.Components.SKoreButton();
            this.MuteTimeCmbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MutaUtenteTimerNbx = new System.Windows.Forms.NumericUpDown();
            this.Utente = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsersCmbx = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.KickUserWithAlertBtn = new Sulakore.Components.SKoreButton();
            this.AlertBoxTxb = new System.Windows.Forms.TextBox();
            this.AlertUserBtn = new Sulakore.Components.SKoreButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.banForInfoLeakBtn = new Sulakore.Components.SKoreButton();
            this.BanForNicknameNotAllowedBtn = new Sulakore.Components.SKoreButton();
            this.BanForSecurityLockBtn = new Sulakore.Components.SKoreButton();
            this.ManualBanBtn = new Sulakore.Components.SKoreButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BanTimeManualNbx = new System.Windows.Forms.NumericUpDown();
            this.BantimeCmbx = new System.Windows.Forms.ComboBox();
            this.BanManualReasonTxb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutaUtenteTimerNbx)).BeginInit();
            this.Utente.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanTimeManualNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTxbx
            // 
            this.UserNameTxbx.Enabled = false;
            this.UserNameTxbx.Location = new System.Drawing.Point(10, 109);
            this.UserNameTxbx.MaxLength = 2147483647;
            this.UserNameTxbx.Name = "UserNameTxbx";
            this.UserNameTxbx.Size = new System.Drawing.Size(234, 26);
            this.UserNameTxbx.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectUserLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(192, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(368, 92);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected User";
            // 
            // SelectUserLabel
            // 
            this.SelectUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectUserLabel.AutoSize = true;
            this.SelectUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectUserLabel.Enabled = false;
            this.SelectUserLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectUserLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SelectUserLabel.Location = new System.Drawing.Point(44, 38);
            this.SelectUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectUserLabel.Name = "SelectUserLabel";
            this.SelectUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectUserLabel.Size = new System.Drawing.Size(29, 36);
            this.SelectUserLabel.TabIndex = 0;
            this.SelectUserLabel.Text = "?";
            this.SelectUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TotUserRegistered);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(22, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(153, 105);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logged Users.";
            // 
            // TotUserRegistered
            // 
            this.TotUserRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotUserRegistered.AutoSize = true;
            this.TotUserRegistered.BackColor = System.Drawing.Color.Transparent;
            this.TotUserRegistered.Enabled = false;
            this.TotUserRegistered.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotUserRegistered.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotUserRegistered.Location = new System.Drawing.Point(58, 38);
            this.TotUserRegistered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotUserRegistered.Name = "TotUserRegistered";
            this.TotUserRegistered.Size = new System.Drawing.Size(29, 36);
            this.TotUserRegistered.TabIndex = 0;
            this.TotUserRegistered.Text = "?";
            this.TotUserRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MottoTxbx
            // 
            this.MottoTxbx.Enabled = false;
            this.MottoTxbx.Location = new System.Drawing.Point(7, 168);
            this.MottoTxbx.MaxLength = 2147483647;
            this.MottoTxbx.Name = "MottoTxbx";
            this.MottoTxbx.Size = new System.Drawing.Size(234, 26);
            this.MottoTxbx.TabIndex = 26;
            // 
            // LookTxbx
            // 
            this.LookTxbx.Enabled = false;
            this.LookTxbx.Location = new System.Drawing.Point(7, 233);
            this.LookTxbx.MaxLength = 2147483647;
            this.LookTxbx.Name = "LookTxbx";
            this.LookTxbx.Size = new System.Drawing.Size(234, 26);
            this.LookTxbx.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Motto";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Enabled = false;
            this.Label3.Location = new System.Drawing.Point(3, 210);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 20);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Look";
            // 
            // BanUserForSpamBtn
            // 
            this.BanUserForSpamBtn.Enabled = false;
            this.BanUserForSpamBtn.Location = new System.Drawing.Point(20, 36);
            this.BanUserForSpamBtn.Name = "BanUserForSpamBtn";
            this.BanUserForSpamBtn.Size = new System.Drawing.Size(189, 39);
            this.BanUserForSpamBtn.TabIndex = 1;
            this.BanUserForSpamBtn.Text = "Ban per SPAM";
            this.BanUserForSpamBtn.Click += new System.EventHandler(this.BanUserForSpamBtn_Click);
            // 
            // FloodBtn
            // 
            this.FloodBtn.Enabled = false;
            this.FloodBtn.Location = new System.Drawing.Point(925, 44);
            this.FloodBtn.Name = "FloodBtn";
            this.FloodBtn.Size = new System.Drawing.Size(160, 37);
            this.FloodBtn.TabIndex = 0;
            this.FloodBtn.Text = "Flooda x25";
            this.FloodBtn.Click += new System.EventHandler(this.FloodBtn_Click);
            // 
            // MuteUserBtn
            // 
            this.MuteUserBtn.Enabled = false;
            this.MuteUserBtn.Location = new System.Drawing.Point(6, 171);
            this.MuteUserBtn.Name = "MuteUserBtn";
            this.MuteUserBtn.Size = new System.Drawing.Size(228, 40);
            this.MuteUserBtn.TabIndex = 31;
            this.MuteUserBtn.Text = "Muta Utente";
            this.MuteUserBtn.Click += new System.EventHandler(this.MuteUserBtn_click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnmuteUserBtn);
            this.groupBox2.Controls.Add(this.MuteTimeCmbx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.MuteUserBtn);
            this.groupBox2.Controls.Add(this.MutaUtenteTimerNbx);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(362, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 282);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muta Utente";
            // 
            // UnmuteUserBtn
            // 
            this.UnmuteUserBtn.Enabled = false;
            this.UnmuteUserBtn.Location = new System.Drawing.Point(6, 233);
            this.UnmuteUserBtn.Name = "UnmuteUserBtn";
            this.UnmuteUserBtn.Size = new System.Drawing.Size(228, 40);
            this.UnmuteUserBtn.TabIndex = 93;
            this.UnmuteUserBtn.Text = "Smuta Utente";
            this.UnmuteUserBtn.Click += new System.EventHandler(this.UnmuteUserBtn_Click);
            // 
            // MuteTimeCmbx
            // 
            this.MuteTimeCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MuteTimeCmbx.Enabled = false;
            this.MuteTimeCmbx.FormattingEnabled = true;
            this.MuteTimeCmbx.Location = new System.Drawing.Point(10, 57);
            this.MuteTimeCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MuteTimeCmbx.Name = "MuteTimeCmbx";
            this.MuteTimeCmbx.Size = new System.Drawing.Size(164, 28);
            this.MuteTimeCmbx.TabIndex = 92;
            this.MuteTimeCmbx.SelectedIndexChanged += new System.EventHandler(this.MuteTimeCmbx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tempo in secondi";
            // 
            // MutaUtenteTimerNbx
            // 
            this.MutaUtenteTimerNbx.Enabled = false;
            this.MutaUtenteTimerNbx.Location = new System.Drawing.Point(6, 127);
            this.MutaUtenteTimerNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MutaUtenteTimerNbx.Name = "MutaUtenteTimerNbx";
            this.MutaUtenteTimerNbx.Size = new System.Drawing.Size(228, 26);
            this.MutaUtenteTimerNbx.TabIndex = 33;
            // 
            // Utente
            // 
            this.Utente.Controls.Add(this.label6);
            this.Utente.Controls.Add(this.UsersCmbx);
            this.Utente.Controls.Add(this.Label3);
            this.Utente.Controls.Add(this.label2);
            this.Utente.Controls.Add(this.label1);
            this.Utente.Controls.Add(this.LookTxbx);
            this.Utente.Controls.Add(this.MottoTxbx);
            this.Utente.Controls.Add(this.UserNameTxbx);
            this.Utente.Enabled = false;
            this.Utente.Location = new System.Drawing.Point(22, 128);
            this.Utente.Name = "Utente";
            this.Utente.Size = new System.Drawing.Size(257, 276);
            this.Utente.TabIndex = 33;
            this.Utente.TabStop = false;
            this.Utente.Text = "Dettagli Utente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Utenti usciti dalla stanza";
            // 
            // UsersCmbx
            // 
            this.UsersCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsersCmbx.Enabled = false;
            this.UsersCmbx.FormattingEnabled = true;
            this.UsersCmbx.Location = new System.Drawing.Point(10, 53);
            this.UsersCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsersCmbx.Name = "UsersCmbx";
            this.UsersCmbx.Size = new System.Drawing.Size(204, 28);
            this.UsersCmbx.TabIndex = 94;
            this.UsersCmbx.SelectedIndexChanged += new System.EventHandler(this.UsersCmbx_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.KickUserWithAlertBtn);
            this.groupBox3.Controls.Add(this.AlertBoxTxb);
            this.groupBox3.Controls.Add(this.AlertUserBtn);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(22, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 187);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alert Utente";
            // 
            // KickUserWithAlertBtn
            // 
            this.KickUserWithAlertBtn.Enabled = false;
            this.KickUserWithAlertBtn.Location = new System.Drawing.Point(6, 141);
            this.KickUserWithAlertBtn.Name = "KickUserWithAlertBtn";
            this.KickUserWithAlertBtn.Size = new System.Drawing.Size(294, 40);
            this.KickUserWithAlertBtn.TabIndex = 33;
            this.KickUserWithAlertBtn.Text = "Caccia con alert";
            this.KickUserWithAlertBtn.Click += new System.EventHandler(this.KickUserWithAlertBtn_Click);
            // 
            // AlertBoxTxb
            // 
            this.AlertBoxTxb.Enabled = false;
            this.AlertBoxTxb.Location = new System.Drawing.Point(6, 41);
            this.AlertBoxTxb.MaxLength = 2147483647;
            this.AlertBoxTxb.Name = "AlertBoxTxb";
            this.AlertBoxTxb.Size = new System.Drawing.Size(294, 26);
            this.AlertBoxTxb.TabIndex = 32;
            // 
            // AlertUserBtn
            // 
            this.AlertUserBtn.Enabled = false;
            this.AlertUserBtn.Location = new System.Drawing.Point(6, 82);
            this.AlertUserBtn.Name = "AlertUserBtn";
            this.AlertUserBtn.Size = new System.Drawing.Size(294, 40);
            this.AlertUserBtn.TabIndex = 31;
            this.AlertUserBtn.Text = "Alerta Utente";
            this.AlertUserBtn.Click += new System.EventHandler(this.AlertUserBtn_click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.banForInfoLeakBtn);
            this.groupBox5.Controls.Add(this.BanForNicknameNotAllowedBtn);
            this.groupBox5.Controls.Add(this.BanForSecurityLockBtn);
            this.groupBox5.Controls.Add(this.BanUserForSpamBtn);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(612, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 266);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preimpostati( Bannano utente al click)";
            // 
            // banForInfoLeakBtn
            // 
            this.banForInfoLeakBtn.Enabled = false;
            this.banForInfoLeakBtn.Location = new System.Drawing.Point(20, 216);
            this.banForInfoLeakBtn.Name = "banForInfoLeakBtn";
            this.banForInfoLeakBtn.Size = new System.Drawing.Size(240, 41);
            this.banForInfoLeakBtn.TabIndex = 34;
            this.banForInfoLeakBtn.Text = "Rilascio di informazioni Personali";
            this.banForInfoLeakBtn.Click += new System.EventHandler(this.banForInfoLeakBtn_Click);
            // 
            // BanForNicknameNotAllowedBtn
            // 
            this.BanForNicknameNotAllowedBtn.Enabled = false;
            this.BanForNicknameNotAllowedBtn.Location = new System.Drawing.Point(20, 152);
            this.BanForNicknameNotAllowedBtn.Name = "BanForNicknameNotAllowedBtn";
            this.BanForNicknameNotAllowedBtn.Size = new System.Drawing.Size(209, 41);
            this.BanForNicknameNotAllowedBtn.TabIndex = 33;
            this.BanForNicknameNotAllowedBtn.Text = "Username Non consentito";
            this.BanForNicknameNotAllowedBtn.Click += new System.EventHandler(this.BanForNicknameNotAllowedBtn_Click);
            // 
            // BanForSecurityLockBtn
            // 
            this.BanForSecurityLockBtn.Enabled = false;
            this.BanForSecurityLockBtn.Location = new System.Drawing.Point(20, 95);
            this.BanForSecurityLockBtn.Name = "BanForSecurityLockBtn";
            this.BanForSecurityLockBtn.Size = new System.Drawing.Size(209, 41);
            this.BanForSecurityLockBtn.TabIndex = 32;
            this.BanForSecurityLockBtn.Text = "Blocco Di sicurezza (SCAM)";
            this.BanForSecurityLockBtn.Click += new System.EventHandler(this.BanForSecurityLockBtn_Click);
            // 
            // ManualBanBtn
            // 
            this.ManualBanBtn.Enabled = false;
            this.ManualBanBtn.Location = new System.Drawing.Point(27, 236);
            this.ManualBanBtn.Name = "ManualBanBtn";
            this.ManualBanBtn.Size = new System.Drawing.Size(386, 40);
            this.ManualBanBtn.TabIndex = 31;
            this.ManualBanBtn.Text = "Ban Manuale ";
            this.ManualBanBtn.Click += new System.EventHandler(this.ManualBanBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.BanTimeManualNbx);
            this.groupBox6.Controls.Add(this.BantimeCmbx);
            this.groupBox6.Controls.Add(this.BanManualReasonTxb);
            this.groupBox6.Controls.Add(this.ManualBanBtn);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(644, 289);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(441, 299);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ban Manuale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "Motivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(23, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Tempo (in secondi)";
            // 
            // BanTimeManualNbx
            // 
            this.BanTimeManualNbx.Enabled = false;
            this.BanTimeManualNbx.Location = new System.Drawing.Point(27, 112);
            this.BanTimeManualNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.BanTimeManualNbx.Name = "BanTimeManualNbx";
            this.BanTimeManualNbx.Size = new System.Drawing.Size(386, 26);
            this.BanTimeManualNbx.TabIndex = 38;
            // 
            // BantimeCmbx
            // 
            this.BantimeCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BantimeCmbx.Enabled = false;
            this.BantimeCmbx.FormattingEnabled = true;
            this.BantimeCmbx.Location = new System.Drawing.Point(27, 32);
            this.BantimeCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BantimeCmbx.Name = "BantimeCmbx";
            this.BantimeCmbx.Size = new System.Drawing.Size(386, 28);
            this.BantimeCmbx.TabIndex = 89;
            this.BantimeCmbx.SelectedIndexChanged += new System.EventHandler(this.BantimeCmbx_SelectedIndexChanged);
            // 
            // BanManualReasonTxb
            // 
            this.BanManualReasonTxb.Enabled = false;
            this.BanManualReasonTxb.Location = new System.Drawing.Point(27, 185);
            this.BanManualReasonTxb.Name = "BanManualReasonTxb";
            this.BanManualReasonTxb.Size = new System.Drawing.Size(386, 26);
            this.BanManualReasonTxb.TabIndex = 32;
            // 
            // ModerationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.FloodBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Utente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "ModerationPage";
            this.Size = new System.Drawing.Size(1103, 612);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutaUtenteTimerNbx)).EndInit();
            this.Utente.ResumeLayout(false);
            this.Utente.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanTimeManualNbx)).EndInit();
            this.ResumeLayout(false);

        }

#endregion
        private System.Windows.Forms.TextBox UserNameTxbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelectUserLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TotUserRegistered;
        private System.Windows.Forms.TextBox MottoTxbx;
        private System.Windows.Forms.TextBox LookTxbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private Sulakore.Components.SKoreButton BanUserForSpamBtn;
        private Sulakore.Components.SKoreButton FloodBtn;
        private Sulakore.Components.SKoreButton MuteUserBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown MutaUtenteTimerNbx;
        private System.Windows.Forms.GroupBox Utente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sulakore.Components.SKoreButton AlertUserBtn;
        private System.Windows.Forms.TextBox AlertBoxTxb;
        private System.Windows.Forms.GroupBox groupBox5;
        private Sulakore.Components.SKoreButton banForInfoLeakBtn;
        private Sulakore.Components.SKoreButton BanForNicknameNotAllowedBtn;
        private Sulakore.Components.SKoreButton BanForSecurityLockBtn;
        private Sulakore.Components.SKoreButton ManualBanBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox BanManualReasonTxb;
        private System.Windows.Forms.ComboBox BantimeCmbx;
        private System.Windows.Forms.NumericUpDown BanTimeManualNbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Sulakore.Components.SKoreButton KickUserWithAlertBtn;
        private System.Windows.Forms.ComboBox MuteTimeCmbx;
        private Sulakore.Components.SKoreButton UnmuteUserBtn;
        private System.Windows.Forms.ComboBox UsersCmbx;
        private System.Windows.Forms.Label label6;
    }
}
