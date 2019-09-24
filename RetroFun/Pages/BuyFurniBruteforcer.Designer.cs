namespace RetroFun.Pages
{
    partial class BuyFurniBruteforcer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.furnITextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendPurchaseBtn = new Sulakore.Components.SKoreButton();
            this.PurchaseLoopCoolDown = new System.Windows.Forms.NumericUpDown();
            this.CataloguePageIdBruteforcerbtx = new Sulakore.Components.SKoreButton();
            this.CatalogueFurnIDBruteForcerbtx = new Sulakore.Components.SKoreButton();
            this.CatalogueBruteForceBtn = new Sulakore.Components.SKoreButton();
            this.CataloguePageIDBox = new System.Windows.Forms.NumericUpDown();
            this.CatalogueFurniIDBox = new System.Windows.Forms.NumericUpDown();
            this.CatalogueSButtonLoopToggle = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseLoopCoolDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataloguePageIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogueFurniIDBox)).BeginInit();
            this.SuspendLayout();
            // 
            // furnITextBox
            // 
            this.furnITextBox.Location = new System.Drawing.Point(334, 77);
            this.furnITextBox.Name = "furnITextBox";
            this.furnITextBox.Size = new System.Drawing.Size(123, 20);
            this.furnITextBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 52);
            this.label5.TabIndex = 36;
            this.label5.Text = "If The Furni supports text\r\nwrite here,\r\nelse \r\nleave blank as default\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "FurniID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "PageID";
            // 
            // SendPurchaseBtn
            // 
            this.SendPurchaseBtn.Location = new System.Drawing.Point(214, 218);
            this.SendPurchaseBtn.Name = "SendPurchaseBtn";
            this.SendPurchaseBtn.Size = new System.Drawing.Size(224, 20);
            this.SendPurchaseBtn.TabIndex = 26;
            this.SendPurchaseBtn.Text = "Purchase Item";
            this.SendPurchaseBtn.Click += new System.EventHandler(this.SendPurchaseBtn_Click);
            // 
            // PurchaseLoopCoolDown
            // 
            this.PurchaseLoopCoolDown.Location = new System.Drawing.Point(357, 105);
            this.PurchaseLoopCoolDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PurchaseLoopCoolDown.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.PurchaseLoopCoolDown.Name = "PurchaseLoopCoolDown";
            this.PurchaseLoopCoolDown.Size = new System.Drawing.Size(81, 20);
            this.PurchaseLoopCoolDown.TabIndex = 39;
            this.PurchaseLoopCoolDown.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            // 
            // CataloguePageIdBruteforcerbtx
            // 
            this.CataloguePageIdBruteforcerbtx.Location = new System.Drawing.Point(138, 105);
            this.CataloguePageIdBruteforcerbtx.Name = "CataloguePageIdBruteforcerbtx";
            this.CataloguePageIdBruteforcerbtx.Size = new System.Drawing.Size(169, 20);
            this.CataloguePageIdBruteforcerbtx.TabIndex = 40;
            this.CataloguePageIdBruteforcerbtx.Text = "PageID Bruteforcer : Disabled";
            this.CataloguePageIdBruteforcerbtx.Click += new System.EventHandler(this.CataloguePageIdBruteforcerbtx_Click);
            // 
            // CatalogueFurnIDBruteForcerbtx
            // 
            this.CatalogueFurnIDBruteForcerbtx.Location = new System.Drawing.Point(138, 141);
            this.CatalogueFurnIDBruteForcerbtx.Name = "CatalogueFurnIDBruteForcerbtx";
            this.CatalogueFurnIDBruteForcerbtx.Size = new System.Drawing.Size(169, 20);
            this.CatalogueFurnIDBruteForcerbtx.TabIndex = 41;
            this.CatalogueFurnIDBruteForcerbtx.Text = "FurniID Bruteforcer : Disabled";
            this.CatalogueFurnIDBruteForcerbtx.Click += new System.EventHandler(this.CatalogueFurnIDBruteForcerbtx_Click);
            // 
            // CatalogueBruteForceBtn
            // 
            this.CatalogueBruteForceBtn.Location = new System.Drawing.Point(98, 54);
            this.CatalogueBruteForceBtn.Name = "CatalogueBruteForceBtn";
            this.CatalogueBruteForceBtn.Size = new System.Drawing.Size(129, 20);
            this.CatalogueBruteForceBtn.TabIndex = 42;
            this.CatalogueBruteForceBtn.Text = "BruteForcer : Disabled";
            this.CatalogueBruteForceBtn.Click += new System.EventHandler(this.CatalogueBruteForceBtn_Click);
            // 
            // CataloguePageIDBox
            // 
            this.CataloguePageIDBox.Location = new System.Drawing.Point(12, 105);
            this.CataloguePageIDBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CataloguePageIDBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.CataloguePageIDBox.Name = "CataloguePageIDBox";
            this.CataloguePageIDBox.Size = new System.Drawing.Size(120, 20);
            this.CataloguePageIDBox.TabIndex = 43;
            // 
            // CatalogueFurniIDBox
            // 
            this.CatalogueFurniIDBox.Location = new System.Drawing.Point(12, 141);
            this.CatalogueFurniIDBox.Maximum = new decimal(new int[] {
            2147483647,
            2,
            0,
            0});
            this.CatalogueFurniIDBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.CatalogueFurniIDBox.Name = "CatalogueFurniIDBox";
            this.CatalogueFurniIDBox.Size = new System.Drawing.Size(120, 20);
            this.CatalogueFurniIDBox.TabIndex = 44;
            // 
            // CatalogueSButtonLoopToggle
            // 
            this.CatalogueSButtonLoopToggle.Location = new System.Drawing.Point(12, 218);
            this.CatalogueSButtonLoopToggle.Name = "CatalogueSButtonLoopToggle";
            this.CatalogueSButtonLoopToggle.Size = new System.Drawing.Size(169, 20);
            this.CatalogueSButtonLoopToggle.TabIndex = 38;
            this.CatalogueSButtonLoopToggle.Text = "Buy On loop : Disabled";
            this.CatalogueSButtonLoopToggle.Click += new System.EventHandler(this.CatalogueSButtonLoopToggle_Click);
            // 
            // BuyFurniBruteforcer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CatalogueFurniIDBox);
            this.Controls.Add(this.CataloguePageIDBox);
            this.Controls.Add(this.CatalogueBruteForceBtn);
            this.Controls.Add(this.CatalogueFurnIDBruteForcerbtx);
            this.Controls.Add(this.CataloguePageIdBruteforcerbtx);
            this.Controls.Add(this.PurchaseLoopCoolDown);
            this.Controls.Add(this.CatalogueSButtonLoopToggle);
            this.Controls.Add(this.furnITextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendPurchaseBtn);
            this.Name = "BuyFurniBruteforcer";
            this.Size = new System.Drawing.Size(477, 257);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseLoopCoolDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataloguePageIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogueFurniIDBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox furnITextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sulakore.Components.SKoreButton SendPurchaseBtn;
        private System.Windows.Forms.NumericUpDown PurchaseLoopCoolDown;
        private Sulakore.Components.SKoreButton CataloguePageIdBruteforcerbtx;
        private Sulakore.Components.SKoreButton CatalogueFurnIDBruteForcerbtx;
        private Sulakore.Components.SKoreButton CatalogueBruteForceBtn;
        private System.Windows.Forms.NumericUpDown CataloguePageIDBox;
        private System.Windows.Forms.NumericUpDown CatalogueFurniIDBox;
        private Sulakore.Components.SKoreButton CatalogueSButtonLoopToggle;
    }
}
