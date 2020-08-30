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
    public partial class JobsDataForm : Form
    {
        public JobsDataForm()
        {
            InitializeComponent();
            List<Job> jobList = DataManager.GetJobs().Values.ToList();
            listView1.Items.Clear();
            doPost(jobList);
        }
        void doPost(List<Job> jobList)
        {
            foreach (Job j in jobList)
            {
                string[] row = { j.jobName, j.jobAction };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Job> jobList = DataManager.GetJobs().Values.ToList();
            listView1.Items.Clear();
            jobList.Sort();
            doPost(jobList);
        }
    }
}
