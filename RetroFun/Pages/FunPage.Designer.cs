namespace RetroFun.Pages
{
    partial class FunPage
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
            this.EnableOnLoopBtn = new Sulakore.Components.SKoreButton();
            this.EnableNbx = new System.Windows.Forms.NumericUpDown();
            this.EnableAdd1Btn = new Sulakore.Components.SKoreButton();
            this.EnableSub1Btn = new Sulakore.Components.SKoreButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GiveAllEffectToUserBtn = new Sulakore.Components.SKoreButton();
            this.SetEffectToClickedUserbtn = new Sulakore.Components.SKoreButton();
            this.GiveEffectToAllUsersBtn = new Sulakore.Components.SKoreButton();
            this.IsServerSideBtn = new Sulakore.Components.SKoreButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SetEnableBtn = new Sulakore.Components.SKoreButton();
            this.CooldownEffectNbx = new System.Windows.Forms.NumericUpDown();
            this.LiveEditBtn = new Sulakore.Components.SKoreButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RestoreUsersBtn = new Sulakore.Components.SKoreButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PetColorChbx = new System.Windows.Forms.CheckBox();
            this.PetColorTxb = new System.Windows.Forms.TextBox();
            this.KnownPetsCmbx = new System.Windows.Forms.ComboBox();
            this.PetIDChbx = new System.Windows.Forms.CheckBox();
            this.PetIdNbx = new System.Windows.Forms.NumericUpDown();
            this.PetTypeIdNbx = new System.Windows.Forms.NumericUpDown();
            this.TransformAllUserIntoPetsBtn = new Sulakore.Components.SKoreButton();
            this.SetPetColorBtn = new Sulakore.Components.SKoreButton();
            this.EnableTellerChbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnableNbx)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownEffectNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetTypeIdNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableOnLoopBtn
            // 
            this.EnableOnLoopBtn.Location = new System.Drawing.Point(16, 164);
            this.EnableOnLoopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableOnLoopBtn.Name = "EnableOnLoopBtn";
            this.EnableOnLoopBtn.Size = new System.Drawing.Size(199, 31);
            this.EnableOnLoopBtn.TabIndex = 77;
            this.EnableOnLoopBtn.Text = "Enable Effect On loop : OFF";
            this.EnableOnLoopBtn.Click += new System.EventHandler(this.EnableOnLoopBtn_Click);
            // 
            // EnableNbx
            // 
            this.EnableNbx.Location = new System.Drawing.Point(24, 75);
            this.EnableNbx.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.EnableNbx.Name = "EnableNbx";
            this.EnableNbx.Size = new System.Drawing.Size(172, 26);
            this.EnableNbx.TabIndex = 10;
            this.EnableNbx.ValueChanged += new System.EventHandler(this.EnableNbx_ValueChanged);
            // 
            // EnableAdd1Btn
            // 
            this.EnableAdd1Btn.Location = new System.Drawing.Point(24, 108);
            this.EnableAdd1Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableAdd1Btn.Name = "EnableAdd1Btn";
            this.EnableAdd1Btn.Size = new System.Drawing.Size(41, 31);
            this.EnableAdd1Btn.TabIndex = 95;
            this.EnableAdd1Btn.Text = " + 1";
            this.EnableAdd1Btn.Click += new System.EventHandler(this.EnableAdd1Btn_Click);
            // 
            // EnableSub1Btn
            // 
            this.EnableSub1Btn.Location = new System.Drawing.Point(92, 108);
            this.EnableSub1Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableSub1Btn.Name = "EnableSub1Btn";
            this.EnableSub1Btn.Size = new System.Drawing.Size(42, 31);
            this.EnableSub1Btn.TabIndex = 96;
            this.EnableSub1Btn.Text = " - 1";
            this.EnableSub1Btn.Click += new System.EventHandler(this.EnableSub1Btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EnableTellerChbx);
            this.groupBox5.Controls.Add(this.GiveAllEffectToUserBtn);
            this.groupBox5.Controls.Add(this.SetEffectToClickedUserbtn);
            this.groupBox5.Controls.Add(this.GiveEffectToAllUsersBtn);
            this.groupBox5.Controls.Add(this.IsServerSideBtn);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.SetEnableBtn);
            this.groupBox5.Controls.Add(this.EnableSub1Btn);
            this.groupBox5.Controls.Add(this.CooldownEffectNbx);
            this.groupBox5.Controls.Add(this.EnableAdd1Btn);
            this.groupBox5.Controls.Add(this.EnableNbx);
            this.groupBox5.Controls.Add(this.LiveEditBtn);
            this.groupBox5.Controls.Add(this.EnableOnLoopBtn);
            this.groupBox5.Location = new System.Drawing.Point(17, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(517, 342);
            this.groupBox5.TabIndex = 97;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Effects";
            // 
            // GiveAllEffectToUserBtn
            // 
            this.GiveAllEffectToUserBtn.Location = new System.Drawing.Point(244, 253);
            this.GiveAllEffectToUserBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GiveAllEffectToUserBtn.Name = "GiveAllEffectToUserBtn";
            this.GiveAllEffectToUserBtn.Size = new System.Drawing.Size(237, 31);
            this.GiveAllEffectToUserBtn.TabIndex = 104;
            this.GiveAllEffectToUserBtn.Text = "Give Effect To All Users  : OFF";
            this.GiveAllEffectToUserBtn.Click += new System.EventHandler(this.GiveAllEffectToUserBtn_Click);
            // 
            // SetEffectToClickedUserbtn
            // 
            this.SetEffectToClickedUserbtn.Location = new System.Drawing.Point(244, 146);
            this.SetEffectToClickedUserbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetEffectToClickedUserbtn.Name = "SetEffectToClickedUserbtn";
            this.SetEffectToClickedUserbtn.Size = new System.Drawing.Size(258, 32);
            this.SetEffectToClickedUserbtn.TabIndex = 103;
            this.SetEffectToClickedUserbtn.Text = "Give Effect To Clicked User : OFF";
            this.SetEffectToClickedUserbtn.Click += new System.EventHandler(this.SetEffectToClickedUserbtn_Click);
            // 
            // GiveEffectToAllUsersBtn
            // 
            this.GiveEffectToAllUsersBtn.Location = new System.Drawing.Point(244, 203);
            this.GiveEffectToAllUsersBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GiveEffectToAllUsersBtn.Name = "GiveEffectToAllUsersBtn";
            this.GiveEffectToAllUsersBtn.Size = new System.Drawing.Size(199, 31);
            this.GiveEffectToAllUsersBtn.TabIndex = 102;
            this.GiveEffectToAllUsersBtn.Text = "Give Effect To All Users";
            this.GiveEffectToAllUsersBtn.Click += new System.EventHandler(this.GiveEffectToAllUsersBtn_Click);
            // 
            // IsServerSideBtn
            // 
            this.IsServerSideBtn.Location = new System.Drawing.Point(244, 36);
            this.IsServerSideBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IsServerSideBtn.Name = "IsServerSideBtn";
            this.IsServerSideBtn.Size = new System.Drawing.Size(199, 31);
            this.IsServerSideBtn.TabIndex = 101;
            this.IsServerSideBtn.Text = "Server Side : OFF";
            this.IsServerSideBtn.Click += new System.EventHandler(this.IsServerSideBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Loop Cooldown";
            // 
            // SetEnableBtn
            // 
            this.SetEnableBtn.Location = new System.Drawing.Point(16, 36);
            this.SetEnableBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetEnableBtn.Name = "SetEnableBtn";
            this.SetEnableBtn.Size = new System.Drawing.Size(199, 31);
            this.SetEnableBtn.TabIndex = 97;
            this.SetEnableBtn.Text = "Set Effect";
            this.SetEnableBtn.Click += new System.EventHandler(this.SetEnableBtn_Click);
            // 
            // CooldownEffectNbx
            // 
            this.CooldownEffectNbx.Location = new System.Drawing.Point(16, 223);
            this.CooldownEffectNbx.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.CooldownEffectNbx.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CooldownEffectNbx.Name = "CooldownEffectNbx";
            this.CooldownEffectNbx.Size = new System.Drawing.Size(199, 26);
            this.CooldownEffectNbx.TabIndex = 99;
            this.CooldownEffectNbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // LiveEditBtn
            // 
            this.LiveEditBtn.Location = new System.Drawing.Point(244, 93);
            this.LiveEditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LiveEditBtn.Name = "LiveEditBtn";
            this.LiveEditBtn.Size = new System.Drawing.Size(199, 31);
            this.LiveEditBtn.TabIndex = 98;
            this.LiveEditBtn.Text = "Live Edit : OFF";
            this.LiveEditBtn.Click += new System.EventHandler(this.LiveEditBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RestoreUsersBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PetColorChbx);
            this.groupBox1.Controls.Add(this.PetColorTxb);
            this.groupBox1.Controls.Add(this.KnownPetsCmbx);
            this.groupBox1.Controls.Add(this.PetIDChbx);
            this.groupBox1.Controls.Add(this.PetIdNbx);
            this.groupBox1.Controls.Add(this.PetTypeIdNbx);
            this.groupBox1.Controls.Add(this.TransformAllUserIntoPetsBtn);
            this.groupBox1.Controls.Add(this.SetPetColorBtn);
            this.groupBox1.Location = new System.Drawing.Point(597, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 381);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effects";
            // 
            // RestoreUsersBtn
            // 
            this.RestoreUsersBtn.Location = new System.Drawing.Point(263, 276);
            this.RestoreUsersBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RestoreUsersBtn.Name = "RestoreUsersBtn";
            this.RestoreUsersBtn.Size = new System.Drawing.Size(199, 31);
            this.RestoreUsersBtn.TabIndex = 114;
            this.RestoreUsersBtn.Text = "Restore Users";
            this.RestoreUsersBtn.Click += new System.EventHandler(this.RestoreUsersBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "PetTypeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "PetID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Pet Color";
            // 
            // PetColorChbx
            // 
            this.PetColorChbx.AutoSize = true;
            this.PetColorChbx.Location = new System.Drawing.Point(9, 318);
            this.PetColorChbx.Name = "PetColorChbx";
            this.PetColorChbx.Size = new System.Drawing.Size(200, 24);
            this.PetColorChbx.TabIndex = 110;
            this.PetColorChbx.Text = "Use Selected Pet Color";
            this.PetColorChbx.UseVisualStyleBackColor = true;
            // 
            // PetColorTxb
            // 
            this.PetColorTxb.Location = new System.Drawing.Point(9, 276);
            this.PetColorTxb.Name = "PetColorTxb";
            this.PetColorTxb.Size = new System.Drawing.Size(179, 26);
            this.PetColorTxb.TabIndex = 109;
            // 
            // KnownPetsCmbx
            // 
            this.KnownPetsCmbx.FormattingEnabled = true;
            this.KnownPetsCmbx.Location = new System.Drawing.Point(263, 156);
            this.KnownPetsCmbx.Name = "KnownPetsCmbx";
            this.KnownPetsCmbx.Size = new System.Drawing.Size(213, 28);
            this.KnownPetsCmbx.TabIndex = 106;
            this.KnownPetsCmbx.SelectedIndexChanged += new System.EventHandler(this.KnownPetsCmbx_SelectedIndexChanged);
            // 
            // PetIDChbx
            // 
            this.PetIDChbx.AutoSize = true;
            this.PetIDChbx.Location = new System.Drawing.Point(8, 122);
            this.PetIDChbx.Name = "PetIDChbx";
            this.PetIDChbx.Size = new System.Drawing.Size(180, 24);
            this.PetIDChbx.TabIndex = 107;
            this.PetIDChbx.Text = "Use Selected Pet ID";
            this.PetIDChbx.UseVisualStyleBackColor = true;
            // 
            // PetIdNbx
            // 
            this.PetIdNbx.Location = new System.Drawing.Point(8, 86);
            this.PetIdNbx.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.PetIdNbx.Name = "PetIdNbx";
            this.PetIdNbx.Size = new System.Drawing.Size(172, 26);
            this.PetIdNbx.TabIndex = 105;
            // 
            // PetTypeIdNbx
            // 
            this.PetTypeIdNbx.Location = new System.Drawing.Point(8, 189);
            this.PetTypeIdNbx.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.PetTypeIdNbx.Name = "PetTypeIdNbx";
            this.PetTypeIdNbx.Size = new System.Drawing.Size(172, 26);
            this.PetTypeIdNbx.TabIndex = 104;
            // 
            // TransformAllUserIntoPetsBtn
            // 
            this.TransformAllUserIntoPetsBtn.Location = new System.Drawing.Point(254, 75);
            this.TransformAllUserIntoPetsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransformAllUserIntoPetsBtn.Name = "TransformAllUserIntoPetsBtn";
            this.TransformAllUserIntoPetsBtn.Size = new System.Drawing.Size(258, 31);
            this.TransformAllUserIntoPetsBtn.TabIndex = 102;
            this.TransformAllUserIntoPetsBtn.Text = "Transform All users In Pets : OFF";
            this.TransformAllUserIntoPetsBtn.Click += new System.EventHandler(this.TransformAllUserIntoPetsBtn_Click);
            // 
            // SetPetColorBtn
            // 
            this.SetPetColorBtn.Location = new System.Drawing.Point(263, 218);
            this.SetPetColorBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetPetColorBtn.Name = "SetPetColorBtn";
            this.SetPetColorBtn.Size = new System.Drawing.Size(199, 31);
            this.SetPetColorBtn.TabIndex = 98;
            this.SetPetColorBtn.Text = "Set Pet Color";
            this.SetPetColorBtn.Click += new System.EventHandler(this.SetPetColorBtn_Click);
            // 
            // EnableTellerChbx
            // 
            this.EnableTellerChbx.AutoSize = true;
            this.EnableTellerChbx.Location = new System.Drawing.Point(24, 312);
            this.EnableTellerChbx.Name = "EnableTellerChbx";
            this.EnableTellerChbx.Size = new System.Drawing.Size(274, 24);
            this.EnableTellerChbx.TabIndex = 105;
            this.EnableTellerChbx.Text = "Tell Enable Of User entering room";
            this.EnableTellerChbx.UseVisualStyleBackColor = true;
            // 
            // FunPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "FunPage";
            this.Size = new System.Drawing.Size(1300, 627);
            ((System.ComponentModel.ISupportInitialize)(this.EnableNbx)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownEffectNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetIdNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetTypeIdNbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sulakore.Components.SKoreButton EnableOnLoopBtn;
        private System.Windows.Forms.NumericUpDown EnableNbx;
        private Sulakore.Components.SKoreButton EnableAdd1Btn;
        private Sulakore.Components.SKoreButton EnableSub1Btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private Sulakore.Components.SKoreButton LiveEditBtn;
        private Sulakore.Components.SKoreButton SetEnableBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CooldownEffectNbx;
        private Sulakore.Components.SKoreButton IsServerSideBtn;
        private Sulakore.Components.SKoreButton GiveEffectToAllUsersBtn;
        private Sulakore.Components.SKoreButton SetEffectToClickedUserbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PetColorChbx;
        private System.Windows.Forms.TextBox PetColorTxb;
        private System.Windows.Forms.ComboBox KnownPetsCmbx;
        private System.Windows.Forms.CheckBox PetIDChbx;
        private System.Windows.Forms.NumericUpDown PetIdNbx;
        private System.Windows.Forms.NumericUpDown PetTypeIdNbx;
        private Sulakore.Components.SKoreButton TransformAllUserIntoPetsBtn;
        private Sulakore.Components.SKoreButton SetPetColorBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sulakore.Components.SKoreButton RestoreUsersBtn;
        private Sulakore.Components.SKoreButton GiveAllEffectToUserBtn;
        private System.Windows.Forms.CheckBox EnableTellerChbx;
    }
}
