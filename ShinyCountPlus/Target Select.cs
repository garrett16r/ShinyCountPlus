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
    public partial class TargetForm : Form
    {
        private Main mainForm = null;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        Color accentColor;

        public TargetForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm as Main;
        }

        private void TargetForm_Load(object sender, EventArgs e)
        {
            accentColor = mainForm.getAccentColor();
            setAccentColor();
        }

        private void setAccentColor()
        {
            Control[] normalAccentControls = { gen1Btn, gen2Btn, gen3Btn, gen4Btn, gen5Btn, gen6Btn, gen7Btn, gen8Btn };

            foreach (Control control in normalAccentControls)
            {
                control.BackColor = accentColor;
            }
        }

        #region Tool bar
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
