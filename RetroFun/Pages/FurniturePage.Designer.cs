namespace RetroFun.Pages
{
    partial class FurniturePage
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
            this.RemoverGrbx = new System.Windows.Forms.GroupBox();
            this.FurniPickChbx = new System.Windows.Forms.CheckBox();
            this.DoubleClickFurnitureRemovalChbx = new System.Windows.Forms.CheckBox();
            this.RestoreFurnisBtn = new Sulakore.Components.SKoreButton();
            this.FurnitureIDTxt = new Sulakore.Components.SKoreLabelBox();
            this.RemoveWallItemBtn = new Sulakore.Components.SKoreButton();
            this.RemoveFloorItemBtn = new Sulakore.Components.SKoreButton();
            this.FloorFurniIDNbx = new System.Windows.Forms.NumericUpDown();
            this.FloorFurniXNbx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FloorFurniYNbx = new System.Windows.Forms.NumericUpDown();
            this.RotationUp = new System.Windows.Forms.RadioButton();
            this.RotationDown = new System.Windows.Forms.RadioButton();
            this.rotationLeft = new System.Windows.Forms.RadioButton();
            this.RotationRight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LiveEditFloorFurniBtn = new Sulakore.Components.SKoreButton();
            this.CaptureFloorFurniBtn = new Sulakore.Components.SKoreButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FloorFurniLiveEditCooldownNbx = new System.Windows.Forms.NumericUpDown();
            this.RemoverGrbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniIDNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniXNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniYNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniLiveEditCooldownNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoverGrbx
            // 
            this.RemoverGrbx.Controls.Add(this.FurniPickChbx);
            this.RemoverGrbx.Controls.Add(this.DoubleClickFurnitureRemovalChbx);
            this.RemoverGrbx.Controls.Add(this.RestoreFurnisBtn);
            this.RemoverGrbx.Controls.Add(this.FurnitureIDTxt);
            this.RemoverGrbx.Controls.Add(this.RemoveWallItemBtn);
            this.RemoverGrbx.Controls.Add(this.RemoveFloorItemBtn);
            this.RemoverGrbx.Location = new System.Drawing.Point(4, 5);
            this.RemoverGrbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoverGrbx.Name = "RemoverGrbx";
            this.RemoverGrbx.Padding = new System.Windows.Forms.Padding(4, 5, 4, 9);
            this.RemoverGrbx.Size = new System.Drawing.Size(378, 260);
            this.RemoverGrbx.TabIndex = 0;
            this.RemoverGrbx.TabStop = false;
            this.RemoverGrbx.Text = "Remover";
            // 
            // FurniPickChbx
            // 
            this.FurniPickChbx.AutoSize = true;
            this.FurniPickChbx.Location = new System.Drawing.Point(14, 168);
            this.FurniPickChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniPickChbx.Name = "FurniPickChbx";
            this.FurniPickChbx.Size = new System.Drawing.Size(171, 24);
            this.FurniPickChbx.TabIndex = 6;
            this.FurniPickChbx.Text = "Tell FurniID Picked.";
            this.FurniPickChbx.UseVisualStyleBackColor = true;
            // 
            // DoubleClickFurnitureRemovalChbx
            // 
            this.DoubleClickFurnitureRemovalChbx.AutoSize = true;
            this.DoubleClickFurnitureRemovalChbx.Location = new System.Drawing.Point(14, 138);
            this.DoubleClickFurnitureRemovalChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DoubleClickFurnitureRemovalChbx.Name = "DoubleClickFurnitureRemovalChbx";
            this.DoubleClickFurnitureRemovalChbx.Size = new System.Drawing.Size(201, 24);
            this.DoubleClickFurnitureRemovalChbx.TabIndex = 4;
            this.DoubleClickFurnitureRemovalChbx.Text = "Enable Pick up furni CS";
            this.DoubleClickFurnitureRemovalChbx.UseVisualStyleBackColor = true;
            // 
            // RestoreFurnisBtn
            // 
            this.RestoreFurnisBtn.Location = new System.Drawing.Point(14, 213);
            this.RestoreFurnisBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RestoreFurnisBtn.Name = "RestoreFurnisBtn";
            this.RestoreFurnisBtn.Size = new System.Drawing.Size(278, 34);
            this.RestoreFurnisBtn.TabIndex = 5;
            this.RestoreFurnisBtn.Text = "Revert All CS Edits.";
            this.RestoreFurnisBtn.Click += new System.EventHandler(this.RestoreFurnisBtn_Click);
            // 
            // FurnitureIDTxt
            // 
            this.FurnitureIDTxt.Location = new System.Drawing.Point(14, 23);
            this.FurnitureIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurnitureIDTxt.Name = "FurnitureIDTxt";
            this.FurnitureIDTxt.Size = new System.Drawing.Size(339, 20);
            this.FurnitureIDTxt.TabIndex = 3;
            this.FurnitureIDTxt.Text = "";
            this.FurnitureIDTxt.TextPaddingWidth = 0;
            this.FurnitureIDTxt.Title = "Furniture ID:";
            this.FurnitureIDTxt.Value = "";
            this.FurnitureIDTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FurnitureIDTxt.ValueReadOnly = false;
            // 
            // RemoveWallItemBtn
            // 
            this.RemoveWallItemBtn.Location = new System.Drawing.Point(188, 63);
            this.RemoveWallItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveWallItemBtn.Name = "RemoveWallItemBtn";
            this.RemoveWallItemBtn.Size = new System.Drawing.Size(165, 31);
            this.RemoveWallItemBtn.TabIndex = 2;
            this.RemoveWallItemBtn.Text = "Remove Wall Item";
            this.RemoveWallItemBtn.Click += new System.EventHandler(this.RemoveWallItemBtn_Click);
            // 
            // RemoveFloorItemBtn
            // 
            this.RemoveFloorItemBtn.Location = new System.Drawing.Point(14, 63);
            this.RemoveFloorItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveFloorItemBtn.Name = "RemoveFloorItemBtn";
            this.RemoveFloorItemBtn.Size = new System.Drawing.Size(165, 31);
            this.RemoveFloorItemBtn.TabIndex = 1;
            this.RemoveFloorItemBtn.Text = "Remove Floor Item";
            this.RemoveFloorItemBtn.Click += new System.EventHandler(this.RemoveFloorItemBtn_Click);
            // 
            // FloorFurniIDNbx
            // 
            this.FloorFurniIDNbx.Location = new System.Drawing.Point(38, 24);
            this.FloorFurniIDNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FloorFurniIDNbx.Name = "FloorFurniIDNbx";
            this.FloorFurniIDNbx.Size = new System.Drawing.Size(177, 26);
            this.FloorFurniIDNbx.TabIndex = 6;
            // 
            // FloorFurniXNbx
            // 
            this.FloorFurniXNbx.Location = new System.Drawing.Point(38, 87);
            this.FloorFurniXNbx.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.FloorFurniXNbx.Name = "FloorFurniXNbx";
            this.FloorFurniXNbx.Size = new System.Drawing.Size(84, 26);
            this.FloorFurniXNbx.TabIndex = 7;
            this.FloorFurniXNbx.ValueChanged += new System.EventHandler(this.FloorFurniXNbx_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // FloorFurniYNbx
            // 
            this.FloorFurniYNbx.Location = new System.Drawing.Point(148, 87);
            this.FloorFurniYNbx.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.FloorFurniYNbx.Name = "FloorFurniYNbx";
            this.FloorFurniYNbx.Size = new System.Drawing.Size(84, 26);
            this.FloorFurniYNbx.TabIndex = 10;
            this.FloorFurniYNbx.ValueChanged += new System.EventHandler(this.FloorFurniYNbx_ValueChanged);
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
            // rotationLeft
            // 
            this.rotationLeft.AutoSize = true;
            this.rotationLeft.Location = new System.Drawing.Point(14, 72);
            this.rotationLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotationLeft.Name = "rotationLeft";
            this.rotationLeft.Size = new System.Drawing.Size(21, 20);
            this.rotationLeft.TabIndex = 3;
            this.rotationLeft.UseVisualStyleBackColor = true;
            this.rotationLeft.CheckedChanged += new System.EventHandler(this.rotationLeft_CheckedChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RotationRight);
            this.groupBox1.Controls.Add(this.rotationLeft);
            this.groupBox1.Controls.Add(this.RotationDown);
            this.groupBox1.Controls.Add(this.RotationUp);
            this.groupBox1.Location = new System.Drawing.Point(176, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(164, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation";
            // 
            // LiveEditFloorFurniBtn
            // 
            this.LiveEditFloorFurniBtn.Location = new System.Drawing.Point(7, 241);
            this.LiveEditFloorFurniBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LiveEditFloorFurniBtn.Name = "LiveEditFloorFurniBtn";
            this.LiveEditFloorFurniBtn.Size = new System.Drawing.Size(157, 34);
            this.LiveEditFloorFurniBtn.TabIndex = 7;
            this.LiveEditFloorFurniBtn.Text = "Live Edit : OFF";
            this.LiveEditFloorFurniBtn.Click += new System.EventHandler(this.LiveEditFloorFurniBtn_Click);
            // 
            // CaptureFloorFurniBtn
            // 
            this.CaptureFloorFurniBtn.Location = new System.Drawing.Point(176, 307);
            this.CaptureFloorFurniBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaptureFloorFurniBtn.Name = "CaptureFloorFurniBtn";
            this.CaptureFloorFurniBtn.Size = new System.Drawing.Size(157, 34);
            this.CaptureFloorFurniBtn.TabIndex = 11;
            this.CaptureFloorFurniBtn.Text = "Capture Furni : OFF";
            this.CaptureFloorFurniBtn.Click += new System.EventHandler(this.CaptureFloorFurniBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FloorFurniLiveEditCooldownNbx);
            this.groupBox2.Controls.Add(this.CaptureFloorFurniBtn);
            this.groupBox2.Controls.Add(this.LiveEditFloorFurniBtn);
            this.groupBox2.Controls.Add(this.FloorFurniYNbx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.FloorFurniXNbx);
            this.groupBox2.Controls.Add(this.FloorFurniIDNbx);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(450, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 349);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Floor Furni Editor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Live Edit cooldown";
            // 
            // FloorFurniLiveEditCooldownNbx
            // 
            this.FloorFurniLiveEditCooldownNbx.Location = new System.Drawing.Point(17, 307);
            this.FloorFurniLiveEditCooldownNbx.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.FloorFurniLiveEditCooldownNbx.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.FloorFurniLiveEditCooldownNbx.Name = "FloorFurniLiveEditCooldownNbx";
            this.FloorFurniLiveEditCooldownNbx.Size = new System.Drawing.Size(125, 26);
            this.FloorFurniLiveEditCooldownNbx.TabIndex = 12;
            this.FloorFurniLiveEditCooldownNbx.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // FurniturePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RemoverGrbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FurniturePage";
            this.Size = new System.Drawing.Size(1089, 422);
            this.RemoverGrbx.ResumeLayout(false);
            this.RemoverGrbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniIDNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniXNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniYNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniLiveEditCooldownNbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RemoverGrbx;
        private System.Windows.Forms.CheckBox DoubleClickFurnitureRemovalChbx;
        private Sulakore.Components.SKoreLabelBox FurnitureIDTxt;
        private Sulakore.Components.SKoreButton RemoveWallItemBtn;
        private Sulakore.Components.SKoreButton RemoveFloorItemBtn;
        private Sulakore.Components.SKoreButton RestoreFurnisBtn;
        private System.Windows.Forms.CheckBox FurniPickChbx;
        private System.Windows.Forms.NumericUpDown FloorFurniIDNbx;
        private System.Windows.Forms.NumericUpDown FloorFurniXNbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FloorFurniYNbx;
        private System.Windows.Forms.RadioButton RotationUp;
        private System.Windows.Forms.RadioButton RotationDown;
        private System.Windows.Forms.RadioButton rotationLeft;
        private System.Windows.Forms.RadioButton RotationRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sulakore.Components.SKoreButton LiveEditFloorFurniBtn;
        private Sulakore.Components.SKoreButton CaptureFloorFurniBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FloorFurniLiveEditCooldownNbx;
    }
}