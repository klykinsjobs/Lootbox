using Lootbox.Properties;

namespace Lootbox
{
    public partial class ExploreForm : Form
    {
        public new List<Event> Events = new();
        private int experienceGain = 0;

        public ExploreForm()
        {
            InitializeComponent();
        }

        private void ExploreForm_Load(object sender, EventArgs e)
        {
            // Show current experience
            ExperienceProgressBar.Value = Settings.Default.Experience;

            // Demo data
            Events.Add(new Event() { Name = "Aurora", Description = "An aurora has been spotted!", Experience = 25 });
            Events.Add(new Event() { Name = "Full Moon", Description = "A full moon has been spotted!", Experience = 50 });
            Events.Add(new Event() { Name = "New Moon", Description = "A new moon has been spotted!", Experience = 50 });
            Events.Add(new Event() { Name = "Mercury", Description = "Mercury has been spotted!", Experience = 75 });
            Events.Add(new Event() { Name = "Venus", Description = "Venus has been spotted!", Experience = 75 });
            Events.Add(new Event() { Name = "Mars", Description = "Mars has been spotted!", Experience = 75 });
            Events.Add(new Event() { Name = "Jupiter", Description = "Jupiter has been spotted!", Experience = 75 });
            Events.Add(new Event() { Name = "Saturn", Description = "Saturn has been spotted!", Experience = 75 });
            Events.Add(new Event() { Name = "Satellite", Description = "A satellite has been spotted!", Experience = 100 });
            Events.Add(new Event() { Name = "Solar Eclipse", Description = "A solar eclipse has been spotted!", Experience = 200 });
            Events.Add(new Event() { Name = "Lunar Eclipse", Description = "A lunar eclipse has been spotted!", Experience = 200 });
            Events.Add(new Event() { Name = "Meteor Shower", Description = "A meteor shower has been spotted!", Experience = 250 });
            Events.Add(new Event() { Name = "Comet", Description = "A comet has been spotted!", Experience = 250 });
            Events.Add(new Event() { Name = "Asteroid", Description = "An asteroid has been spotted!", Experience = 250 });
            Events.Add(new Event() { Name = "Supermoon", Description = "A supermoon has been spotted!", Experience = 500 });
            Events.Add(new Event() { Name = "Andromeda Galaxy", Description = "The Andromeda galaxy has been spotted!", Experience = 1000 });

            GenerateBackgroundImage();
            ExploreTimer.Enabled = true;
            GenerateEvent();
        }

        private void GenerateBackgroundImage()
        {
            if (AstronomyPanel.BackgroundImage != null)
            {
                AstronomyPanel.BackgroundImage.Dispose();
            }

            // Generate a random bitmap
            Random random = new();
            Bitmap bitmap = new(500, 500);
            for (int x = 0; x < 500; x++)
            {
                for (int y = 0; y < 500; y++)
                {
                    if (random.Next(0, 10000) > random.Next(9995, 10000))
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.Black);
                    }
                }
            }

            // Update the panel
            AstronomyPanel.BackgroundImage = bitmap;
        }

        private void GenerateEvent()
        {
            // Generate an index for events
            Random random = new();
            int index = random.Next(0, Events.Count - 1);

            // Append the textbox with the event
            StatusTextBox.AppendText(Events[index].Description + " | " + Events[index].Experience.ToString() + " xp gained.\r\n");

            // Gain the appropriate amount of XP
            Settings.Default.Experience = (Settings.Default.Experience + Events[index].Experience) % 2000;
            experienceGain += Events[index].Experience;
            ExperienceTimer.Enabled = true;
        }

        private void ExperienceTimer_Tick(object sender, EventArgs e)
        {
            if (experienceGain > 0)
            {
                if (ExperienceProgressBar.Value == ExperienceProgressBar.Maximum)
                {
                    // Gained a lootbox
                    ExperienceProgressBar.Value = ExperienceProgressBar.Minimum;
                    Settings.Default.Lootboxes++;
                    Settings.Default.Save();
                }

                // Increment in smaller pieces to make the progressbar look better
                if (experienceGain > 50)
                {
                    ExperienceProgressBar.Increment(50);
                    experienceGain -= 50;
                }
                else
                {
                    ExperienceProgressBar.Increment(experienceGain);
                    experienceGain = 0;
                }
            }
            else
            {
                ExperienceTimer.Enabled = false;
            }
        }

        private void ExploreTimer_Tick(object sender, EventArgs e)
        {
            GenerateBackgroundImage();
            GenerateEvent();
        }
    }

    public class Event
    {
        public string? Name { get; set; }
        public int Experience { get; set; }
        public string? Description { get; set; }
    }
}
