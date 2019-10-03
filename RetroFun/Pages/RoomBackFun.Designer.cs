namespace RetroFun.Pages
{
    partial class RoomBackFun
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
            this.label1 = new System.Windows.Forms.Label();
            this.TonNbx = new System.Windows.Forms.NumericUpDown();
            this.SatNbx = new System.Windows.Forms.NumericUpDown();
            this.LightNbx = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FurniIDnb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TonNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDnb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tonality";
            // 
            // TonNbx
            // 
            this.TonNbx.Location = new System.Drawing.Point(29, 73);
            this.TonNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TonNbx.Name = "TonNbx";
            this.TonNbx.Size = new System.Drawing.Size(120, 20);
            this.TonNbx.TabIndex = 1;
            // 
            // SatNbx
            // 
            this.SatNbx.Location = new System.Drawing.Point(29, 118);
            this.SatNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SatNbx.Name = "SatNbx";
            this.SatNbx.Size = new System.Drawing.Size(120, 20);
            this.SatNbx.TabIndex = 2;
            // 
            // LightNbx
            // 
            this.LightNbx.Location = new System.Drawing.Point(30, 167);
            this.LightNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LightNbx.Name = "LightNbx";
            this.LightNbx.Size = new System.Drawing.Size(120, 20);
            this.LightNbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Luminosity";
            // 
            // FurniIDnb
            // 
            this.FurniIDnb.Location = new System.Drawing.Point(29, 232);
            this.FurniIDnb.Name = "FurniIDnb";
            this.FurniIDnb.Size = new System.Drawing.Size(120, 20);
            this.FurniIDnb.TabIndex = 6;
            // 
            // RoomBackFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FurniIDnb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LightNbx);
            this.Controls.Add(this.SatNbx);
            this.Controls.Add(this.TonNbx);
            this.Controls.Add(this.label1);
            this.Name = "RoomBackFun";
            this.Size = new System.Drawing.Size(503, 327);
            ((System.ComponentModel.ISupportInitialize)(this.TonNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDnb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TonNbx;
        private System.Windows.Forms.NumericUpDown SatNbx;
        private System.Windows.Forms.NumericUpDown LightNbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FurniIDnb;
    }
}
