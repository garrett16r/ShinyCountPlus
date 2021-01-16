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
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyCountPlus
{
    public partial class Main : Form
    {
        // Framework for loading embedded FredokaOne font
        #region Font framework/variables
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fredokaOne72b;
        Font fredokaOne18;
        Font fredokaOne1575;
        Font fredokaOne2175b;
        public Font fredokaOne1425;
        Font fredokaOne1125;
        #endregion

        public string FILES_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus\\");
        public string IMG_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus\\img\\");
        public string SAVE_FILE = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ShinyCountPlus\\data.sav");
        public PrivateFontCollection pfc = new PrivateFontCollection();

        bool dragging = false;
        Point startPoint = new Point(0, 0);

        Color accentColor = Color.FromArgb(128, 128, 255);

        bool menuOut = false;
        public int count = 0;
        public int increment = 1;
        public string target = "";
        public string targetImgPath = "";
        public string method = "";
        public int odds = 8192;
        public bool shinyCharm = false;

        public Main()
        {
            InitializeComponent();
            loadFonts();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            createDirectories();
            setTargetDisplay();
            setMethodDisplay();

            // Prevents accidental drift of countLbl due to the ticking animation
            var timer = new System.Threading.Timer(t => correctCountPos(), null, TimeSpan.Zero, TimeSpan.FromSeconds(10));

            versionLbl.Text = $"v{ FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion }";
            sidePanel.Location = new Point(-253, 0);
            optionsSubPanel.Visible = false;
            countLbl.Text = count.ToString();
            incrementUpDown.Value = increment;
        }

        #region Custom methods
        public void save()
        {
            using (StreamWriter sw = new StreamWriter(SAVE_FILE))
            {
                sw.WriteLine("encounters: " + count.ToString());
                sw.WriteLine("target: " + target);
                sw.WriteLine("target_sprite_path: " + targetImgPath);
                sw.WriteLine("window_opacity: " + this.Opacity);
                sw.WriteLine("accent_color_r: " + accentColor.R);
                sw.WriteLine("accent_color_g: " + accentColor.G);
                sw.WriteLine("accent_color_b: " + accentColor.B);
                sw.WriteLine("method: " + method);
                sw.WriteLine("increment: " + increment);
                sw.WriteLine("shiny charm: " + shinyCharm);
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
                    target = sr.ReadLine().Split(' ')[1];
                    targetImgPath = sr.ReadLine().Split(' ')[1];

                    this.Opacity = float.Parse(sr.ReadLine().Split(':')[1]);
                    opacitySlider.Value = (int)(this.Opacity * 10);

                    int r = int.Parse(sr.ReadLine().Split(':')[1]);
                    int g = int.Parse(sr.ReadLine().Split(':')[1]);
                    int b = int.Parse(sr.ReadLine().Split(':')[1]);

                    method = sr.ReadLine().Split(new string[] { ": " }, StringSplitOptions.None)[1];
                    increment = int.Parse(sr.ReadLine().Split(':')[1]);
                    shinyCharm = bool.Parse(sr.ReadLine().Split(':')[1]);

                    sr.Close();
                    setAccentColor(Color.FromArgb(r, g, b));
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
        }

        private void loadFonts()
        {
            byte[] fontData = Resources.FredokaOne_Regular;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Resources.FredokaOne_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.FredokaOne_Regular.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            fredokaOne72b = new Font(fonts.Families[0], 72, FontStyle.Bold);
            fredokaOne18 = new Font(fonts.Families[0], 18);
            fredokaOne1575 = new Font(fonts.Families[0], 15.75f);
            fredokaOne2175b = new Font(fonts.Families[0], 21.75f, FontStyle.Bold);
            fredokaOne1425 = new Font(fonts.Families[0], 14.25f);
            fredokaOne1125 = new Font(fonts.Families[0], 11.25f);

            // Apply fonts to all needed controls
            foreach (var c in Util.GetAllChildren(this))
            {
                if (c.Font.Size == 72)
                {
                    c.Font = fredokaOne72b;
                } else if (c.Font.Size == 18)
                {
                    c.Font = fredokaOne18;
                } else if (c.Font.Size == 15.75)
                {
                    c.Font = fredokaOne1575;
                } else if (c.Font.Size == 21.75)
                {
                    c.Font = fredokaOne2175b;
                } else if (c.Font.Size == 14.25)
                {
                    c.Font = fredokaOne1425;
                } else if (c.Font.Size == 11.25)
                {
                    c.Font = fredokaOne1125;
                }
            }
        }

        private void correctCountPos()
        {
            if (!menuOut && countLbl.Location != new Point(78, 245))
            {
                countLbl.Location = new Point(78, 245); 
            }
        }

        // Create needed directories and files if they don't exist
        private void createDirectories()
        {
            if (!Directory.Exists(FILES_DIR))
            {
                Directory.CreateDirectory(FILES_DIR);
                Directory.CreateDirectory(IMG_DIR);
                File.Create(SAVE_FILE).Close();
            } else
            {
                load();
            }
        }

        // Display the currently selected target
        public void setTargetDisplay()
        {
            if (target != "")
            {
                try
                {
                    targetDisplayBtn.BackgroundImage = Image.FromFile(targetImgPath);
                } catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }

        // Update counter and save data
        private void updateCount(int increment = 1)
        {
            if (increment < 0)
            {
                animateCounter(0);
                if (count == 0)
                {
                    return;
                }
            } else
            {
                animateCounter(1);
            }


            count += increment;
            countLbl.Text = count.ToString();
            updateOdds();
            save();
        }

        public void setMethod(String method)
        {
            this.method = method;
            setMethodDisplay();
        }

        // Display the currently selected method and odds
        public void setMethodDisplay()
        {
            if (this.method != "")
            {
                try
                {
                    methodDisplayBtn.Text = "1/" + Odds.getOdds(method, count, shinyCharm) + "\n" + method;
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }

        // Check if current method requires updating odds dynamically, update them if so
        public void updateOdds()
        {
            string[] dynamicMethods =
            {
                "SoS Calls", "Catch Combo (No Lure)", "Catch Combo (With Lure)", "Chain Fishing", "Dex Nav", "Poke Radar (Gen 4)", "Poke Radar (Gen 6)"
            };

            if (dynamicMethods.Contains(method))
            {
                setOdds(Odds.getOdds(method, count, shinyCharm));
                setMethodDisplay();
            }
        }

        public void setOdds(int odds)
        {
            this.odds = odds;
        }

        // Set accent color
        public void setAccentColor(Color c)
        {
            Control[] normalAccentControls = { 
                sidePanel, sidebarBgPanel, optionsPanel, targetPanel, methodPanel, 
                iconColorPanel, underlinePanel, iconColorPanel, gitHubPanel, paypalPanel, 
                aboutPanel, methodDisplayBtn
            };
            Control[] darkAccentControls = { optionsSubPanel, opacityPanel, incrementPanel };
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
            incrementUpDown.ForeColor = c;
            methodDisplayBtn.FlatAppearance.MouseOverBackColor = c;
            methodDisplayBtn.FlatAppearance.MouseDownBackColor = c;
        }

        public Color getAccentColor()
        {
            return accentColor;
        }

        public void setShinyCharm(bool charm)
        {
            shinyCharm = charm;
            setOdds(Odds.getOdds(method, count, shinyCharm));
            setMethodDisplay();
        }

        // Expand the side panel in a smooth sliding animation
        async void animateSidePanel()
        {
            Point panelLocation = sidePanel.Location;
            Point countLblLocation = countLbl.Location;
            Point targetBtnLocation = targetDisplayBtn.Location;
            Point titleLocation = titleLbl.Location;
            Point underlineLocation = underlinePanel.Location;
            Point methodDisplayLocation = methodDisplayBtn.Location;
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
                    targetDisplayBtn.Location = new Point(targetBtnLocation.X + xDelta, targetBtnLocation.Y);
                    countLblLocation.X += xDelta;
                    targetBtnLocation.X += xDelta;
                }

                // Move method display
                methodDisplayBtn.Location = new Point(methodDisplayLocation.X, methodDisplayLocation.Y + titleXDelta);
                methodDisplayLocation.Y += xDelta;

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

        // Tick the counter up or down when increasing/decreasing value
        async void animateCounter(int upDown)
        {
            Point countPosition = countLbl.Location;

            int yDelta = 4;

            if (upDown == 0) yDelta = -4;

            countLbl.Location = new Point(countPosition.X, countPosition.Y - yDelta);
            await Task.Delay(50);
            countLbl.Location = new Point(countPosition.X, countPosition.Y);
            await Task.Delay(50);
            countLbl.Location = new Point(countPosition.X, countPosition.Y);
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

        #region Other event handlers
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
                incrementUpDown.Visible = false;
                menuIcon.BackgroundImage = Resources.menu_icon_close;
                await Task.Delay(200);
                sidePanel.Visible = false;
            }
        }

        private void incrementBtn_Click(object sender, EventArgs e)
        {
            updateCount(increment);
        }

        private void countLbl_Click(object sender, EventArgs e)
        {
            updateCount(increment);
        }

        private void methodDisplayBtn_Click(object sender, EventArgs e)
        {
            updateCount(increment);
        }
        #endregion

        #region Keybinds
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                updateCount(increment);
            }
            else if (e.KeyCode == Keys.Down)
            {
                updateCount(0 - increment);
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
            menuIcon_MouseClick(sender, (MouseEventArgs)e);
            GenSelectForm gsf = new GenSelectForm(this);
            gsf.ShowDialog();
        }
        #endregion

        #region - Select Method
        private void methodPanel_Click(object sender, EventArgs e)
        {
            menuIcon_MouseClick(sender, (MouseEventArgs)e);
            MethodSelectForm msf = new MethodSelectForm(this);
            msf.ShowDialog();
        }

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

        private void incrementPanel_Click(object sender, EventArgs e)
        {
            if (!incrementUpDown.Visible)
            {
                incrementUpDown.Visible = true;
            } else
            {
                incrementUpDown.Visible = false;
            }
        }

        private void incrementUpDown_ValueChanged(object sender, EventArgs e)
        {
            increment = (int)incrementUpDown.Value;
            save();
        }

        private void incrementPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(incrementPanel, true);
        }

        private void incrementPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(incrementPanel, true);
        }
        #endregion

        #region - Bottom Buttons
        private void gitHubPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Syntthetix/ShinyCountPlus");
        }

        private void paypalPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/Syntthetix");
        }

        private void aboutPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pokecommunity.com/showthread.php?t=444223");
        }

        private void gitHubPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(gitHubPanel, false);
        }

        private void gitHubPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(gitHubPanel, false);
        }

        private void paypalPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(paypalPanel, false);
        }

        private void paypalPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(paypalPanel, false);
        }

        private void aboutPanel_MouseEnter(object sender, EventArgs e)
        {
            highlightPanelOnEnter(aboutPanel, false);
        }

        private void aboutPanel_MouseLeave(object sender, EventArgs e)
        {
            unhighlightPanelOnLeave(aboutPanel, false);
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
            // Have the window disappear while cleanup runs for a couple seconds in the background
            this.Visible = false;
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
