using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Primewater
{
    public partial class dashboard : Form
    {
        private graphs home;
        private capex capex;
        private inventory inventory;
        private history history;
        private settings settings;

        // Panel to host the dynamic content
        private Panel contentPanel;

        private int targetHeight;
        private int initialHeight;
        private float animationProgress = 0f;
        private const float AnimationSpeed = 0.5f;
        bool menuExpand = false;

        public dashboard()
        {
            InitializeComponent();
            InitializeContentPanel();
            LoadDefaultForm();
            // Make sure menuContainer starts at the correct height
            menuContainer.Height = 60; // Initial collapsed height
        }
        private void InitializeContentPanel()
        {
            // Create a panel to host the dynamic content
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,  // Fill the remaining space
                Location = new Point(flowLayoutPanel2.Width, 0),
                Size = new Size(
                    this.ClientSize.Width - flowLayoutPanel2.Width,
                    this.ClientSize.Height
                )
            };

            // Add the content panel to the form
            this.Controls.Add(contentPanel);
            contentPanel.BringToFront();
        }

        private void LoadDefaultForm()
        {
            // Load dashboard by default when the form opens
            if (capex == null)
                capex = new capex();

            LoadForm(capex);
        }

        private void LoadForm(Form form)
        {
            // Clear any existing forms in the content panel
            contentPanel.Controls.Clear();

            // Configure the new form
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            // Add the form to the content panel
            contentPanel.Controls.Add(form);
            form.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settings == null)
                settings = new settings();
            LoadForm(settings);
        }

        private void btnCapex_Click(object sender, EventArgs e)
        {
            if (capex == null)
                capex = new capex();
            LoadForm(capex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Use easing function for smoother animation
            animationProgress += AnimationSpeed;

            if (animationProgress > 1f)
            {
                animationProgress = 1f;
                timer1.Stop();
                menuExpand = !menuExpand;
            }

            // Calculate current height using easing function
            float easedProgress = EaseInOutCubic(animationProgress);
            int currentHeight = initialHeight + (int)((targetHeight - initialHeight) * easedProgress);

            menuContainer.Height = currentHeight;
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            // Call ToggleMenu instead of directly starting the timer
            ToggleMenu();
        }

        // Called when starting animation
        private void ToggleMenu()
        {
            // Reset animation progress
            animationProgress = 0f;

            // Store initial height
            initialHeight = menuContainer.Height;

            // Set target height based on menu state
            targetHeight = menuExpand ? 60 : 183;

            // Start the animation
            timer1.Start();
        }

        // Cubic easing function for smooth animation
        private float EaseInOutCubic(float t)
        {
            return t < 0.5f ? 4f * t * t * t : 1f - (float)Math.Pow(-2f * t + 2f, 3) / 2f;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (home == null)
                home = new graphs();
            LoadForm(home);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (inventory == null)
                inventory = new inventory();
            LoadForm(inventory);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (history == null)
                history = new history();
            LoadForm(history);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Implement logout logic
            this.Close();
            // Optionally, show login form again
            new Form1().Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}