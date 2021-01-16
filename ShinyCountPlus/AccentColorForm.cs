using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyCountPlus
{
    public partial class AccentColorForm : Form
    {
        bool dragging = false;
        Point startPoint = new Point(0, 0);

        private Main mainForm = null;

        public AccentColorForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm as Main;
        }

        private void updateColors(Color c)
        {
            mainForm.setAccentColor(c);
            mainForm.optionsPanel.BackColor = Color.FromArgb(c.R - 24, c.G - 24, c.B);
            mainForm.accentPanel.BackColor = Color.FromArgb(c.R - 16, c.G - 16, c.B);
        }

        #region Color Buttons
        private void purpleBtn_Click(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(128, 128, 255);
            updateColors(c);
        }

        private void salmonBtn_Click(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(224, 74, 92);
            mainForm.setAccentColor(c);
            updateColors(c);
        }

        private void tealBtn_Click(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(34, 214, 169);
            mainForm.setAccentColor(c);
            updateColors(c);
        }

        private void pinkBtn_Click(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(222, 100, 199);
            mainForm.setAccentColor(c);
            updateColors(c);
        }
        #endregion

        #region Tools
        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
    }
}
