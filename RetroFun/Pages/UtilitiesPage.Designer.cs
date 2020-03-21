namespace RetroFun.Pages
{
    partial class UtilitiesPage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReedemGiftBtn = new Sulakore.Components.SKoreButton();
            this.label3 = new System.Windows.Forms.Label();
            this.GiftExchangerIDNBx = new System.Windows.Forms.NumericUpDown();
            this.AutoGiftExchangerBtn = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RedeemCreditsBtn = new Sulakore.Components.SKoreButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CreditsIDNbx = new System.Windows.Forms.NumericUpDown();
            this.MultiplierNbx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ExchangeMPChbx = new System.Windows.Forms.CheckBox();
            this.ExchangeCreditChbx = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftExchangerIDNBx)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsIDNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReedemGiftBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.GiftExchangerIDNBx);
            this.groupBox3.Controls.Add(this.AutoGiftExchangerBtn);
            this.groupBox3.Location = new System.Drawing.Point(336, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(282, 363);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gift Exchanger";
            // 
            // ReedemGiftBtn
            // 
            this.ReedemGiftBtn.Location = new System.Drawing.Point(34, 185);
            this.ReedemGiftBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReedemGiftBtn.Name = "ReedemGiftBtn";
            this.ReedemGiftBtn.Size = new System.Drawing.Size(195, 31);
            this.ReedemGiftBtn.TabIndex = 12;
            this.ReedemGiftBtn.Text = "Redeem Gift.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gift ID";
            // 
            // GiftExchangerIDNBx
            // 
            this.GiftExchangerIDNBx.Location = new System.Drawing.Point(34, 131);
            this.GiftExchangerIDNBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GiftExchangerIDNBx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.GiftExchangerIDNBx.Name = "GiftExchangerIDNBx";
            this.GiftExchangerIDNBx.Size = new System.Drawing.Size(222, 26);
            this.GiftExchangerIDNBx.TabIndex = 10;
            // 
            // AutoGiftExchangerBtn
            // 
            this.AutoGiftExchangerBtn.AutoSize = true;
            this.AutoGiftExchangerBtn.Location = new System.Drawing.Point(34, 57);
            this.AutoGiftExchangerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoGiftExchangerBtn.Name = "AutoGiftExchangerBtn";
            this.AutoGiftExchangerBtn.Size = new System.Drawing.Size(217, 24);
            this.AutoGiftExchangerBtn.TabIndex = 6;
            this.AutoGiftExchangerBtn.Text = "Automatic Gift Exchanger";
            this.AutoGiftExchangerBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RedeemCreditsBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CreditsIDNbx);
            this.groupBox2.Controls.Add(this.MultiplierNbx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ExchangeMPChbx);
            this.groupBox2.Controls.Add(this.ExchangeCreditChbx);
            this.groupBox2.Location = new System.Drawing.Point(24, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(282, 363);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credits Reedemer";
            // 
            // RedeemCreditsBtn
            // 
            this.RedeemCreditsBtn.Location = new System.Drawing.Point(34, 309);
            this.RedeemCreditsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedeemCreditsBtn.Name = "RedeemCreditsBtn";
            this.RedeemCreditsBtn.Size = new System.Drawing.Size(195, 31);
            this.RedeemCreditsBtn.TabIndex = 12;
            this.RedeemCreditsBtn.Text = "Redeem Credit.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Credit ID";
            // 
            // CreditsIDNbx
            // 
            this.CreditsIDNbx.Location = new System.Drawing.Point(34, 131);
            this.CreditsIDNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreditsIDNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CreditsIDNbx.Name = "CreditsIDNbx";
            this.CreditsIDNbx.Size = new System.Drawing.Size(222, 26);
            this.CreditsIDNbx.TabIndex = 10;
            // 
            // MultiplierNbx
            // 
            this.MultiplierNbx.Location = new System.Drawing.Point(34, 242);
            this.MultiplierNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MultiplierNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MultiplierNbx.Name = "MultiplierNbx";
            this.MultiplierNbx.Size = new System.Drawing.Size(222, 26);
            this.MultiplierNbx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Multiplier";
            // 
            // ExchangeMPChbx
            // 
            this.ExchangeMPChbx.AutoSize = true;
            this.ExchangeMPChbx.Location = new System.Drawing.Point(34, 185);
            this.ExchangeMPChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExchangeMPChbx.Name = "ExchangeMPChbx";
            this.ExchangeMPChbx.Size = new System.Drawing.Size(218, 24);
            this.ExchangeMPChbx.TabIndex = 7;
            this.ExchangeMPChbx.Text = "Exchange Credit Multiplier";
            this.ExchangeMPChbx.UseVisualStyleBackColor = true;
            // 
            // ExchangeCreditChbx
            // 
            this.ExchangeCreditChbx.AutoSize = true;
            this.ExchangeCreditChbx.Location = new System.Drawing.Point(34, 57);
            this.ExchangeCreditChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExchangeCreditChbx.Name = "ExchangeCreditChbx";
            this.ExchangeCreditChbx.Size = new System.Drawing.Size(233, 24);
            this.ExchangeCreditChbx.TabIndex = 6;
            this.ExchangeCreditChbx.Text = "Automatic Credit Exchanger";
            this.ExchangeCreditChbx.UseVisualStyleBackColor = true;
            // 
            // UtilitiesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UtilitiesPage";
            this.Size = new System.Drawing.Size(1089, 422);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftExchangerIDNBx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsIDNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierNbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private Sulakore.Components.SKoreButton ReedemGiftBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown GiftExchangerIDNBx;
        private System.Windows.Forms.CheckBox AutoGiftExchangerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sulakore.Components.SKoreButton RedeemCreditsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CreditsIDNbx;
        private System.Windows.Forms.NumericUpDown MultiplierNbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ExchangeMPChbx;
        private System.Windows.Forms.CheckBox ExchangeCreditChbx;
    }
}
