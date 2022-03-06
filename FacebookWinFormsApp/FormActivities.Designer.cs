namespace BasicFacebookFeatures
{
    partial class FormActivity
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
            this.startYearActivity = new System.Windows.Forms.Button();
            this.startYear = new System.Windows.Forms.ComboBox();
            this.endYear = new System.Windows.Forms.ComboBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.nextImage = new System.Windows.Forms.Button();
            this.previousImage = new System.Windows.Forms.Button();
            this.picturesByYear = new System.Windows.Forms.CheckBox();
            this.postsByYear = new System.Windows.Forms.CheckBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.comboBoxComments = new System.Windows.Forms.ComboBox();
            this.filterByYear = new System.Windows.Forms.CheckBox();
            this.filterByComments = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // startYearActivity
            // 
            this.startYearActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startYearActivity.Location = new System.Drawing.Point(277, 105);
            this.startYearActivity.Name = "startYearActivity";
            this.startYearActivity.Size = new System.Drawing.Size(74, 41);
            this.startYearActivity.TabIndex = 1;
            this.startYearActivity.Text = "Start";
            this.startYearActivity.UseVisualStyleBackColor = true;
            this.startYearActivity.Click += new System.EventHandler(this.startYearActivity_Click);
            // 
            // startYear
            // 
            this.startYear.FormattingEnabled = true;
            this.startYear.Location = new System.Drawing.Point(164, 46);
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(121, 24);
            this.startYear.TabIndex = 2;
            this.startYear.SelectedIndexChanged += new System.EventHandler(this.startYear_SelectedIndexChanged);
            // 
            // endYear
            // 
            this.endYear.FormattingEnabled = true;
            this.endYear.Location = new System.Drawing.Point(328, 46);
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(121, 24);
            this.endYear.TabIndex = 3;
            // 
            // startLabel
            // 
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(164, 18);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(121, 23);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Starting Year";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ending Year";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(380, 160);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(279, 252);
            this.pictureBoxAlbum.TabIndex = 7;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // nextImage
            // 
            this.nextImage.Location = new System.Drawing.Point(684, 252);
            this.nextImage.Name = "nextImage";
            this.nextImage.Size = new System.Drawing.Size(80, 66);
            this.nextImage.TabIndex = 8;
            this.nextImage.Text = "right";
            this.nextImage.UseVisualStyleBackColor = true;
            this.nextImage.Visible = false;
            this.nextImage.Click += new System.EventHandler(this.nextImage_Click);
            // 
            // previousImage
            // 
            this.previousImage.Location = new System.Drawing.Point(277, 252);
            this.previousImage.Name = "previousImage";
            this.previousImage.Size = new System.Drawing.Size(80, 66);
            this.previousImage.TabIndex = 9;
            this.previousImage.Text = "left";
            this.previousImage.UseVisualStyleBackColor = true;
            this.previousImage.Visible = false;
            this.previousImage.Click += new System.EventHandler(this.previousImage_Click);
            // 
            // picturesByYear
            // 
            this.picturesByYear.AutoSize = true;
            this.picturesByYear.Location = new System.Drawing.Point(27, 46);
            this.picturesByYear.Name = "picturesByYear";
            this.picturesByYear.Size = new System.Drawing.Size(81, 21);
            this.picturesByYear.TabIndex = 10;
            this.picturesByYear.Text = "Pictures";
            this.picturesByYear.UseVisualStyleBackColor = true;
            this.picturesByYear.CheckedChanged += new System.EventHandler(this.picturesByYear_CheckedChanged);
            // 
            // postsByYear
            // 
            this.postsByYear.AutoSize = true;
            this.postsByYear.Location = new System.Drawing.Point(27, 73);
            this.postsByYear.Name = "postsByYear";
            this.postsByYear.Size = new System.Drawing.Size(65, 21);
            this.postsByYear.TabIndex = 11;
            this.postsByYear.Text = "Posts";
            this.postsByYear.UseVisualStyleBackColor = true;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(27, 162);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(221, 276);
            this.listBoxPosts.TabIndex = 60;
            // 
            // commentsLabel
            // 
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(543, -21);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(259, 87);
            this.commentsLabel.TabIndex = 61;
            this.commentsLabel.Text = "Minimum comments for picture";
            this.commentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxComments
            // 
            this.comboBoxComments.FormattingEnabled = true;
            this.comboBoxComments.Location = new System.Drawing.Point(644, 70);
            this.comboBoxComments.Name = "comboBoxComments";
            this.comboBoxComments.Size = new System.Drawing.Size(121, 24);
            this.comboBoxComments.TabIndex = 62;
            // 
            // filterByYear
            // 
            this.filterByYear.AutoSize = true;
            this.filterByYear.Location = new System.Drawing.Point(468, 49);
            this.filterByYear.Name = "filterByYear";
            this.filterByYear.Size = new System.Drawing.Size(108, 21);
            this.filterByYear.TabIndex = 63;
            this.filterByYear.Text = "filter by year";
            this.filterByYear.UseVisualStyleBackColor = true;
            // 
            // filterByComments
            // 
            this.filterByComments.AutoSize = true;
            this.filterByComments.Location = new System.Drawing.Point(644, 43);
            this.filterByComments.Name = "filterByComments";
            this.filterByComments.Size = new System.Drawing.Size(144, 21);
            this.filterByComments.TabIndex = 64;
            this.filterByComments.Text = "filter by comments";
            this.filterByComments.UseVisualStyleBackColor = true;
            this.filterByComments.CheckedChanged += new System.EventHandler(this.filterByComments_CheckedChanged);
            // 
            // FormActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterByComments);
            this.Controls.Add(this.filterByYear);
            this.Controls.Add(this.comboBoxComments);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.postsByYear);
            this.Controls.Add(this.picturesByYear);
            this.Controls.Add(this.previousImage);
            this.Controls.Add(this.nextImage);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endYear);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.startYearActivity);
            this.Name = "FormActivity";
            this.Text = "FormActivity";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startYearActivity;
        private System.Windows.Forms.ComboBox startYear;
        private System.Windows.Forms.ComboBox endYear;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Button nextImage;
        private System.Windows.Forms.Button previousImage;
        private System.Windows.Forms.CheckBox picturesByYear;
        private System.Windows.Forms.CheckBox postsByYear;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.ComboBox comboBoxComments;
        private System.Windows.Forms.CheckBox filterByYear;
        private System.Windows.Forms.CheckBox filterByComments;
    }
}