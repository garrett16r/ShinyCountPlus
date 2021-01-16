namespace ShinyCountPlus
{
    partial class TargetSelectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pkmnGridView = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Col10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.targetLbl = new System.Windows.Forms.Label();
            this.exitIcon = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pkmnGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkmnGridView
            // 
            this.pkmnGridView.AllowUserToAddRows = false;
            this.pkmnGridView.AllowUserToDeleteRows = false;
            this.pkmnGridView.AllowUserToResizeColumns = false;
            this.pkmnGridView.AllowUserToResizeRows = false;
            this.pkmnGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pkmnGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pkmnGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pkmnGridView.ColumnHeadersHeight = 32;
            this.pkmnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pkmnGridView.ColumnHeadersVisible = false;
            this.pkmnGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8,
            this.Col9,
            this.Col10});
            this.pkmnGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.pkmnGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pkmnGridView.Location = new System.Drawing.Point(0, 32);
            this.pkmnGridView.MultiSelect = false;
            this.pkmnGridView.Name = "pkmnGridView";
            this.pkmnGridView.ReadOnly = true;
            this.pkmnGridView.RowHeadersVisible = false;
            this.pkmnGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pkmnGridView.RowTemplate.Height = 75;
            this.pkmnGridView.RowTemplate.ReadOnly = true;
            this.pkmnGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pkmnGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pkmnGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.pkmnGridView.Size = new System.Drawing.Size(1020, 557);
            this.pkmnGridView.TabIndex = 0;
            this.pkmnGridView.TabStop = false;
            this.pkmnGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pkmnGridView_CellDoubleClick);
            this.pkmnGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TargetSelectForm_KeyDown);
            this.pkmnGridView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TargetSelectForm_PreviewKeyDown);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "";
            this.Col1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "";
            this.Col2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "";
            this.Col3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "";
            this.Col4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "";
            this.Col5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "";
            this.Col6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "";
            this.Col7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "";
            this.Col8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            // 
            // Col9
            // 
            this.Col9.HeaderText = "";
            this.Col9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col9.Name = "Col9";
            this.Col9.ReadOnly = true;
            // 
            // Col10
            // 
            this.Col10.HeaderText = "";
            this.Col10.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Col10.Name = "Col10";
            this.Col10.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.targetLbl);
            this.panel1.Controls.Add(this.exitIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // targetLbl
            // 
            this.targetLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetLbl.Location = new System.Drawing.Point(0, 0);
            this.targetLbl.Name = "targetLbl";
            this.targetLbl.Size = new System.Drawing.Size(979, 29);
            this.targetLbl.TabIndex = 8;
            this.targetLbl.Text = "target message";
            this.targetLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.targetLbl.Visible = false;
            // 
            // exitIcon
            // 
            this.exitIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitIcon.BackgroundImage = global::ShinyCountPlus.Properties.Resources.icons8_delete_32px;
            this.exitIcon.Location = new System.Drawing.Point(985, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(32, 32);
            this.exitIcon.TabIndex = 7;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // TargetSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 563);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pkmnGridView);
            this.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TargetSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TargetSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TargetSelectForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TargetSelectForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pkmnGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pkmnGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel exitIcon;
        private System.Windows.Forms.DataGridViewImageColumn Col1;
        private System.Windows.Forms.DataGridViewImageColumn Col2;
        private System.Windows.Forms.DataGridViewImageColumn Col3;
        private System.Windows.Forms.DataGridViewImageColumn Col4;
        private System.Windows.Forms.DataGridViewImageColumn Col5;
        private System.Windows.Forms.DataGridViewImageColumn Col6;
        private System.Windows.Forms.DataGridViewImageColumn Col7;
        private System.Windows.Forms.DataGridViewImageColumn Col8;
        private System.Windows.Forms.DataGridViewImageColumn Col9;
        private System.Windows.Forms.DataGridViewImageColumn Col10;
        private System.Windows.Forms.Label targetLbl;
    }
}