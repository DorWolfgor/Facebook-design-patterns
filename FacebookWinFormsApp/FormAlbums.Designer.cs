
namespace BasicFacebookFeatures
{
    partial class FormAlbums
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label createdTimeLabel1;
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.nextImage = new System.Windows.Forms.Button();
            this.previousImage = new System.Windows.Forms.Button();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureAlbumURLPictureBox = new System.Windows.Forms.PictureBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonDescription = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            createdTimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbumURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(12, 520);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(38, 17);
            linkLabel.TabIndex = 11;
            linkLabel.Text = "Link:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 558);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // createdTimeLabel1
            // 
            createdTimeLabel1.AutoSize = true;
            createdTimeLabel1.Location = new System.Drawing.Point(8, 495);
            createdTimeLabel1.Name = "createdTimeLabel1";
            createdTimeLabel1.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel1.TabIndex = 16;
            createdTimeLabel1.Text = "Created Time:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(4, 133);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(228, 356);
            this.listBoxAlbums.TabIndex = 4;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelAlbums);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 99);
            this.panel1.TabIndex = 5;
            // 
            // labelAlbums
            // 
            this.labelAlbums.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAlbums.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.ForeColor = System.Drawing.Color.Navy;
            this.labelAlbums.Location = new System.Drawing.Point(269, 9);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(270, 80);
            this.labelAlbums.TabIndex = 58;
            this.labelAlbums.Text = "Albums";
            this.labelAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextImage
            // 
            this.nextImage.Location = new System.Drawing.Point(843, 252);
            this.nextImage.Name = "nextImage";
            this.nextImage.Size = new System.Drawing.Size(80, 66);
            this.nextImage.TabIndex = 7;
            this.nextImage.Text = "right";
            this.nextImage.UseVisualStyleBackColor = true;
            this.nextImage.Click += new System.EventHandler(this.nextImage_Click);
            // 
            // previousImage
            // 
            this.previousImage.Location = new System.Drawing.Point(378, 243);
            this.previousImage.Name = "previousImage";
            this.previousImage.Size = new System.Drawing.Size(80, 66);
            this.previousImage.TabIndex = 8;
            this.previousImage.Text = "left";
            this.previousImage.UseVisualStyleBackColor = true;
            this.previousImage.Click += new System.EventHandler(this.previousImage_Click);
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(149, 527);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(261, 25);
            this.linkLinkLabel.TabIndex = 12;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(111, 553);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(299, 22);
            this.nameTextBox.TabIndex = 14;
            // 
            // pictureAlbumURLPictureBox
            // 
            this.pictureAlbumURLPictureBox.Location = new System.Drawing.Point(510, 146);
            this.pictureAlbumURLPictureBox.Name = "pictureAlbumURLPictureBox";
            this.pictureAlbumURLPictureBox.Size = new System.Drawing.Size(290, 267);
            this.pictureAlbumURLPictureBox.TabIndex = 16;
            this.pictureAlbumURLPictureBox.TabStop = false;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(111, 495);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(299, 22);
            this.createdTimeDateTimePicker.TabIndex = 17;
            // 
            // ButtonDescription
            // 
            this.ButtonDescription.Location = new System.Drawing.Point(658, 419);
            this.ButtonDescription.Name = "ButtonDescription";
            this.ButtonDescription.Size = new System.Drawing.Size(142, 48);
            this.ButtonDescription.TabIndex = 18;
            this.ButtonDescription.Text = "ChangeDescription";
            this.ButtonDescription.UseVisualStyleBackColor = true;
            this.ButtonDescription.Click += new System.EventHandler(this.ButtonDescription_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(608, 481);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(192, 125);
            this.textBoxDescription.TabIndex = 21;
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.albumBindingSource;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 651);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.ButtonDescription);
            this.Controls.Add(createdTimeLabel1);
            this.Controls.Add(this.createdTimeDateTimePicker);
            this.Controls.Add(linkLabel);
            this.Controls.Add(this.linkLinkLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureAlbumURLPictureBox);
            this.Controls.Add(this.previousImage);
            this.Controls.Add(this.nextImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxAlbums);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbumURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Button nextImage;
        private System.Windows.Forms.Button previousImage;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox pictureAlbumURLPictureBox;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.Button ButtonDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.BindingSource photosBindingSource;
    }
}