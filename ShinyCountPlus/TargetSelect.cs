using ShinyCountPlus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyCountPlus
{
    public partial class TargetSelectForm : Form
    {
        private GenSelectForm genSelectForm = null;
        private Main mainForm = null;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        int numPkmn, gen;
        string listFile;
        List<string> pokemon = new List<string>();

        public TargetSelectForm(Form genSelectForm, Form mainForm, int numPkmn, int gen)
        {
            InitializeComponent();
            this.genSelectForm = genSelectForm as GenSelectForm;
            this.mainForm = mainForm as Main;
            this.numPkmn = numPkmn;
            this.gen = gen;
            if (mainForm.TopMost) this.TopMost = true;
        }

        private void TargetSelect_Load(object sender, EventArgs e)
        {
            targetLbl.Font = mainForm.fredokaOne1425;
            targetLbl.ForeColor = mainForm.getAccentColor();
            pkmnGridView.RowCount = (numPkmn / 10) + 1;
            pkmnGridView.DefaultCellStyle.SelectionBackColor = mainForm.getAccentColor();
            setListFile();
            loadPokemon();
        }

        private void setListFile()
        {
            if (gen == 1) listFile = Resources.gen1;
            if (gen == 2) listFile = Resources.gen2;
            if (gen == 3) listFile = Resources.gen3;
            if (gen == 4) listFile = Resources.gen4;
            if (gen == 5) listFile = Resources.gen5;
            if (gen == 6) listFile = Resources.gen6;
            if (gen == 7) listFile = Resources.gen7;
            if (gen == 8) listFile = Resources.gen8;
        }

        private bool genIsDownloaded(int gen)
        {
            if (gen == 1) { if (File.Exists(mainForm.IMG_DIR + "bulbasaur.png")) return true; }
            if (gen == 2) { if (File.Exists(mainForm.IMG_DIR + "chikorita.png")) return true; }
            if (gen == 3) { if (File.Exists(mainForm.IMG_DIR + "treecko.png")) return true; }
            if (gen == 4) { if (File.Exists(mainForm.IMG_DIR + "turtwig.png")) return true; }
            if (gen == 5) { if (File.Exists(mainForm.IMG_DIR + "snivy.png")) return true; }
            if (gen == 6) { if (File.Exists(mainForm.IMG_DIR + "chespin.png")) return true; }
            if (gen == 7) { if (File.Exists(mainForm.IMG_DIR + "rowlet.png")) return true; }
            if (gen == 8) { if (File.Exists(mainForm.IMG_DIR + "grookey.png")) return true; }

            return false;
        }

        private void loadPokemon()
        {
            bool isDownloaded = genIsDownloaded(gen);
            using (StringReader sr = new StringReader(listFile))
            {
                string name = "";
                string url = "";
                for (int i = 0; i < numPkmn; i++)
                {
                    name = sr.ReadLine().ToLower();
                    pokemon.Add(name);

                    if (!isDownloaded)
                    {
                        // Use Home sprites if pokemon is Galarian form or from Gen 8, otherwise use Bank sprites
                        if (name.Contains("-galarian") || name == "meltan" || name == "melmetal" || numPkmn == 81)
                        {
                            url = "https://img.pokemondb.net/sprites/home/shiny/" + name + ".png";
                        }
                        else
                        {
                            url = "https://img.pokemondb.net/sprites/bank/shiny/" + name + ".png";
                        }

                        try
                        {
                            WebRequest wr = WebRequest.Create(url);
                            WebResponse response = wr.GetResponse();

                            Image pkmn = Image.FromStream(response.GetResponseStream());
                            pkmn.Save(mainForm.IMG_DIR + name.ToLower() + ".png");
                            genSelectForm.pkmnLoadBar.Value++;
                        } catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine(e.StackTrace);
                        }
                    }
                }
                genSelectForm.pkmnLoadBar.Value = 0;
                genSelectForm.pkmnLoadBar.Visible = false;

                int count = 0;
                for (int i = 0; i < pkmnGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < pkmnGridView.Rows[i].Cells.Count; j++)
                    {
                        if (count < numPkmn)
                        {
                            Image img = Image.FromFile(mainForm.IMG_DIR + pokemon[count] + ".png");
                            pkmnGridView.Rows[i].Cells[j].Value = img;
                        }
                        else
                        {
                            pkmnGridView.Rows[i].Cells[j].Value = Resources.bg;
                        }
                        count++;
                    }
                }
                sr.Close();
            }
        }

        async void pkmnGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Focus();
            int pkmnGridNum = (e.RowIndex * 10) + (e.ColumnIndex + 1);
            string target = "";

            using (StringReader sr = new StringReader(listFile))
            {
                for (int i = 0; i < pkmnGridNum; i++)
                {
                    target = sr.ReadLine();
                }
                sr.Close();
            }

            try
            {
                if (target.Length > 0)
                {
                    mainForm.target = target;
                    mainForm.targetImgPath = mainForm.IMG_DIR + target + ".png";
                    Console.WriteLine(mainForm.targetImgPath);
                    mainForm.setTargetDisplay();

                    targetLbl.Visible = true;
                    targetLbl.Text = "Target set to " + target + "!";
                    await Task.Delay(1250);
                    targetLbl.Visible = false;

                    mainForm.save();
                }
            }
            catch (Exception) { }
        }

        #region Tools
        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Dispose();
            genSelectForm.Close();
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

        private void TargetSelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void TargetSelectForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
