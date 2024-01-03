namespace Lootbox
{
    partial class CollectionBookForm
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
            PreviousButton = new Button();
            NextButton = new Button();
            FirstBorderPanel = new Panel();
            FirstPanel = new Panel();
            SecondBorderPanel = new Panel();
            SecondPanel = new Panel();
            ThirdBorderPanel = new Panel();
            ThirdPanel = new Panel();
            FourthBorderPanel = new Panel();
            FourthPanel = new Panel();
            FirstBorderPanel.SuspendLayout();
            SecondBorderPanel.SuspendLayout();
            ThirdBorderPanel.SuspendLayout();
            FourthBorderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PreviousButton
            // 
            PreviousButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            PreviousButton.FlatStyle = FlatStyle.Flat;
            PreviousButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousButton.ForeColor = Color.White;
            PreviousButton.Location = new Point(12, 12);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(75, 42);
            PreviousButton.TabIndex = 0;
            PreviousButton.Text = "<";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(655, 12);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(75, 42);
            NextButton.TabIndex = 1;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // FirstBorderPanel
            // 
            FirstBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            FirstBorderPanel.Controls.Add(FirstPanel);
            FirstBorderPanel.Location = new Point(12, 60);
            FirstBorderPanel.Name = "FirstBorderPanel";
            FirstBorderPanel.Size = new Size(175, 375);
            FirstBorderPanel.TabIndex = 2;
            // 
            // FirstPanel
            // 
            FirstPanel.Location = new Point(3, 3);
            FirstPanel.Name = "FirstPanel";
            FirstPanel.Size = new Size(167, 367);
            FirstPanel.TabIndex = 0;
            FirstPanel.Click += FirstPanel_Click;
            // 
            // SecondBorderPanel
            // 
            SecondBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            SecondBorderPanel.Controls.Add(SecondPanel);
            SecondBorderPanel.Location = new Point(193, 60);
            SecondBorderPanel.Name = "SecondBorderPanel";
            SecondBorderPanel.Size = new Size(175, 375);
            SecondBorderPanel.TabIndex = 3;
            // 
            // SecondPanel
            // 
            SecondPanel.Location = new Point(3, 3);
            SecondPanel.Name = "SecondPanel";
            SecondPanel.Size = new Size(167, 367);
            SecondPanel.TabIndex = 0;
            SecondPanel.Click += SecondPanel_Click;
            // 
            // ThirdBorderPanel
            // 
            ThirdBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            ThirdBorderPanel.Controls.Add(ThirdPanel);
            ThirdBorderPanel.Location = new Point(374, 60);
            ThirdBorderPanel.Name = "ThirdBorderPanel";
            ThirdBorderPanel.Size = new Size(175, 375);
            ThirdBorderPanel.TabIndex = 4;
            // 
            // ThirdPanel
            // 
            ThirdPanel.Location = new Point(3, 3);
            ThirdPanel.Name = "ThirdPanel";
            ThirdPanel.Size = new Size(167, 367);
            ThirdPanel.TabIndex = 0;
            ThirdPanel.Click += ThirdPanel_Click;
            // 
            // FourthBorderPanel
            // 
            FourthBorderPanel.BorderStyle = BorderStyle.FixedSingle;
            FourthBorderPanel.Controls.Add(FourthPanel);
            FourthBorderPanel.Location = new Point(555, 60);
            FourthBorderPanel.Name = "FourthBorderPanel";
            FourthBorderPanel.Size = new Size(175, 375);
            FourthBorderPanel.TabIndex = 5;
            // 
            // FourthPanel
            // 
            FourthPanel.Location = new Point(3, 3);
            FourthPanel.Name = "FourthPanel";
            FourthPanel.Size = new Size(167, 367);
            FourthPanel.TabIndex = 0;
            FourthPanel.Click += FourthPanel_Click;
            // 
            // CollectionBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(739, 446);
            Controls.Add(FourthBorderPanel);
            Controls.Add(ThirdBorderPanel);
            Controls.Add(SecondBorderPanel);
            Controls.Add(FirstBorderPanel);
            Controls.Add(NextButton);
            Controls.Add(PreviousButton);
            Name = "CollectionBookForm";
            Text = "CollectionBookForm";
            Load += CollectionBookForm_Load;
            FirstBorderPanel.ResumeLayout(false);
            SecondBorderPanel.ResumeLayout(false);
            ThirdBorderPanel.ResumeLayout(false);
            FourthBorderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button PreviousButton;
        private Button NextButton;
        private Panel FirstBorderPanel;
        private Panel SecondBorderPanel;
        private Panel ThirdBorderPanel;
        private Panel FourthBorderPanel;
        private Panel FirstPanel;
        private Panel SecondPanel;
        private Panel ThirdPanel;
        private Panel FourthPanel;
    }
}