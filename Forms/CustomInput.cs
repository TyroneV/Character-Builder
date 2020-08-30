using Character_Builder.Classes;
using System;
using System.Windows.Forms;

namespace Character_Builder.Forms
{
    public partial class CustomInput : Form
    {
        public CustomInput()
        {
            InitializeComponent();
        }


        private void CustomInput_Load(object sender, EventArgs e)
        {

        }

        private async void submitGender_Click(object sender, EventArgs e)
        {
            if (!genderTxt.Text.Equals(string.Empty))
            {
                bool success = await DataManager.AddGender(genderTxt.Text.ToLower());
                if (!success)
                {
                    resultText.Text = "Gender already exist!";
                }
                else
                {
                    resultText.Text = "Gender added!";
                }
            }
            else
            {
                resultText.Text = "Input values for gender first!";
            }

        }

        private async void submitRace_Click(object sender, EventArgs e)
        {
            if (!raceTxt.Text.Equals(string.Empty) && !raceTraitTxt.Text.Equals(string.Empty))
            {
                Race race = new Race(raceTxt.Text, raceTraitTxt.Text);
                bool success = await DataManager.AddRace(race);
                if (!success)
                {
                    resultText.Text = "Race already exist!";
                }
                else
                {
                    resultText.Text = "Race added!";
                }
            }
            else
            {
                resultText.Text = "Input values for race first!";
            }
        }

        private async void submitJob_Click(object sender, EventArgs e)
        {
            if (!jobTxt.Text.Equals(string.Empty) && !JobWorkTxt.Text.Equals(string.Empty))
            {
                Job job = new Job(jobTxt.Text, JobWorkTxt.Text);
                bool success = await DataManager.AddJob(job);
                if (!success)
                {
                    resultText.Text = "Job already exist!";
                }
                else
                {
                    resultText.Text = "Job added!";
                }
            }
            else
            {
                resultText.Text = "Input values for job first!";
            }
        }
    }
}
