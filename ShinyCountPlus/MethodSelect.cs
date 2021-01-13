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
    public partial class MethodSelectForm : Form
    {
        private Main mainForm = null;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private Color accentColor;

        private bool shinyCharm = false;

        private List<Control> accentControls = new List<Control>();

        public MethodSelectForm(Form mainForm)
        {
            this.mainForm = mainForm as Main;
            InitializeComponent();
        }

        private void MethodSelectForm_Load(object sender, EventArgs e)
        {
            accentColor = mainForm.getAccentColor();
            shinyCharm = mainForm.shinyCharm;

            #region Add controls to accentControls<>
            accentControls.Add(shinyCharmBtn);
            accentControls.Add(re1Btn);
            accentControls.Add(re2Btn);
            accentControls.Add(sr1Btn);
            accentControls.Add(sr2Btn);
            accentControls.Add(radar1Btn);
            accentControls.Add(radar2Btn);
            accentControls.Add(combo1Btn);
            accentControls.Add(combo2Btn);
            accentControls.Add(oldMasudaBtn);
            accentControls.Add(chainFishBtn);
            accentControls.Add(hordeBtn);
            accentControls.Add(dexNavBtn);
            accentControls.Add(newMasudaBtn);
            accentControls.Add(friendSafariBtn);
            accentControls.Add(sosBtn);
            accentControls.Add(adventureBtn);
            #endregion

            setAccentColor();
        }

        private void setAccentColor()
        {
            foreach (Control control in accentControls)
            {
                control.BackColor = accentColor;
            }
        }

        private void shinyCharmBtn_Click(object sender, EventArgs e)
        {
            if (!shinyCharm)
            {
                shinyCharmBtn.Text = "Shiny Charm On";
                shinyCharm = true;
                radar1Btn.Enabled = false;
                radar2Btn.Enabled = false;
                friendSafariBtn.Enabled = false;
            } else
            {
                shinyCharmBtn.Text = "Shiny Charm Off";
                shinyCharm = false;
                radar1Btn.Enabled = true;
                radar2Btn.Enabled = true;
                friendSafariBtn.Enabled = true;
            }
        }

        #region Method buttons
        private void re1Btn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("REs (Gen 1-5)", mainForm.count, shinyCharm));
            mainForm.setMethod("REs (Gen 1-5)");
        }

        private void re2Btn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("REs (Gen 6+)", mainForm.count, shinyCharm));
            mainForm.setMethod("REs (Gen 6+)");
        }

        private void sr1Btn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("SRs (Gen 1-5)", mainForm.count, shinyCharm));
            mainForm.setMethod("SRs (Gen 1-5)");
        }

        private void sr2Btn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("SRs (Gen 6+)", mainForm.count, shinyCharm));
            mainForm.setMethod("SRs (Gen 6+)");
        }

        private void friendSafariBtn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("Friend Safari", mainForm.count, shinyCharm));
            mainForm.setMethod("Friend Safari");
        }

        private void oldMasudaBtn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("Masuda (Gen 4-5)", mainForm.count, shinyCharm));
            mainForm.setMethod("Masuda (Gen 4-5)");
        }

        private void newMasudaBtn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("Masuda (Gen 6+)", mainForm.count, shinyCharm));
            mainForm.setMethod("Masuda (Gen 6+)");
        }

        private void sosBtn_Click(object sender, EventArgs e)
        {
            mainForm.setOdds(Odds.getOdds("SoS Calls", mainForm.count, shinyCharm));
            mainForm.setMethod("SoS Calls");
        }
        #endregion

        #region Tools
        private void exitIcon_Click(object sender, EventArgs e)
        {
            mainForm.save();
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

        private void MethodSelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MethodSelectForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
    }
}
