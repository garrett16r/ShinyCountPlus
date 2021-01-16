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
            this.versionLbl = new System.Windows.Forms.Label();
            this.paypalPanel = new System.Windows.Forms.Panel();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.gitHubPanel = new System.Windows.Forms.Panel();
            this.optionsSubPanel = new System.Windows.Forms.Panel();
            this.incrementPanel = new System.Windows.Forms.Panel();
            this.incrementUpDown = new System.Windows.Forms.NumericUpDown();
            this.incrementLbl = new System.Windows.Forms.Label();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.accentLbl = new System.Windows.Forms.Label();
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
            this.sidebarBgPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titleLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.incrementBtn = new System.Windows.Forms.Button();
            this.minIcon = new System.Windows.Forms.Panel();
            this.menuIcon = new System.Windows.Forms.Panel();
            this.iconColorPanel = new System.Windows.Forms.Panel();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.exitIcon = new System.Windows.Forms.Panel();
            this.targetDisplayBtn = new System.Windows.Forms.Button();
            this.methodDisplayBtn = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.optionsSubPanel.SuspendLayout();
            this.incrementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incrementUpDown)).BeginInit();
            this.accentPanel.SuspendLayout();
            this.opacityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacitySlider)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.methodPanel.SuspendLayout();
            this.targetPanel.SuspendLayout();
            this.padPanel.SuspendLayout();
            this.iconColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sidePanel.Controls.Add(this.versionLbl);
            this.sidePanel.Controls.Add(this.paypalPanel);
            this.sidePanel.Controls.Add(this.aboutPanel);
            this.sidePanel.Controls.Add(this.gitHubPanel);
            this.sidePanel.Controls.Add(this.optionsSubPanel);
            this.sidePanel.Controls.Add(this.optionsPanel);
            this.sidePanel.Controls.Add(this.methodPanel);
            this.sidePanel.Controls.Add(this.targetPanel);
            this.sidePanel.Controls.Add(this.padPanel);
            this.sidePanel.Location = new System.Drawing.Point(283, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(253, 648);
            this.sidePanel.TabIndex = 0;
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Fredoka One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.versionLbl.Location = new System.Drawing.Point(21, 578);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(46, 19);
            this.versionLbl.TabIndex = 0;
            this.versionLbl.Tag = "11.25";
            this.versionLbl.Text = "v1.x.x";
            // 
            // paypalPanel
            // 
            this.paypalPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paypalPanel.BackgroundImage")));
            this.paypalPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paypalPanel.Location = new System.Drawing.Point(103, 598);
            this.paypalPanel.Name = "paypalPanel";
            this.paypalPanel.Size = new System.Drawing.Size(50, 50);
            this.paypalPanel.TabIndex = 6;
            this.paypalPanel.Click += new System.EventHandler(this.paypalPanel_Click);
            this.paypalPanel.MouseEnter += new System.EventHandler(this.paypalPanel_MouseEnter);
            this.paypalPanel.MouseLeave += new System.EventHandler(this.paypalPanel_MouseLeave);
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackgroundImage = global::ShinyCountPlus.Properties.Resources.ask_question_100px;
            this.aboutPanel.Location = new System.Drawing.Point(181, 598);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(50, 50);
            this.aboutPanel.TabIndex = 6;
            this.aboutPanel.Click += new System.EventHandler(this.aboutPanel_Click);
            this.aboutPanel.MouseEnter += new System.EventHandler(this.aboutPanel_MouseEnter);
            this.aboutPanel.MouseLeave += new System.EventHandler(this.aboutPanel_MouseLeave);
            // 
            // gitHubPanel
            // 
            this.gitHubPanel.BackgroundImage = global::ShinyCountPlus.Properties.Resources.GitHub_Mark2;
            this.gitHubPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gitHubPanel.Location = new System.Drawing.Point(22, 598);
            this.gitHubPanel.Name = "gitHubPanel";
            this.gitHubPanel.Size = new System.Drawing.Size(50, 50);
            this.gitHubPanel.TabIndex = 5;
            this.gitHubPanel.Click += new System.EventHandler(this.gitHubPanel_Click);
            this.gitHubPanel.MouseEnter += new System.EventHandler(this.gitHubPanel_MouseEnter);
            this.gitHubPanel.MouseLeave += new System.EventHandler(this.gitHubPanel_MouseLeave);
            // 
            // optionsSubPanel
            // 
            this.optionsSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.optionsSubPanel.Controls.Add(this.incrementPanel);
            this.optionsSubPanel.Controls.Add(this.accentPanel);
            this.optionsSubPanel.Controls.Add(this.opacityPanel);
            this.optionsSubPanel.Location = new System.Drawing.Point(0, 242);
            this.optionsSubPanel.Name = "optionsSubPanel";
            this.optionsSubPanel.Size = new System.Drawing.Size(253, 204);
            this.optionsSubPanel.TabIndex = 3;
            // 
            // incrementPanel
            // 
            this.incrementPanel.Controls.Add(this.incrementUpDown);
            this.incrementPanel.Controls.Add(this.incrementLbl);
            this.incrementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.incrementPanel.Location = new System.Drawing.Point(0, 136);
            this.incrementPanel.Name = "incrementPanel";
            this.incrementPanel.Size = new System.Drawing.Size(253, 68);
            this.incrementPanel.TabIndex = 2;
            this.incrementPanel.Click += new System.EventHandler(this.incrementPanel_Click);
            this.incrementPanel.MouseEnter += new System.EventHandler(this.incrementPanel_MouseEnter);
            this.incrementPanel.MouseLeave += new System.EventHandler(this.incrementPanel_MouseLeave);
            // 
            // incrementUpDown
            // 
            this.incrementUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incrementUpDown.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementUpDown.InterceptArrowKeys = false;
            this.incrementUpDown.Location = new System.Drawing.Point(161, 17);
            this.incrementUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.incrementUpDown.Name = "incrementUpDown";
            this.incrementUpDown.Size = new System.Drawing.Size(58, 33);
            this.incrementUpDown.TabIndex = 3;
            this.incrementUpDown.TabStop = false;
            this.incrementUpDown.Tag = "18";
            this.incrementUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.incrementUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.incrementUpDown.Visible = false;
            this.incrementUpDown.ValueChanged += new System.EventHandler(this.incrementUpDown_ValueChanged);
            // 
            // incrementLbl
            // 
            this.incrementLbl.AutoSize = true;
            this.incrementLbl.Font = new System.Drawing.Font("Fredoka One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.incrementLbl.Location = new System.Drawing.Point(21, 22);
            this.incrementLbl.Name = "incrementLbl";
            this.incrementLbl.Size = new System.Drawing.Size(102, 24);
            this.incrementLbl.TabIndex = 2;
            this.incrementLbl.Tag = "15.75";
            this.incrementLbl.Text = "Increment";
            this.incrementLbl.Click += new System.EventHandler(this.incrementPanel_Click);
            this.incrementLbl.MouseEnter += new System.EventHandler(this.incrementPanel_MouseEnter);
            this.incrementLbl.MouseLeave += new System.EventHandler(this.incrementPanel_MouseLeave);
            // 
            // accentPanel
            // 
            this.accentPanel.Controls.Add(this.accentLbl);
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accentPanel.Location = new System.Drawing.Point(0, 68);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(253, 68);
            this.accentPanel.TabIndex = 1;
            this.accentPanel.Click += new System.EventHandler(this.accentPanel_Click);
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
            this.accentLbl.Size = new System.Drawing.Size(130, 24);
            this.accentLbl.TabIndex = 2;
            this.accentLbl.Tag = "15.75";
            this.accentLbl.Text = "Accent Color";
            this.accentLbl.Click += new System.EventHandler(this.accentPanel_Click);
            this.accentLbl.MouseEnter += new System.EventHandler(this.accentPanel_MouseEnter);
            this.accentLbl.MouseLeave += new System.EventHandler(this.accentPanel_MouseLeave);
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
            this.opacityPanel.MouseEnter += new System.EventHandler(this.opacityPanel_MouseEnter);
            this.opacityPanel.MouseLeave += new System.EventHandler(this.opacityPanel_MouseLeave);
            // 
            // opacityLbl
            // 
            this.opacityLbl.AutoSize = true;
            this.opacityLbl.Font = new System.Drawing.Font("Fredoka One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opacityLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opacityLbl.Location = new System.Drawing.Point(21, 18);
            this.opacityLbl.Name = "opacityLbl";
            this.opacityLbl.Size = new System.Drawing.Size(88, 24);
            this.opacityLbl.TabIndex = 1;
            this.opacityLbl.Tag = "15.75";
            this.opacityLbl.Text = "Opacity:";
            this.opacityLbl.MouseEnter += new System.EventHandler(this.opacityPanel_MouseEnter);
            this.opacityLbl.MouseLeave += new System.EventHandler(this.opacityPanel_MouseLeave);
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
            this.opacitySlider.MouseEnter += new System.EventHandler(this.opacityPanel_MouseEnter);
            this.opacitySlider.MouseLeave += new System.EventHandler(this.opacityPanel_MouseLeave);
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
            this.optionsLbl.Size = new System.Drawing.Size(97, 29);
            this.optionsLbl.TabIndex = 1;
            this.optionsLbl.Tag = "18";
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
            this.methodPanel.Click += new System.EventHandler(this.methodPanel_Click);
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
            this.methodLbl.Size = new System.Drawing.Size(93, 29);
            this.methodLbl.TabIndex = 1;
            this.methodLbl.Tag = "18";
            this.methodLbl.Text = "Method";
            this.methodLbl.Click += new System.EventHandler(this.methodPanel_Click);
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
            this.targetPanel.Click += new System.EventHandler(this.targetPanel_Click);
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
            this.targetLbl.Size = new System.Drawing.Size(79, 29);
            this.targetLbl.TabIndex = 0;
            this.targetLbl.Tag = "18";
            this.targetLbl.Text = "Target";
            this.targetLbl.Click += new System.EventHandler(this.targetPanel_Click);
            this.targetLbl.MouseEnter += new System.EventHandler(this.targetPanel_MouseEnter);
            this.targetLbl.MouseLeave += new System.EventHandler(this.targetPanel_MouseLeave);
            // 
            // padPanel
            // 
            this.padPanel.Controls.Add(this.sidebarBgPanel);
            this.padPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.padPanel.Location = new System.Drawing.Point(0, 0);
            this.padPanel.Name = "padPanel";
            this.padPanel.Size = new System.Drawing.Size(253, 62);
            this.padPanel.TabIndex = 0;
            // 
            // sidebarBgPanel
            // 
            this.sidebarBgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarBgPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarBgPanel.Name = "sidebarBgPanel";
            this.sidebarBgPanel.Size = new System.Drawing.Size(253, 62);
            this.sidebarBgPanel.TabIndex = 0;
            this.sidebarBgPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.sidebarBgPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.sidebarBgPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(50, 11);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(117, 22);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Tag = "14.25";
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
            this.countLbl.Font = new System.Drawing.Font("Fredoka One", 72F, System.Drawing.FontStyle.Bold);
            this.countLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countLbl.Location = new System.Drawing.Point(78, 245);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(301, 133);
            this.countLbl.TabIndex = 6;
            this.countLbl.Tag = "72b";
            this.countLbl.Text = "1200";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.countLbl.Click += new System.EventHandler(this.countLbl_Click);
            // 
            // incrementBtn
            // 
            this.incrementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
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
            this.minIcon.Visible = false;
            this.minIcon.Click += new System.EventHandler(this.minIcon_Click);
            // 
            // menuIcon
            // 
            this.menuIcon.BackgroundImage = global::ShinyCountPlus.Properties.Resources.menu_icon_close;
            this.menuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuIcon.Location = new System.Drawing.Point(0, 0);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.Size = new System.Drawing.Size(50, 50);
            this.menuIcon.TabIndex = 1;
            this.menuIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuIcon_MouseClick);
            // 
            // iconColorPanel
            // 
            this.iconColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconColorPanel.Controls.Add(this.menuIcon);
            this.iconColorPanel.Location = new System.Drawing.Point(0, 0);
            this.iconColorPanel.Name = "iconColorPanel";
            this.iconColorPanel.Size = new System.Drawing.Size(50, 50);
            this.iconColorPanel.TabIndex = 5;
            // 
            // underlinePanel
            // 
            this.underlinePanel.Location = new System.Drawing.Point(53, 38);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(118, 3);
            this.underlinePanel.TabIndex = 8;
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
            // targetDisplayBtn
            // 
            this.targetDisplayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.targetDisplayBtn.FlatAppearance.BorderSize = 0;
            this.targetDisplayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.targetDisplayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.targetDisplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetDisplayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.targetDisplayBtn.Location = new System.Drawing.Point(126, 85);
            this.targetDisplayBtn.Name = "targetDisplayBtn";
            this.targetDisplayBtn.Size = new System.Drawing.Size(192, 192);
            this.targetDisplayBtn.TabIndex = 10;
            this.targetDisplayBtn.UseVisualStyleBackColor = true;
            this.targetDisplayBtn.Click += new System.EventHandler(this.incrementBtn_Click);
            // 
            // methodDisplayBtn
            // 
            this.methodDisplayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.methodDisplayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.methodDisplayBtn.FlatAppearance.BorderSize = 0;
            this.methodDisplayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.methodDisplayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.methodDisplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodDisplayBtn.Font = new System.Drawing.Font("Fredoka One", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodDisplayBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.methodDisplayBtn.Location = new System.Drawing.Point(0, 564);
            this.methodDisplayBtn.Name = "methodDisplayBtn";
            this.methodDisplayBtn.Size = new System.Drawing.Size(440, 84);
            this.methodDisplayBtn.TabIndex = 11;
            this.methodDisplayBtn.TabStop = false;
            this.methodDisplayBtn.Tag = "21.75b";
            this.methodDisplayBtn.Text = "1/621\r\nMasuda (Gen 4-5)";
            this.methodDisplayBtn.UseVisualStyleBackColor = false;
            this.methodDisplayBtn.Click += new System.EventHandler(this.methodDisplayBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(438, 648);
            this.ControlBox = false;
            this.Controls.Add(this.methodDisplayBtn);
            this.Controls.Add(this.iconColorPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.targetDisplayBtn);
            this.Controls.Add(this.underlinePanel);
            this.Controls.Add(this.minIcon);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.incrementBtn);
            this.Font = new System.Drawing.Font("Fredoka One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Main_PreviewKeyDown);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.optionsSubPanel.ResumeLayout(false);
            this.incrementPanel.ResumeLayout(false);
            this.incrementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incrementUpDown)).EndInit();
            this.accentPanel.ResumeLayout(false);
            this.accentPanel.PerformLayout();
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
            this.iconColorPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel sidebarBgPanel;
        public System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label methodLbl;
        public System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.Label accentLbl;
        private System.Windows.Forms.Panel iconColorPanel;
        private System.Windows.Forms.Panel underlinePanel;
        private System.Windows.Forms.Button targetDisplayBtn;
        private System.Windows.Forms.Button methodDisplayBtn;
        public System.Windows.Forms.Panel incrementPanel;
        private System.Windows.Forms.Label incrementLbl;
        private System.Windows.Forms.NumericUpDown incrementUpDown;
        private System.Windows.Forms.Panel paypalPanel;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Panel gitHubPanel;
        private System.Windows.Forms.Label versionLbl;
    }
}

