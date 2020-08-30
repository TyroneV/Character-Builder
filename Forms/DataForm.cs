using Character_Builder.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Builder.Forms
{
    public partial class DataForm : Form
    {
        void doPost(List<Character> charList)
        {
            foreach (Character c in charList)
            {
                string[] row = { c.name, c.gender, c.race.raceName, c.job.jobName };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
        public DataForm()
        {
            InitializeComponent();
            List<Character> charList = DataManager.GetCharacters().Values.ToList();
            listView1.Items.Clear();
            doPost(charList);
        }

        private void characterBtnSort_Click(object sender, EventArgs e)
        {
            List<Character> charList = DataManager.GetCharacters().Values.ToList();
            charList.Sort();
            listView1.Items.Clear();
            doPost(charList);
        }

        private void gendersort_Click(object sender, EventArgs e)
        {
            List<Character> charList = DataManager.GetCharacters().Values.ToList();
            SortByGender s = new SortByGender();
            charList.Sort(s);
            listView1.Items.Clear();
            doPost(charList);
        }

        private void racesort_Click(object sender, EventArgs e)
        {
            List<Character> charList = DataManager.GetCharacters().Values.ToList();
            SortByRace s = new SortByRace();
            charList.Sort(s);
            listView1.Items.Clear();
            doPost(charList);
        }

        private void jobsort_Click(object sender, EventArgs e)
        {
            List<Character> charList = DataManager.GetCharacters().Values.ToList();
            SortByJob s = new SortByJob();
            charList.Sort(s);
            listView1.Items.Clear();
            doPost(charList);
        }

        private void jobs_Click(object sender, EventArgs e)
        {
            JobsDataForm jobs = new JobsDataForm();
            jobs.Show();
        }
    }
}
