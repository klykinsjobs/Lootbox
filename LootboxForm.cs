using Lootbox.Properties;

namespace Lootbox
{
    public enum Rarities
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    enum PanelNames
    {
        FirstPanel,
        SecondPanel,
        ThirdPanel,
        FourthPanel
    }

    enum BorderPanelNames
    {
        FirstBorderPanel,
        SecondBorderPanel,
        ThirdBorderPanel,
        FourthBorderPanel
    }

    public partial class LootboxForm : Form
    {
        private readonly MainForm _mainForm;

        public LootboxForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void LootboxForm_Load(object sender, EventArgs e)
        {
            // Update the UI if there are unopened lootboxes
            if (Settings.Default.Lootboxes > 0)
            {
                OpenLootboxButton.Text = "Open Lootbox (" + Settings.Default.Lootboxes.ToString() + ")";
                OpenLootboxButton.Enabled = true;
            }
        }

        private void OpenLootboxButton_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Lootboxes > 0)
            {
                Random random = new();

                // Roll the four rarities
                List<Rarities> rarities = new();
                for (int i = 0; i < 4; i++)
                {
                    switch (random.Next(0, 100))
                    {
                        case > 92:
                            rarities.Add(Rarities.Legendary);
                            break;
                        case > 76:
                            rarities.Add(Rarities.Epic);
                            break;
                        case > 44:
                            rarities.Add(Rarities.Rare);
                            break;
                        default:
                            rarities.Add(Rarities.Common);
                            break;
                    }
                }

                // If each rarity is common, randomly upgrade one to rare
                if (rarities[0] == Rarities.Common && rarities[1] == Rarities.Common && rarities[2] == Rarities.Common && rarities[3] == Rarities.Common)
                {
                    rarities[random.Next(0, 4)] = Rarities.Rare;
                }

                // Get a list of the loot IDs
                List<int> lootIDs = new();
                for (int i = 0; i < 4; i++)
                {
                    // Get a list of possible loot for this particular rarity
                    List<Collectible> lootPool = new();
                    lootPool.AddRange(_mainForm.Collectibles.FindAll(x => x.Rarity == rarities[i]));

                    // Add a random item's ID
                    lootIDs.Add(lootPool[random.Next(0, lootPool.Count)].ID);
                }

                // Get a list of the current collectibles for duplicate detection
                List<int> currentCollectibles = new();
                foreach (string? collectible in Settings.Default.Collectibles)
                {
                    if (collectible != null)
                    {
                        currentCollectibles.Add(int.Parse(collectible));
                    }
                }

                // Iterate through the loot IDs to distribute rewards
                foreach (int lootID in lootIDs)
                {
                    if (currentCollectibles.Contains(lootID) == false)
                    {
                        currentCollectibles.Add(lootID);
                    }
                }

                // Display the collectibles in the lootbox
                for (int i = 0; i < 4; i++)
                {
                    Collectible? loot = _mainForm.Collectibles.Find(x => x.ID == lootIDs[i]);
                    if (loot != null)
                    {
                        // Display the collectible
                        Control? panelControl = _mainForm.Controls.Find(((PanelNames)i).ToString(), true).FirstOrDefault();
                        if (panelControl != null)
                        {
                            panelControl.BackColor = loot.BackColor;
                        }

                        // Display a border showcasing each collectible's rarity level
                        Control? borderPanelControl = _mainForm.Controls.Find(((BorderPanelNames)i).ToString(), true).FirstOrDefault();
                        if (borderPanelControl != null)
                        {
                            switch (loot.Rarity)
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

                // Subtract one lootbox
                Settings.Default.Lootboxes -= 1;

                // Alphabetize the updated collection
                currentCollectibles.Sort();
                Settings.Default.Collectibles.Clear();
                foreach (int i in currentCollectibles)
                {
                    Settings.Default.Collectibles.Add(i.ToString());
                }

                // Save application settings
                Settings.Default.Save();

                // Update the UI for the new amount of lootboxes
                OpenLootboxButton.Text = "Open Lootbox (" + Settings.Default.Lootboxes.ToString() + ")";
                if (Settings.Default.Lootboxes == 0)
                {
                    OpenLootboxButton.Enabled = false;
                }
            }
        }
    }
}
