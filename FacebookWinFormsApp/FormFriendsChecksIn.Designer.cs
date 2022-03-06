
namespace BasicFacebookFeatures
{
    partial class FormFriendsChecksIn
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
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.ListBoxFriendsInLocation = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonSearchLocation = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckinFriendPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckinFriendPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.HorizontalScrollbar = true;
            this.listBoxCheckIns.ItemHeight = 16;
            this.listBoxCheckIns.Location = new System.Drawing.Point(682, 101);
            this.listBoxCheckIns.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(275, 244);
            this.listBoxCheckIns.TabIndex = 10;
            this.listBoxCheckIns.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckIns_SelectedIndexChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label9.Location = new System.Drawing.Point(707, 77);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(179, 20);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "All Friend`s Check Ins";
            // 
            // ListBoxFriendsInLocation
            // 
            this.ListBoxFriendsInLocation.FormattingEnabled = true;
            this.ListBoxFriendsInLocation.ItemHeight = 16;
            this.ListBoxFriendsInLocation.Location = new System.Drawing.Point(13, 115);
            this.ListBoxFriendsInLocation.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxFriendsInLocation.Name = "ListBoxFriendsInLocation";
            this.ListBoxFriendsInLocation.Size = new System.Drawing.Size(407, 132);
            this.ListBoxFriendsInLocation.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Who Have Been There";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(481, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter location name OR Choose one from the following list";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(15, 45);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(615, 22);
            this.textBoxLocation.TabIndex = 16;
            // 
            // buttonSearchLocation
            // 
            this.buttonSearchLocation.Location = new System.Drawing.Point(629, 45);
            this.buttonSearchLocation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchLocation.Name = "buttonSearchLocation";
            this.buttonSearchLocation.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchLocation.TabIndex = 14;
            this.buttonSearchLocation.Text = "Search";
            this.buttonSearchLocation.UseVisualStyleBackColor = true;
            this.buttonSearchLocation.Click += new System.EventHandler(this.buttonSearchLocation_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(682, 579);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(276, 34);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset Info";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(13, 244);
            this.buttonShowInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(407, 32);
            this.buttonShowInfo.TabIndex = 18;
            this.buttonShowInfo.Text = "Show CheckIn Information";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pictureBoxCheckinFriendPicture);
            this.groupBox2.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(13, 284);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(635, 249);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check In Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Friend`s Picture";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.labelLocation);
            this.groupBox1.Location = new System.Drawing.Point(269, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(358, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check In Info";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatus.Location = new System.Drawing.Point(40, 163);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 16);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(39, 43);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Friend`s Name:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDate.Location = new System.Drawing.Point(39, 127);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(101, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date and Time:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLocation.Location = new System.Drawing.Point(39, 84);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(64, 16);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Location:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.check_in__3_;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(682, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 232);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCheckinFriendPicture
            // 
            this.pictureBoxCheckinFriendPicture.Location = new System.Drawing.Point(19, 53);
            this.pictureBoxCheckinFriendPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCheckinFriendPicture.Name = "pictureBoxCheckinFriendPicture";
            this.pictureBoxCheckinFriendPicture.Size = new System.Drawing.Size(231, 191);
            this.pictureBoxCheckinFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheckinFriendPicture.TabIndex = 5;
            this.pictureBoxCheckinFriendPicture.TabStop = false;
            // 
            // FormFriendsChecksIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.buttonSearchLocation);
            this.Controls.Add(this.ListBoxFriendsInLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(this.Label9);
            this.Name = "FormFriendsChecksIn";
            this.Text = "FormFriendsChecksIn";
            this.Load += new System.EventHandler(this.FormFriendsChecksIn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckinFriendPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.Label Label9;
        public System.Windows.Forms.ListBox ListBoxFriendsInLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonSearchLocation;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.PictureBox pictureBoxCheckinFriendPicture;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}