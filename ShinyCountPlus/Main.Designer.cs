namespace ShinyCountPlus
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.optionsSubPanel = new System.Windows.Forms.Panel();
            this.opacityPanel = new System.Windows.Forms.Panel();
            this.opacityLbl = new System.Windows.Forms.Label();
            this.opacitySlider = new System.Windows.Forms.TrackBar();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.optionsLbl = new System.Windows.Forms.Label();
            this.methodPanel = new System.Windows.Forms.Panel();
            this.methodLbl = new System.Windows.Forms.Label();
            this.targetPanel = new System.Windows.Forms.Panel();
            this.targetLbl = new System.Windows.Forms.Label();
            this.padPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titleLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.incrementBtn = new System.Windows.Forms.Button();
            this.minIcon = new System.Windows.Forms.Panel();
            this.exitIcon = new System.Windows.Forms.Panel();
            this.menuIcon = new System.Windows.Forms.Panel();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.accentLbl = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.optionsSubPanel.SuspendLayout();
            this.opacityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySlider)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.methodPanel.SuspendLayout();
            this.targetPanel.SuspendLayout();
            this.padPanel.SuspendLayout();
            this.accentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sidePanel.Controls.Add(this.optionsSubPanel);
            this.sidePanel.Controls.Add(this.optionsPanel);
            this.sidePanel.Controls.Add(this.methodPanel);
            this.sidePanel.Controls.Add(this.targetPanel);
            this.sidePanel.Controls.Add(this.padPanel);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(253, 648);
            this.sidePanel.TabIndex = 0;
            // 
            // optionsSubPanel
            // 
            this.optionsSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.optionsSubPanel.Controls.Add(this.accentPanel);
            this.optionsSubPanel.Controls.Add(this.opacityPanel);
            this.optionsSubPanel.Location = new System.Drawing.Point(0, 242);
            this.optionsSubPanel.Name = "optionsSubPanel";
            this.optionsSubPanel.Size = new System.Drawing.Size(253, 136);
            this.optionsSubPanel.TabIndex = 3;
            // 
            // opacityPanel
            // 
            this.opacityPanel.Controls.Add(this.opacityLbl);
            this.opacityPanel.Controls.Add(this.opacitySlider);
            this.opacityPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.opacityPanel.Location = new System.Drawing.Point(0, 0);
            this.opacityPanel.Name = "opacityPanel";
            this.opacityPanel.Size = new System.Drawing.Size(253, 68);
            this.opacityPanel.TabIndex = 0;
            // 
            // opacityLbl
            // 
            this.opacityLbl.AutoSize = true;
            this.opacityLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.opacityLbl.Font = new System.Drawing.Font("Fredoka One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opacityLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opacityLbl.Location = new System.Drawing.Point(21, 18);
            this.opacityLbl.Name = "opacityLbl";
            this.opacityLbl.Size = new System.Drawing.Size(96, 25);
            this.opacityLbl.TabIndex = 1;
            this.opacityLbl.Text = "Opacity:";
            // 
            // opacitySlider
            // 
            this.opacitySlider.LargeChange = 2;
            this.opacitySlider.Location = new System.Drawing.Point(123, 20);
            this.opacitySlider.Minimum = 1;
            this.opacitySlider.Name = "opacitySlider";
            this.opacitySlider.Size = new System.Drawing.Size(104, 45);
            this.opacitySlider.TabIndex = 2;
            this.opacitySlider.TabStop = false;
            this.opacitySlider.TickFrequency = 10;
            this.opacitySlider.Value = 10;
            this.opacitySlider.ValueChanged += new System.EventHandler(this.opacitySlider_ValueChanged);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.optionsLbl);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsPanel.Location = new System.Drawing.Point(0, 182);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(253, 60);
            this.optionsPanel.TabIndex = 4;
            this.optionsPanel.Click += new System.EventHandler(this.optionsPanel_Click);
            this.optionsPanel.MouseEnter += new System.EventHandler(this.optionsPanel_MouseEnter);
            this.optionsPanel.MouseLeave += new System.EventHandler(this.optionsPanel_MouseLeave);
            // 
            // optionsLbl
            // 
            this.optionsLbl.AutoSize = true;
            this.optionsLbl.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.optionsLbl.Location = new System.Drawing.Point(3, 15);
            this.optionsLbl.Name = "optionsLbl";
            this.optionsLbl.Size = new System.Drawing.Size(104, 29);
            this.optionsLbl.TabIndex = 1;
            this.optionsLbl.Text = "Options";
            this.optionsLbl.Click += new System.EventHandler(this.optionsLbl_Click);
            this.optionsLbl.MouseEnter += new System.EventHandler(this.optionsPanel_MouseEnter);
            this.optionsLbl.MouseLeave += new System.EventHandler(this.optionsPanel_MouseLeave);
            // 
            // methodPanel
            // 
            this.methodPanel.Controls.Add(this.methodLbl);
            this.methodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.methodPanel.Location = new System.Drawing.Point(0, 122);
            this.methodPanel.Name = "methodPanel";
            this.methodPanel.Size = new System.Drawing.Size(253, 60);
            this.methodPanel.TabIndex = 2;
            this.methodPanel.MouseEnter += new System.EventHandler(this.methodPanel_MouseEnter);
            this.methodPanel.MouseLeave += new System.EventHandler(this.methodPanel_MouseLeave);
            // 
            // methodLbl
            // 
            this.methodLbl.AutoSize = true;
            this.methodLbl.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.methodLbl.Location = new System.Drawing.Point(4, 15);
            this.methodLbl.Name = "methodLbl";
            this.methodLbl.Size = new System.Drawing.Size(181, 29);
            this.methodLbl.TabIndex = 1;
            this.methodLbl.Text = "Select Method";
            this.methodLbl.MouseEnter += new System.EventHandler(this.methodPanel_MouseEnter);
            this.methodLbl.MouseLeave += new System.EventHandler(this.methodPanel_MouseLeave);
            // 
            // targetPanel
            // 
            this.targetPanel.Controls.Add(this.targetLbl);
            this.targetPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.targetPanel.Location = new System.Drawing.Point(0, 62);
            this.targetPanel.Name = "targetPanel";
            this.targetPanel.Size = new System.Drawing.Size(253, 60);
            this.targetPanel.TabIndex = 0;
            this.targetPanel.MouseEnter += new System.EventHandler(this.targetPanel_MouseEnter);
            this.targetPanel.MouseLeave += new System.EventHandler(this.targetPanel_MouseLeave);
            // 
            // targetLbl
            // 
            this.targetLbl.AutoSize = true;
            this.targetLbl.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.targetLbl.Location = new System.Drawing.Point(4, 15);
            this.targetLbl.Name = "targetLbl";
            this.targetLbl.Size = new System.Drawing.Size(170, 29);
            this.targetLbl.TabIndex = 0;
            this.targetLbl.Text = "Select Target";
            this.targetLbl.MouseEnter += new System.EventHandler(this.targetPanel_MouseEnter);
            this.targetLbl.MouseLeave += new System.EventHandler(this.targetPanel_MouseLeave);
            // 
            // padPanel
            // 
            this.padPanel.Controls.Add(this.panel1);
            this.padPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.padPanel.Location = new System.Drawing.Point(0, 0);
            this.padPanel.Name = "padPanel";
            this.padPanel.Size = new System.Drawing.Size(253, 62);
            this.padPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 62);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(51, 12);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(126, 23);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "ShinyCount+";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.titleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.titleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // countLbl
            // 
            this.countLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countLbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.countLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countLbl.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countLbl.Location = new System.Drawing.Point(73, 166);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(301, 116);
            this.countLbl.TabIndex = 6;
            this.countLbl.Text = "1200";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countLbl.Click += new System.EventHandler(this.countLbl_Click);
            // 
            // incrementBtn
            // 
            this.incrementBtn.FlatAppearance.BorderSize = 0;
            this.incrementBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.incrementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.incrementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incrementBtn.Location = new System.Drawing.Point(0, 50);
            this.incrementBtn.Name = "incrementBtn";
            this.incrementBtn.Size = new System.Drawing.Size(437, 598);
            this.incrementBtn.TabIndex = 7;
            this.incrementBtn.TabStop = false;
            this.incrementBtn.UseVisualStyleBackColor = true;
            this.incrementBtn.Click += new System.EventHandler(this.incrementBtn_Click);
            this.incrementBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.incrementBtn_KeyDown);
            this.incrementBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.incrementBtn_PreviewKeyDown);
            // 
            // minIcon
            // 
            this.minIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minIcon.BackgroundImage = global::ShinyCountPlus.Properties.Resources.icons8_subtract_32px;
            this.minIcon.Location = new System.Drawing.Point(363, 8);
            this.minIcon.Name = "minIcon";
            this.minIcon.Size = new System.Drawing.Size(32, 32);
            this.minIcon.TabIndex = 5;
            this.minIcon.Click += new System.EventHandler(this.minIcon_Click);
            // 
            // exitIcon
            // 
            this.exitIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitIcon.BackgroundImage = global::ShinyCountPlus.Properties.Resources.icons8_delete_32px;
            this.exitIcon.Location = new System.Drawing.Point(396, 8);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(32, 32);
            this.exitIcon.TabIndex = 4;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // menuIcon
            // 
            this.menuIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuIcon.BackgroundImage")));
            this.menuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuIcon.Location = new System.Drawing.Point(0, 0);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.Size = new System.Drawing.Size(50, 50);
            this.menuIcon.TabIndex = 1;
            this.menuIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuIcon_MouseClick);
            // 
            // accentPanel
            // 
            this.accentPanel.Controls.Add(this.accentLbl);
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accentPanel.Location = new System.Drawing.Point(0, 68);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(253, 68);
            this.accentPanel.TabIndex = 1;
            this.accentPanel.MouseEnter += new System.EventHandler(this.accentPanel_MouseEnter);
            this.accentPanel.MouseLeave += new System.EventHandler(this.accentPanel_MouseLeave);
            // 
            // accentLbl
            // 
            this.accentLbl.AutoSize = true;
            this.accentLbl.Font = new System.Drawing.Font("Fredoka One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accentLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accentLbl.Location = new System.Drawing.Point(21, 22);
            this.accentLbl.Name = "accentLbl";
            this.accentLbl.Size = new System.Drawing.Size(145, 25);
            this.accentLbl.TabIndex = 2;
            this.accentLbl.Text = "Accent Color";
            this.accentLbl.MouseEnter += new System.EventHandler(this.accentPanel_MouseEnter);
            this.accentLbl.MouseLeave += new System.EventHandler(this.accentPanel_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(438, 648);
            this.ControlBox = false;
            this.Controls.Add(this.minIcon);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.menuIcon);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.incrementBtn);
            this.Font = new System.Drawing.Font("Fredoka One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Main_PreviewKeyDown);
            this.sidePanel.ResumeLayout(false);
            this.optionsSubPanel.ResumeLayout(false);
            this.opacityPanel.ResumeLayout(false);
            this.opacityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySlider)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.methodPanel.ResumeLayout(false);
            this.methodPanel.PerformLayout();
            this.targetPanel.ResumeLayout(false);
            this.targetPanel.PerformLayout();
            this.padPanel.ResumeLayout(false);
            this.accentPanel.ResumeLayout(false);
            this.accentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel menuIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel exitIcon;
        private System.Windows.Forms.Panel minIcon;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button incrementBtn;
        private System.Windows.Forms.Panel padPanel;
        private System.Windows.Forms.Panel targetPanel;
        private System.Windows.Forms.Label targetLbl;
        private System.Windows.Forms.Label opacityLbl;
        private System.Windows.Forms.TrackBar opacitySlider;
        private System.Windows.Forms.Panel methodPanel;
        private System.Windows.Forms.Label optionsLbl;
        private System.Windows.Forms.Panel optionsSubPanel;
        private System.Windows.Forms.Panel opacityPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label methodLbl;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.Label accentLbl;
    }
}

