namespace ShinyCountPlus
{
    partial class GenSelectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.pkmnLoadBar = new System.Windows.Forms.ProgressBar();
            this.exitIcon = new System.Windows.Forms.Panel();
            this.gen8Btn = new System.Windows.Forms.Button();
            this.gen7Btn = new System.Windows.Forms.Button();
            this.gen6Btn = new System.Windows.Forms.Button();
            this.gen5Btn = new System.Windows.Forms.Button();
            this.gen4Btn = new System.Windows.Forms.Button();
            this.gen3Btn = new System.Windows.Forms.Button();
            this.gen2Btn = new System.Windows.Forms.Button();
            this.gen1Btn = new System.Windows.Forms.Button();
            this.toolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Controls.Add(this.pkmnLoadBar);
            this.toolBarPanel.Controls.Add(this.exitIcon);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(412, 32);
            this.toolBarPanel.TabIndex = 8;
            this.toolBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.toolBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.toolBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pkmnLoadBar
            // 
            this.pkmnLoadBar.ForeColor = System.Drawing.Color.LightGreen;
            this.pkmnLoadBar.Location = new System.Drawing.Point(3, 3);
            this.pkmnLoadBar.Name = "pkmnLoadBar";
            this.pkmnLoadBar.Size = new System.Drawing.Size(370, 26);
            this.pkmnLoadBar.TabIndex = 7;
            this.pkmnLoadBar.Visible = false;
            // 
            // exitIcon
            // 
            this.exitIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitIcon.BackgroundImage = global::ShinyCountPlus.Properties.Resources.icons8_delete_32px;
            this.exitIcon.Location = new System.Drawing.Point(377, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(32, 32);
            this.exitIcon.TabIndex = 6;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // gen8Btn
            // 
            this.gen8Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen8Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen8Btn.FlatAppearance.BorderSize = 3;
            this.gen8Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen8Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen8Btn.Location = new System.Drawing.Point(0, 508);
            this.gen8Btn.Name = "gen8Btn";
            this.gen8Btn.Size = new System.Drawing.Size(412, 68);
            this.gen8Btn.TabIndex = 16;
            this.gen8Btn.Text = "Gen 8\r\n(810-893)\r\n";
            this.gen8Btn.UseVisualStyleBackColor = false;
            this.gen8Btn.Click += new System.EventHandler(this.gen8Btn_Click);
            this.gen8Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen8Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen7Btn
            // 
            this.gen7Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen7Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen7Btn.FlatAppearance.BorderSize = 3;
            this.gen7Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen7Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen7Btn.Location = new System.Drawing.Point(0, 440);
            this.gen7Btn.Name = "gen7Btn";
            this.gen7Btn.Size = new System.Drawing.Size(412, 68);
            this.gen7Btn.TabIndex = 15;
            this.gen7Btn.Text = "Gen 7\r\n(722-809)\r\n";
            this.gen7Btn.UseVisualStyleBackColor = false;
            this.gen7Btn.Click += new System.EventHandler(this.gen7Btn_Click);
            this.gen7Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen7Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen6Btn
            // 
            this.gen6Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen6Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen6Btn.FlatAppearance.BorderSize = 3;
            this.gen6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen6Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen6Btn.Location = new System.Drawing.Point(0, 372);
            this.gen6Btn.Name = "gen6Btn";
            this.gen6Btn.Size = new System.Drawing.Size(412, 68);
            this.gen6Btn.TabIndex = 14;
            this.gen6Btn.Text = "Gen 6\r\n(650-721)\r\n";
            this.gen6Btn.UseVisualStyleBackColor = false;
            this.gen6Btn.Click += new System.EventHandler(this.gen6Btn_Click);
            this.gen6Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen6Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen5Btn
            // 
            this.gen5Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen5Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen5Btn.FlatAppearance.BorderSize = 3;
            this.gen5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen5Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen5Btn.Location = new System.Drawing.Point(0, 304);
            this.gen5Btn.Name = "gen5Btn";
            this.gen5Btn.Size = new System.Drawing.Size(412, 68);
            this.gen5Btn.TabIndex = 13;
            this.gen5Btn.Text = "Gen 5\r\n(494-649)\r\n";
            this.gen5Btn.UseVisualStyleBackColor = false;
            this.gen5Btn.Click += new System.EventHandler(this.gen5Btn_Click);
            this.gen5Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen5Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen4Btn
            // 
            this.gen4Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen4Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen4Btn.FlatAppearance.BorderSize = 3;
            this.gen4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen4Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen4Btn.Location = new System.Drawing.Point(0, 236);
            this.gen4Btn.Name = "gen4Btn";
            this.gen4Btn.Size = new System.Drawing.Size(412, 68);
            this.gen4Btn.TabIndex = 12;
            this.gen4Btn.Text = "Gen 4\r\n(387-493)\r\n";
            this.gen4Btn.UseVisualStyleBackColor = false;
            this.gen4Btn.Click += new System.EventHandler(this.gen4Btn_Click);
            this.gen4Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen4Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen3Btn
            // 
            this.gen3Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen3Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen3Btn.FlatAppearance.BorderSize = 3;
            this.gen3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen3Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen3Btn.Location = new System.Drawing.Point(0, 168);
            this.gen3Btn.Name = "gen3Btn";
            this.gen3Btn.Size = new System.Drawing.Size(412, 68);
            this.gen3Btn.TabIndex = 11;
            this.gen3Btn.Text = "Gen 3\r\n(252-386)\r\n";
            this.gen3Btn.UseVisualStyleBackColor = false;
            this.gen3Btn.Click += new System.EventHandler(this.gen3Btn_Click);
            this.gen3Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen3Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen2Btn
            // 
            this.gen2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen2Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen2Btn.FlatAppearance.BorderSize = 3;
            this.gen2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen2Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen2Btn.Location = new System.Drawing.Point(0, 100);
            this.gen2Btn.Name = "gen2Btn";
            this.gen2Btn.Size = new System.Drawing.Size(412, 68);
            this.gen2Btn.TabIndex = 10;
            this.gen2Btn.Text = "Gen 2\r\n(152-251)\r\n";
            this.gen2Btn.UseVisualStyleBackColor = false;
            this.gen2Btn.Click += new System.EventHandler(this.gen2Btn_Click);
            this.gen2Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen2Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // gen1Btn
            // 
            this.gen1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gen1Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen1Btn.FlatAppearance.BorderSize = 3;
            this.gen1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen1Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gen1Btn.Location = new System.Drawing.Point(0, 32);
            this.gen1Btn.Name = "gen1Btn";
            this.gen1Btn.Size = new System.Drawing.Size(412, 68);
            this.gen1Btn.TabIndex = 9;
            this.gen1Btn.Text = "Gen 1\r\n(1-151)\r\n";
            this.gen1Btn.UseVisualStyleBackColor = false;
            this.gen1Btn.Click += new System.EventHandler(this.gen1Btn_Click);
            this.gen1Btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.gen1Btn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            // 
            // GenSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(412, 578);
            this.ControlBox = false;
            this.Controls.Add(this.gen8Btn);
            this.Controls.Add(this.gen7Btn);
            this.Controls.Add(this.gen6Btn);
            this.Controls.Add(this.gen5Btn);
            this.Controls.Add(this.gen4Btn);
            this.Controls.Add(this.gen3Btn);
            this.Controls.Add(this.gen2Btn);
            this.Controls.Add(this.gen1Btn);
            this.Controls.Add(this.toolBarPanel);
            this.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GenSelectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TargetForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenSelectForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenSelectForm_PreviewKeyDown);
            this.toolBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Button gen8Btn;
        private System.Windows.Forms.Button gen7Btn;
        private System.Windows.Forms.Button gen6Btn;
        private System.Windows.Forms.Button gen5Btn;
        private System.Windows.Forms.Button gen4Btn;
        private System.Windows.Forms.Button gen3Btn;
        private System.Windows.Forms.Button gen2Btn;
        private System.Windows.Forms.Button gen1Btn;
        private System.Windows.Forms.Panel exitIcon;
        public System.Windows.Forms.ProgressBar pkmnLoadBar;
    }
}