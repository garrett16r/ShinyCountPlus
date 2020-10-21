using ShinyCountPlus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyCountPlus
{
    public partial class Main : Form
    {
        public string SAVE_FILE = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus\\save.xml");
        public string RES_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus\\");

        bool dragging = false;
        Point startPoint = new Point(0, 0);

        bool menuOut = false;
        int count = 0;

        public Main()
        {
            InitializeComponent();
        }

        #region Custom methods
        // Expand the side panel in a smooth sliding animation
        async void animateSidePanel()
        {
            Point panelLocation = sidePanel.Location;
            Point countLblLocation = countLbl.Location;
            Point titleLocation = titleLbl.Location;
            int xDelta;
            int titleXDelta; // Title needs to move less, so needs a separate var

            if (menuOut) xDelta = -23; else xDelta = 23;
            if (menuOut) titleXDelta = -19; else titleXDelta = 19;

            for (int i = 0; i < 11; i++)
            {
                // Delay movement of the counter
                if (i > 5)
                {
                    countLbl.Location = new Point(countLblLocation.X + xDelta, countLblLocation.Y);
                    countLblLocation.X += xDelta;
                }

                // Move title label
                titleLbl.Location = new Point(titleLocation.X + titleXDelta, titleLocation.Y);
                titleLocation.X += titleXDelta;

                // Move side panel
                sidePanel.Location = new Point(panelLocation.X + xDelta, panelLocation.Y);
                panelLocation.X += xDelta;

                await Task.Delay(10);
            }
        }

        private void showSubMenu(Panel p)
        {
            if (!p.Visible)
            {
                p.Visible = true;
            } else
            {
                p.Visible = false;
            }
        }

        private void highlightPanelOnEnter(Panel p, int r = 112, int g = 112, int b = 255)
        {
            p.BackColor = Color.FromArgb(r, g, b);
        }

        private void unhighlightPanelOnLeave(Panel p, int r = 128, int g = 128, int b = 255)
        {
            p.BackColor = Color.FromArgb(r, g, b);
        }
        private void highlightPanelOnEnter(Panel p, Panel sp)
        {
            if (!sp.Visible)
            {
                p.BackColor = Color.FromArgb(112, 112, 255);
            }
            else
            {
                p.BackColor = Color.FromArgb(95, 95, 255);
            }
        }

        private void unhighlightPanelOnLeave(Panel p, Panel sp)
        {
            if (!sp.Visible)
            {
                p.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                p.BackColor = Color.FromArgb(104, 104, 255);
            }
        }
        #endregion

        #region Keybinds
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                count++;
                countLbl.Text = count.ToString();
            } else if (e.KeyCode == Keys.Down)
            {
                count--;
                countLbl.Text = count.ToString();
            }
        }

        private void incrementBtn_KeyDown(object sender, KeyEventArgs e)
        {
            Main_KeyDown(sender, e);
        }

        // Allow arrow keys to be used as input
        private void Main_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void incrementBtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
        #endregion

        #region Menus
        #region - Select Target
        private void targetPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(targetPanel);
        }

        private void targetPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(targetPanel);
        }
        #endregion

        #region - Select Method
        private void methodPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(methodPanel);
        }

        private void methodPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(methodPanel);
        }
        #endregion

        #region - Options
        private void optionsPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(optionsPanel, optionsSubPanel);
        }

        private void optionsPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(optionsPanel, optionsSubPanel);
        }

        private void optionsLbl_MouseEnter(object sender, EventArgs e)
        {
            optionsPanel_MouseEnter(sender, e);
        }

        private void optionsPanel_Click(object sender, EventArgs e)
        {
            showSubMenu(optionsSubPanel);
        }

        private void optionsLbl_Click(object sender, EventArgs e)
        {
            showSubMenu(optionsSubPanel);
        }

        private void opacitySlider_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)opacitySlider.Value / 10;
        }

        private void accentPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(accentPanel, 104, 104, 255);
        }
        private void accentPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(accentPanel, 112, 112, 255);
        }
        #endregion
        #endregion

        #region Other
        // Next three methods allow window to be moved without a titlebar
        private void Main_Load(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(-253, 0);
            optionsSubPanel.Visible = false;
            optionsSubPanel.Visible = false;
            countLbl.Text = count.ToString();
        }

        private void menuIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (!menuOut)
            {
                menuIcon.BackgroundImage = Resources.menu_icon_2;
                sidePanel.Visible = true;
                animateSidePanel();
                menuOut = true;
            }
            else
            {
                animateSidePanel();
                menuIcon.BackgroundImage = Resources.Menu_icon;
                sidePanel.Visible = false;
                menuOut = false;
            }
        }
        private void incrementBtn_Click(object sender, EventArgs e)
        {
            count++;
            countLbl.Text = count.ToString();
        }

        private void countLbl_Click(object sender, EventArgs e)
        {
            incrementBtn_Click(sender, e);
        }
        #endregion

        #region Tool Bar
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
