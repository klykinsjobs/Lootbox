namespace Lootbox
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ParentForm.TopMost = TopMostCheckBox.Checked;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            TopMostCheckBox.Checked = ParentForm.TopMost;
        }
    }
}
