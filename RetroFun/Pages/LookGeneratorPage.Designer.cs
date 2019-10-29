namespace RetroFun.Pages
{
    partial class LookGeneratorPage
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
            this.XmlParserBtn = new Sulakore.Components.SKoreButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // XmlParserBtn
            // 
            this.XmlParserBtn.Location = new System.Drawing.Point(24, 15);
            this.XmlParserBtn.Name = "XmlParserBtn";
            this.XmlParserBtn.Size = new System.Drawing.Size(100, 20);
            this.XmlParserBtn.TabIndex = 0;
            this.XmlParserBtn.Text = "Parse Xml ";
            this.XmlParserBtn.Click += new System.EventHandler(this.XmlParserBtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 185);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 2;
            // 
            // LookGeneratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.XmlParserBtn);
            this.Name = "LookGeneratorPage";
            this.Size = new System.Drawing.Size(532, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton XmlParserBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
