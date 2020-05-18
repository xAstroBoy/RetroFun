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
            this.CaptureRoomBGBtn = new Sulakore.Components.SKoreButton();
            this.SetRoomBGBtn = new Sulakore.Components.SKoreButton();
            this.LiveEditBtn = new Sulakore.Components.SKoreButton();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomBGNBx = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomBGurlTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OffsetZNbx = new System.Windows.Forms.NumericUpDown();
            this.OffsetYNbx = new System.Windows.Forms.NumericUpDown();
            this.OffsetXNbx = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RoomBGXNbx = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftExchangerIDNBx)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsIDNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBGNBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetZNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBGXNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReedemGiftBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.GiftExchangerIDNBx);
            this.groupBox3.Controls.Add(this.AutoGiftExchangerBtn);
            this.groupBox3.Location = new System.Drawing.Point(224, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 236);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gift Exchanger";
            // 
            // ReedemGiftBtn
            // 
            this.ReedemGiftBtn.Location = new System.Drawing.Point(23, 120);
            this.ReedemGiftBtn.Name = "ReedemGiftBtn";
            this.ReedemGiftBtn.Size = new System.Drawing.Size(130, 20);
            this.ReedemGiftBtn.TabIndex = 12;
            this.ReedemGiftBtn.Text = "Redeem Gift.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gift ID";
            // 
            // GiftExchangerIDNBx
            // 
            this.GiftExchangerIDNBx.Location = new System.Drawing.Point(23, 85);
            this.GiftExchangerIDNBx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.GiftExchangerIDNBx.Name = "GiftExchangerIDNBx";
            this.GiftExchangerIDNBx.Size = new System.Drawing.Size(148, 20);
            this.GiftExchangerIDNBx.TabIndex = 10;
            // 
            // AutoGiftExchangerBtn
            // 
            this.AutoGiftExchangerBtn.AutoSize = true;
            this.AutoGiftExchangerBtn.Location = new System.Drawing.Point(23, 37);
            this.AutoGiftExchangerBtn.Name = "AutoGiftExchangerBtn";
            this.AutoGiftExchangerBtn.Size = new System.Drawing.Size(153, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(16, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 236);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credits Reedemer";
            // 
            // RedeemCreditsBtn
            // 
            this.RedeemCreditsBtn.Location = new System.Drawing.Point(23, 201);
            this.RedeemCreditsBtn.Name = "RedeemCreditsBtn";
            this.RedeemCreditsBtn.Size = new System.Drawing.Size(130, 20);
            this.RedeemCreditsBtn.TabIndex = 12;
            this.RedeemCreditsBtn.Text = "Redeem Credit.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Credit ID";
            // 
            // CreditsIDNbx
            // 
            this.CreditsIDNbx.Location = new System.Drawing.Point(23, 85);
            this.CreditsIDNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CreditsIDNbx.Name = "CreditsIDNbx";
            this.CreditsIDNbx.Size = new System.Drawing.Size(148, 20);
            this.CreditsIDNbx.TabIndex = 10;
            // 
            // MultiplierNbx
            // 
            this.MultiplierNbx.Location = new System.Drawing.Point(23, 157);
            this.MultiplierNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MultiplierNbx.Name = "MultiplierNbx";
            this.MultiplierNbx.Size = new System.Drawing.Size(148, 20);
            this.MultiplierNbx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Multiplier";
            // 
            // ExchangeMPChbx
            // 
            this.ExchangeMPChbx.AutoSize = true;
            this.ExchangeMPChbx.Location = new System.Drawing.Point(23, 120);
            this.ExchangeMPChbx.Name = "ExchangeMPChbx";
            this.ExchangeMPChbx.Size = new System.Drawing.Size(155, 21);
            this.ExchangeMPChbx.TabIndex = 7;
            this.ExchangeMPChbx.Text = "Exchange Credit Multiplier";
            this.ExchangeMPChbx.UseVisualStyleBackColor = true;
            // 
            // ExchangeCreditChbx
            // 
            this.ExchangeCreditChbx.AutoSize = true;
            this.ExchangeCreditChbx.Location = new System.Drawing.Point(23, 37);
            this.ExchangeCreditChbx.Name = "ExchangeCreditChbx";
            this.ExchangeCreditChbx.Size = new System.Drawing.Size(164, 21);
            this.ExchangeCreditChbx.TabIndex = 6;
            this.ExchangeCreditChbx.Text = "Automatic Credit Exchanger";
            this.ExchangeCreditChbx.UseVisualStyleBackColor = true;
            // 
            // CaptureRoomBGBtn
            // 
            this.CaptureRoomBGBtn.Location = new System.Drawing.Point(179, 168);
            this.CaptureRoomBGBtn.Name = "CaptureRoomBGBtn";
            this.CaptureRoomBGBtn.Size = new System.Drawing.Size(143, 20);
            this.CaptureRoomBGBtn.TabIndex = 66;
            this.CaptureRoomBGBtn.Text = "Capture RoomBG : OFF";
            this.CaptureRoomBGBtn.Click += new System.EventHandler(this.CaptureRoomBGBtn_Click);
            // 
            // SetRoomBGBtn
            // 
            this.SetRoomBGBtn.Location = new System.Drawing.Point(201, 261);
            this.SetRoomBGBtn.Name = "SetRoomBGBtn";
            this.SetRoomBGBtn.Size = new System.Drawing.Size(143, 20);
            this.SetRoomBGBtn.TabIndex = 65;
            this.SetRoomBGBtn.Text = "Set RoomBG";
            this.SetRoomBGBtn.Click += new System.EventHandler(this.SetRoomBGBtn_Click);
            // 
            // LiveEditBtn
            // 
            this.LiveEditBtn.Location = new System.Drawing.Point(24, 261);
            this.LiveEditBtn.Name = "LiveEditBtn";
            this.LiveEditBtn.Size = new System.Drawing.Size(143, 20);
            this.LiveEditBtn.TabIndex = 64;
            this.LiveEditBtn.Text = "Live Edit : OFF";
            this.LiveEditBtn.Click += new System.EventHandler(this.LiveEditBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "RoomBG ID";
            // 
            // RoomBGNBx
            // 
            this.RoomBGNBx.Location = new System.Drawing.Point(24, 28);
            this.RoomBGNBx.Maximum = new decimal(new int[] {
            2147483647,
            2,
            0,
            0});
            this.RoomBGNBx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.RoomBGNBx.Name = "RoomBGNBx";
            this.RoomBGNBx.Size = new System.Drawing.Size(120, 20);
            this.RoomBGNBx.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Image URL";
            // 
            // RoomBGurlTxb
            // 
            this.RoomBGurlTxb.Location = new System.Drawing.Point(24, 219);
            this.RoomBGurlTxb.Margin = new System.Windows.Forms.Padding(2);
            this.RoomBGurlTxb.Name = "RoomBGurlTxb";
            this.RoomBGurlTxb.Size = new System.Drawing.Size(286, 20);
            this.RoomBGurlTxb.TabIndex = 51;
            this.RoomBGurlTxb.TextChanged += new System.EventHandler(this.RoomBGUrlTxb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Offset Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Offset Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Offset X";
            // 
            // OffsetZNbx
            // 
            this.OffsetZNbx.Location = new System.Drawing.Point(24, 168);
            this.OffsetZNbx.Maximum = new decimal(new int[] {
            2147483647,
            2,
            0,
            0});
            this.OffsetZNbx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.OffsetZNbx.Name = "OffsetZNbx";
            this.OffsetZNbx.Size = new System.Drawing.Size(120, 20);
            this.OffsetZNbx.TabIndex = 47;
            this.OffsetZNbx.ValueChanged += new System.EventHandler(this.OffsetZNbx_ValueChanged);
            // 
            // OffsetYNbx
            // 
            this.OffsetYNbx.Location = new System.Drawing.Point(24, 122);
            this.OffsetYNbx.Maximum = new decimal(new int[] {
            2147483647,
            2,
            0,
            0});
            this.OffsetYNbx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.OffsetYNbx.Name = "OffsetYNbx";
            this.OffsetYNbx.Size = new System.Drawing.Size(120, 20);
            this.OffsetYNbx.TabIndex = 46;
            this.OffsetYNbx.ValueChanged += new System.EventHandler(this.OffsetYNbx_ValueChanged);
            // 
            // OffsetXNbx
            // 
            this.OffsetXNbx.Location = new System.Drawing.Point(24, 75);
            this.OffsetXNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.OffsetXNbx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.OffsetXNbx.Name = "OffsetXNbx";
            this.OffsetXNbx.Size = new System.Drawing.Size(120, 20);
            this.OffsetXNbx.TabIndex = 45;
            this.OffsetXNbx.ValueChanged += new System.EventHandler(this.OffsetXNbx_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RoomBGXNbx);
            this.groupBox1.Controls.Add(this.CaptureRoomBGBtn);
            this.groupBox1.Controls.Add(this.SetRoomBGBtn);
            this.groupBox1.Controls.Add(this.LiveEditBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RoomBGNBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RoomBGurlTxb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.OffsetZNbx);
            this.groupBox1.Controls.Add(this.OffsetYNbx);
            this.groupBox1.Controls.Add(this.OffsetXNbx);
            this.groupBox1.Location = new System.Drawing.Point(423, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(348, 299);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Background Editor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Room BG x (NOT OFFSET)";
            this.label9.Visible = false;
            // 
            // RoomBGXNbx
            // 
            this.RoomBGXNbx.Location = new System.Drawing.Point(186, 44);
            this.RoomBGXNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.RoomBGXNbx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.RoomBGXNbx.Name = "RoomBGXNbx";
            this.RoomBGXNbx.Size = new System.Drawing.Size(120, 20);
            this.RoomBGXNbx.TabIndex = 67;
            this.RoomBGXNbx.Visible = false;
            // 
            // UtilitiesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UtilitiesPage";
            this.Size = new System.Drawing.Size(789, 346);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftExchangerIDNBx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsIDNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBGNBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetZNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomBGXNbx)).EndInit();
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
        private Sulakore.Components.SKoreButton CaptureRoomBGBtn;
        private Sulakore.Components.SKoreButton SetRoomBGBtn;
        private Sulakore.Components.SKoreButton LiveEditBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RoomBGNBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown OffsetZNbx;
        private System.Windows.Forms.NumericUpDown OffsetYNbx;
        private System.Windows.Forms.NumericUpDown OffsetXNbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RoomBGurlTxb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown RoomBGXNbx;
    }
}
