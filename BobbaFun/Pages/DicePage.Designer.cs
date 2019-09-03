namespace BobbaFun.Pages
{
    partial class ChatPage
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(31, 33);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(122, 169);
            this.checkedListBox1.TabIndex = 0;
            // 
            // ChatPage
            // 
            this.Controls.Add(this.checkedListBox1);
            this.Name = "ChatPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ImageComboBox BubblesCmbx;
        private System.Windows.Forms.CheckBox UseSelectedBubbleChbx;
        private System.Windows.Forms.CheckBox HideSpeakingBubbleChbx;
        private System.Windows.Forms.CheckBox AntiBobbaFilterChbx;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
