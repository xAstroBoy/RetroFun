namespace RetroFun.Pages
{
    partial class PetPage
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
            this.BuyPetBtn = new Sulakore.Components.SKoreButton();
            this.PetIdNbx = new System.Windows.Forms.NumericUpDown();
            this.PageIDNbx = new System.Windows.Forms.NumericUpDown();
            this.PetNameTbx = new System.Windows.Forms.TextBox();
            this.PetColorHTMLTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PetRaceNbx = new System.Windows.Forms.NumericUpDown();
            this.InterceptPetPurchaseBtn = new Sulakore.Components.SKoreButton();
            this.ChoosePetColorBtn = new Sulakore.Components.SKoreButton();
            this.PetColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageIDNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetRaceNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyPetBtn
            // 
            this.BuyPetBtn.Location = new System.Drawing.Point(6, 402);
            this.BuyPetBtn.Name = "BuyPetBtn";
            this.BuyPetBtn.Size = new System.Drawing.Size(194, 42);
            this.BuyPetBtn.TabIndex = 0;
            this.BuyPetBtn.Text = "Buy Pet";
            this.BuyPetBtn.Click += new System.EventHandler(this.BuyPetBtn_Click);
            // 
            // PetIdNbx
            // 
            this.PetIdNbx.Location = new System.Drawing.Point(22, 125);
            this.PetIdNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PetIdNbx.Name = "PetIdNbx";
            this.PetIdNbx.Size = new System.Drawing.Size(120, 26);
            this.PetIdNbx.TabIndex = 1;
            // 
            // PageIDNbx
            // 
            this.PageIDNbx.Location = new System.Drawing.Point(22, 64);
            this.PageIDNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PageIDNbx.Name = "PageIDNbx";
            this.PageIDNbx.Size = new System.Drawing.Size(143, 26);
            this.PageIDNbx.TabIndex = 2;
            // 
            // PetNameTbx
            // 
            this.PetNameTbx.Location = new System.Drawing.Point(22, 209);
            this.PetNameTbx.MaxLength = 2147483647;
            this.PetNameTbx.Name = "PetNameTbx";
            this.PetNameTbx.Size = new System.Drawing.Size(155, 26);
            this.PetNameTbx.TabIndex = 3;
            // 
            // PetColorHTMLTbx
            // 
            this.PetColorHTMLTbx.Location = new System.Drawing.Point(22, 333);
            this.PetColorHTMLTbx.MaxLength = 2147483647;
            this.PetColorHTMLTbx.Name = "PetColorHTMLTbx";
            this.PetColorHTMLTbx.Size = new System.Drawing.Size(155, 26);
            this.PetColorHTMLTbx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "PageID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PetID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pet Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pet Race";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pet HTML Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PetRaceNbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PetColorHTMLTbx);
            this.groupBox1.Controls.Add(this.PetNameTbx);
            this.groupBox1.Controls.Add(this.PageIDNbx);
            this.groupBox1.Controls.Add(this.PetIdNbx);
            this.groupBox1.Controls.Add(this.BuyPetBtn);
            this.groupBox1.Location = new System.Drawing.Point(16, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 464);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Editor";
            // 
            // PetRaceNbx
            // 
            this.PetRaceNbx.Location = new System.Drawing.Point(22, 269);
            this.PetRaceNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PetRaceNbx.Name = "PetRaceNbx";
            this.PetRaceNbx.Size = new System.Drawing.Size(143, 26);
            this.PetRaceNbx.TabIndex = 11;
            // 
            // InterceptPetPurchaseBtn
            // 
            this.InterceptPetPurchaseBtn.Location = new System.Drawing.Point(288, 424);
            this.InterceptPetPurchaseBtn.Name = "InterceptPetPurchaseBtn";
            this.InterceptPetPurchaseBtn.Size = new System.Drawing.Size(239, 42);
            this.InterceptPetPurchaseBtn.TabIndex = 11;
            this.InterceptPetPurchaseBtn.Text = "Intercept Pet purchase : OFF";
            this.InterceptPetPurchaseBtn.Click += new System.EventHandler(this.InterceptPetPurchaseBtn_Click);
            // 
            // ChoosePetColorBtn
            // 
            this.ChoosePetColorBtn.Location = new System.Drawing.Point(310, 330);
            this.ChoosePetColorBtn.Name = "ChoosePetColorBtn";
            this.ChoosePetColorBtn.Size = new System.Drawing.Size(151, 51);
            this.ChoosePetColorBtn.TabIndex = 12;
            this.ChoosePetColorBtn.Text = "Select Color";
            this.ChoosePetColorBtn.Click += new System.EventHandler(this.ChoosePetColorBtn_Click);
            // 
            // PetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChoosePetColorBtn);
            this.Controls.Add(this.InterceptPetPurchaseBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "PetPage";
            this.Size = new System.Drawing.Size(906, 522);
            ((System.ComponentModel.ISupportInitialize)(this.PetIdNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageIDNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetRaceNbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sulakore.Components.SKoreButton BuyPetBtn;
        private System.Windows.Forms.NumericUpDown PetIdNbx;
        private System.Windows.Forms.NumericUpDown PageIDNbx;
        private System.Windows.Forms.TextBox PetNameTbx;
        private System.Windows.Forms.TextBox PetColorHTMLTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sulakore.Components.SKoreButton InterceptPetPurchaseBtn;
        private System.Windows.Forms.NumericUpDown PetRaceNbx;
        private Sulakore.Components.SKoreButton ChoosePetColorBtn;
        private System.Windows.Forms.ColorDialog PetColor;
    }
}
