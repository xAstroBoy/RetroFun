namespace RetroFun.Pages
{
    partial class FurniSpawnPage
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
            this.components = new System.ComponentModel.Container();
            this.FurnIDnbx = new System.Windows.Forms.NumericUpDown();
            this.CoordXNbx = new System.Windows.Forms.NumericUpDown();
            this.CoordZNBx = new System.Windows.Forms.NumericUpDown();
            this.CoordYNbx = new System.Windows.Forms.NumericUpDown();
            this.SpawnFloorFurniBtn = new Sulakore.Components.SKoreButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RotationNbx = new System.Windows.Forms.NumericUpDown();
            this.RotationRight = new System.Windows.Forms.RadioButton();
            this.rotationLeft = new System.Windows.Forms.RadioButton();
            this.RotationDown = new System.Windows.Forms.RadioButton();
            this.RotationUp = new System.Windows.Forms.RadioButton();
            this.SetOwnUsernameBtn = new Sulakore.Components.SKoreButton();
            this.FurniOwnerTxbx = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SpawnFloorFurniOnClickBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.FurnIDnbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordXNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordZNBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordYNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // FurnIDnbx
            // 
            this.FurnIDnbx.Location = new System.Drawing.Point(24, 52);
            this.FurnIDnbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FurnIDnbx.Name = "FurnIDnbx";
            this.FurnIDnbx.Size = new System.Drawing.Size(277, 26);
            this.FurnIDnbx.TabIndex = 0;
            // 
            // CoordXNbx
            // 
            this.CoordXNbx.Location = new System.Drawing.Point(24, 115);
            this.CoordXNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CoordXNbx.Name = "CoordXNbx";
            this.CoordXNbx.Size = new System.Drawing.Size(80, 26);
            this.CoordXNbx.TabIndex = 1;
            // 
            // CoordZNBx
            // 
            this.CoordZNBx.Location = new System.Drawing.Point(24, 237);
            this.CoordZNBx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CoordZNBx.Name = "CoordZNBx";
            this.CoordZNBx.Size = new System.Drawing.Size(80, 26);
            this.CoordZNBx.TabIndex = 3;
            // 
            // CoordYNbx
            // 
            this.CoordYNbx.Location = new System.Drawing.Point(24, 174);
            this.CoordYNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CoordYNbx.Name = "CoordYNbx";
            this.CoordYNbx.Size = new System.Drawing.Size(80, 26);
            this.CoordYNbx.TabIndex = 2;
            // 
            // SpawnFloorFurniBtn
            // 
            this.SpawnFloorFurniBtn.Location = new System.Drawing.Point(24, 335);
            this.SpawnFloorFurniBtn.Name = "SpawnFloorFurniBtn";
            this.SpawnFloorFurniBtn.Size = new System.Drawing.Size(195, 35);
            this.SpawnFloorFurniBtn.TabIndex = 4;
            this.SpawnFloorFurniBtn.Text = "Spawn Floor Furni";
            this.SpawnFloorFurniBtn.Click += new System.EventHandler(this.SpawnFloorFurniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "FurniID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RotationNbx);
            this.groupBox1.Controls.Add(this.RotationRight);
            this.groupBox1.Controls.Add(this.rotationLeft);
            this.groupBox1.Controls.Add(this.RotationDown);
            this.groupBox1.Controls.Add(this.RotationUp);
            this.groupBox1.Location = new System.Drawing.Point(137, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(164, 145);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation";
            // 
            // RotationNbx
            // 
            this.RotationNbx.Enabled = false;
            this.RotationNbx.Location = new System.Drawing.Point(54, 65);
            this.RotationNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.RotationNbx.Name = "RotationNbx";
            this.RotationNbx.Size = new System.Drawing.Size(56, 26);
            this.RotationNbx.TabIndex = 13;
            // 
            // RotationRight
            // 
            this.RotationRight.AutoSize = true;
            this.RotationRight.Location = new System.Drawing.Point(117, 71);
            this.RotationRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotationRight.Name = "RotationRight";
            this.RotationRight.Size = new System.Drawing.Size(21, 20);
            this.RotationRight.TabIndex = 4;
            this.RotationRight.UseVisualStyleBackColor = true;
            this.RotationRight.CheckedChanged += new System.EventHandler(this.RotationRight_CheckedChanged);
            // 
            // rotationLeft
            // 
            this.rotationLeft.AutoSize = true;
            this.rotationLeft.Location = new System.Drawing.Point(26, 71);
            this.rotationLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotationLeft.Name = "rotationLeft";
            this.rotationLeft.Size = new System.Drawing.Size(21, 20);
            this.rotationLeft.TabIndex = 3;
            this.rotationLeft.UseVisualStyleBackColor = true;
            this.rotationLeft.CheckedChanged += new System.EventHandler(this.rotationLeft_CheckedChanged);
            // 
            // RotationDown
            // 
            this.RotationDown.AutoSize = true;
            this.RotationDown.Location = new System.Drawing.Point(68, 112);
            this.RotationDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotationDown.Name = "RotationDown";
            this.RotationDown.Size = new System.Drawing.Size(21, 20);
            this.RotationDown.TabIndex = 2;
            this.RotationDown.UseVisualStyleBackColor = true;
            this.RotationDown.CheckedChanged += new System.EventHandler(this.RotationDown_CheckedChanged);
            // 
            // RotationUp
            // 
            this.RotationUp.AutoSize = true;
            this.RotationUp.Checked = true;
            this.RotationUp.Location = new System.Drawing.Point(68, 29);
            this.RotationUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotationUp.Name = "RotationUp";
            this.RotationUp.Size = new System.Drawing.Size(21, 20);
            this.RotationUp.TabIndex = 1;
            this.RotationUp.TabStop = true;
            this.RotationUp.UseVisualStyleBackColor = true;
            this.RotationUp.CheckedChanged += new System.EventHandler(this.RotationUp_CheckedChanged);
            // 
            // SetOwnUsernameBtn
            // 
            this.SetOwnUsernameBtn.Location = new System.Drawing.Point(307, 276);
            this.SetOwnUsernameBtn.Name = "SetOwnUsernameBtn";
            this.SetOwnUsernameBtn.Size = new System.Drawing.Size(195, 37);
            this.SetOwnUsernameBtn.TabIndex = 10;
            this.SetOwnUsernameBtn.Text = "Set own username";
            this.SetOwnUsernameBtn.Click += new System.EventHandler(this.SetOwnUsernameBtn_Click);
            // 
            // FurniOwnerTxbx
            // 
            this.FurniOwnerTxbx.Location = new System.Drawing.Point(24, 287);
            this.FurniOwnerTxbx.Name = "FurniOwnerTxbx";
            this.FurniOwnerTxbx.Size = new System.Drawing.Size(251, 26);
            this.FurniOwnerTxbx.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SpawnFloorFurniOnClickBtn
            // 
            this.SpawnFloorFurniOnClickBtn.Location = new System.Drawing.Point(24, 414);
            this.SpawnFloorFurniOnClickBtn.Name = "SpawnFloorFurniOnClickBtn";
            this.SpawnFloorFurniOnClickBtn.Size = new System.Drawing.Size(251, 35);
            this.SpawnFloorFurniOnClickBtn.TabIndex = 12;
            this.SpawnFloorFurniOnClickBtn.Text = "Spawn Floor Furni on click : OFF";
            this.SpawnFloorFurniOnClickBtn.Click += new System.EventHandler(this.SpawnFloorFurniOnClickBtn_Click);
            // 
            // FurniSpawnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpawnFloorFurniOnClickBtn);
            this.Controls.Add(this.FurniOwnerTxbx);
            this.Controls.Add(this.SetOwnUsernameBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpawnFloorFurniBtn);
            this.Controls.Add(this.CoordZNBx);
            this.Controls.Add(this.CoordYNbx);
            this.Controls.Add(this.CoordXNbx);
            this.Controls.Add(this.FurnIDnbx);
            this.Name = "FurniSpawnPage";
            this.Size = new System.Drawing.Size(839, 493);
            ((System.ComponentModel.ISupportInitialize)(this.FurnIDnbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordXNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordZNBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordYNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown FurnIDnbx;
        private System.Windows.Forms.NumericUpDown CoordXNbx;
        private System.Windows.Forms.NumericUpDown CoordZNBx;
        private System.Windows.Forms.NumericUpDown CoordYNbx;
        private Sulakore.Components.SKoreButton SpawnFloorFurniBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RotationRight;
        private System.Windows.Forms.RadioButton rotationLeft;
        private System.Windows.Forms.RadioButton RotationDown;
        private System.Windows.Forms.RadioButton RotationUp;
        private Sulakore.Components.SKoreButton SetOwnUsernameBtn;
        private System.Windows.Forms.TextBox FurniOwnerTxbx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown RotationNbx;
        private Sulakore.Components.SKoreButton SpawnFloorFurniOnClickBtn;
    }
}
