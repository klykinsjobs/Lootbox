namespace Lootbox
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftPanel = new Panel();
            CollectionBookButton = new Button();
            SettingsButton = new Button();
            LootboxButton = new Button();
            ExploreButton = new Button();
            MainPanel = new Panel();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(30, 30, 30);
            LeftPanel.Controls.Add(CollectionBookButton);
            LeftPanel.Controls.Add(SettingsButton);
            LeftPanel.Controls.Add(LootboxButton);
            LeftPanel.Controls.Add(ExploreButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(200, 451);
            LeftPanel.TabIndex = 0;
            // 
            // CollectionBookButton
            // 
            CollectionBookButton.AutoSize = true;
            CollectionBookButton.Dock = DockStyle.Top;
            CollectionBookButton.FlatAppearance.BorderSize = 0;
            CollectionBookButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            CollectionBookButton.FlatStyle = FlatStyle.Flat;
            CollectionBookButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CollectionBookButton.ForeColor = Color.White;
            CollectionBookButton.Location = new Point(0, 80);
            CollectionBookButton.Name = "CollectionBookButton";
            CollectionBookButton.Size = new Size(200, 40);
            CollectionBookButton.TabIndex = 2;
            CollectionBookButton.Text = "Collection Book";
            CollectionBookButton.UseVisualStyleBackColor = true;
            CollectionBookButton.Click += CollectionBookButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.AutoSize = true;
            SettingsButton.Dock = DockStyle.Bottom;
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.ForeColor = Color.White;
            SettingsButton.Location = new Point(0, 411);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(200, 40);
            SettingsButton.TabIndex = 3;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // LootboxButton
            // 
            LootboxButton.AutoSize = true;
            LootboxButton.Dock = DockStyle.Top;
            LootboxButton.FlatAppearance.BorderSize = 0;
            LootboxButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            LootboxButton.FlatStyle = FlatStyle.Flat;
            LootboxButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LootboxButton.ForeColor = Color.White;
            LootboxButton.Location = new Point(0, 40);
            LootboxButton.Name = "LootboxButton";
            LootboxButton.Size = new Size(200, 40);
            LootboxButton.TabIndex = 1;
            LootboxButton.Text = "Lootbox";
            LootboxButton.UseVisualStyleBackColor = true;
            LootboxButton.Click += LootboxButton_Click;
            // 
            // ExploreButton
            // 
            ExploreButton.AutoSize = true;
            ExploreButton.Dock = DockStyle.Top;
            ExploreButton.FlatAppearance.BorderSize = 0;
            ExploreButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            ExploreButton.FlatStyle = FlatStyle.Flat;
            ExploreButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExploreButton.ForeColor = Color.White;
            ExploreButton.Location = new Point(0, 0);
            ExploreButton.Name = "ExploreButton";
            ExploreButton.Size = new Size(200, 40);
            ExploreButton.TabIndex = 0;
            ExploreButton.Text = "Explore";
            ExploreButton.UseVisualStyleBackColor = true;
            ExploreButton.Click += ExploreButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(35, 35, 35);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(744, 451);
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 451);
            Controls.Add(MainPanel);
            Controls.Add(LeftPanel);
            MinimumSize = new Size(960, 490);
            Name = "MainForm";
            Text = "Lootbox";
            Load += MainForm_Load;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Button CollectionBookButton;
        private Button SettingsButton;
        private Button LootboxButton;
        private Button ExploreButton;
        private Panel MainPanel;
    }
}
