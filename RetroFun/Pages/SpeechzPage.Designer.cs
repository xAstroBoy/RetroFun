namespace RetroFun.Pages
{
    partial class SpeechzPage
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_speechtext = new System.Windows.Forms.TextBox();
            this.lbl_speechtext_title = new System.Windows.Forms.Label();
            this.lbl_speechtext_desc = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.nmr_bubbletype = new System.Windows.Forms.NumericUpDown();
            this.lbl_bubbletype_title = new System.Windows.Forms.Label();
            this.lbl_bubbletype_desc = new System.Windows.Forms.Label();
            this.nmr_interval = new System.Windows.Forms.NumericUpDown();
            this.lbl_interval_title = new System.Windows.Forms.Label();
            this.lbl_interval_desc = new System.Windows.Forms.Label();
            this.rdo_client = new System.Windows.Forms.RadioButton();
            this.rdo_server = new System.Windows.Forms.RadioButton();
            this.lbl_sendto_title = new System.Windows.Forms.Label();
            this.lbl_sendto_desc = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grp_bubble_type_counting = new System.Windows.Forms.GroupBox();
            this.rdo_manual_value = new System.Windows.Forms.RadioButton();
            this.rdo_live_counting = new System.Windows.Forms.RadioButton();
            this.grp_counting_direction = new System.Windows.Forms.GroupBox();
            this.rdo_descending = new System.Windows.Forms.RadioButton();
            this.rdo_ascending = new System.Windows.Forms.RadioButton();
            this.btn_pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_bubbletype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).BeginInit();
            this.grp_bubble_type_counting.SuspendLayout();
            this.grp_counting_direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_speechtext
            // 
            this.txt_speechtext.Location = new System.Drawing.Point(12, 12);
            this.txt_speechtext.Name = "txt_speechtext";
            this.txt_speechtext.Size = new System.Drawing.Size(110, 20);
            this.txt_speechtext.TabIndex = 0;
            this.txt_speechtext.Text = "<id>";
            // 
            // lbl_speechtext_title
            // 
            this.lbl_speechtext_title.AutoSize = true;
            this.lbl_speechtext_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speechtext_title.Location = new System.Drawing.Point(9, 35);
            this.lbl_speechtext_title.Name = "lbl_speechtext_title";
            this.lbl_speechtext_title.Size = new System.Drawing.Size(73, 13);
            this.lbl_speechtext_title.TabIndex = 1;
            this.lbl_speechtext_title.Text = "speech text";
            // 
            // lbl_speechtext_desc
            // 
            this.lbl_speechtext_desc.AutoSize = true;
            this.lbl_speechtext_desc.Location = new System.Drawing.Point(9, 48);
            this.lbl_speechtext_desc.Name = "lbl_speechtext_desc";
            this.lbl_speechtext_desc.Size = new System.Drawing.Size(113, 65);
            this.lbl_speechtext_desc.TabIndex = 2;
            this.lbl_speechtext_desc.Text = "The text in the speech\r\nbubble.\r\n<id> will be replaced\r\nby the current speech\r\nbu" +
    "bble type ID.";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 180);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(236, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // nmr_bubbletype
            // 
            this.nmr_bubbletype.Location = new System.Drawing.Point(133, 12);
            this.nmr_bubbletype.Name = "nmr_bubbletype";
            this.nmr_bubbletype.Size = new System.Drawing.Size(107, 20);
            this.nmr_bubbletype.TabIndex = 4;
            this.nmr_bubbletype.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            // 
            // lbl_bubbletype_title
            // 
            this.lbl_bubbletype_title.AutoSize = true;
            this.lbl_bubbletype_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bubbletype_title.Location = new System.Drawing.Point(130, 35);
            this.lbl_bubbletype_title.Name = "lbl_bubbletype_title";
            this.lbl_bubbletype_title.Size = new System.Drawing.Size(73, 13);
            this.lbl_bubbletype_title.TabIndex = 1;
            this.lbl_bubbletype_title.Text = "bubble type";
            // 
            // lbl_bubbletype_desc
            // 
            this.lbl_bubbletype_desc.AutoSize = true;
            this.lbl_bubbletype_desc.Location = new System.Drawing.Point(130, 48);
            this.lbl_bubbletype_desc.Name = "lbl_bubbletype_desc";
            this.lbl_bubbletype_desc.Size = new System.Drawing.Size(110, 52);
            this.lbl_bubbletype_desc.TabIndex = 2;
            this.lbl_bubbletype_desc.Text = "The type of the\r\nspeech bubble (1-38).\r\nThis number\r\nwill go descending.";
            // 
            // nmr_interval
            // 
            this.nmr_interval.Location = new System.Drawing.Point(246, 12);
            this.nmr_interval.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nmr_interval.Name = "nmr_interval";
            this.nmr_interval.Size = new System.Drawing.Size(115, 20);
            this.nmr_interval.TabIndex = 5;
            this.nmr_interval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl_interval_title
            // 
            this.lbl_interval_title.AutoSize = true;
            this.lbl_interval_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interval_title.Location = new System.Drawing.Point(243, 35);
            this.lbl_interval_title.Name = "lbl_interval_title";
            this.lbl_interval_title.Size = new System.Drawing.Size(76, 13);
            this.lbl_interval_title.TabIndex = 1;
            this.lbl_interval_title.Text = "interval [ms]";
            // 
            // lbl_interval_desc
            // 
            this.lbl_interval_desc.AutoSize = true;
            this.lbl_interval_desc.Location = new System.Drawing.Point(243, 48);
            this.lbl_interval_desc.Name = "lbl_interval_desc";
            this.lbl_interval_desc.Size = new System.Drawing.Size(118, 91);
            this.lbl_interval_desc.TabIndex = 2;
            this.lbl_interval_desc.Text = "The time span between\r\nsending the next\r\nmessages. While there\r\nis a serverside f" +
    "lood\r\nprevention, there\r\naren\'t any\r\nclientside limits.";
            // 
            // rdo_client
            // 
            this.rdo_client.AutoSize = true;
            this.rdo_client.Checked = true;
            this.rdo_client.Location = new System.Drawing.Point(362, 162);
            this.rdo_client.Name = "rdo_client";
            this.rdo_client.Size = new System.Drawing.Size(51, 17);
            this.rdo_client.TabIndex = 6;
            this.rdo_client.TabStop = true;
            this.rdo_client.Text = "Client";
            this.rdo_client.UseVisualStyleBackColor = true;
            // 
            // rdo_server
            // 
            this.rdo_server.AutoSize = true;
            this.rdo_server.Location = new System.Drawing.Point(362, 139);
            this.rdo_server.Name = "rdo_server";
            this.rdo_server.Size = new System.Drawing.Size(56, 17);
            this.rdo_server.TabIndex = 6;
            this.rdo_server.Text = "Server";
            this.rdo_server.UseVisualStyleBackColor = true;
            // 
            // lbl_sendto_title
            // 
            this.lbl_sendto_title.AutoSize = true;
            this.lbl_sendto_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sendto_title.Location = new System.Drawing.Point(359, 120);
            this.lbl_sendto_title.Name = "lbl_sendto_title";
            this.lbl_sendto_title.Size = new System.Drawing.Size(51, 13);
            this.lbl_sendto_title.TabIndex = 1;
            this.lbl_sendto_title.Text = "Send to";
            // 
            // lbl_sendto_desc
            // 
            this.lbl_sendto_desc.AutoSize = true;
            this.lbl_sendto_desc.Location = new System.Drawing.Point(321, 185);
            this.lbl_sendto_desc.Name = "lbl_sendto_desc";
            this.lbl_sendto_desc.Size = new System.Drawing.Size(126, 78);
            this.lbl_sendto_desc.TabIndex = 2;
            this.lbl_sendto_desc.Text = "Specific bubble types are\r\nblocked serverside\r\n(HC-/Staff-only)\r\nbut there aren\'t" +
    " any\r\nlimits for clientside\r\ntesting.";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grp_bubble_type_counting
            // 
            this.grp_bubble_type_counting.Controls.Add(this.rdo_manual_value);
            this.grp_bubble_type_counting.Controls.Add(this.rdo_live_counting);
            this.grp_bubble_type_counting.Location = new System.Drawing.Point(129, 98);
            this.grp_bubble_type_counting.Name = "grp_bubble_type_counting";
            this.grp_bubble_type_counting.Size = new System.Drawing.Size(108, 41);
            this.grp_bubble_type_counting.TabIndex = 7;
            this.grp_bubble_type_counting.TabStop = false;
            // 
            // rdo_manual_value
            // 
            this.rdo_manual_value.AutoSize = true;
            this.rdo_manual_value.Checked = true;
            this.rdo_manual_value.Location = new System.Drawing.Point(6, 22);
            this.rdo_manual_value.Name = "rdo_manual_value";
            this.rdo_manual_value.Size = new System.Drawing.Size(89, 17);
            this.rdo_manual_value.TabIndex = 1;
            this.rdo_manual_value.TabStop = true;
            this.rdo_manual_value.Text = "Manual value";
            this.rdo_manual_value.UseVisualStyleBackColor = true;
            // 
            // rdo_live_counting
            // 
            this.rdo_live_counting.AutoSize = true;
            this.rdo_live_counting.Location = new System.Drawing.Point(6, 7);
            this.rdo_live_counting.Name = "rdo_live_counting";
            this.rdo_live_counting.Size = new System.Drawing.Size(89, 17);
            this.rdo_live_counting.TabIndex = 0;
            this.rdo_live_counting.Text = "Live counting";
            this.rdo_live_counting.UseVisualStyleBackColor = true;
            this.rdo_live_counting.CheckedChanged += new System.EventHandler(this.rdo_live_counting_CheckedChanged);
            // 
            // grp_counting_direction
            // 
            this.grp_counting_direction.Controls.Add(this.rdo_descending);
            this.grp_counting_direction.Controls.Add(this.rdo_ascending);
            this.grp_counting_direction.Location = new System.Drawing.Point(129, 133);
            this.grp_counting_direction.Name = "grp_counting_direction";
            this.grp_counting_direction.Size = new System.Drawing.Size(108, 41);
            this.grp_counting_direction.TabIndex = 8;
            this.grp_counting_direction.TabStop = false;
            // 
            // rdo_descending
            // 
            this.rdo_descending.AutoSize = true;
            this.rdo_descending.Checked = true;
            this.rdo_descending.Location = new System.Drawing.Point(6, 22);
            this.rdo_descending.Name = "rdo_descending";
            this.rdo_descending.Size = new System.Drawing.Size(82, 17);
            this.rdo_descending.TabIndex = 1;
            this.rdo_descending.TabStop = true;
            this.rdo_descending.Text = "Descending";
            this.rdo_descending.UseVisualStyleBackColor = true;
            // 
            // rdo_ascending
            // 
            this.rdo_ascending.AutoSize = true;
            this.rdo_ascending.Location = new System.Drawing.Point(6, 7);
            this.rdo_ascending.Name = "rdo_ascending";
            this.rdo_ascending.Size = new System.Drawing.Size(75, 17);
            this.rdo_ascending.TabIndex = 0;
            this.rdo_ascending.Text = "Ascending";
            this.rdo_ascending.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(12, 209);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(236, 23);
            this.btn_pause.TabIndex = 9;
            this.btn_pause.Text = "⏸Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Visible = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // Speechz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.grp_bubble_type_counting);
            this.Controls.Add(this.rdo_server);
            this.Controls.Add(this.rdo_client);
            this.Controls.Add(this.nmr_interval);
            this.Controls.Add(this.nmr_bubbletype);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_sendto_desc);
            this.Controls.Add(this.lbl_interval_desc);
            this.Controls.Add(this.lbl_bubbletype_desc);
            this.Controls.Add(this.lbl_speechtext_desc);
            this.Controls.Add(this.lbl_sendto_title);
            this.Controls.Add(this.lbl_interval_title);
            this.Controls.Add(this.lbl_bubbletype_title);
            this.Controls.Add(this.lbl_speechtext_title);
            this.Controls.Add(this.txt_speechtext);
            this.Controls.Add(this.grp_counting_direction);
            this.Name = "Speechz";
            this.Size = new System.Drawing.Size(497, 276);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_bubbletype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).EndInit();
            this.grp_bubble_type_counting.ResumeLayout(false);
            this.grp_bubble_type_counting.PerformLayout();
            this.grp_counting_direction.ResumeLayout(false);
            this.grp_counting_direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_speechtext;
        private System.Windows.Forms.Label lbl_speechtext_title;
        private System.Windows.Forms.Label lbl_speechtext_desc;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown nmr_bubbletype;
        private System.Windows.Forms.Label lbl_bubbletype_title;
        private System.Windows.Forms.Label lbl_bubbletype_desc;
        private System.Windows.Forms.NumericUpDown nmr_interval;
        private System.Windows.Forms.Label lbl_interval_title;
        private System.Windows.Forms.Label lbl_interval_desc;
        private System.Windows.Forms.RadioButton rdo_client;
        private System.Windows.Forms.RadioButton rdo_server;
        private System.Windows.Forms.Label lbl_sendto_title;
        private System.Windows.Forms.Label lbl_sendto_desc;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox grp_bubble_type_counting;
        private System.Windows.Forms.RadioButton rdo_manual_value;
        private System.Windows.Forms.RadioButton rdo_live_counting;
        private System.Windows.Forms.GroupBox grp_counting_direction;
        private System.Windows.Forms.RadioButton rdo_descending;
        private System.Windows.Forms.RadioButton rdo_ascending;
        private System.Windows.Forms.Button btn_pause;
    }
}
