namespace Character_Builder.Forms
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.characterBtnSort = new System.Windows.Forms.Button();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.race = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gendersort = new System.Windows.Forms.Button();
            this.racesort = new System.Windows.Forms.Button();
            this.jobsort = new System.Windows.Forms.Button();
            this.jobs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.gender,
            this.race,
            this.job});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 372);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // characterBtnSort
            // 
            this.characterBtnSort.Location = new System.Drawing.Point(589, 38);
            this.characterBtnSort.Name = "characterBtnSort";
            this.characterBtnSort.Size = new System.Drawing.Size(156, 46);
            this.characterBtnSort.TabIndex = 1;
            this.characterBtnSort.Text = "Name Sort";
            this.characterBtnSort.UseVisualStyleBackColor = true;
            this.characterBtnSort.Click += new System.EventHandler(this.characterBtnSort_Click);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // gender
            // 
            this.gender.Text = "gender";
            this.gender.Width = 100;
            // 
            // race
            // 
            this.race.Text = "race";
            this.race.Width = 150;
            // 
            // job
            // 
            this.job.Text = "job";
            this.job.Width = 150;
            // 
            // gendersort
            // 
            this.gendersort.Location = new System.Drawing.Point(589, 107);
            this.gendersort.Name = "gendersort";
            this.gendersort.Size = new System.Drawing.Size(156, 46);
            this.gendersort.TabIndex = 2;
            this.gendersort.Text = "Gender Sort";
            this.gendersort.UseVisualStyleBackColor = true;
            this.gendersort.Click += new System.EventHandler(this.gendersort_Click);
            // 
            // racesort
            // 
            this.racesort.Location = new System.Drawing.Point(589, 182);
            this.racesort.Name = "racesort";
            this.racesort.Size = new System.Drawing.Size(156, 46);
            this.racesort.TabIndex = 3;
            this.racesort.Text = "Race Sort";
            this.racesort.UseVisualStyleBackColor = true;
            this.racesort.Click += new System.EventHandler(this.racesort_Click);
            // 
            // jobsort
            // 
            this.jobsort.Location = new System.Drawing.Point(589, 258);
            this.jobsort.Name = "jobsort";
            this.jobsort.Size = new System.Drawing.Size(156, 46);
            this.jobsort.TabIndex = 4;
            this.jobsort.Text = "Job Sort";
            this.jobsort.UseVisualStyleBackColor = true;
            this.jobsort.Click += new System.EventHandler(this.jobsort_Click);
            // 
            // jobs
            // 
            this.jobs.Location = new System.Drawing.Point(589, 340);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(156, 45);
            this.jobs.TabIndex = 5;
            this.jobs.Text = "Jobs";
            this.jobs.UseVisualStyleBackColor = true;
            this.jobs.Click += new System.EventHandler(this.jobs_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.jobsort);
            this.Controls.Add(this.racesort);
            this.Controls.Add(this.gendersort);
            this.Controls.Add(this.characterBtnSort);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button characterBtnSort;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader race;
        private System.Windows.Forms.ColumnHeader job;
        private System.Windows.Forms.Button gendersort;
        private System.Windows.Forms.Button racesort;
        private System.Windows.Forms.Button jobsort;
        private System.Windows.Forms.Button jobs;
    }
}