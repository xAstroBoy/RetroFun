namespace RetroFun.Pages
{
    partial class PersonalPage
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
            this.EnableModToolsBtn = new Sulakore.Components.SKoreButton();
            this.CreditsNbx = new System.Windows.Forms.NumericUpDown();
            this.CrystalsNbx = new System.Windows.Forms.NumericUpDown();
            this.DucketsNbx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.GroupBox();
            this.DucketsChbx = new System.Windows.Forms.CheckBox();
            this.CrystalsChbx = new System.Windows.Forms.CheckBox();
            this.CreditsChbx = new System.Windows.Forms.CheckBox();
            this.AcquireMODPermissionsBtn = new Sulakore.Components.SKoreButton();
            this.SetCurrencyBtn = new Sulakore.Components.SKoreButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TradeSpammerCooldownNbx = new System.Windows.Forms.NumericUpDown();
            this.UserIntUpDwn = new System.Windows.Forms.NumericUpDown();
            this.CaptureTradeUserBtn = new Sulakore.Components.SKoreButton();
            this.CrashUserBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalsNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DucketsNbx)).BeginInit();
            this.Currency.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSpammerCooldownNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIntUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableModToolsBtn
            // 
            this.EnableModToolsBtn.Location = new System.Drawing.Point(524, 110);
            this.EnableModToolsBtn.Name = "EnableModToolsBtn";
            this.EnableModToolsBtn.Size = new System.Drawing.Size(278, 33);
            this.EnableModToolsBtn.TabIndex = 0;
            this.EnableModToolsBtn.Text = "Show Mod Tools (CS)";
            this.EnableModToolsBtn.Click += new System.EventHandler(this.EnableModToolsBtn_Click);
            // 
            // CreditsNbx
            // 
            this.CreditsNbx.Location = new System.Drawing.Point(61, 36);
            this.CreditsNbx.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.CreditsNbx.Name = "CreditsNbx";
            this.CreditsNbx.Size = new System.Drawing.Size(261, 26);
            this.CreditsNbx.TabIndex = 1;
            // 
            // CrystalsNbx
            // 
            this.CrystalsNbx.Location = new System.Drawing.Point(61, 83);
            this.CrystalsNbx.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.CrystalsNbx.Name = "CrystalsNbx";
            this.CrystalsNbx.Size = new System.Drawing.Size(261, 26);
            this.CrystalsNbx.TabIndex = 2;
            // 
            // DucketsNbx
            // 
            this.DucketsNbx.Location = new System.Drawing.Point(61, 126);
            this.DucketsNbx.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.DucketsNbx.Name = "DucketsNbx";
            this.DucketsNbx.Size = new System.Drawing.Size(261, 26);
            this.DucketsNbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crystals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duckets";
            // 
            // Currency
            // 
            this.Currency.Controls.Add(this.DucketsChbx);
            this.Currency.Controls.Add(this.CrystalsChbx);
            this.Currency.Controls.Add(this.CreditsChbx);
            this.Currency.Controls.Add(this.CreditsNbx);
            this.Currency.Controls.Add(this.label3);
            this.Currency.Controls.Add(this.CrystalsNbx);
            this.Currency.Controls.Add(this.label2);
            this.Currency.Controls.Add(this.DucketsNbx);
            this.Currency.Controls.Add(this.label1);
            this.Currency.Location = new System.Drawing.Point(22, 25);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(402, 162);
            this.Currency.TabIndex = 7;
            this.Currency.TabStop = false;
            this.Currency.Text = "Currency Set (CLIENT SIDE)";
            // 
            // DucketsChbx
            // 
            this.DucketsChbx.AutoSize = true;
            this.DucketsChbx.Location = new System.Drawing.Point(24, 126);
            this.DucketsChbx.Name = "DucketsChbx";
            this.DucketsChbx.Size = new System.Drawing.Size(22, 21);
            this.DucketsChbx.TabIndex = 9;
            this.DucketsChbx.UseVisualStyleBackColor = true;
            // 
            // CrystalsChbx
            // 
            this.CrystalsChbx.AutoSize = true;
            this.CrystalsChbx.Location = new System.Drawing.Point(24, 83);
            this.CrystalsChbx.Name = "CrystalsChbx";
            this.CrystalsChbx.Size = new System.Drawing.Size(22, 21);
            this.CrystalsChbx.TabIndex = 8;
            this.CrystalsChbx.UseVisualStyleBackColor = true;
            // 
            // CreditsChbx
            // 
            this.CreditsChbx.AutoSize = true;
            this.CreditsChbx.Location = new System.Drawing.Point(24, 36);
            this.CreditsChbx.Name = "CreditsChbx";
            this.CreditsChbx.Size = new System.Drawing.Size(22, 21);
            this.CreditsChbx.TabIndex = 7;
            this.CreditsChbx.UseVisualStyleBackColor = true;
            // 
            // AcquireMODPermissionsBtn
            // 
            this.AcquireMODPermissionsBtn.Location = new System.Drawing.Point(524, 48);
            this.AcquireMODPermissionsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AcquireMODPermissionsBtn.Name = "AcquireMODPermissionsBtn";
            this.AcquireMODPermissionsBtn.Size = new System.Drawing.Size(278, 34);
            this.AcquireMODPermissionsBtn.TabIndex = 8;
            this.AcquireMODPermissionsBtn.Text = "Acquire MOD Permissions (CS)";
            this.AcquireMODPermissionsBtn.Click += new System.EventHandler(this.AcquireMODPermissionsBtn_Click);
            // 
            // SetCurrencyBtn
            // 
            this.SetCurrencyBtn.Location = new System.Drawing.Point(22, 203);
            this.SetCurrencyBtn.Name = "SetCurrencyBtn";
            this.SetCurrencyBtn.Size = new System.Drawing.Size(393, 33);
            this.SetCurrencyBtn.TabIndex = 9;
            this.SetCurrencyBtn.Text = "Set Currency (CS)";
            this.SetCurrencyBtn.Click += new System.EventHandler(this.SetCurrencyBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TradeSpammerCooldownNbx);
            this.groupBox4.Controls.Add(this.UserIntUpDwn);
            this.groupBox4.Controls.Add(this.CaptureTradeUserBtn);
            this.groupBox4.Controls.Add(this.CrashUserBtn);
            this.groupBox4.Location = new System.Drawing.Point(386, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 193);
            this.groupBox4.TabIndex = 81;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trade Spammer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cooldown";
            // 
            // TradeSpammerCooldownNbx
            // 
            this.TradeSpammerCooldownNbx.Location = new System.Drawing.Point(183, 140);
            this.TradeSpammerCooldownNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TradeSpammerCooldownNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TradeSpammerCooldownNbx.Name = "TradeSpammerCooldownNbx";
            this.TradeSpammerCooldownNbx.Size = new System.Drawing.Size(178, 26);
            this.TradeSpammerCooldownNbx.TabIndex = 75;
            this.TradeSpammerCooldownNbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // UserIntUpDwn
            // 
            this.UserIntUpDwn.Location = new System.Drawing.Point(183, 74);
            this.UserIntUpDwn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserIntUpDwn.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UserIntUpDwn.Name = "UserIntUpDwn";
            this.UserIntUpDwn.Size = new System.Drawing.Size(178, 26);
            this.UserIntUpDwn.TabIndex = 60;
            // 
            // CaptureTradeUserBtn
            // 
            this.CaptureTradeUserBtn.Location = new System.Drawing.Point(-3, 69);
            this.CaptureTradeUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaptureTradeUserBtn.Name = "CaptureTradeUserBtn";
            this.CaptureTradeUserBtn.Size = new System.Drawing.Size(178, 31);
            this.CaptureTradeUserBtn.TabIndex = 74;
            this.CaptureTradeUserBtn.Text = "Capture User";
            this.CaptureTradeUserBtn.Click += new System.EventHandler(this.CaptureTradeUserBtn_Click);
            // 
            // CrashUserBtn
            // 
            this.CrashUserBtn.Location = new System.Drawing.Point(183, 33);
            this.CrashUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CrashUserBtn.Name = "CrashUserBtn";
            this.CrashUserBtn.Size = new System.Drawing.Size(178, 31);
            this.CrashUserBtn.TabIndex = 74;
            this.CrashUserBtn.Text = "Spam Trade : OFF";
            this.CrashUserBtn.Click += new System.EventHandler(this.CrashUserBtn_Click);
            // 
            // PersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SetCurrencyBtn);
            this.Controls.Add(this.AcquireMODPermissionsBtn);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.EnableModToolsBtn);
            this.Name = "PersonalPage";
            this.Size = new System.Drawing.Size(832, 488);
            ((System.ComponentModel.ISupportInitialize)(this.CreditsNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalsNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DucketsNbx)).EndInit();
            this.Currency.ResumeLayout(false);
            this.Currency.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSpammerCooldownNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIntUpDwn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sulakore.Components.SKoreButton EnableModToolsBtn;
        private System.Windows.Forms.NumericUpDown CreditsNbx;
        private System.Windows.Forms.NumericUpDown CrystalsNbx;
        private System.Windows.Forms.NumericUpDown DucketsNbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Currency;
        private Sulakore.Components.SKoreButton AcquireMODPermissionsBtn;
        private System.Windows.Forms.CheckBox DucketsChbx;
        private System.Windows.Forms.CheckBox CrystalsChbx;
        private System.Windows.Forms.CheckBox CreditsChbx;
        private Sulakore.Components.SKoreButton SetCurrencyBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TradeSpammerCooldownNbx;
        private System.Windows.Forms.NumericUpDown UserIntUpDwn;
        private Sulakore.Components.SKoreButton CaptureTradeUserBtn;
        private Sulakore.Components.SKoreButton CrashUserBtn;
    }
}
