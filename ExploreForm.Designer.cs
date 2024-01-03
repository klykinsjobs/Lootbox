namespace Lootbox
{
    partial class ExploreForm
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
            components = new System.ComponentModel.Container();
            ExperienceTimer = new System.Windows.Forms.Timer(components);
            ExperienceProgressBar = new ProgressBar();
            StatusTextBox = new TextBox();
            AstronomyPanel = new Panel();
            ExploreTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ExperienceTimer
            // 
            ExperienceTimer.Tick += ExperienceTimer_Tick;
            // 
            // ExperienceProgressBar
            // 
            ExperienceProgressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExperienceProgressBar.Location = new Point(12, 415);
            ExperienceProgressBar.Maximum = 1999;
            ExperienceProgressBar.Name = "ExperienceProgressBar";
            ExperienceProgressBar.Size = new Size(100, 23);
            ExperienceProgressBar.TabIndex = 0;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusTextBox.BackColor = Color.FromArgb(45, 45, 45);
            StatusTextBox.BorderStyle = BorderStyle.FixedSingle;
            StatusTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            StatusTextBox.ForeColor = Color.AntiqueWhite;
            StatusTextBox.Location = new Point(118, 381);
            StatusTextBox.Multiline = true;
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ScrollBars = ScrollBars.Vertical;
            StatusTextBox.Size = new Size(670, 57);
            StatusTextBox.TabIndex = 1;
            StatusTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // AstronomyPanel
            // 
            AstronomyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AstronomyPanel.Location = new Point(12, 12);
            AstronomyPanel.Name = "AstronomyPanel";
            AstronomyPanel.Size = new Size(776, 363);
            AstronomyPanel.TabIndex = 6;
            // 
            // ExploreTimer
            // 
            ExploreTimer.Interval = 5000;
            ExploreTimer.Tick += ExploreTimer_Tick;
            // 
            // ExploreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(StatusTextBox);
            Controls.Add(AstronomyPanel);
            Controls.Add(ExperienceProgressBar);
            Name = "ExploreForm";
            Text = "ExploreForm";
            Load += ExploreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer ExperienceTimer;
        private ProgressBar ExperienceProgressBar;
        private TextBox StatusTextBox;
        private Panel AstronomyPanel;
        private System.Windows.Forms.Timer ExploreTimer;
    }
}