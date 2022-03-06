namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxIntroUser = new System.Windows.Forms.GroupBox();
            this.labelUserGender = new System.Windows.Forms.Label();
            this.labelUserRelationshipStatus = new System.Windows.Forms.Label();
            this.labelUserBirthday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDekstop = new System.Windows.Forms.Panel();
            this.buttonFetchFriendsChecksIn = new System.Windows.Forms.Button();
            this.buttonActivity = new System.Windows.Forms.Button();
            this.buttonFetchLikedPages = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxIntroUser.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.groupBoxIntroUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 135);
            this.panel1.TabIndex = 57;
            // 
            // groupBoxIntroUser
            // 
            this.groupBoxIntroUser.Controls.Add(this.labelUserGender);
            this.groupBoxIntroUser.Controls.Add(this.labelUserRelationshipStatus);
            this.groupBoxIntroUser.Controls.Add(this.labelUserBirthday);
            this.groupBoxIntroUser.Location = new System.Drawing.Point(283, 6);
            this.groupBoxIntroUser.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIntroUser.Name = "groupBoxIntroUser";
            this.groupBoxIntroUser.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIntroUser.Size = new System.Drawing.Size(202, 129);
            this.groupBoxIntroUser.TabIndex = 57;
            this.groupBoxIntroUser.TabStop = false;
            this.groupBoxIntroUser.Text = "About:";
            this.groupBoxIntroUser.Visible = false;
            // 
            // labelUserGender
            // 
            this.labelUserGender.AutoSize = true;
            this.labelUserGender.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserGender.Location = new System.Drawing.Point(13, 74);
            this.labelUserGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserGender.Name = "labelUserGender";
            this.labelUserGender.Size = new System.Drawing.Size(53, 16);
            this.labelUserGender.TabIndex = 2;
            this.labelUserGender.Text = "Gender";
            // 
            // labelUserRelationshipStatus
            // 
            this.labelUserRelationshipStatus.AutoSize = true;
            this.labelUserRelationshipStatus.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserRelationshipStatus.Location = new System.Drawing.Point(13, 111);
            this.labelUserRelationshipStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserRelationshipStatus.Name = "labelUserRelationshipStatus";
            this.labelUserRelationshipStatus.Size = new System.Drawing.Size(127, 16);
            this.labelUserRelationshipStatus.TabIndex = 1;
            this.labelUserRelationshipStatus.Text = "Relationship Status";
            // 
            // labelUserBirthday
            // 
            this.labelUserBirthday.AutoSize = true;
            this.labelUserBirthday.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserBirthday.Location = new System.Drawing.Point(13, 37);
            this.labelUserBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserBirthday.Name = "labelUserBirthday";
            this.labelUserBirthday.Size = new System.Drawing.Size(60, 16);
            this.labelUserBirthday.TabIndex = 0;
            this.labelUserBirthday.Text = "Birthday";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(553, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 88);
            this.label1.TabIndex = 56;
            this.label1.Text = "Facebook";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1032, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(11, 9);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(256, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(11, 176);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(256, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonFetchFriendsChecksIn);
            this.panel2.Controls.Add(this.buttonActivity);
            this.panel2.Controls.Add(this.buttonFetchLikedPages);
            this.panel2.Controls.Add(this.buttonFetchPosts);
            this.panel2.Controls.Add(this.pictureBoxProfile);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.buttonFetchAlbums);
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.buttonFetchGroups);
            this.panel2.Controls.Add(this.buttonFetchEvents);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 794);
            this.panel2.TabIndex = 58;
            // 
            // panelDekstop
            // 
            this.panelDekstop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDekstop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDekstop.Location = new System.Drawing.Point(275, 135);
            this.panelDekstop.Name = "panelDekstop";
            this.panelDekstop.Size = new System.Drawing.Size(1009, 674);
            this.panelDekstop.TabIndex = 59;
            // 
            // buttonFetchFriendsChecksIn
            // 
            this.buttonFetchFriendsChecksIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonFetchFriendsChecksIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFetchFriendsChecksIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFetchFriendsChecksIn.FlatAppearance.BorderSize = 0;
            this.buttonFetchFriendsChecksIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchFriendsChecksIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchFriendsChecksIn.Image = global::BasicFacebookFeatures.Properties.Resources.check_in__1_;
            this.buttonFetchFriendsChecksIn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFetchFriendsChecksIn.Location = new System.Drawing.Point(3, 710);
            this.buttonFetchFriendsChecksIn.Name = "buttonFetchFriendsChecksIn";
            this.buttonFetchFriendsChecksIn.Size = new System.Drawing.Size(261, 79);
            this.buttonFetchFriendsChecksIn.TabIndex = 66;
            this.buttonFetchFriendsChecksIn.Text = "Friends Checks In";
            this.buttonFetchFriendsChecksIn.UseVisualStyleBackColor = false;
            this.buttonFetchFriendsChecksIn.Click += new System.EventHandler(this.buttonFriendsChecksIn_Click);
            // 
            // buttonActivity
            // 
            this.buttonActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonActivity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonActivity.FlatAppearance.BorderSize = 0;
            this.buttonActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActivity.Image = global::BasicFacebookFeatures.Properties.Resources.activity;
            this.buttonActivity.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonActivity.Location = new System.Drawing.Point(10, 614);
            this.buttonActivity.Name = "buttonActivity";
            this.buttonActivity.Size = new System.Drawing.Size(261, 79);
            this.buttonActivity.TabIndex = 66;
            this.buttonActivity.Text = "Activity";
            this.buttonActivity.UseVisualStyleBackColor = false;
            this.buttonActivity.Click += new System.EventHandler(this.buttonActivity_Click);
            // 
            // buttonFetchLikedPages
            // 
            this.buttonFetchLikedPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonFetchLikedPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFetchLikedPages.FlatAppearance.BorderSize = 0;
            this.buttonFetchLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchLikedPages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchLikedPages.Image = global::BasicFacebookFeatures.Properties.Resources.likedpages2;
            this.buttonFetchLikedPages.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFetchLikedPages.Location = new System.Drawing.Point(10, 376);
            this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
            this.buttonFetchLikedPages.Size = new System.Drawing.Size(262, 75);
            this.buttonFetchLikedPages.TabIndex = 65;
            this.buttonFetchLikedPages.Text = "Liked Pages";
            this.buttonFetchLikedPages.UseVisualStyleBackColor = false;
            this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonFetchPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFetchPosts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFetchPosts.FlatAppearance.BorderSize = 0;
            this.buttonFetchPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchPosts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchPosts.Image = global::BasicFacebookFeatures.Properties.Resources.posts_icon;
            this.buttonFetchPosts.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFetchPosts.Location = new System.Drawing.Point(11, 529);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(261, 79);
            this.buttonFetchPosts.TabIndex = 64;
            this.buttonFetchPosts.Text = "Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProfile.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.ErrorImage")));
            this.pictureBoxProfile.Image = global::BasicFacebookFeatures.Properties.Resources.user_login_3;
            this.pictureBoxProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.InitialImage")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(35, 44);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(204, 125);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonFetchAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFetchAlbums.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFetchAlbums.FlatAppearance.BorderSize = 0;
            this.buttonFetchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums_icon2;
            this.buttonFetchAlbums.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(11, 444);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(261, 79);
            this.buttonFetchAlbums.TabIndex = 62;
            this.buttonFetchAlbums.Text = "Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonFetchGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFetchGroups.FlatAppearance.BorderSize = 0;
            this.buttonFetchGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchGroups.Image = global::BasicFacebookFeatures.Properties.Resources.group_icon21;
            this.buttonFetchGroups.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFetchGroups.Location = new System.Drawing.Point(6, 227);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(266, 76);
            this.buttonFetchGroups.TabIndex = 59;
            this.buttonFetchGroups.Text = "Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = false;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.buttonFetchEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFetchEvents.FlatAppearance.BorderSize = 0;
            this.buttonFetchEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFetchEvents.Image = global::BasicFacebookFeatures.Properties.Resources.enents1;
            this.buttonFetchEvents.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFetchEvents.Location = new System.Drawing.Point(3, 309);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(265, 74);
            this.buttonFetchEvents.TabIndex = 60;
            this.buttonFetchEvents.Text = "Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = false;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 809);
            this.Controls.Add(this.panelDekstop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.panel1.ResumeLayout(false);
            this.groupBoxIntroUser.ResumeLayout(false);
            this.groupBoxIntroUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Panel panelDekstop;

        private System.Windows.Forms.GroupBox groupBoxIntroUser;
        private System.Windows.Forms.Label labelUserGender;
        private System.Windows.Forms.Label labelUserRelationshipStatus;
        private System.Windows.Forms.Label labelUserBirthday;
        private System.Windows.Forms.Button buttonFetchFriendsChecksIn;
        private System.Windows.Forms.Button buttonActivity;

    }
}

