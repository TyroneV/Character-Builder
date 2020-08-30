namespace Character_Builder
{
    partial class MainForm
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
            System.Windows.Forms.Button database;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.charName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RaceBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.customBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            database = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // charName
            // 
            this.charName.Location = new System.Drawing.Point(12, 37);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(299, 20);
            this.charName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(12, 102);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(188, 21);
            this.GenderBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // RaceBox
            // 
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Location = new System.Drawing.Point(12, 171);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(188, 21);
            this.RaceBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job";
            // 
            // JobBox
            // 
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Location = new System.Drawing.Point(12, 254);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(188, 21);
            this.JobBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate Character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(213, 352);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 24);
            this.progressLabel.TabIndex = 17;
            // 
            // customBtn
            // 
            this.customBtn.Location = new System.Drawing.Point(12, 425);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(128, 33);
            this.customBtn.TabIndex = 18;
            this.customBtn.Text = "Go to custom input";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(379, 18);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 39);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "Reload";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // database
            // 
            database.Location = new System.Drawing.Point(396, 425);
            database.Name = "database";
            database.Size = new System.Drawing.Size(89, 33);
            database.TabIndex = 20;
            database.Text = "Database";
            database.UseVisualStyleBackColor = true;
            database.Click += new System.EventHandler(this.database_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 470);
            this.Controls.Add(database);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.customBtn);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RaceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Character Builder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox charName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RaceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox JobBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button refresh;
    }
}

