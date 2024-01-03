namespace Lootbox
{
    public partial class MainForm : Form
    {
        public List<Collectible> Collectibles = new();
        private Form? _currentChildForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadChildForm(string formName)
        {
            try
            {
                // Close current child form
                if (_currentChildForm != null)
                {
                    _currentChildForm.Close();
                }

                // Update current child form based on the parameter
                switch (formName)
                {
                    case "ExploreForm":
                        _currentChildForm = new ExploreForm();
                        break;
                    case "LootboxForm":
                        _currentChildForm = new LootboxForm(this);
                        break;
                    case "CollectionBookForm":
                        _currentChildForm = new CollectionBookForm(this);
                        break;
                    case "SettingsForm":
                        _currentChildForm = new SettingsForm();
                        break;
                    default:
                        throw new Exception("Invalid form name.");
                }

                // Update some properties
                _currentChildForm.TopLevel = false;
                _currentChildForm.FormBorderStyle = FormBorderStyle.None;
                _currentChildForm.Dock = DockStyle.Fill;

                // Add the child form to the main panel's controls
                MainPanel.Controls.Add(_currentChildForm);
                MainPanel.Tag = _currentChildForm;

                // Show the child form
                _currentChildForm.BringToFront();
                _currentChildForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExploreButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExploreButton.Enabled = false;
                LoadChildForm("ExploreForm");
            }
            finally
            {
                ExploreButton.Enabled = true;
            }
        }

        private void LootboxButton_Click(object sender, EventArgs e)
        {
            try
            {
                LootboxButton.Enabled = false;
                LoadChildForm("LootboxForm");
            }
            finally
            {
                LootboxButton.Enabled = true;
            }
        }

        private void CollectionBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                CollectionBookButton.Enabled = false;
                LoadChildForm("CollectionBookForm");
            }
            finally
            {
                CollectionBookButton.Enabled = true;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsButton.Enabled = false;
                LoadChildForm("SettingsForm");
            }
            finally
            {
                SettingsButton.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Demo data
            Collectibles.Add(new Collectible() { ID = 1, BackColor = Color.AliceBlue, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 2, BackColor = Color.AntiqueWhite, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 3, BackColor = Color.Aqua, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 4, BackColor = Color.Aquamarine, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 5, BackColor = Color.Azure, Rarity = Rarities.Rare });

            Collectibles.Add(new Collectible() { ID = 6, BackColor = Color.Beige, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 7, BackColor = Color.Bisque, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 8, BackColor = Color.Black, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 9, BackColor = Color.BlanchedAlmond, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 10, BackColor = Color.Blue, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 11, BackColor = Color.BlueViolet, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 12, BackColor = Color.Brown, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 13, BackColor = Color.BurlyWood, Rarity = Rarities.Rare });

            Collectibles.Add(new Collectible() { ID = 14, BackColor = Color.CadetBlue, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 15, BackColor = Color.Chartreuse, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 16, BackColor = Color.Chocolate, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 17, BackColor = Color.Coral, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 18, BackColor = Color.CornflowerBlue, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 19, BackColor = Color.Cornsilk, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 20, BackColor = Color.Crimson, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 21, BackColor = Color.Cyan, Rarity = Rarities.Rare });

            Collectibles.Add(new Collectible() { ID = 22, BackColor = Color.DarkBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 23, BackColor = Color.DarkCyan, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 24, BackColor = Color.DarkGoldenrod, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 25, BackColor = Color.DarkGray, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 26, BackColor = Color.DarkGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 27, BackColor = Color.DarkKhaki, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 28, BackColor = Color.DarkMagenta, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 29, BackColor = Color.DarkOliveGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 30, BackColor = Color.DarkOrange, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 31, BackColor = Color.DarkOrchid, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 32, BackColor = Color.DarkRed, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 33, BackColor = Color.DarkSalmon, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 34, BackColor = Color.DarkSeaGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 35, BackColor = Color.DarkSlateBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 36, BackColor = Color.DarkSlateGray, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 37, BackColor = Color.DarkTurquoise, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 38, BackColor = Color.DarkViolet, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 39, BackColor = Color.DeepPink, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 40, BackColor = Color.DeepSkyBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 41, BackColor = Color.DimGray, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 42, BackColor = Color.DodgerBlue, Rarity = Rarities.Common });

            Collectibles.Add(new Collectible() { ID = 43, BackColor = Color.Firebrick, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 44, BackColor = Color.FloralWhite, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 45, BackColor = Color.ForestGreen, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 46, BackColor = Color.Fuchsia, Rarity = Rarities.Epic });

            Collectibles.Add(new Collectible() { ID = 47, BackColor = Color.Gainsboro, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 48, BackColor = Color.GhostWhite, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 49, BackColor = Color.Gold, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 50, BackColor = Color.Goldenrod, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 51, BackColor = Color.Gray, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 52, BackColor = Color.Green, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 53, BackColor = Color.GreenYellow, Rarity = Rarities.Rare });

            Collectibles.Add(new Collectible() { ID = 54, BackColor = Color.Honeydew, Rarity = Rarities.Legendary });
            Collectibles.Add(new Collectible() { ID = 55, BackColor = Color.HotPink, Rarity = Rarities.Legendary });

            Collectibles.Add(new Collectible() { ID = 56, BackColor = Color.IndianRed, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 57, BackColor = Color.Indigo, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 58, BackColor = Color.Ivory, Rarity = Rarities.Epic });

            Collectibles.Add(new Collectible() { ID = 59, BackColor = Color.Khaki, Rarity = Rarities.Legendary });

            Collectibles.Add(new Collectible() { ID = 60, BackColor = Color.Lavender, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 61, BackColor = Color.LavenderBlush, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 62, BackColor = Color.LawnGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 63, BackColor = Color.LemonChiffon, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 64, BackColor = Color.LightBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 65, BackColor = Color.LightCoral, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 66, BackColor = Color.LightCyan, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 67, BackColor = Color.LightGoldenrodYellow, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 68, BackColor = Color.LightGray, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 69, BackColor = Color.LightGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 70, BackColor = Color.LightPink, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 71, BackColor = Color.LightSalmon, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 72, BackColor = Color.LightSeaGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 73, BackColor = Color.LightSkyBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 74, BackColor = Color.LightSlateGray, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 75, BackColor = Color.LightSteelBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 76, BackColor = Color.LightYellow, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 77, BackColor = Color.Lime, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 78, BackColor = Color.LimeGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 79, BackColor = Color.Linen, Rarity = Rarities.Common });

            Collectibles.Add(new Collectible() { ID = 80, BackColor = Color.Magenta, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 81, BackColor = Color.Maroon, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 82, BackColor = Color.MediumAquamarine, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 83, BackColor = Color.MediumBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 84, BackColor = Color.MediumOrchid, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 85, BackColor = Color.MediumPurple, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 86, BackColor = Color.MediumSeaGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 87, BackColor = Color.MediumSlateBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 88, BackColor = Color.MediumSpringGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 89, BackColor = Color.MediumTurquoise, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 90, BackColor = Color.MediumVioletRed, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 91, BackColor = Color.MidnightBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 92, BackColor = Color.MintCream, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 93, BackColor = Color.MistyRose, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 94, BackColor = Color.Moccasin, Rarity = Rarities.Common });

            Collectibles.Add(new Collectible() { ID = 95, BackColor = Color.NavajoWhite, Rarity = Rarities.Legendary });
            Collectibles.Add(new Collectible() { ID = 96, BackColor = Color.Navy, Rarity = Rarities.Legendary });

            Collectibles.Add(new Collectible() { ID = 97, BackColor = Color.OldLace, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 98, BackColor = Color.Olive, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 99, BackColor = Color.OliveDrab, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 100, BackColor = Color.Orange, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 101, BackColor = Color.OrangeRed, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 102, BackColor = Color.Orchid, Rarity = Rarities.Rare });

            Collectibles.Add(new Collectible() { ID = 103, BackColor = Color.PaleGoldenrod, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 104, BackColor = Color.PaleGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 105, BackColor = Color.PaleTurquoise, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 106, BackColor = Color.PaleVioletRed, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 107, BackColor = Color.PapayaWhip, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 108, BackColor = Color.PeachPuff, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 109, BackColor = Color.Peru, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 110, BackColor = Color.Pink, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 111, BackColor = Color.Plum, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 112, BackColor = Color.PowderBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 113, BackColor = Color.Purple, Rarity = Rarities.Common });

            Collectibles.Add(new Collectible() { ID = 114, BackColor = Color.RebeccaPurple, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 115, BackColor = Color.Red, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 116, BackColor = Color.RosyBrown, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 117, BackColor = Color.RoyalBlue, Rarity = Rarities.Epic });

            Collectibles.Add(new Collectible() { ID = 118, BackColor = Color.SaddleBrown, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 119, BackColor = Color.Salmon, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 120, BackColor = Color.SandyBrown, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 121, BackColor = Color.SeaGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 122, BackColor = Color.SeaShell, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 123, BackColor = Color.Sienna, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 124, BackColor = Color.Silver, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 125, BackColor = Color.SkyBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 126, BackColor = Color.SlateBlue, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 127, BackColor = Color.SlateGray, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 128, BackColor = Color.Snow, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 129, BackColor = Color.SpringGreen, Rarity = Rarities.Common });
            Collectibles.Add(new Collectible() { ID = 130, BackColor = Color.SteelBlue, Rarity = Rarities.Common });

            Collectibles.Add(new Collectible() { ID = 131, BackColor = Color.Tan, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 132, BackColor = Color.Teal, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 133, BackColor = Color.Thistle, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 134, BackColor = Color.Tomato, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 135, BackColor = Color.Transparent, Rarity = Rarities.Rare });
            Collectibles.Add(new Collectible() { ID = 136, BackColor = Color.Turquoise, Rarity = Rarities.Rare });

            Collectibles.Add(new Collectible() { ID = 137, BackColor = Color.Violet, Rarity = Rarities.Legendary });

            Collectibles.Add(new Collectible() { ID = 138, BackColor = Color.Wheat, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 139, BackColor = Color.White, Rarity = Rarities.Epic });
            Collectibles.Add(new Collectible() { ID = 140, BackColor = Color.WhiteSmoke, Rarity = Rarities.Epic });

            Collectibles.Add(new Collectible() { ID = 141, BackColor = Color.Yellow, Rarity = Rarities.Legendary });
            Collectibles.Add(new Collectible() { ID = 142, BackColor = Color.YellowGreen, Rarity = Rarities.Legendary });
        }
    }
}
