namespace Character_Builder.Forms
{
    partial class CustomInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomInput));
            this.raceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.raceTraitTxt = new System.Windows.Forms.TextBox();
            this.JobWorkTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jobTxt = new System.Windows.Forms.TextBox();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.submitGender = new System.Windows.Forms.Button();
            this.submitRace = new System.Windows.Forms.Button();
            this.submitJob = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // raceTxt
            // 
            this.raceTxt.Location = new System.Drawing.Point(11, 108);
            this.raceTxt.Name = "raceTxt";
            this.raceTxt.Size = new System.Drawing.Size(163, 20);
            this.raceTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Race Traits";
            // 
            // raceTraitTxt
            // 
            this.raceTraitTxt.Location = new System.Drawing.Point(11, 152);
            this.raceTraitTxt.Name = "raceTraitTxt";
            this.raceTraitTxt.Size = new System.Drawing.Size(302, 20);
            this.raceTraitTxt.TabIndex = 3;
            // 
            // JobWorkTxt
            // 
            this.JobWorkTxt.Location = new System.Drawing.Point(11, 255);
            this.JobWorkTxt.Name = "JobWorkTxt";
            this.JobWorkTxt.Size = new System.Drawing.Size(302, 20);
            this.JobWorkTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Job Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Job";
            // 
            // jobTxt
            // 
            this.jobTxt.Location = new System.Drawing.Point(11, 211);
            this.jobTxt.Name = "jobTxt";
            this.jobTxt.Size = new System.Drawing.Size(163, 20);
            this.jobTxt.TabIndex = 4;
            // 
            // genderTxt
            // 
            this.genderTxt.Location = new System.Drawing.Point(11, 39);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(163, 20);
            this.genderTxt.TabIndex = 8;
            // 
            // submitGender
            // 
            this.submitGender.Location = new System.Drawing.Point(202, 37);
            this.submitGender.Name = "submitGender";
            this.submitGender.Size = new System.Drawing.Size(111, 23);
            this.submitGender.TabIndex = 11;
            this.submitGender.Text = "Submit Gender";
            this.submitGender.UseVisualStyleBackColor = true;
            this.submitGender.Click += new System.EventHandler(this.submitGender_Click);
            // 
            // submitRace
            // 
            this.submitRace.Location = new System.Drawing.Point(202, 106);
            this.submitRace.Name = "submitRace";
            this.submitRace.Size = new System.Drawing.Size(111, 23);
            this.submitRace.TabIndex = 12;
            this.submitRace.Text = "Submit Race";
            this.submitRace.UseVisualStyleBackColor = true;
            this.submitRace.Click += new System.EventHandler(this.submitRace_Click);
            // 
            // submitJob
            // 
            this.submitJob.Location = new System.Drawing.Point(202, 208);
            this.submitJob.Name = "submitJob";
            this.submitJob.Size = new System.Drawing.Size(111, 23);
            this.submitJob.TabIndex = 13;
            this.submitJob.Text = "Submit Job";
            this.submitJob.UseVisualStyleBackColor = true;
            this.submitJob.Click += new System.EventHandler(this.submitJob_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(11, 306);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 20);
            this.resultText.TabIndex = 15;
            // 
            // CustomInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 363);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitJob);
            this.Controls.Add(this.submitRace);
            this.Controls.Add(this.submitGender);
            this.Controls.Add(this.genderTxt);
            this.Controls.Add(this.JobWorkTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jobTxt);
            this.Controls.Add(this.raceTraitTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomInput";
            this.Text = "Custom Inputs";
            this.Load += new System.EventHandler(this.CustomInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox raceTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox raceTraitTxt;
        private System.Windows.Forms.TextBox JobWorkTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jobTxt;
        private System.Windows.Forms.TextBox genderTxt;
        private System.Windows.Forms.Button submitGender;
        private System.Windows.Forms.Button submitRace;
        private System.Windows.Forms.Button submitJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultText;
    }
}