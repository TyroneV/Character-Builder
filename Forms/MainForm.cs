using Character_Builder.Classes;
using Character_Builder.Forms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Builder
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            GenderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            JobBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var t = Task.Run(() => inializeBoxes());
            t.Wait();
        }

        public async Task inializeBoxes()
        {
            await DataManager.LoadSave();
            UpdateDropboxes();
        }

        public void UpdateDropboxes()
        {
            GenderBox.DataSource = DataManager.ListGenders();
            RaceBox.DataSource = DataManager.ListRaces();
            JobBox.DataSource = DataManager.ListJobs();
        }

        private Bitmap MyImage;
        public void ShowMyImage(string fileToDisplay, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }
            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = MyImage;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                using (RandomPicture atask = new RandomPicture())
                {
                    Task<string> getImage = atask.GetRandomImage();
                    progressLabel.Text = "Generating Character";
                    string path = await getImage;
                    progressLabel.Text = "Completed!";
                    ShowMyImage(path, 200, 200);
                    Job j;
                    Race r;
                    if (DataManager.GetJobs().TryGetValue(JobBox.Text, out j) 
                        && DataManager.GetRaces().TryGetValue(RaceBox.Text, out r))
                    {
                        Character character = new Character(charName.Text, GenderBox.Text,j,r);
                        bool success = await DataManager.AddCharacter(character);
                        if (!success)
                        {
                            progressLabel.Text = "Character already exist!";
                        }
                    }
                }
            }
        }

        private bool validateInput()
        {
            bool good = false;
            if (charName.Text.Equals(string.Empty))
            {
                progressLabel.Text = "Please insert Character Name!";
            }
            else if (GenderBox.Text.Equals(string.Empty))
            {
                progressLabel.Text = "Please select a gender";
            }
            else if (RaceBox.Text.Equals(string.Empty))
            {
                progressLabel.Text = "Please select a race";
            }
            else if (JobBox.Text.Equals(string.Empty))
            {
                progressLabel.Text = "Please select a job";
            }
            else
            {
                good = true;
            }
            return good;
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            CustomInput customInput = new CustomInput();
            customInput.Show();
        }

        private  void refresh_Click(object sender, EventArgs e)
        {
            UpdateDropboxes();
        }

        private void database_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm();
            df.Show();
        }
    }
}
