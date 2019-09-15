namespace RetroFun.Pages
{
    partial class CustomMotto
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
            this.EnableAnimatedChbx = new System.Windows.Forms.CheckBox();
            this.SetMottobtn = new Sulakore.Components.SKoreButton();
            this.MottoToBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SecondMottoAnim = new System.Windows.Forms.RadioButton();
            this.FirstMottoAnim = new System.Windows.Forms.RadioButton();
            this.SpeedTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTime)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableAnimatedChbx
            // 
            this.EnableAnimatedChbx.AutoSize = true;
            this.EnableAnimatedChbx.Location = new System.Drawing.Point(29, 148);
            this.EnableAnimatedChbx.Name = "EnableAnimatedChbx";
            this.EnableAnimatedChbx.Size = new System.Drawing.Size(119, 17);
            this.EnableAnimatedChbx.TabIndex = 6;
            this.EnableAnimatedChbx.Text = "Set Animated Motto";
            this.EnableAnimatedChbx.UseVisualStyleBackColor = true;
            this.EnableAnimatedChbx.CheckedChanged += new System.EventHandler(this.AnimMottoCheck_CheckedChanged);
            // 
            // SetMottobtn
            // 
            this.SetMottobtn.Location = new System.Drawing.Point(35, 218);
            this.SetMottobtn.Name = "SetMottobtn";
            this.SetMottobtn.Size = new System.Drawing.Size(139, 20);
            this.SetMottobtn.TabIndex = 9;
            this.SetMottobtn.Text = "Set Motto";
            this.SetMottobtn.Click += new System.EventHandler(this.SetMottobtn_Click_1);
            // 
            // MottoToBox
            // 
            this.MottoToBox.AcceptsTab = true;
            this.MottoToBox.HideSelection = false;
            this.MottoToBox.Location = new System.Drawing.Point(29, 181);
            this.MottoToBox.Name = "MottoToBox";
            this.MottoToBox.Size = new System.Drawing.Size(313, 20);
            this.MottoToBox.TabIndex = 8;
            this.MottoToBox.Text = "RetroFun Maintained by Marcocorriero.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecondMottoAnim);
            this.groupBox1.Controls.Add(this.FirstMottoAnim);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motto Animations";
            // 
            // SecondMottoAnim
            // 
            this.SecondMottoAnim.AutoSize = true;
            this.SecondMottoAnim.Location = new System.Drawing.Point(6, 42);
            this.SecondMottoAnim.Name = "SecondMottoAnim";
            this.SecondMottoAnim.Size = new System.Drawing.Size(53, 17);
            this.SecondMottoAnim.TabIndex = 1;
            this.SecondMottoAnim.Text = "~~~~";
            this.SecondMottoAnim.UseVisualStyleBackColor = true;
            this.SecondMottoAnim.CheckedChanged += new System.EventHandler(this.SecondMottoAnim_CheckedChanged);
            // 
            // FirstMottoAnim
            // 
            this.FirstMottoAnim.AutoSize = true;
            this.FirstMottoAnim.Checked = true;
            this.FirstMottoAnim.Location = new System.Drawing.Point(6, 19);
            this.FirstMottoAnim.Name = "FirstMottoAnim";
            this.FirstMottoAnim.Size = new System.Drawing.Size(28, 17);
            this.FirstMottoAnim.TabIndex = 0;
            this.FirstMottoAnim.TabStop = true;
            this.FirstMottoAnim.Text = "I";
            this.FirstMottoAnim.UseVisualStyleBackColor = true;
            this.FirstMottoAnim.CheckedChanged += new System.EventHandler(this.FirstMottoAnim_CheckedChanged);
            // 
            // SpeedTime
            // 
            this.SpeedTime.Location = new System.Drawing.Point(178, 37);
            this.SpeedTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SpeedTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedTime.Name = "SpeedTime";
            this.SpeedTime.Size = new System.Drawing.Size(120, 20);
            this.SpeedTime.TabIndex = 13;
            this.SpeedTime.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set Animation Speed";
            // 
            // CustomMotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EnableAnimatedChbx);
            this.Controls.Add(this.SetMottobtn);
            this.Controls.Add(this.MottoToBox);
            this.Name = "CustomMotto";
            this.Size = new System.Drawing.Size(468, 265);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox EnableAnimatedChbx;
        private Sulakore.Components.SKoreButton SetMottobtn;
        private System.Windows.Forms.TextBox MottoToBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SecondMottoAnim;
        private System.Windows.Forms.RadioButton FirstMottoAnim;
        private System.Windows.Forms.NumericUpDown SpeedTime;
        private System.Windows.Forms.Label label1;
    }
}
