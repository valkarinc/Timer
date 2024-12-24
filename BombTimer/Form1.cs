using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombTimer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Validate the user input
            if (int.TryParse(timeInputBox.Text, out int userTime) && userTime > 0)
            {
                timeRemaining = userTime; // Set the timer to the user-defined time
                int minutes = timeRemaining / 60;
                int seconds = timeRemaining % 60;
                timerLabel.Text = $"{minutes:D2}:{seconds:D2}"; // Display the initial time
                bombTimer.Start(); // Start the timer
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the time.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int timeRemaining = 60; // Timer starts from 60 seconds

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--; // Decrease the time
                int minutes = timeRemaining / 60;
                int seconds = timeRemaining % 60;
                timerLabel.Text = $"{minutes:D2}:{seconds:D2}"; // Update label
            }
            else
            {
                bombTimer.Stop(); // Stop the timer
                timerLabel.Text = "Time's up!";

                // Play the explosion sound
                try
                {
                    SoundPlayer player = new SoundPlayer("explosion.wav"); // Adjust path if needed
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
