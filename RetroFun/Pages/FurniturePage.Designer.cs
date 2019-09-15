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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RotationRight = new System.Windows.Forms.RadioButton();
            this.rotationLeft = new System.Windows.Forms.RadioButton();
            this.RotationDown = new System.Windows.Forms.RadioButton();
            this.RotationUp = new System.Windows.Forms.RadioButton();
            this.ToggleFurniRotCS = new System.Windows.Forms.CheckBox();
            this.DoubleClickFurnitureRemovalChbx = new System.Windows.Forms.CheckBox();
            this.FurnitureIDTxt = new Sulakore.Components.SKoreLabelBox();
            this.RemoveWallItemBtn = new Sulakore.Components.SKoreButton();
            this.RemoveFloorItemBtn = new Sulakore.Components.SKoreButton();
            this.RemoverGrbx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoverGrbx
            // 
            this.RemoverGrbx.Controls.Add(this.groupBox1);
            this.RemoverGrbx.Controls.Add(this.ToggleFurniRotCS);
            this.RemoverGrbx.Controls.Add(this.DoubleClickFurnitureRemovalChbx);
            this.RemoverGrbx.Controls.Add(this.FurnitureIDTxt);
            this.RemoverGrbx.Controls.Add(this.RemoveWallItemBtn);
            this.RemoverGrbx.Controls.Add(this.RemoveFloorItemBtn);
            this.RemoverGrbx.Location = new System.Drawing.Point(3, 3);
            this.RemoverGrbx.Name = "RemoverGrbx";
            this.RemoverGrbx.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.RemoverGrbx.Size = new System.Drawing.Size(252, 162);
            this.RemoverGrbx.TabIndex = 0;
            this.RemoverGrbx.TabStop = false;
            this.RemoverGrbx.Text = "Remover";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RotationRight);
            this.groupBox1.Controls.Add(this.rotationLeft);
            this.groupBox1.Controls.Add(this.RotationDown);
            this.groupBox1.Controls.Add(this.RotationUp);
            this.groupBox1.Location = new System.Drawing.Point(143, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation";
            // 
            // RotationRight
            // 
            this.RotationRight.AutoSize = true;
            this.RotationRight.Location = new System.Drawing.Point(78, 46);
            this.RotationRight.Name = "RotationRight";
            this.RotationRight.Size = new System.Drawing.Size(14, 13);
            this.RotationRight.TabIndex = 4;
            this.RotationRight.UseVisualStyleBackColor = true;
            // 
            // rotationLeft
            // 
            this.rotationLeft.AutoSize = true;
            this.rotationLeft.Location = new System.Drawing.Point(9, 47);
            this.rotationLeft.Name = "rotationLeft";
            this.rotationLeft.Size = new System.Drawing.Size(14, 13);
            this.rotationLeft.TabIndex = 3;
            this.rotationLeft.UseVisualStyleBackColor = true;
            // 
            // RotationDown
            // 
            this.RotationDown.AutoSize = true;
            this.RotationDown.Location = new System.Drawing.Point(45, 73);
            this.RotationDown.Name = "RotationDown";
            this.RotationDown.Size = new System.Drawing.Size(14, 13);
            this.RotationDown.TabIndex = 2;
            this.RotationDown.UseVisualStyleBackColor = true;
            // 
            // RotationUp
            // 
            this.RotationUp.AutoSize = true;
            this.RotationUp.Checked = true;
            this.RotationUp.Location = new System.Drawing.Point(45, 19);
            this.RotationUp.Name = "RotationUp";
            this.RotationUp.Size = new System.Drawing.Size(14, 13);
            this.RotationUp.TabIndex = 1;
            this.RotationUp.TabStop = true;
            this.RotationUp.UseVisualStyleBackColor = true;
            // 
            // ToggleFurniRotCS
            // 
            this.ToggleFurniRotCS.AutoSize = true;
            this.ToggleFurniRotCS.Location = new System.Drawing.Point(9, 113);
            this.ToggleFurniRotCS.Name = "ToggleFurniRotCS";
            this.ToggleFurniRotCS.Size = new System.Drawing.Size(137, 17);
            this.ToggleFurniRotCS.TabIndex = 5;
            this.ToggleFurniRotCS.Text = "Enable Rotate Furni CS";
            this.ToggleFurniRotCS.UseVisualStyleBackColor = true;
            // 
            // DoubleClickFurnitureRemovalChbx
            // 
            this.DoubleClickFurnitureRemovalChbx.AutoSize = true;
            this.DoubleClickFurnitureRemovalChbx.Location = new System.Drawing.Point(9, 90);
            this.DoubleClickFurnitureRemovalChbx.Name = "DoubleClickFurnitureRemovalChbx";
            this.DoubleClickFurnitureRemovalChbx.Size = new System.Drawing.Size(138, 17);
            this.DoubleClickFurnitureRemovalChbx.TabIndex = 4;
            this.DoubleClickFurnitureRemovalChbx.Text = "Enable Pick up furni CS";
            this.DoubleClickFurnitureRemovalChbx.UseVisualStyleBackColor = true;
            // 
            // FurnitureIDTxt
            // 
            this.FurnitureIDTxt.Location = new System.Drawing.Point(9, 15);
            this.FurnitureIDTxt.Name = "FurnitureIDTxt";
            this.FurnitureIDTxt.Size = new System.Drawing.Size(226, 20);
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
            this.RemoveWallItemBtn.Location = new System.Drawing.Point(125, 41);
            this.RemoveWallItemBtn.Name = "RemoveWallItemBtn";
            this.RemoveWallItemBtn.Size = new System.Drawing.Size(110, 20);
            this.RemoveWallItemBtn.TabIndex = 2;
            this.RemoveWallItemBtn.Text = "Remove Wall Item";
            this.RemoveWallItemBtn.Click += new System.EventHandler(this.RemoveWallItemBtn_Click);
            // 
            // RemoveFloorItemBtn
            // 
            this.RemoveFloorItemBtn.Location = new System.Drawing.Point(9, 41);
            this.RemoveFloorItemBtn.Name = "RemoveFloorItemBtn";
            this.RemoveFloorItemBtn.Size = new System.Drawing.Size(110, 20);
            this.RemoveFloorItemBtn.TabIndex = 1;
            this.RemoveFloorItemBtn.Text = "Remove Floor Item";
            this.RemoveFloorItemBtn.Click += new System.EventHandler(this.RemoveFloorItemBtn_Click);
            // 
            // FurniturePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoverGrbx);
            this.Name = "FurniturePage";
            this.RemoverGrbx.ResumeLayout(false);
            this.RemoverGrbx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RemoverGrbx;
        private System.Windows.Forms.CheckBox DoubleClickFurnitureRemovalChbx;
        private Sulakore.Components.SKoreLabelBox FurnitureIDTxt;
        private Sulakore.Components.SKoreButton RemoveWallItemBtn;
        private Sulakore.Components.SKoreButton RemoveFloorItemBtn;
        private System.Windows.Forms.CheckBox ToggleFurniRotCS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RotationRight;
        private System.Windows.Forms.RadioButton rotationLeft;
        private System.Windows.Forms.RadioButton RotationDown;
        private System.Windows.Forms.RadioButton RotationUp;
    }
}
