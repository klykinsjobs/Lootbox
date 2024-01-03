namespace Lootbox
{
    partial class LootboxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstBorderPanel = new Panel();
            FirstPanel = new Panel();
            SecondBorderPanel = new Panel();
            SecondPanel = new Panel();
            ThirdBorderPanel = new Panel();
            ThirdPanel = new Panel();
            FourthBorderPanel = new Panel();
            FourthPanel = new Panel();
            OpenLootboxButton = new Button();
            FirstBorderPanel.SuspendLayout();
            SecondBorderPanel.SuspendLayout();
            ThirdBorderPanel.SuspendLayout();
            FourthBorderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FirstBorderPanel
            // 
            FirstBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            FirstBorderPanel.Controls.Add(FirstPanel);
            FirstBorderPanel.Location = new Point(12, 12);
            FirstBorderPanel.Name = "FirstBorderPanel";
            FirstBorderPanel.Size = new Size(175, 375);
            FirstBorderPanel.TabIndex = 0;
            FirstBorderPanel.Tag = "0";
            // 
            // FirstPanel
            // 
            FirstPanel.Location = new Point(5, 3);
            FirstPanel.Name = "FirstPanel";
            FirstPanel.Size = new Size(165, 367);
            FirstPanel.TabIndex = 0;
            // 
            // SecondBorderPanel
            // 
            SecondBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            SecondBorderPanel.Controls.Add(SecondPanel);
            SecondBorderPanel.Location = new Point(193, 12);
            SecondBorderPanel.Name = "SecondBorderPanel";
            SecondBorderPanel.Size = new Size(175, 375);
            SecondBorderPanel.TabIndex = 1;
            SecondBorderPanel.Tag = "1";
            // 
            // SecondPanel
            // 
            SecondPanel.Location = new Point(3, 3);
            SecondPanel.Name = "SecondPanel";
            SecondPanel.Size = new Size(167, 367);
            SecondPanel.TabIndex = 0;
            // 
            // ThirdBorderPanel
            // 
            ThirdBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            ThirdBorderPanel.Controls.Add(ThirdPanel);
            ThirdBorderPanel.Location = new Point(374, 12);
            ThirdBorderPanel.Name = "ThirdBorderPanel";
            ThirdBorderPanel.Size = new Size(175, 375);
            ThirdBorderPanel.TabIndex = 2;
            ThirdBorderPanel.Tag = "2";
            // 
            // ThirdPanel
            // 
            ThirdPanel.Location = new Point(3, 3);
            ThirdPanel.Name = "ThirdPanel";
            ThirdPanel.Size = new Size(167, 367);
            ThirdPanel.TabIndex = 0;
            // 
            // FourthBorderPanel
            // 
            FourthBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            FourthBorderPanel.Controls.Add(FourthPanel);
            FourthBorderPanel.Location = new Point(555, 12);
            FourthBorderPanel.Name = "FourthBorderPanel";
            FourthBorderPanel.Size = new Size(175, 375);
            FourthBorderPanel.TabIndex = 3;
            FourthBorderPanel.Tag = "3";
            // 
            // FourthPanel
            // 
            FourthPanel.Location = new Point(3, 3);
            FourthPanel.Name = "FourthPanel";
            FourthPanel.Size = new Size(167, 367);
            FourthPanel.TabIndex = 0;
            // 
            // OpenLootboxButton
            // 
            OpenLootboxButton.AutoSize = true;
            OpenLootboxButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OpenLootboxButton.Enabled = false;
            OpenLootboxButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            OpenLootboxButton.FlatStyle = FlatStyle.Flat;
            OpenLootboxButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OpenLootboxButton.ForeColor = Color.White;
            OpenLootboxButton.Location = new Point(294, 393);
            OpenLootboxButton.Name = "OpenLootboxButton";
            OpenLootboxButton.Size = new Size(157, 42);
            OpenLootboxButton.TabIndex = 4;
            OpenLootboxButton.Text = "Open Lootbox";
            OpenLootboxButton.UseVisualStyleBackColor = true;
            OpenLootboxButton.Click += OpenLootboxButton_Click;
            // 
            // LootboxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(739, 446);
            Controls.Add(OpenLootboxButton);
            Controls.Add(FourthBorderPanel);
            Controls.Add(ThirdBorderPanel);
            Controls.Add(SecondBorderPanel);
            Controls.Add(FirstBorderPanel);
            Name = "LootboxForm";
            Text = "LootboxForm";
            Load += LootboxForm_Load;
            FirstBorderPanel.ResumeLayout(false);
            SecondBorderPanel.ResumeLayout(false);
            ThirdBorderPanel.ResumeLayout(false);
            FourthBorderPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel FirstBorderPanel;
        private Panel SecondBorderPanel;
        private Panel ThirdBorderPanel;
        private Panel FourthBorderPanel;
        private Button OpenLootboxButton;
        private Panel FirstPanel;
        private Panel SecondPanel;
        private Panel ThirdPanel;
        private Panel FourthPanel;
    }
}