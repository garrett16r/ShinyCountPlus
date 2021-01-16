using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyCountPlus
{
    public partial class GenSelectForm : Form
    {
        private Main mainForm = null;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        Color accentColor;

        int[] pkmnInGen = { 176, 101, 137, 107, 160, 72, 88, 81 };

        public GenSelectForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm as Main;
        }

        private void TargetForm_Load(object sender, EventArgs e)
        {
            applyFonts();
            this.Focus();
            accentColor = mainForm.getAccentColor();
            setAccentColor();
        }

        private void applyFonts()
        {
            foreach (var c in Util.GetAllChildren(this).OfType<Button>())
            {
                c.Font = mainForm.fredokaOne1425;
            }
        }

        private void setAccentColor()
        {
            Control[] normalAccentControls = { gen1Btn, gen2Btn, gen3Btn, gen4Btn, gen5Btn, gen6Btn, gen7Btn, gen8Btn };

            foreach (Control control in normalAccentControls)
            {
                control.BackColor = Color.FromArgb(accentColor.R - 16, accentColor.G - 16, accentColor.B);
            }
        }

        #region Generation Buttons
        private void gen1Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[0];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 1);
            tsf.ShowDialog();
        }

        private void gen2Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[1];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 2);
            tsf.ShowDialog();
        }

        private void gen3Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[2];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 3);
            tsf.ShowDialog();
        }

        private void gen4Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[3];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 4);
            tsf.ShowDialog();
        }

        private void gen5Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[4];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 5);
            tsf.ShowDialog();
        }

        private void gen6Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[5];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 6);
            tsf.ShowDialog();
        }

        private void gen7Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[6];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 7);
            tsf.ShowDialog();
        }

        private void gen8Btn_Click(object sender, EventArgs e)
        {
            int numPkmn = pkmnInGen[7];

            pkmnLoadBar.Maximum = numPkmn;
            pkmnLoadBar.Visible = true;

            TargetSelectForm tsf = new TargetSelectForm(this, mainForm, numPkmn, 8);
            tsf.ShowDialog();
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

        private void GenSelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void GenSelectForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
        #endregion
    }
}
