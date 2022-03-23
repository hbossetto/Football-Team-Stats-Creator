using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class ramsPictureBox : Form
    {
        public ramsPictureBox()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare all variables and strings
                string teamName;
                string teamCity;
                int gamesWon;
                int gamesLoss;
                string cityName;
                int gamesPlayed;
                double winningPercentage;

                // Input Data
                teamName = teamNameTextBox.Text;
                teamCity = teamCityTextBox.Text;
                gamesWon = int.Parse(gamesWonTextBox.Text);
                gamesLoss = int.Parse(gamesLossTextBox.Text);

                // Combine City and Name
                cityName = "The" + " " + teamCity + " " + teamName;

                // Output the combination
                cityNameLabel.Text = cityName;

                // Calculate total games played
                gamesPlayed = gamesWon + gamesLoss;

                // Output total games
                gamesPlayedLabel.Text = gamesPlayed.ToString();

                // Calculate winning percentage
                winningPercentage = (double)gamesWon / (double)gamesPlayed;

                // Output winning percentage
                winningPercentageLabel.Text = winningPercentage.ToString("p1");
            }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clearing all text boxs and labels.
            teamNameTextBox.Text = "";
            teamCityTextBox.Text = "";
            gamesWonTextBox.Text = "";
            gamesLossTextBox.Text = "";
            cityNameLabel.Text = "";
            gamesPlayedLabel.Text = "";
            winningPercentageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void ramsPictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
