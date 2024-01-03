using Lootbox.Properties;

namespace Lootbox
{
    public partial class CollectionBookForm : Form
    {
        private int _pages = 1;
        private int _currentPage = 1;
        private readonly MainForm _mainForm;

        public CollectionBookForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void CollectionBookForm_Load(object sender, EventArgs e)
        {
            // Calculate how many pages it will take to display all the collectibles
            _pages = Settings.Default.Collectibles.Count / 4;
            _pages += (Settings.Default.Collectibles.Count % 4) > 0 ? 1 : 0;

            UpdatePanels();
        }

        private void UpdatePanels()
        {
            // Get the starting index
            int index = _currentPage == 1 ? 0 : (_currentPage - 1) * 4;

            // Populate the panels
            for (int i = 0; i < 4; i++)
            {
                if (index + i <= Settings.Default.Collectibles.Count - 1)
                {
                    string? s = Settings.Default.Collectibles[index + i];
                    if (s != null)
                    {
                        Collectible? collectible = _mainForm.Collectibles.Find(x => x.ID == int.Parse(s));
                        if (collectible != null)
                        {
                            // Fill the inner panel with the collectible color
                            Control? panelControl = _mainForm.Controls.Find(((PanelNames)i).ToString(), true).FirstOrDefault();
                            if (panelControl != null)
                            {
                                panelControl.BackColor = collectible.BackColor;
                            }

                            // Fill the outer panel with the rarity color
                            Control? borderPanelControl = _mainForm.Controls.Find(((BorderPanelNames)i).ToString(), true).FirstOrDefault();
                            if (borderPanelControl != null)
                            {
                                switch (collectible.Rarity)
                                {
                                    case Rarities.Common:
                                        borderPanelControl.BackColor = Color.White;
                                        break;
                                    case Rarities.Rare:
                                        borderPanelControl.BackColor = Color.Blue;
                                        break;
                                    case Rarities.Epic:
                                        borderPanelControl.BackColor = Color.Purple;
                                        break;
                                    case Rarities.Legendary:
                                        borderPanelControl.BackColor = Color.Orange;
                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // No collectible to display so make it appear empty
                    switch (i)
                    {
                        case 0:
                            FirstPanel.BackColor = Color.FromArgb(40, 40, 40);
                            FirstBorderPanel.BackColor = Color.FromArgb(40, 40, 40);
                            break;
                        case 1:
                            SecondPanel.BackColor = Color.FromArgb(40, 40, 40);
                            SecondBorderPanel.BackColor = Color.FromArgb(40, 40, 40);
                            break;
                        case 2:
                            ThirdPanel.BackColor = Color.FromArgb(40, 40, 40);
                            ThirdBorderPanel.BackColor = Color.FromArgb(40, 40, 40);
                            break;
                        case 3:
                            FourthPanel.BackColor = Color.FromArgb(40, 40, 40);
                            FourthBorderPanel.BackColor = Color.FromArgb(40, 40, 40);
                            break;
                    }
                }
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                UpdatePanels();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_currentPage < _pages)
            {
                _currentPage++;
                UpdatePanels();
            }
        }

        private void FirstPanel_Click(object sender, EventArgs e)
        {
            ShowCollectibleName((_currentPage - 1) * 4);
        }

        private void SecondPanel_Click(object sender, EventArgs e)
        {
            ShowCollectibleName(((_currentPage - 1) * 4) + 1);
        }

        private void ThirdPanel_Click(object sender, EventArgs e)
        {
            ShowCollectibleName(((_currentPage - 1) * 4) + 2);
        }

        private void FourthPanel_Click(object sender, EventArgs e)
        {
            ShowCollectibleName(((_currentPage - 1) * 4) + 3);
        }

        private void ShowCollectibleName(int index)
        {
            try
            {
                // Display the collectible name in a message box
                if (index < Settings.Default.Collectibles.Count)
                {
                    string? s = Settings.Default.Collectibles[index];
                    if (s != null)
                    {
                        Collectible? collectible = _mainForm.Collectibles.Find(x => x.ID == int.Parse(s));
                        if (collectible != null)
                        {
                            MessageBox.Show(collectible.BackColor.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
