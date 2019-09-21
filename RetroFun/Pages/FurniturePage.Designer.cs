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
            this.DoubleClickFurnitureRemovalChbx = new System.Windows.Forms.CheckBox();
            this.FurnitureIDTxt = new Sulakore.Components.SKoreLabelBox();
            this.RemoveWallItemBtn = new Sulakore.Components.SKoreButton();
            this.RemoveFloorItemBtn = new Sulakore.Components.SKoreButton();
            this.RemoverGrbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoverGrbx
            // 
            this.RemoverGrbx.Controls.Add(this.DoubleClickFurnitureRemovalChbx);
            this.RemoverGrbx.Controls.Add(this.FurnitureIDTxt);
            this.RemoverGrbx.Controls.Add(this.RemoveWallItemBtn);
            this.RemoverGrbx.Controls.Add(this.RemoveFloorItemBtn);
            this.RemoverGrbx.Location = new System.Drawing.Point(70, 65);
            this.RemoverGrbx.Name = "RemoverGrbx";
            this.RemoverGrbx.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.RemoverGrbx.Size = new System.Drawing.Size(299, 97);
            this.RemoverGrbx.TabIndex = 0;
            this.RemoverGrbx.TabStop = false;
            this.RemoverGrbx.Text = "Remover";
            // 
            // DoubleClickFurnitureRemovalChbx
            // 
            this.DoubleClickFurnitureRemovalChbx.AutoSize = true;
            this.DoubleClickFurnitureRemovalChbx.Location = new System.Drawing.Point(62, 19);
            this.DoubleClickFurnitureRemovalChbx.Name = "DoubleClickFurnitureRemovalChbx";
            this.DoubleClickFurnitureRemovalChbx.Size = new System.Drawing.Size(175, 17);
            this.DoubleClickFurnitureRemovalChbx.TabIndex = 4;
            this.DoubleClickFurnitureRemovalChbx.Text = "Double-Click Furniture Removal";
            this.DoubleClickFurnitureRemovalChbx.UseVisualStyleBackColor = true;
            // 
            // FurnitureIDTxt
            // 
            this.FurnitureIDTxt.Location = new System.Drawing.Point(36, 42);
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
            this.RemoveWallItemBtn.Location = new System.Drawing.Point(152, 68);
            this.RemoveWallItemBtn.Name = "RemoveWallItemBtn";
            this.RemoveWallItemBtn.Size = new System.Drawing.Size(110, 20);
            this.RemoveWallItemBtn.TabIndex = 2;
            this.RemoveWallItemBtn.Text = "Remove Wall Item";
            this.RemoveWallItemBtn.Click += new System.EventHandler(this.RemoveWallItemBtn_Click);
            // 
            // RemoveFloorItemBtn
            // 
            this.RemoveFloorItemBtn.Location = new System.Drawing.Point(36, 68);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RemoverGrbx;
        private System.Windows.Forms.CheckBox DoubleClickFurnitureRemovalChbx;
        private Sulakore.Components.SKoreLabelBox FurnitureIDTxt;
        private Sulakore.Components.SKoreButton RemoveWallItemBtn;
        private Sulakore.Components.SKoreButton RemoveFloorItemBtn;
    }
}
