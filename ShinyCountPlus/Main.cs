using ShinyCountPlus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ShinyCountPlus
{
    public partial class Main : Form
    {
        public string FILES_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus/");
        public string SAVE_FILE = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus/data.sav");

        bool dragging = false;
        Point startPoint = new Point(0, 0);

        Color accentColor = Color.FromArgb(128, 128, 255); // Will pull from save file

        bool menuOut = false;
        int count = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            createDirectories();
            sidePanel.Location = new Point(-253, 0);
            optionsSubPanel.Visible = false;
            countLbl.Text = count.ToString();
        }

        #region Custom methods
        private void save()
        {
            using (StreamWriter sw = new StreamWriter(SAVE_FILE))
            {
                sw.WriteLine("encounters: " + count.ToString());
                sw.WriteLine("window_opacity: " + this.Opacity);
                sw.WriteLine("accent_color_r: " + accentColor.R);
                sw.WriteLine("accent_color_g: " + accentColor.G);
                sw.WriteLine("accent_color_b: " + accentColor.B);
                sw.Close();
            }
        }

        private void load()
        {
            using (StreamReader sr = new StreamReader(SAVE_FILE))
            {
                try
                {
                    count = int.Parse(sr.ReadLine().Split(':')[1]);

                    this.Opacity = float.Parse(sr.ReadLine().Split(':')[1]);
                    opacitySlider.Value = (int)(this.Opacity * 10);

                    int r = int.Parse(sr.ReadLine().Split(':')[1]);
                    int g = int.Parse(sr.ReadLine().Split(':')[1]);
                    int b = int.Parse(sr.ReadLine().Split(':')[1]);

                    sr.Close();
                    setAccentColor(Color.FromArgb(r, g, b));
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
        }

        // Create needed directories and files if they don't exist
        private void createDirectories()
        {
            if (!Directory.Exists(FILES_DIR))
            {
                Directory.CreateDirectory(FILES_DIR);
                File.Create(SAVE_FILE).Close();
            } else
            {
                load();
            }
        }

        // Update counter and save data
        private void updateCount(int increment = 1)
        {
            if (increment < 0)
            {
                if (count == 0)
                {
                    return;
                }
            }
            count += increment;
            countLbl.Text = count.ToString();
            save();
        }

        // Set accent color
        public void setAccentColor(Color c)
        {
            Control[] normalAccentControls = { sidePanel, panel1, optionsPanel, targetPanel, methodPanel, iconColorPanel, underlinePanel, iconColorPanel };
            Control[] darkAccentControls = { optionsSubPanel, opacityPanel };
            accentColor = c;
            save();
            
            foreach (Control ctrl in normalAccentControls)
            {
                ctrl.BackColor = c;
            }

            foreach (Control ctrl in darkAccentControls)
            {
                ctrl.BackColor = Color.FromArgb(c.R - 16, c.G - 16, c.B);
            }
            countLbl.ForeColor = c;
        }

        public Color getAccentColor()
        {
            return accentColor;
        }

        // Expand the side panel in a smooth sliding animation
        async void animateSidePanel()
        {
            Point panelLocation = sidePanel.Location;
            Point countLblLocation = countLbl.Location;
            Point titleLocation = titleLbl.Location;
            Point underlineLocation = underlinePanel.Location;
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

                // Move title underline
                underlinePanel.Location = new Point(underlineLocation.X + titleXDelta, underlineLocation.Y);
                underlineLocation.X += titleXDelta;

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

        private void highlightPanelOnEnter(Panel p, bool isSubPanel)
        {
            int colorDelta;
            if (isSubPanel) colorDelta = 24; else colorDelta = 16;

            p.BackColor = Color.FromArgb(accentColor.R - colorDelta, accentColor.G - colorDelta, accentColor.B);
        }

        private void unhighlightPanelOnLeave(Panel p, bool isSubPanel)
        {
            int colorDelta = 0;
            if (isSubPanel) colorDelta = 16;

            p.BackColor = Color.FromArgb(accentColor.R - colorDelta, accentColor.G - colorDelta, accentColor.B);
        }

        private void highlightPanelOnEnter(Panel p, Panel sp)
        {
            if (!sp.Visible)
            {
                int colorDelta = 16;
                p.BackColor = Color.FromArgb(accentColor.R - colorDelta, accentColor.G - colorDelta, accentColor.B);
            } else
            {
                int colorDelta = 33;
                p.BackColor = Color.FromArgb(accentColor.R - colorDelta, accentColor.G - colorDelta, accentColor.B);
            }
        }

        private void unhighlightPanelOnLeave(Panel p, Panel sp)
        {
            if (!sp.Visible)
            {
                p.BackColor = accentColor;
            } else
            {
                int colorDelta = 24;
                p.BackColor = Color.FromArgb(accentColor.R - colorDelta, accentColor.G - colorDelta, accentColor.B);
            }
        }
        #endregion

        #region Main events
        async void menuIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (!menuOut)
            {
                menuIcon.BackgroundImage = Resources.menu_icon_open;
                sidePanel.Visible = true;
                animateSidePanel();
                menuOut = true;
            }
            else
            {
                animateSidePanel();
                menuOut = false;
                incrementBtn.Focus();
                await Task.Delay(125);
                menuIcon.BackgroundImage = Resources.menu_icon_close;
                await Task.Delay(200);
                sidePanel.Visible = false;
            }
        }
        private void incrementBtn_Click(object sender, EventArgs e)
        {
            updateCount();
        }

        private void countLbl_Click(object sender, EventArgs e)
        {
            updateCount();
        }
        #endregion

        #region Keybinds
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                updateCount();
            }
            else if (e.KeyCode == Keys.Down)
            {
                updateCount(-1);
            } else if (e.KeyCode == Keys.R)
            {
                count = 0;
                countLbl.Text = count.ToString();
                save();
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
            highlightPanelOnEnter(targetPanel, false);
        }

        private void targetPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(targetPanel, false);
        }

        private void targetPanel_Click(object sender, EventArgs e)
        {
            TargetForm tf = new TargetForm(this);
            tf.ShowDialog();
        }
        #endregion

        #region - Select Method
        private void methodPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(methodPanel, false);
        }

        private void methodPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(methodPanel, false);
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

        private void opacityPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(opacityPanel, true);
        }

        private void opacityPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(opacityPanel, true);
        }

        private void accentPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(accentPanel, true);
        }

        private void accentPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(accentPanel, true);
        }

        private void accentPanel_Click(object sender, EventArgs e)
        {
            AccentColorForm acf = new AccentColorForm(this);
            acf.ShowDialog();
        }
        #endregion
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
            save();
            Application.Exit();
        }

        private void minIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
